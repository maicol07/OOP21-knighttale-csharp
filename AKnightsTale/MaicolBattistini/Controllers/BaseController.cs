using AKnightsTale.MaicolBattistini.Views;

namespace AKnightsTale.MaicolBattistini.Controllers
{
    /// <summary>
    /// Abstract controller class
    /// </summary>
    /// <typeparam name="TC">Controller interface</typeparam>
    /// <typeparam name="TV">View associated to this controller</typeparam>
    public abstract class BaseController<TC, TV>: IController<TC, TV>
        where TC : IController<TC, TV>
        where TV : IView<TC, TV>
    {
        /// <inheritdoc cref="IController{TC,TV}.View"/>
        public TV? View { private get; set; }
        
        /// <inheritdoc cref="IController{TC,TV}.UnregisterView"/>
        public void UnregisterView()
        {
            View = default;
        }

        /// <inheritdoc cref="IController{TC,TV}.ShowView"/>
        public void ShowView()
        {
            View?.Show();
        }

        /// <inheritdoc cref="IController{TC,TV}.HideView"/>
        public void HideView()
        {
            View?.Hide();
        }

        /// <inheritdoc cref="IController{TC,TV}.CloseView"/>
        public void CloseView()
        {
            View?.Close();
        }
    }
}