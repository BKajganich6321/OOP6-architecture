using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_A06_Architecture.Domain
{
    class Inventory
    {
        //Properties - Get/Sets

        private List<Game> gameList;
        private int count;

        internal List<Game> GameList { get { return gameList; } }
        internal int Count { get { return count; } }

        //Constructors
        internal Inventory()
        {
            gameList = new List<Game>();
            count = 0;
        }

        //Methods

        //Add a game
        internal void AddGame(Game game)
        {
            gameList.Add(game);
        }

        //Remove a game
        internal void RemoveGame(Game game)
        {
            gameList.Remove(game);
        }

        //Clear the List
        internal void WipeInventory()
        {
            gameList.Clear();
        }
    }
             
}
