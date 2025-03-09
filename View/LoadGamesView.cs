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
