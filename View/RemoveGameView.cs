using OOP_A06_Architecture.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_A06_Architecture.View
{
    class RemoveGameView
    {
        internal void RemoveGame(Inventory inventory)
        {    
            int index = inventory.GuidIndex(UI.GetGuid());
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
