using AKnightsTale.MaicolBattistini.Controllers;

namespace AKnightsTale.MaicolBattistini.Views
{
    /// <summary>
    /// View interface
    /// </summary>
    /// <typeparam name="TC">Associated controller</typeparam>
    /// <typeparam name="TV">View interface</typeparam>
    public interface IView<in TC, TV>
        where TC : IController<TC, TV>
        where TV : IView<TC, TV>
    {
        /// <summary>
        /// Controller associated to this view
        /// </summary>
        TC Controller { set; }

        /// <summary>
        /// View name
        /// </summary>
        string ViewName { get; }
        
        /// <summary>
        /// View title
        /// </summary>
        string ViewTitle { get; }

        /// <summary>
        /// Shows the view.
        /// </summary>
        void Show();

        /// <summary>
        /// Hides the view.
        /// </summary>
        void Hide();

        /// <summary>
        /// Closes the view.
        /// </summary>
        void Close();

        // NOTE: Since this is a partial porting, we'll not cover view factories and view instantiation here.
    }
}