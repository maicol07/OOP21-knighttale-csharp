using AKnightsTale.SimoneRedighieri.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AKnightsTale.Leonardo_Viola.View.interfaces;

namespace AKnightsTale.Leonardo_Viola.Controller.interfaces
{
    internal interface IMapController : Controller<IMapView>
    {
        /// <summary>
        /// The constant NUM_COL.
        /// </summary>
        int NUM_COL = 48;

        /// <summary>
        /// The constant NUM_ROW.
        /// </summary>
        int NUM_ROW = 27;
        
        /// <summary>
        /// Draw map.
        /// </summary>
        void DrawMap();
        
        /// <summary>
        /// Update the size of the tiles when the size of Windows changes.
        /// </summary>
        void UpdateScreenSize();
        
        /// <summary>
        /// Draw the enemies in the game world.
        /// </summary>
        void DrawEnemies();
        
        /// <summary>
        /// Reposition all the entities when window's size change.
        /// </summary>
        void RepositionEntities();
        
        /// <summary>
        /// Draw player in the game world.
        /// </summary>
        void DrawPlayer();

        /// <summary>
        /// Update the entities and check if the game is over.
        /// </summary>
        void Update();
        
        /// <summary>
        /// Gets the player.
        /// </summary>
        /// <returns>the player</returns>
        CharacterController<ICharacter, AnimatedEntityView> GetPlayer();
        
        /// <summary>
        /// Makes the player stop in the game world.
        /// </summary>
        void SetIdlePlayer();
        
        /// <summary>
        /// Update player.
        /// </summary>
        /// <param name="direction ">the new player's direction.</param> 
        void updatePlayer(Direction direction);
        
        /// <summary>
        /// Makes the player attack.
        /// </summary>
        void PlayerAttack();
        
        /// <summary>
        /// Makes enemies move in a new direction.
        /// </summary>
        void MoveEnemies();
        
        /// <summary>
        /// Get the enemies in the map.
        /// </summary>
        List<CharacterController<? super ICharacter, ? super AnimatedEntityView>> getEnemies();
        
        /// <summary>
        /// set a spawn position to entity.
        /// <param name="entity">the entity whose location to be set</param>
        /// </summary>
        void SetSpawnPosition(CharacterController<? super ICharacter, ? super AnimatedEntityView> entity);

        /// <summary>
        /// Switch to main menu.
        /// </summary>
        void ReturnToMainMenu();
  

    }
}
