using DxDirectPrint.Data.EF;
using DxDirectPrint.Data.Services;
using Microsoft.AspNetCore.SignalR;

namespace DxDirectPrint
{
    public record PrintPDFArgs(string Printer, int Copies, int OrderID, string UserID);
    public class PrintHub: Hub
    {
        private readonly static ConnectionMapping<string> _connections =
            new ConnectionMapping<string>();
        private readonly ILogger<PrintHub> log;
        readonly InvoiceService invoiceService;


        public PrintHub(ILogger<PrintHub> logger, InvoiceService invoiceService)
        {
            this.invoiceService = invoiceService;
            log = logger;
        }

        public async override Task OnConnectedAsync()
        {
            string name = Context.User?.Identity?.Name!;
            HttpContext ctx = Context.GetHttpContext()!;
            var printID = ctx.Request.Query["printID"];
            if (!string.IsNullOrEmpty(printID))
            {
                _connections.Add(printID, Context.ConnectionId);
            }

            await base.OnConnectedAsync();
        }

        public async override Task OnDisconnectedAsync(Exception? exception)
        {
            HttpContext ctx = Context.GetHttpContext()!;
            var printID = ctx.Request.Query["printID"];
            _connections.Remove(printID, Context.ConnectionId);

            await base.OnDisconnectedAsync(exception);
        }

        public async Task<bool> PrintReceipt(string username, string printID, PrintPDFArgs args)
        {
            string name = Context.User?.Identity?.Name ?? username;
            var clients = _connections.GetConnections(printID);
            if (clients != null)
            {

                if (!string.IsNullOrEmpty(name))
                {
                    //we need to check if the item exists
                    var orderExists = invoiceService.MainStore.Query().Where(i => i.InvoiceId == args.OrderID).Any();
                    
                    int prnCount = 0;
                    if (orderExists)
                    {
                        foreach (var connectionId in clients)
                        {
                            await Clients.Client(connectionId).SendAsync("PrintReceipt",
                                printID, args, CancellationToken.None);
                            prnCount++;
                        }

                        return prnCount == 0 ? false : true;
                    }
                    else
                        log.LogError($"Error locating document for PrintConnectorID {printID}");
                }
            }
            return false;
        }

    }

    public class ConnectionMapping<T>
        where T : notnull
    {
        private readonly Dictionary<T, HashSet<string>> _connections =
            new Dictionary<T, HashSet<string>>();

        public int Count => _connections.Count;

        public void Add(T key, string connectionId)
        {
            lock (_connections)
            {

                if (!_connections.TryGetValue(key, out HashSet<string>? connections))
                {
                    connections = new HashSet<string>();
                    _connections.Add(key, connections);
                }

                lock (connections)
                {
                    connections.Add(connectionId);
                }
            }
        }

        public IEnumerable<string> GetConnections(T key)
        {
            if (_connections.TryGetValue(key, out HashSet<string>? connections))
            {
                return connections ?? Enumerable.Empty<string>();
            }

            return Enumerable.Empty<string>();
        }

        public void Remove(T key, string connectionId)
        {
            lock (_connections)
            {

                if (!_connections.TryGetValue(key, out HashSet<string>? connections))
                {
                    return;
                }

                lock (connections)
                {
                    connections.Remove(connectionId);

                    if (connections.Count == 0)
                    {
                        _connections.Remove(key);
                    }
                }
            }
        }
    }
}
