using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;


namespace HandsOn_Demo_2
{ 
    class Program
    {

        
        public static void Main(string[] args)
        {
            int i = 1;
            Server s = new Server();
            List<string> list = new List<string>();
            Server.read r = new Server.read(list);
            Server.write w = new Server.write(list);
            Server.clear c = new Server.clear(list);
            Server.delete d = new Server.delete(list);
            Server.contains cont = new Server.contains(list);
            Server.CheckUser sc = new Server.CheckUser(list);
            Server.ReadHistory rd = new Server.ReadHistory();
            while (i == 1)
            {
                Console.Clear();
                Console.WriteLine("Enter 1 to Register\nEnter 2 to View all Clients\nEnter 3 to clear server\nEnter 4 to remove user\nEnter 5 to check user\nEnter 6 to chat\nEnter 7 to read chat history saved in server");
                Console.WriteLine("\n\nEnter you choice from the above list to proceed");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch ((choice))
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\n\nEnter the name to register as user\nYour user name and mobile number should follow the below format\nUser_999");
                        w.addItem(Console.ReadLine());
                        break;
                    case 2:
                        r.readItem();
                        Console.Clear();
                        break;
                    case 3:
                        c.clearItem();
                        Console.Clear();
                        break;
                    case 4:
                        d.deleteItem();
                        Console.Clear();
                        break;
                    case 5:
                        cont.containsItem();
                        Console.Clear();
                        break;
                    case 6:
                        if (sc.Checkuser())
                        {
                            Client cl = new Client();
                            Console.WriteLine("You are registered, you can proceed");
                            cl.clientchat(" ");
                        }
                        else
                        {
                            Console.WriteLine("User doesnt exist please register to chat");
                            Console.ReadKey();
                        }
                        break;
                    case 7:
                        rd.Read();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Enter the Right choice to proceed");
                        Console.Clear();
                        break;
                }
                Console.WriteLine("\n");
            }
            
        }
    }
}