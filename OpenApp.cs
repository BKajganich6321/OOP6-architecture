/*/
*FILE : OpenShop.cs
* PROJECT : OOP Assignment 6
* PROGRAMMER : Brad Kajganich
* FIRST VERSION : 2025 - 3 - 9
* DESCRIPTION : Class for handling menu display and user choices
/*/
using OOP_A06_Architecture.View;
using OOP_A06_Architecture.Domain;

namespace OOP_A06_Architecture
{
    internal class OpenShop
    {
        /// <summary>
        /// Declare initial menu and inventory objects and the SHop Applicaiton that handles the direct user interaction
        /// </summary>
        private MainMenuView view;
        private Inventory games;
        internal OpenShop()
        {
            view = new MainMenuView();
            games = new Inventory();
        }

        /// <summary>
        /// Initialization of primary Menu opperations, using a switch case and 8 circumstances to reacte to inputs thorugh 
        ///     a class object for each case respectively. Exits operations when bool "run" is changed througbh switch case 8
        /// </summary>
        internal void ShopInstance()
        {
            bool run = true;
            while (run)
            {
                view.MainMenu();
                int userInput = UI.GetInt();
                switch (userInput)
                {
                    case 1:
                        AddGameView addGame = new AddGameView();
                        addGame.NewGame(games);
                        break;
                    case 2:
                        RemoveGameView removeGame = new RemoveGameView();
                        removeGame.RemoveGame(games);
                        break;
                    case 3:
                        ChangeStockView moreStock = new ChangeStockView();
                        moreStock.AddStock(games);
                        break;
                    case 4:
                        ChangeStockView lessStock = new ChangeStockView();
                        lessStock.RemoveStock(games);
                        break;
                    case 5:
                        StockValueView stockList = new StockValueView();
                        stockList.DisplayGames(games);
                        break;
                    case 6:
                        LoadGamesView loadFile = new LoadGamesView();
                        games = loadFile.LoadData(games);
                        break;
                    case 7:
                        SaveGamesView saveFile = new SaveGamesView();
                        saveFile.SaveData(games);
                        break;
                    case 8:
                        run = false;
                        break;
                    default:
                        UI.Display("The number chosen must be a menu number, 1-8");
                        break;
                } 
            }
            return;
        }
    }
}
