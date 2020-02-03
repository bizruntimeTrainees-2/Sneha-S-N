﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace ConsoleApp1
{
    class SocketListener
    {
        static int Main(String[] args)
        { 
            StartServer();
            return 0;
        }
        public static void StartServer()
        {
            //Get Host IP Address that is used to establish a connection
            //In this case, we get one IP address of localhost that is IP 
            //If a host has multiple addresses, you will get a list of addresses
            IPHostEntry host = Dns.GetHostEntry("local host");
            IPAddress iPAddress = host.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(iPAddress, 11000);

            try
            {
                //Create a Socket that will use Tcp protocol
                Socket listener = new Socket(iPAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                //A Socket must be associated witha an endpoint using the Bind method
                listener.Bind(localEndPoint);
                //Specify how many requests a Socket can listen before it gives Server Busy Response
                //We will listen 10 requests at a time
                listener.Listen(10);

                Console.WriteLine("Waiting for a connection...");
                Socket handler = listener.Accept();

                //Incoming data from the client
                string data = null;
                byte[] bytes = null;

                while (true)
                {
                    bytes = new byte[1024];
                    int bytesRec = handler.Receive(bytes);
                    data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    if (data.IndexOf("<EOF>") > -1)
                    {
                        break;
                    }
                }
                
                Console.WriteLine("Text received : {0}", data);

                byte[] msg = Encoding.ASCII.GetBytes(data);
                handler.Send(msg);
                handler.Shutdown(SocketShutdown.Both);
                handler.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("\n Press any key to continue...");
            Console.ReadKey();
        }
    }
}
