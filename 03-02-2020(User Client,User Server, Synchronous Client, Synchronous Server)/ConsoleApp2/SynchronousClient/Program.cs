using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Timers;
using System.Threading;
using System.Threading.Tasks;

namespace SynchronousClient
{
    public class Program
    {
        public static void StartClient()
        {
            byte[] bytes = new byte[1024];
            try
            {
                var hostName = Dns.GetHostName();
                IPHostEntry ipHost = Dns.GetHostEntry(hostName);
                Console.WriteLine($"Host: {hostName}");
                IPAddress ip = ipHost.AddressList[0];
                IPEndPoint remoteEp = new IPEndPoint(ip, 453323);

                Socket sender = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    sender.Connect(remoteEp);
                    Console.WriteLine("socket Connected");
                    sender.RemoteEndPoint.ToString();
                    byte[] msg = Encoding.ASCII.GetBytes("This is just a test");
                    int byteSent = sender.Send(msg);
                    int byteRec = sender.Receive(bytes);
                    Console.WriteLine($"Echoed test {Encoding.ASCII.GetString(bytes, 0, byteRec)}");

                    //release the socket
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
                catch (SocketException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
            public static void Main(string[] args)
            {
            Console.WriteLine("press any key to cont...");
            Console.ReadLine();
            Program.StartClient();
            Console.ReadLine();
        }
    }
}
