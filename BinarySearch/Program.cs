using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree(80);
            tree.AddNode(20);
            tree.AddNode(60);
            tree.AddNode(90);
            tree.AddNode(100);
            tree.AddNode(85);
            tree.AddNode(15);

            Console.WriteLine("B.I.N.A.R.Y. T.R.E.E. 3001 Initialized..");
            Console.WriteLine("Printing inital tree..");
            Console.WriteLine("");
            tree.root.Print("", true);
            Console.WriteLine("");
            Console.WriteLine("Available commands: add, find, quit");
            while (true)
            {
                
                string [] input = Console.ReadLine().Split(' ');

                switch (input[0])
                {
                    case "add":
                        int a;
                        try
                        {
                            if (input.Length < 2)
                            {
                                Console.WriteLine("What value would you like to add?");
                                a = Int32.Parse(Console.ReadLine());
                            }
                            else
                                a = Int32.Parse(input[1]);
                            tree.AddNode(a);
                            Console.WriteLine("Printing new tree");
                            tree.root.Print("", true);
                        }
                        catch
                        {
                            Console.WriteLine("Error #2: could not add value, did you enter a number?");
                        }
                
                        break;

                    case "find":
                        int f;
                        try
                        {
                            if (input.Length < 2)
                            {
                                Console.WriteLine("What value would you like to add?");
                                f = Int32.Parse(Console.ReadLine());
                            }
                            else
                                f = Int32.Parse(input[1]);

                            Console.WriteLine("Finding path to value..");
                            tree.root.Find(f).ForEach(Console.WriteLine);

                        }
                        catch
                        {
                            Console.WriteLine("Error #3: could not find value, did you enter a number?");
                        }
                        break;
                    case "quit":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Error # 4: Not a valid command");
                        break;

                }
            }
           
           

        }

        
    }
}
