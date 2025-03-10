/*/
*FILE : LoadGamesView.cs
* PROJECT : OOP Assignment 6
* PROGRAMMER : Brad Kajganich
* FIRST VERSION : 2025 - 3 - 9
* DESCRIPTION : Class for handling operations to Load a new inventory, replacing current one
/*/

using OOP_A06_Architecture.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_A06_Architecture.View
{
    class LoadGamesView
    {
        /// <summary>
        /// LoadData: Prompts user for filename, verifies deletion of current data, wipes inventory and loads new one if found.
        /// </summary>
        /// <param name="inventory"></param>
        /// <returns></returns>
        internal Inventory LoadData(Inventory inventory)
        {
            string fileName;
            Inventory games = new Inventory();
            UI.ClearScreen();
            UI.Display("Enter the file name to load inventory data from:");
            fileName = UI.GetString();
            if (UI.ConfirmOverwrite())
            {
                inventory.WipeInventory();
                games = Logic.ReadGames(fileName);
                return games;
            }
            return inventory;
        }
    }
}
