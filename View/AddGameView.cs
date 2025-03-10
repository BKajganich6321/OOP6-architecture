/*/
*FILE : AddGameView.cs
* PROJECT : OOP Assignment 6
* PROGRAMMER : Brad Kajganich
* FIRST VERSION : 2025 - 3 - 9
* DESCRIPTION : Class for handling operations to add a game to inventory
/*/
using OOP_A06_Architecture.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_A06_Architecture.View
{
    internal class AddGameView
    {
        /// <summary>
        /// Function NewGame that gets input from a User to create a game and send that game into a given inventory
        /// </summary>
        /// <param name="inventory"></param>
        internal void NewGame(Inventory inventory)
        {
            UI.ClearScreen();
           
            UI.Display("Please Enter the Game Title");
            string name = UI.GetString();

            UI.Display("Please Enter the Game Manufacturer");
            string manufacturer = UI.GetString();
              
            UI.Display("Please Enter the Game Price");
            double price = UI.GetDouble();
            
            UI.Display("Please Enter the Game Stock");
            int stock = UI.GetInt();

            Game game = new Game(price, manufacturer, stock, name);

            inventory.AddGame(game);
        }
    }
}
