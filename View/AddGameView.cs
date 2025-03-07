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
        internal void NewGame(GameStock inventory)
        {
            Game game = new Game();
            string userInput = "";
            UI.Display("Please Enter the Game Title");
            userInput = UI.GetString();
        }
    }
}
