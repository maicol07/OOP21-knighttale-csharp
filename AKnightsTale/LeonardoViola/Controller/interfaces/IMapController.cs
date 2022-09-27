using AKnightsTale.SimoneRedighieri.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AKnightsTale.Leonardo_Viola.View.interfaces;
using AKnightsTale.MaicolBattistini.Controllers;

namespace AKnightsTale.Leonardo_Viola.Controller.interfaces
{
    internal interface IMapController : IController<IMapController, IMapView>
    {
        /// <summary>
        /// The constant NUM_COL.
        /// </summary>
        const int NUM_COL = 48;

        /// <summary>
        /// The constant NUM_ROW.
        /// </summary>
        const int NUM_ROW = 27;
        
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
        ICharacterController<ICharacter, IAnimatedEntityView> GetPlayer();
        
        /// <summary>
        /// Makes the player stop in the game world.
        /// </summary>
        void SetIdlePlayer();
        
        /// <summary>
        /// Update player.
        /// <param name="direction ">the new player's direction.</param> 
        /// </summary>
        void UpdatePlayer(Direction direction);
        
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
        List<ICharacterController<ICharacter, IAnimatedEntityView>> GetEnemies();
        
        /// <summary>
        /// set a spawn position to entity.
        /// <param name="entity">the entity whose location to be set</param>
        /// </summary>
        void SetSpawnPosition(ICharacterController<ICharacter, IAnimatedEntityView> entity);

        /// <summary>
        /// Switch to main menu.
        /// </summary>
        void ReturnToMainMenu();
  

    }
}
