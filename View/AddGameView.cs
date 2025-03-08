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
        Logic logic = new Logic();
        internal void NewGame(Inventory inventory)
        {
            UI.ClearScreen();
            Game game = new Game();         
                
            UI.Display("Please Enter the Game Title");
            game.Manufacturer = UI.GetString();

            UI.Display("Please Enter the Game Manufacturer");
            game.Manufacturer = UI.GetString();
              
            UI.Display("Please Enter the Game Price");
            game.Price = UI.GetDouble();
            
            UI.Display("Please Enter the Game Stock");
            game.Stock = UI.GetInt();
        }
    }
}
