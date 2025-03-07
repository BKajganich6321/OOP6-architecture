using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_A06_Architecture.View
{
    internal class MainMenuView
    {   
        internal void MainMenu()
        {
            UI.ClearScreen();
            UI.Display("1. Add a Game");
            UI.Display("2. Remove a Game");
            UI.Display("3. Increase Game Count");
            UI.Display("4. Decrease Game Count");
            UI.Display("5. Display Inventory and Asset Value");
            UI.Display("6. Load Inventory from Alternative File");
            UI.Display("7. Save Inventory to Alternative File");
            UI.Display("8. Exit");
        }

    }
}
