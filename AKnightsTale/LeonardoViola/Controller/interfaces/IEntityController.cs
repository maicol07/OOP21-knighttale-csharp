using AKnightsTale.LeonardoViola.View.interfaces;
using AKnightsTale.SimoneRedighieri.model;

namespace AKnightsTale.LeonardoViola.Controller.interfaces
{
    public interface IEntityController <TM, TV>
        where TM : IEntity
        where TV : IEntityView
    
    {
        /// <summary>
        /// Gets the model of this entity.
        /// </summary>
        /// <returns>the model</returns>
        TM GetModel();
    
        /// <summary>
        /// Gets the view of this entity.
        /// </summary>
        /// <returns>the view</returns>
        TV GetView();
    
        /// <summary>
        /// Adapt position to screen size.
        /// <param name="traslX">the trasl x</param>
        /// <param name="traslY">the trasl y</param>
        /// </summary>
        void AdaptPositionToScreenSize(double traslX, double traslY);
    }
}