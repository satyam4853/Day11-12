using System;
using System.Collections.Generic;
using System.Text;

namespace Json
{
    class Inventor
    {
        public string name { get; set; }
        public double weight { get; set; }
        public double price { get; set; }

        public Inventor(string name, double weight, double price)
        {
            this.name = name;
            this.weight = weight;
            this.price = price;
        }

    }
}
