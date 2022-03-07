using System;
using System.Collections.Generic;
using System.Text;

namespace big_mamma
{
    class order
    {
        private const double _tax = 1.25;
        private const double _delivery = 40;               
        private static int orderNum = 1;
        public order()
        {                                
            
        }

        private static void PrintInfo(pizza pizza)
        {            
            Console.WriteLine($"{pizza.name} er dette din bestilling");
            Console.WriteLine("order nr." + orderNum++);
            Console.WriteLine($"Price: {(pizza.Price * _tax) + _delivery} DKK");
        }

        public static void orderinformation()
        {            
            bool exit = false;            

            while (!exit)
            {
                Console.WriteLine("skriv navnet på den pizza du kunne tænke dig");
                Console.Write("Name/Command: ");
                switch (Console.ReadLine())
                {
                    case "bork":
                        PrintInfo(store.p1);
                        store.c1.customerinfo();
                        break;
                    case "olaf":
                        PrintInfo(store.p2);
                        store.c2.customerinfo();
                        break;
                    case "nunu":
                        PrintInfo(store.p3);
                        store.c3.customerinfo();
                        break;
                    case "exit":
                        exit = true;
                        return;
                    default:
                        Console.WriteLine("Invalid command" +
                                          "\ntry again");
                        continue;
                }
            }
        }
    }

}


    

 

