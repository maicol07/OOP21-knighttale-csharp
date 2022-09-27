using AKnightsTale.LeonardoViola.Model;
using AKnightsTale.LeonardoViola.View.interfaces;
using AKnightsTale.SimoneRedighieri.model;
using AKnightsTale.SimoneRedighieri.utils;

namespace AKnightsTale.LeonardoViola.Controller.interfaces
{
    public interface IEnemiesController
    {
        /// <summary>
        /// Draw enemies in the game world.
        /// </summary>
        void DrawEnemies(ICollisionManager collision, ICharacterController<ICharacter, IAnimatedEntityView> player);
    
        /// <summary>
        /// Remove dead enemies from game world.
        /// </summary>
        void RemoveDeadEnemies();
    
        /// <summary>
        /// Update enemies's direction.
        /// <param name="playerPosition">the player position</param>
        /// </summary>
        void UpdateDirection(Point<double> playerPosition);
    
        /// <summary>
        /// Adapt position to screen size.
        /// <param name="traslX">the trasl x</param>
        /// <param name="traslY">the trasl y</param>
        /// </summary>
        void AdaptPositionToScreenSize(double traslX, double traslY);
    
        /// <summary>
        /// Gets the number of enemies alive.
        /// </summary>
        /// <returns>the num enemy.</returns>
        int GetNumEnemy();
    
        /// <summary>
        /// create some enemies.
        /// <param name="numEnemies">the number of enemies to create</param>
        /// </summary>
        void CreateEnemies(int numEnemies);
    }
}