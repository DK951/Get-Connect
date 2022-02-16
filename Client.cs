using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn_Demo_2
{
    public class Client
    {
        public void clientchat(string msg)
        {
            Client2 c2 = new Client2();
            string i = "Y";
            FileStream f = new FileStream("c:\\DINESH~DK\\test1.txt", FileMode.Append);
            while (i == "Y")
            {
                Console.WriteLine("\n\tclient 2 sended you a message - "+msg);
                Console.Write("(client 1)Enter your message to send : ");
                string msgClient1 = Console.ReadLine();
                
                StreamWriter s = new StreamWriter(f);
                s.WriteLine("client 1 sent msg - "+msgClient1);
                s.Close();
                f.Close();
                Console.WriteLine("Enter Y to continue or Enter N to Close chat");
                i = Console.ReadLine();
                c2.client2chat(msgClient1);
            }
        }
    }
}
