using AKnightsTale.Leonardo_Viola.utils;
using AKnightsTale.SimoneRedighieri.model;

namespace AKnightsTale.Leonardo_Viola.View.interfaces;

public interface IAnimatedEntityView : IEntityView
{
    ///<summary>
    /// Sets the entity status.
    /// <param name="s">the new status.</param>
    /// </summary>
    void SetStatus(Status s);

    /*
     Impossible to convert because GraphicsContext doesn't exist in c#
    ///<summary>Draws the entity health bar on JavaFX Canvas.
    ///<param name="gc">the JavaFX Canvas.</param>
    ///<param name="x">the x coordinate of the top left corner of the health bar.</param>
    ///<param name="y">the y coordinate of the top left corner of the health bar.</param>
    ///<param name="health">the current health of the entity.</param>
    ///<param name="maxHealth">the maximum health of the entity.</param>
    /// </summary>
    void DrawHealthBar(GraphicsContext gc, double x, double y, double health, double maxHealth);
    */
    
    ///<summary>
    /// updates the image of the entity according to the direction in which it moves.
    /// <param name="d">the direction.</param> 
    /// </summary>
    void Update(Direction d);
}