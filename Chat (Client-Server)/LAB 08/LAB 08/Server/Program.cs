using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Net.Sockets;
using System.Net;


namespace LAB_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int scee;
            byte[] data = new byte[1024];
            string input;
            IPAddress ip = IPAddress.Any;
            IPEndPoint ipe = new IPEndPoint(ip, 8888);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.Bind(ipe);
            Console.WriteLine("\nServer waiting for a client...");
            Console.WriteLine("\n");

            IPEndPoint sender = new IPEndPoint(IPAddress.Any,0);
            EndPoint remote = (EndPoint)(sender);

            scee = socket.ReceiveFrom(data, ref remote);
            Console.WriteLine(Encoding.ASCII.GetString(data, 0, scee));

            data = new byte[1024];
            string s = "Server : Hello Client ! ";
            data = Encoding.ASCII.GetBytes(s);
            socket.SendTo(data, data.Length, SocketFlags.None, remote);

            while (true)
            {
                data = new byte[1024];
                scee = socket.ReceiveFrom(data, ref remote);
                Console.Write("Client: ");
                Console.WriteLine(Encoding.ASCII.GetString(data, 0, scee));

                Console.Write("Server: ");
                input = Console.ReadLine();
                if (input== "exit")
                {
                    break;
                }
                data = Encoding.ASCII.GetBytes(input);
                socket.SendTo(data, data.Length, SocketFlags.None, remote);
            }


        }
    }
}
