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
            double userValue = 0.0;
            int userCount = 0;
            string userInput = "";
            while(userInput == "")
            {
                UI.Display("Please Enter the Game Title");
                userInput = UI.GetString();
                UI.DisplayInline("Game Title is required, please try again\n");
            }
            game.Name = userInput;
            userInput = "";
            while(userInput == "")
            {
                UI.Display("Please Enter the Game Manufacturer");
                userInput = UI.GetString();
                UI.DisplayInline("Somebody made this game, tell me\n");
            }
            game.Manufacturer = userInput;
            while (userValue <= 0)
            {
                UI.Display("Please Enter the Game Price");
                if (!double.TryParse(UI.GetString(), out userValue))
                {
                    UI.DisplayInline("Price must be a positive value. Please try again"); 
                }     
            }
            game.Price = userValue;
            UI.Display("Please Enter the Game Stock");
            while (!int.TryParse(UI.GetString(), out userCount))
            {
                UI.Display("Stock must be a whole number. Please try again");
            }
            game.Stock = userCount;
        }
    }
}
