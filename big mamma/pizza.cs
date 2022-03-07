using System;
using System.Collections.Generic;
using System.Text;

namespace big_mamma
{

    public class pizza
    {
        private string _name;
        private string _topping;
        private double _price;        

        public pizza(string name, string topping, double price)
        {
            _name = name;
            _topping = topping;
            _price = price;
        }
        public string name
        {
            get { return _name; }
        }

        public double Price { get { return _price; } }
        public override string ToString()
        {
            return _topping;
        }
    }
}


