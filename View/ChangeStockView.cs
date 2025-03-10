/*/
*FILE : ChangeStockView.cs
* PROJECT : OOP Assignment 6
* PROGRAMMER : Brad Kajganich
* FIRST VERSION : 2025 - 3 - 9
* DESCRIPTION : Class for handling operations to add or remove the number of stock of a game in a 
*               given gamelist
/*/
using OOP_A06_Architecture.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_A06_Architecture.View
{
    internal class ChangeStockView
    {

        /// <summary>
        /// RemoveStock: Takes a given GameList. Prompts user from game GUID and, if that GUID exists, prompts user
        ///              for how much of that stock to remove before removing it.
        /// </summary>
        /// <param name="gameList"></param>
        internal void RemoveStock(Inventory gameList)
        {
            Guid gameGuid = UI.GetGuid();
            int index = gameList.GuidIndex(gameGuid);
            if (index == -1)
            {
                UI.Display("The Game could not be found. Press amy key to continue.");
                UI.GetKey();
                return;
            }
            else
            {
                UI.Display("How much stock should we remove?");
                int units = UI.GetInt();
                gameList.GameList.ElementAt(index).Stock -= units;
            }
        }

        /// <summary>
        /// AddStock: Takes a given GameList. Prompts user from game GUID and, if that GUID exists, prompts user
        ///              for how much of that stock to add  before adding it.
        /// </summary>
        /// <param name="gameList"></param>
        internal void AddStock(Inventory gameList)
        {
            Guid gameGuid = UI.GetGuid();
            int index = gameList.GuidIndex(gameGuid);
            if (index == -1)
            {
                UI.Display("The Game could not be found. Press amy key to continue.");
                UI.GetKey();
                return;
            }
            else
            {
                UI.Display("How much stock should we add?");
                int units = UI.GetInt();
                gameList.GameList.ElementAt(index).Stock += units;
            }
        }
    }
}

