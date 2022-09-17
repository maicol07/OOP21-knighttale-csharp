using System.Collections.Immutable;
using AKnightsTale.MaicolBattistini.Controllers;

namespace AKnightsTale.MaicolBattistini.Views
{
    /// <summary>
    /// Scoreboard View interface
    /// </summary>
    public interface IScoreboardView: IView<IScoreboardController, IScoreboardView>
    {
        /// <summary>
        /// Updates the scoreboard.
        /// </summary>
        /// <param name="scoreboard">Updated scoreboard entries</param>
        void UpdateScoreboard(ImmutableHashSet<KeyValuePair<string, int>> scoreboard);
    }
}