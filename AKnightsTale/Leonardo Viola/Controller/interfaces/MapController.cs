using AKnightsTale.SimoneRedighieri.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKnightsTale.Leonardo_Viola.Controller.interfaces
{
    internal interface MapController : Controller<MapView>
    {


        /**
         * The constant NUM_COL.
         */
        int NUM_COL = 48;
        /**
         * The constant NUM_ROW.
         */
        int NUM_ROW = 27;

        /**
         * Draw map.
         */
        void drawMap();

        /**
         * Update the size of the tiles when the size of Windows changes.
         */
        void updateScreenSize();

        /**
         * Draw the enemies in the game world.
         */
        void drawEnemies();

        /**
         * Reposition all the entities when window's size change.
         */
        void repositionEntities();

        /**
         * Draw player in the game world.
         */
        void drawPlayer();

        /**
         * Update the entities and check if the game is over.
         */
        void update();

        /**
         * Gets the player.
         *
         * @return the player
         */
        CharacterController<? extends Character, ? extends AnimatedEntityView> getPlayer();

        /**
         * Makes the player stop in the game world.
         */
        void setIdlePlayer();

        /**
         * Update player.
         *
         * @param direction the new player's direction.
         */
        void updatePlayer(Direction direction);

        /**
         * Makes the player attack.
         */
        void playerAttack();

        /**
         * Makes enemies move in a new direction.
         */
        void moveEnemies();

        /**
         * Get the enemies in the map.
         */
        List<CharacterController<? super Character, ? super AnimatedEntityView>> getEnemies();

        /**
         * set a spawn position to entity.
         */
        void setSpawnPosition(CharacterController<? super Character, ? super AnimatedEntityView> entity);

        /**
         * Switch to main menu.
         */
        void returnToMainMenu();
  

    }
}
