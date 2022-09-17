using AKnightsTale.MaicolBattistini.Views;

namespace AKnightsTale.MaicolBattistini.Controllers
{
    /// <summary>
    /// Controller interface.
    /// </summary>
    /// <typeparam name="TC">Controller interface</typeparam>
    /// <typeparam name="TV">View associated to this controller</typeparam>
    public interface IController<TC, in TV>
        where TC: IController<TC, TV>
        where TV: IView<TC, TV>
    {
        /// <summary>
        /// View associated to this controller.
        /// </summary>
        TV? View { set; }
        
        /// <summary>
        /// Unregisters view from controller.
        /// </summary>
        void UnregisterView();

        /// <summary>
        /// Shows the view.
        /// </summary>
        void ShowView();

        /// <summary>
        /// Hides the view.
        /// </summary>
        void HideView();

        /// <summary>
        /// Closes the view.
        /// </summary>
        void CloseView();
    }
}