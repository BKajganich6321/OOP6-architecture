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
