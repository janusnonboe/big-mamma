using System;

namespace big_mamma
{
    class store
    {
        public static pizza p1 = new pizza("bork", "ost og tomatsovs", 60);
        public static pizza p2 = new pizza("olaf", "ost, tomatsovs og skinke", 65);
        public static pizza p3 = new pizza("nunu", "ost, tomatsovs og kebab", 70);

        public static customer c1 = new customer();
        public static customer c2 = new customer();
        public static customer c3 = new customer();

        static void Main(string[] args)
        {           
            Console.WriteLine("hvilken pizza vil du have");
            Console.WriteLine($"Nr1: {p1.name}");
            Console.WriteLine($"{p1.name} is with {p1}");

            Console.WriteLine($"Nr2: {p2.name}");
            Console.WriteLine($"{p2.name} is with {p2}");

            Console.WriteLine($"Nr3: {p3.name}");
            Console.WriteLine($"{p3.name} is with {p3}");            

            order o1 = new order();
            order o2 = new order();
            order o3 = new order();
           
            Console.WriteLine($" hvilken pizza vil du bestille");
           
            
            order.orderinformation();                                                            
        }       
    }
}
