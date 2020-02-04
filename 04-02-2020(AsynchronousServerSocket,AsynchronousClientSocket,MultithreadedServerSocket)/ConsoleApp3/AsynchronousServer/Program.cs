
using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Text;
namespace AsynchronousServer
{
    class Program
    {
            public class ObjectState
            {
                public const int bufferSize = 1024;
                public Socket wSocket = null;
                public byte[] buffer = new byte[bufferSize];
                public StringBuilder sb = new StringBuilder();
            }

        public class AsyncSocketListener
        {
            public static ManualResetEvent allCompleted = new ManualResetEvent(false);
            public static void StartListener()
            {
                byte[] bytes = new byte[1024];

                IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ip = ipHost.AddressList[0];
                IPEndPoint localEndPoint = new IPEndPoint(ip, 4343);
                Socket listener = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    listener.Bind(localEndPoint);
                    listener.Listen(100);

                    while (true)
                    {
                        allCompleted.Reset();
                        Console.WriteLine($"Waiting for incoming connections....");
                        listener.BeginAccept(new AsyncCallback(AcceptCallback), listener);
                        allCompleted.WaitOne();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            private static void AcceptCallback(IAsyncResult ar)
            {
                allCompleted.Set();
                Socket listener = (Socket)ar.AsyncState;
                Socket handler = listener.EndAccept(ar);

                ObjectState state = new ObjectState();
                state.wSocket = handler;
                handler.BeginReceive(state.buffer, 0, ObjectState.bufferSize, 0, new AsyncCallback(ReadCallback), state);
            }

            private static void ReadCallback(IAsyncResult ar)
            {
                string content = String.Empty;
                ObjectState state = (ObjectState)ar.AsyncState;
                Socket handler = state.wSocket;
                int byteRead = handler.EndReceive(ar);
                if (byteRead > 0)
                {
                    state.sb.Append(Encoding.ASCII.GetString(state.buffer, 0, byteRead));
                    content = state.sb.ToString();
                    if (content.IndexOf("<EOF>", StringComparison.Ordinal) > -1)
                    {
                        Console.WriteLine($"Read: {content.Length} bytes from \n socket Data: {content}");
                        Send(handler, content);
                    }
                    else
                    {
                        handler.BeginReceive(state.buffer, 0, ObjectState.bufferSize, 0, new AsyncCallback(ReadCallback), state);
                    }
                }
            }
            private static void Send(Socket handler, string content)
            {
                byte[] byteData = Encoding.ASCII.GetBytes(content);
                handler.BeginSend(byteData, 0, byteData.Length, 0, new AsyncCallback(SendCallback), handler);
            }

            private static void SendCallback(IAsyncResult ar)
            {
                try
                {
                    Socket handler = (Socket)ar.AsyncState;
                    int byteSent = handler.EndSend(ar);
                    Console.WriteLine($"Sent: {byteSent} to client");
                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
            static void Main(string[] args)
            {
                Console.WriteLine("press any key to cont....");
                Console.ReadLine();
                AsyncSocketListener.StartListener();
                Console.ReadLine();
            }
        }
    }

