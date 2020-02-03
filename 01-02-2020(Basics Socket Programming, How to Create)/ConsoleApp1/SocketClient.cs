using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace ConsoleApp1
{
    class SocketClient
    {
        static int Main(String[] args)
        {
            StartClient();
            return 0;
        }
        public static void StartClient()
        {
            //Connect to Remote server
            //Get Host IP Address that is used to establish a connection
            //In this case, we get one IP address of localhost that is IP 
            //If a host has multiple addresses, you will get a list of addresses
            IPHostEntry host = Dns.GetHostEntry("local host");
            IPAddress ipAddress = host.AddressList[0];
            IPEndPoint remoteEP = new IPEndPoint(ipAddress, 11000);

            //Create a TCP/IP Protocol
            Socket sender = new Socket(ipAddress.AddressFamily,SocketType.Stream, ProtocolType.Tcp);

            //Connect the socket to the endpoint. Catch any errors.
            try
            {
                //Connect to remote endpoint
                sender.Connect(remoteEP);

                Console.WriteLine("Socket Connected to {0}", sender.RemoteEndPoint.ToString());

                //Encode the data string into a byte array.
                byte[] msg = Encoding.ASCII.GetBytes("This is test<EOF>");

                //Send the data through the socket.
                int bytessent = sender.Send(msg);

                //Receive the response from the remote device.
                int byteRec = sender.Receive(bytes);
                Console.WriteLine(Console.WriteLine("Echoed test = {0}", Encoding.ASCII.GetString(bytes, 0, bytesRec));

                // Release the socket.    
                sender.Shutdown(SocketShutdown.Both);
                sender.Close();

            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
            }
            catch (SocketException se)
            {
                Console.WriteLine("SocketException : {0}", se.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected exception : {0}", e.ToString());
            }

        }  

        catch (Exception e)  
        {  
            Console.WriteLine(e.ToString());  
        }
    }  
}  


         