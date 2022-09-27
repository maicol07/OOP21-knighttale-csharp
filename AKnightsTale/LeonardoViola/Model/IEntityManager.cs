using AKnightsTale.LeonardoViola.Controller.interfaces;
using AKnightsTale.LeonardoViola.View.interfaces;
using AKnightsTale.SimoneRedighieri.model;

namespace AKnightsTale.LeonardoViola.Model
{
    public interface IEntityManager
    {
 
        ///<summary>
        /// Checks the collisions between all characters.
        /// </summary>
        /// <returns>A list of lists of characters who colliding with each other.</returns>
        IList<IList<IEntityController<ICharacter, IAnimatedEntityView>>> Update();
    
        ///<summary>
        /// Adds a new entity in the list of entities if it is not already present.
        /// <param name="ec">the new entity that will be added if it is not already present.</param>
        /// </summary>
        void AddEntity(IEntityController<ICharacter, IAnimatedEntityView> ec);
    
        ///<summary>
        /// Removes a entity from the entity list if it is present.
        /// <param name="ec">the entity will be removed if it is present.</param>
        /// </summary>
        void RemoveEntity(IEntityController<ICharacter, IAnimatedEntityView> ec);

        ///<summary>
        /// Gets the entity list.
        /// </summary>
        /// <returns>the entity list.</returns>
        List<IEntityController<ICharacter, IAnimatedEntityView>> GetEntities();
    
        ///<summary>
        /// Gets the collision manager.
        /// </summary>
        /// <returns>the collision manager.</returns>
        ICollisionManager GetCollisionManager();
    
        ///<summary>
        /// Sets the collision manager.
        /// <param name="collision">the collision manager.</param>
        /// </summary>
        void SetCollisionManager(ICollisionManager collision);
    }
}