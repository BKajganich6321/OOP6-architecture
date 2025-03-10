/*/
*FILE : StockValueView.cs
* PROJECT : OOP Assignment 6
* PROGRAMMER : Brad Kajganich
* FIRST VERSION : 2025 - 3 - 9
* DESCRIPTION : Class for handling the display of all games in inventory, and the net value of the positive stock on hand
/*/
using OOP_A06_Architecture.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_A06_Architecture.View
{
    internal class StockValueView
    {
        /// <summary>
        /// Display Games - takes a given inventory and displays the game information, 1 game per line, on the screen
        /// game properties are pipe seperated, and at the bottom of the screen the total positive stock value and the
        /// total number of different Game Titles in the inventory are displayed
        /// </summary>
        /// <param name="inventory"></param>
        internal void DisplayGames(Inventory inventory)
        {
            double assets = 0;
            List<Game> games = inventory.GameList;
            foreach(Game game in games)
            {
                assets += game.StockWorth();
            }
            string gameString = Logic.SaveAsString(inventory);
            UI.ClearScreen();
            UI.Display(gameString + "\n");
            UI.Display("Total Games: " + inventory.Count);
            UI.Display("Total asset value: " + assets.ToString());
            UI.Display("Inventory display complete. Press any key to continue");
            UI.GetKey();
        }
    }
}
