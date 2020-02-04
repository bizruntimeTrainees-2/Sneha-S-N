using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ClientSocket
{
    class Program
    {
        static Socket socket;
        static IPAddress address;
        static int Port;
        static void Main(string[] args)
        {
            try
            {
                //make a socket coonection
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //IPAddress
                address = GetIPAddress();
                //set a specific portp
                Port = 1997;
                //Connect the socket with that port and ip
                socket.Connect(new IPEndPoint(address, Port));
                //Receive the message
                var receiveMessage = new Thread(Receive);
                receiveMessage.Start();

                //Send the message
                while (true)
                {
                    Byte[] SendData = Encoding.Default.GetBytes(Console.ReadLine());
                    socket.Send(SendData);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                //close the socket
                socket.Close();
            }
        }


        static IPAddress GetIPAddress()
        {
            string HostName = Dns.GetHostName();
            IPHostEntry address = Dns.GetHostEntry(HostName);
            IPAddress[] iPAddress = address.AddressList;
            return iPAddress[iPAddress.Length - 1];
        }
        public static void Receive()
        {
            while (true)
            {
                Thread.Sleep(500);
                byte[] Buffer = new byte[255];
                int bytesReceived = socket.Receive(Buffer, 0, Buffer.Length, 0);
                Array.Resize(ref Buffer, bytesReceived);
                string Data = Encoding.Default.GetString(Buffer);
                Console.WriteLine(Data);
            }
        }
    }
}
