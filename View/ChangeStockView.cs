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

        internal void RemoveStock(Inventory gameList)
        {
            Guid gameGuid = UI.GetGuid();
            int index = gameList.GuidIndex(gameGuid);
            UI.Display("How much stock should we remove?");
            int units = UI.GetInt();
            if (index == -1)
            {
                UI.Display("The Game could not be found");
            }
            else
            {
                gameList.GameList.ElementAt(index).Stock += units;
            }
        }
        internal void AddStock(Inventory gameList)
        {
            Guid gameGuid = UI.GetGuid();
            int index = gameList.GuidIndex(gameGuid);
            UI.Display("How much stock should we add?");
            int units = UI.GetInt();
            if(index == -1)
            {
                UI.Display("The Game could not be found");
            }
            else
            {
                gameList.GameList.ElementAt(index).Stock += units;   
            }
        }
    }
}

