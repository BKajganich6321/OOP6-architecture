/*/
*FILE : RemoveGamesView.cs
* PROJECT : OOP Assignment 6
* PROGRAMMER : Brad Kajganich
* FIRST VERSION : 2025 - 3 - 9
* DESCRIPTION : Class for handling operations to get user input GUID, search through a given inventory and remove
* any instances of that GUID (and correlated game) that are found
/*/

using OOP_A06_Architecture.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP_A06_Architecture.View
{
    class RemoveGameView
    {
        /// <summary>
        /// Remove Game - get user input GUID, search through a given inventory and remove game if found
        /// </summary>
        /// <param name="inventory"></param>
        internal void RemoveGame(Inventory inventory)
        {
            Guid guid = UI.GetGuid();
            int index = inventory.GuidIndex(guid);
            if (index == -1)
            {
                UI.Display("The game could not be found");
                return;
            }
            else
            {
                inventory.RemoveGame(index);
            }  
        }
    }
}
