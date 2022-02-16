using System;
using System.IO;
using System.Collections.Generic;
using System.Xml;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HandsOn_Demo_2
{
    class Server
    {
        XmlTextWriter textWriter = new XmlTextWriter("C:\\DINESH~DK\\ContactsSavedInServer.xml", null);
        public class write
        {
            private List<string> list;
            public write(List<String> list)
            {
                this.list = list;
            }

            // add items
            public void addItem(String item)
            {

                this.list.Add(item);
                Console.Clear();
                Console.WriteLine("\nUser registered successfully");
                Console.ReadKey();
            }
        }
       
        public class read
        {
            private List<String> list;

            // Receive shared list in constructor
            public read(List<String> list)
            {
                this.list = list;
            }
            XmlTextWriter textWriter = new XmlTextWriter("C:\\DINESH~DK\\Contacts.xml", null);
            public void readItem()
            {
                Console.Clear();
                Console.WriteLine("\nEnter the passcode");
                int code = Convert.ToInt32(Console.ReadLine());
                if (code == 762931)
                {
                    Console.Clear();
                    Console.WriteLine("\nNumber of users registered in this server");
                    textWriter.WriteStartDocument();
                    textWriter.WriteComment("Contacts saved in this sever");
                    textWriter.WriteComment("CREATED BY DINESH~DK");
                    foreach (String item in list)
                    {
                        textWriter.WriteString(item);
                        Console.WriteLine(item);
                    }
                    textWriter.WriteEndDocument();
                    // close writer  
                    textWriter.Close();
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\nEntered passcode is wrong, please try again");
                    Console.ReadKey();
                } 
            }
        }
        public class clear
        {
            private List<String> list;

            // Receive shared list in constructor
            public clear(List<String> list)
            {
                this.list = list;
            }

            // Read the items
            public void clearItem()
            {
                Console.Clear();
                Console.WriteLine("\nEnter the passcode");
                int code = Convert.ToInt32(Console.ReadLine());
                if (code == 762931)
                {
                    Console.Clear();
                    list.Clear();
                    Console.WriteLine("\nThe server is cleared successfully");
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\nEntered passcode is wrong, please try again");
                    Console.ReadKey();
                }
                
            }
        }
        public class delete
        {
            private List<String> list;

            // Receive shared list in constructor
            public delete(List<String> list)
            {
                this.list = list;
            }

            // Read the items
            public void deleteItem()
            {
                Console.Clear();
                Console.WriteLine("\nEnter the passcode");
                int code= Convert.ToInt32(Console.ReadLine());
                if (code == 762931)
                {
                    Console.Clear();
                    Console.WriteLine("\nEnter the Username to be removed");
                    list.Remove(Console.ReadLine());
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\nEntered passcode is wrong, please try again");
                    Console.ReadKey();
                }
            }
        }
        public class contains
        {
            private List<String> list;

            // Receive shared list in constructor
            public contains(List<String> list)
            {
                this.list = list;
            }

            // Read the items
            public bool containsItem()
            {
                Console.Clear();
                Console.WriteLine("\nEnter the Username to check");
                if (list.Contains(Console.ReadLine()))
                {
                    Console.Clear();
                    Console.WriteLine("\nUser found");
                    Console.ReadKey();
                    return true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\nUser not found");
                    Console.ReadKey();
                    return false;
                }
            }
        }
        public class CheckUser
        {
            private List<String> list;

            // Receive shared list in constructor
            public CheckUser(List<String> list)
            {
                this.list = list;
            }

            // Read the items
            public bool Checkuser()
            {
                Console.Clear();
                Console.WriteLine("\nEnter the Username and Mobile Number in the below format\n(User_999)");
                if (list.Contains(Console.ReadLine()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public class ReadHistory
        {
            public void Read()
            {
                Console.Clear();
                Console.WriteLine("\nEnter the passcode");
                int code = Convert.ToInt32(Console.ReadLine());
                if (code == 762931)
                {
                    ReadChat();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\nINVALID CODE");
                    Console.ReadKey();
                }
            }
            public void ReadChat()
            {
                Console.Clear();
                FileStream f1 = new FileStream("c:\\DINESH~DK\\test1.txt", FileMode.Open);
                StreamReader s1 = new StreamReader(f1);
                FileStream f2 = new FileStream("c:\\DINESH~DK\\test2.txt", FileMode.Open);
                StreamReader s2 = new StreamReader(f2);

                string line1 = s1.ReadLine();
                Console.WriteLine("\nChat history of Client 1\n");
                Console.WriteLine(line1);
                Console.WriteLine("\n\n");
                string line2 = s2.ReadLine();
                Console.WriteLine("\nChat history of Client 2\n");
                Console.WriteLine(line1);

                s1.Close();
                f1.Close();
                s2.Close();
                f2.Close();
                Console.ReadKey();
            }
        }
    }
}
