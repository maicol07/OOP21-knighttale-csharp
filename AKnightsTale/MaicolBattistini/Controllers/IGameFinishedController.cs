using AKnightsTale.MaicolBattistini.Views;

namespace AKnightsTale.MaicolBattistini.Controllers
{
    /// <summary>
    /// Game finished view controller
    /// </summary>
    public interface IGameFinishedController: IController<IGameFinishedController, IGameFinishedView>
    {
        /// <summary>
        /// Score of the player
        /// </summary>
        int Score { get; set; }
        
        /// <summary>
        /// Saves the score.
        /// </summary>
        /// <param name="name">Saves the score</param>
        void SaveScore(string name);

        /// <summary>
        /// Shows the main menu
        /// </summary>
        void ShowMainMenu();

        /// <summary>
        /// Shows the scoreboard
        /// </summary>
        void ShowScoreboard();

        /// <summary>
        /// Starts the game
        /// </summary>
        void StartNewGame();
    }
}