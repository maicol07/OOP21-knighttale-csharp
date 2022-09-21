using AKnightsTale.MaicolBattistini.Controllers;

namespace AKnightsTale.MaicolBattistini.Views
{
    /// <summary>
    /// 
    /// </summary>
    public interface IGameFinishedView: IView<IGameFinishedController, IGameFinishedView>
    {
        /// <summary>
        /// Set the score label value
        /// </summary>
        /// <param name="score">The score obtained in the game</param>
        void SetScoreLabel(int score);
    }
}