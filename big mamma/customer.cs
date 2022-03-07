using System;
using System.Collections.Generic;
using System.Text;

namespace big_mamma
{
    class customer
    {



        public void customerinfo()

        {
            Console.WriteLine("dit navn?");
            string name = Console.ReadLine();

            Console.WriteLine("din adresse");
            string adresse = Console.ReadLine();

            Console.WriteLine("telefon nr?");
            string tlfnr = Console.ReadLine();

            Console.WriteLine("så dit navn er " + name);
            Console.WriteLine("adresse " +  adresse);
            Console.WriteLine("telefon nr " +  tlfnr);
        }


    }
}
