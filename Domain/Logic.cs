/*/
*FILE : Logic.cs
* PROJECT : OOP Assignment 6
* PROGRAMMER : Brad Kajganich
* FIRST VERSION : 2025 - 3 - 9
* DESCRIPTION : Class handling indirect operations between Domain/Data_Access namespaces
/*/
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
    static internal class Logic
    {
        //initializes an instanc of Data Access for reading/writing from file onto memoory
        static DataRW dataRW = new DataRW();

        /// <summary>
        /// Read Games - Takes a giiven filename and formats the existing inventory Data such that it can be saved to, loaded from
        ///             and externally viewed with understanding.  The ReadGames function calls the Data Access to provide the file, 
        ///             parses the data and saves it to a local copy of the list
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        static internal Inventory ReadGames(string fileName)
        {
            string[] gameArray;
            string[] gameData;
            string record = "";
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
        

        /// <summary>
        /// WriteGamesToFile = takes a string (derived from SaveAsString) and writes it to a given filename after con
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="entireInventory"></param>
        static internal void WriteGamesToFile(string fileName, string entireInventory)
        {
            if(File.Exists(fileName))
            {
                if (UI.ConfirmOverwrite())
                {
                    dataRW.WriteOutput(entireInventory, fileName);
                }
                else
                {
                    UI.Display("Save cancelled. Press any key to continue");
                    UI.GetKey();
                }
            }
            else
            {
                dataRW.WriteOutput(entireInventory, fileName);
            }
            
        }

        /// <summary>
        /// SaveAsString - Takes a given inventory and saves it to a string in the same format as would be read from an alternative file
        /// </summary>
        /// <param name="games"></param>
        /// <returns></returns>
        static internal string SaveAsString(Inventory games)
        {
            string tempGames = "";
            List<Game> gameArray = games.GameList;
            foreach (Game game in gameArray)
            {
                tempGames += game.Name + "|"
                           + game.Manufacturer + "|"
                           + game.Price.ToString() + "|"
                           + game.GameID.ToString() + "|"
                           + game.Stock.ToString() + "\n";
            }
            return tempGames;
        }
    }
}
