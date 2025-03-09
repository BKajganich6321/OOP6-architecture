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
        internal void SaveData(Inventory inventory)
        {
            string fileName = "";
            UI.ClearScreen();
            UI.Display("Enter the file name to save the existing inventory to");
            fileName = UI.GetString();
            if(UI.ConfirmOverwrite())
            {
                Logic.WriteGamesToFile(fileName, Logic.SaveAsString(inventory));
            }
        }
    }
}
