using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class Program
    {
        public static List<int> l = new List<int>();
        public static Socket client;

        static public string DaoNguocChuoi(string s)
        {
            string st = String.Empty;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                st += s[i];
            }

            return st;
        }

        static public string MaHoa1 (string s)
        {
            string st = String.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                //Console.WriteLine((char)(((int)s[i])-16));

                st = st + (char)(((int)s[i]) - 16);
            }

            return st;
        }

        static public string MaHoa2 (string s)
        {
            string st = String.Empty;
            int result = 0;

            if (s.Length % 2 == 0)
            {
                for (int i = 0; i < s.Length; i += 2)
                {
                    int t = (s[i] - '0') + (s[i + 1] - '0');
                    st = st + t.ToString();

                    //Console.WriteLine(t);

                    l.Add(t);

                    /*if ((i + 1) != (s.Length - 1))
                    {
                        result = result * 10;
                    }*/

                    //Console.WriteLine(s[i] + " " + s[i + 1] + " " + t + " " + st);
                }
            }
            else
            {
                for (int i = 0; i < s.Length - 1; i += 2)
                {
                    int t = (s[i] - '0') + (s[i + 1] - '0');
                    st = st + t.ToString();

                    //Console.WriteLine(t);

                    l.Add(t);

                    /*int t = (s[i] - '0') + (s[i + 1] - '0');
                    result = result + t;
                    if ((i + 1) != (s.Length - 2))
                    {
                        result = result * 10;
                    }*/

                    //Console.WriteLine(s[i] + " " + s[i + 1] + " " + t + " " + st);
                }

                l.Add(s[s.Length -1] - '0');
                st += s[s.Length - 1] + "0";
            }

            return st;
        }

        static public string MaHoa3 (string s)
        {
            string st = String.Empty;
            int sum = 0;

            foreach (int i in l)
            {
                //Console.WriteLine(i);
                sum = sum + i;
            }

            st = sum.ToString();

            return st;
        }

        static void Main(string[] args)
        {
            byte[] send = new byte[1024];
            byte[] receive = new byte[1024];
            int count = 0;

            IPAddress ip = IPAddress.Parse("127.0.0.1");
            IPEndPoint ipep = new IPEndPoint(ip, 9999);
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(ipep);
            server.Listen(10);

            Console.WriteLine("Server listening...");
            while (true)
            {
                client = server.Accept();

                int ive = client.Receive(receive);
                string s = Encoding.ASCII.GetString(receive, 0, ive);

                //Console.WriteLine(s);

                Console.WriteLine(DaoNguocChuoi(s));
                send = Encoding.ASCII.GetBytes(DaoNguocChuoi(s));
                client.Send(send, send.Length, SocketFlags.None);

                string mh1 = MaHoa1(s);
                Console.WriteLine(mh1);
                send = Encoding.ASCII.GetBytes(mh1);
                client.Send(send, send.Length, SocketFlags.None);

                string mh2 = MaHoa2(mh1);
                Console.WriteLine(mh2);
                send = Encoding.ASCII.GetBytes(mh2);
                client.Send(send, send.Length, SocketFlags.None);

                string mh3 = MaHoa3(mh2);
                Console.WriteLine(mh3);
                send = Encoding.ASCII.GetBytes(mh3);
                client.Send(send, send.Length, SocketFlags.None);
            }
        }
    }
}
