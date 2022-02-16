using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn_Demo_2
{
    public class Client2
    {
        public void client2chat(string msg)
        {
            Client c1 = new Client();
            string i = "Y";
            FileStream f = new FileStream("c:\\DINESH~DK\\test2.txt", FileMode.Append);
            while (i=="Y")
            {
                Console.WriteLine("\nclient 1 sended you a message - "+msg);
                Console.Write("(client 2)Enter the message to send : ");
                string msgClient2 = Console.ReadLine();
                
                StreamWriter s = new StreamWriter(f);
                s.WriteLine("client 2 sent msg - " + msgClient2);
                s.Close();
                f.Close();
                Console.WriteLine("Enter Y to continue or Enter N to Close chat");
                i = Console.ReadLine();
                c1.clientchat(msgClient2);
            }
        }
    }
}
