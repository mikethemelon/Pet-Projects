using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] send = new byte[1024];
            byte[] receive = new byte[1024];

            IPAddress ip = IPAddress.Parse("127.0.0.1");
            IPEndPoint ipep = new IPEndPoint(ip, 9999);
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                server.Connect(ipep);
            }
            catch (SocketException e)
            {
                Console.WriteLine("Khong the ket noi den server");
                Console.WriteLine(e.ToString());
                return;
            }

            while (true)
            {
                string n = Console.ReadLine();
                send = Encoding.ASCII.GetBytes(n);
                server.Send(send, send.Length, SocketFlags.None);

                int ive = server.Receive(receive);
                string s = Encoding.ASCII.GetString(receive, 0, ive);
                Console.WriteLine(s);

                ive = server.Receive(receive);
                s = Encoding.ASCII.GetString(receive, 0, ive);
                Console.WriteLine(s);

                ive = server.Receive(receive);
                s = Encoding.ASCII.GetString(receive, 0, ive);
                Console.WriteLine(s);

                ive = server.Receive(receive);
                s = Encoding.ASCII.GetString(receive, 0, ive);
                Console.WriteLine(s);
            }
        }
    }
}
