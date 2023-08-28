using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Net.Sockets;
using System.Net;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            int scee;
            byte[] data = new byte[1024];
            string input;
            string output;
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            IPEndPoint ipe = new IPEndPoint(ip, 8888);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
            EndPoint remote = (EndPoint)(sender);

            string s = "Client : Hello Server ! ";
            data = Encoding.ASCII.GetBytes(s);
            socket.SendTo(data, data.Length, SocketFlags.None, ipe);

            data = new byte[1024];
            scee = socket.ReceiveFrom(data, ref remote);
            Console.WriteLine(Encoding.ASCII.GetString(data, 0, scee));

            while (true)
            {
                data = new byte[1024];
                Console.Write("Nhap tu: ");

                output = Console.ReadLine();

                data = Encoding.ASCII.GetBytes(output);
                socket.SendTo(data, data.Length, SocketFlags.None, ipe);


                data = new byte[1024];
                scee = socket.ReceiveFrom(data, ref remote);
                Console.WriteLine(Encoding.ASCII.GetString(data, 0, scee));
            }
        }
    }
}
