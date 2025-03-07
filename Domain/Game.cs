using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_A06_Architecture.Domain
{
    internal class Game
    {
        private static double[] priceArray = {10.99, 24.99, 49.99, 39.99, 9.99, 59.99, 29.99, 19.99, 33.99 };
        private static int priceIndex = 0; 
        private double price;
        private int nameID;
        private string manufacturer;
        private int stock;
        private string name;

        internal double Price
        {
            get { return price; }
            set { price = value; }
        }

        internal int NameID
        {
            get { return nameID; }
            set { nameID = value; }
        }
        
        internal string Manufacturer
        {
            get { return manufacturer;}
            set { manufacturer = value; }
        }
        
        internal int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        internal string Name
        {
            get { return name; }
            set { name = value; }
        }         
    }
}
