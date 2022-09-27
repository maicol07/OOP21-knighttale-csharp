using AKnightsTale.LeonardoViola.Controller.interfaces;
using AKnightsTale.LeonardoViola.View.interfaces;
using AKnightsTale.SimoneRedighieri.model;

namespace AKnightsTale.LeonardoViola.Model
{
    public interface ICollisionManager
    {
        ///<summary>
        /// Checks if a character has collisions with other characters.
        /// <param name="ec">the character to control.</param>
        /// </summary>
        /// <returns>a list of characters with whom he has collisions.</returns>
        List<IEntityController<ICharacter, IAnimatedEntityView>> CheckCollision(
            IEntityController<ICharacter, IAnimatedEntityView> ec);

    
        ///<summary>
        /// Controls in which directions the character can move.
        /// <param name="ec">the character to control.</param>
        /// </summary>
        /// <returns>a list of directions in which it can move</returns>
        List<Direction> CheckDirections(IEntityController<ICharacter, IAnimatedEntityView> ec);
        
        ///<summary>
        /// Controls the collisions of each character.
        /// </summary>
        /// <returns>a list of lists of characters colliding with each other.</returns>
        List<List<IEntityController<ICharacter, IAnimatedEntityView>>> Update();
    
    
        ///<summary>
        /// Set the width of screen.
        /// </summary>
        double WidthScreen { set; }
    
        ///<summary>
        /// Set the height of screen.
        /// </summary>
        double HeightScreen { set; }

    }
}