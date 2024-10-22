using System.Net;
using System.Net.Sockets;
using System.Text;
public class Server {
    private TcpListener _listener;
    private List<TcpClient> _clients;
    public Server(int port){
        _listener = new TcpListener(IPAddress.Any, port); 
        _clients = new List<TcpClient>();
    }
    public void Start () {
        _listener.Start();
        Console.WriteLine("Server started...");
        while(true){
            var client = _listener.AcceptTcpClient();
            _clients.Add(client);
            Console.WriteLine("Client connected...");
        }
    }
}