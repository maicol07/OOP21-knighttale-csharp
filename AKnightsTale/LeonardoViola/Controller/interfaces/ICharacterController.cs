using AKnightsTale.Leonardo_Viola.View.interfaces;
using AKnightsTale.SimoneRedighieri.model;

namespace AKnightsTale.Leonardo_Viola.Controller.interfaces;

public interface ICharacterController <TM, TV> : IEntityController<TM, TV>
    where TM : ICharacter
    where TV : IAnimatedEntityView
{
    /// <summary>
    /// Moves right the entity and updates the view.
    /// </summary>
    void MoveRight();
    
    /// <summary>
    /// Moves left the entity and updates the view.
    /// </summary>
    void MoveLeft();
    
    /// <summary>
    /// Moves up the entity and updates the view.
    /// </summary>
    void MoveUp();
    
    /// <summary>
    /// Moves down the entity and updates the view.
    /// </summary>
    void MoveDown();
    
    /// <summary>
    /// Attacks the entities that are in attack range of this entity and updates the view.
    /// </summary>
    void Attack();
}