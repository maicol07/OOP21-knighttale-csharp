using AKnightsTale.LeonardoViola.Controller.interfaces;
using AKnightsTale.LeonardoViola.View.interfaces;
using AKnightsTale.SimoneRedighieri.model;
using AKnightsTale.SimoneRedighieri.utils;

namespace AKnightsTale.LeonardoViola.Model
{
    public interface IEntityFactory
    {
        /// <summary>
        /// Gets the entity manager.
        /// </summary>
        /// <returns>the entity manager.</returns>
        IEntityManager GetEntityManager();
    
        /// <summary>
        /// Creates the player.
        /// <param name="p">The position of player.</param>
        /// </summary>
        /// <returns>The player.</returns>
        ICharacterController<ICharacter, IAnimatedEntityView> GetPlayer(Point<double> p);
    
        /// <summary>
        /// Creates the enemy.
        /// <param name="spawnPosition">the enemy's spawn position.</param>
        /// </summary>
        /// <returns>the enemy.</returns>
        ICharacterController<ICharacter, IAnimatedEntityView> GetEnemy(Point<double> spawnPosition);
    }
}
