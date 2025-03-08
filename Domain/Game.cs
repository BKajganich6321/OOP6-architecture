using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_A06_Architecture.Domain
{
    internal class Game
    {
        private static int baseID = 100;
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
        
        ///Constructors
        
        internal Game()
        {
            GameID = Guid.NewGuid();
        }

        internal Game(double price, string manufacturer, int stock, string name)
        {
            Price = price;
            GameID = Guid.NewGuid();
            Manufacturer = manufacturer;
            Stock = stock;
            Name = name;
        }

        //Methods

        internal void ChangeStock(Game game, int change)
        {
            game.Stock += change;
        }

        internal double StockWorth(Game game)
        {
            return game.Stock * game.Price;
        }
    }
}
