using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_A06_Architecture.Domain
{
    internal class Game
    {
        //Initialize the Properties of the struct
        private double price;
        private Guid gameID;
        private string manufacturer;
        private int stock;
        private string name;

        internal double Price
        {
            get { return price; }
            set { price = value; }
        }

        internal Guid GameID
        {
            get { return gameID; }
            set { gameID = value; }
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
        
        ///Constructors - first for one created in the application, 
        internal Game()
        {
            GameID = Guid.NewGuid();
        }
        // Second Constructor for instances created from the Data Access Files
        internal Game(double price, string manufacturer, int stock, string name)
        {
            Price = price;
            GameID = Guid.NewGuid();
            Manufacturer = manufacturer;
            Stock = stock;
            Name = name;
        }

        //Methods


        /// <summary>
        /// StockWorth - Returns a double: the product of the Stock of the Game (if positive) and the Game's assigned estimateed value
        /// </summary>
        /// <returns></returns>
        internal double StockWorth()
        {
            if (this.Stock > 0)
            {
                return this.Stock * this.Price;
            }
            else
            { 
                return 0;
            }
        }
    }
}
