using OOP_A06_Architecture.View;

namespace OOP_A06_Architecture.Domain
{
    class Inventory
    {
        //Public Properties - Get/Sets

        private List<Game> gameList;

        internal List<Game> GameList { get { return gameList; } }
        internal int Count { get { return gameList.Count; } }

        //Constructors
        internal Inventory()
        {
            gameList = new List<Game>();
        }

        //Methods
        

        /// <summary>
        /// Bool that returns true if a guven Game is found in the inventory list
        /// </summary>
        /// <param name="game"></param>
        /// <returns></returns>
        internal bool Contains(Game game)
        {
            return gameList.Contains(game);
        }

        /// <summary>
        /// Function to take a given game and add it to the list of inventory
        /// </summary>
        /// <param name="game"></param>
        internal void AddGame(Game game)
        {
            gameList.Add(game);
        }

        /// <summary>
        /// RemoveGame - takes a given game and removes it from the inventory if it exists
        /// </summary>
        /// <param name="index"></param>
        internal void RemoveGame(int index)
        {
            gameList.RemoveAt(index);
        }

        /// <summary>
        /// Empty the inventory
        /// </summary>
        internal void WipeInventory()
        {
            gameList.Clear();
        }

        /// <summary>
        /// GuidIndex - Takes a given Guid and searches the inventory for it. If found, returns the index for the location of the
        ///             game with the corresponding Guid at that index. If not found, returns an index value of -1
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        internal int GuidIndex(Guid guid)
        {
            int index = -1;
            if (guid == Guid.Empty)
            {
                return index;
            }
            for (int counter = 0; counter < gameList.Count; counter++)
            {
                if (gameList[counter].GameID == guid)
                {
                    index = counter;
                    break;
                }
            }
            return index;
        }
    } 
}