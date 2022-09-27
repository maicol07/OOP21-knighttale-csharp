using System.Collections.Immutable;
using AKnightsTale.MaicolBattistini.Views;

namespace AKnightsTale.MaicolBattistini.Controllers
{
    /// <summary>
    /// Scoreboard controller interface
    /// </summary>
    public interface IScoreboardController: IController<IScoreboardController, IScoreboardView>
    {
        /// <summary>
        /// Get scoreboard entries
        /// </summary>
        /// <returns>Scoreboard entries</returns>
        IEnumerable<KeyValuePair<string, int>> GetScoreboard();
        /// <summary>
        /// Returns to main menu
        /// </summary>
        void ReturnToMainMenu();
    }
}