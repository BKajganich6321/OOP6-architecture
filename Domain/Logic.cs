using OOP_A06_Architecture.Data_Access;
using OOP_A06_Architecture.View;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_A06_Architecture.Domain
{
    internal class Logic
    {
        DataRW dataRW = new DataRW();
        string record;
        string[] gameData;
        string[] gameArray;

        internal Inventory ReadGames(string fileName)
        {
            Inventory inventory = new Inventory();
            if (File.Exists(fileName))
            {
                record = dataRW.ReadOutput(fileName);
                if (record != "")
                {
                    gameData = record.Split('\n');
                    foreach (string element in gameData)
                    {
                        if(element != "")
                        {
                            gameArray = element.Split("|");
                            Game game = new Game();
                            game.Name = gameArray[0];
                            game.Manufacturer = gameArray[1];
                            game.Price = double.Parse(gameArray[2]);
                            game.GameID = Guid.Parse(gameArray[3]);
                            game.Stock = int.Parse(gameArray[4]);
                            inventory.AddGame(game);
                        }
                    }                    
                }
            }
            else
            {
                UI.Display("File does not exist. Press any key to try again");
                UI.GetKey();
            }
            return inventory;            
        }

        internal Inventory WriteGames(string fileName, Inventory games)
        {
        }
    }
}
