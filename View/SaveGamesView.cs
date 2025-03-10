/*/
*FILE : SaveGamesView.cs
* PROJECT : OOP Assignment 6
* PROGRAMMER : Brad Kajganich
* FIRST VERSION : 2025 - 3 - 9
* DESCRIPTION : Class for handling operations to Save a new inventory, replacing existing one if on file
/*/
using OOP_A06_Architecture.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_A06_Architecture.View
{
    class SaveGamesView
    {
        /// <summary>
        /// SaveData: Prompts user for filename, verifies deletion of current data, wipes inventory and loads new one if found.
        /// </summary>
        /// <param name="inventory"></param>
        /// <returns></returns>
        internal void SaveData(Inventory inventory)
        {
            string fileName = "";
            UI.ClearScreen();
            UI.Display("Enter the file name to save the existing inventory to");
            fileName = UI.GetString();
            Logic.WriteGamesToFile(fileName, Logic.SaveAsString(inventory));
        }
    }
}
