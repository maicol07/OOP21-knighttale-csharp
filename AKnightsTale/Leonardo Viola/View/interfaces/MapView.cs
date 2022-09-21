using AKnightsTale.Leonardo_Viola.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKnightsTale.Leonardo_Viola.View.interfaces
{
    internal interface MapView : View<MapController>
    {

        /**
        * Gets tile width.
        *
        * @return the tile width
        */
        double getTileWidth();

        /**
         * Gets tile height.
         *
         * @return the tile height
         */
        double getTileHeight();

        /**
         * Gets screen width.
         *
         * @return the current width of the game window
         */
        double getScreenWidth();

        /**
         * Gets screen height.
         *
         * @return the current width of the game window
         */
        double getScreenHeight();

        /**
         * Gets floor.
         *
         * @return the tile that represent the floor of the game world.
         */
        Tile getFloor();

        /**
         * Gets tree.
         *
         * @return the tile that represent the tree of the game world.
         */
        Tile getTree();

        /**
         * Gets tiles.
         *
         * @return a list that contains all the tiles used in the map
         */
        List<Tile> getTiles();

        /**
         * Delete all the tiles and entities present in the game world.
         */
        void clearMap();

        /**
         * draw tiles or entities in the game world. @param tile the tile
         *
         * @param x the x
         * @param y the y
         */
        void draw(EntityView tile, double x, double y);

        /**
         * Resize the size of all tiles of the game world.
         *
         * @param tileWidth  the new tile's width
         * @param tileHeight the tile height
         */
        void resizeTiles(double tileWidth, double tileHeight);

        /**
         * Initialize the game world.
         */
        void init();

        /**
         * Stop the game when it's finished.
         */
        void stopGame();


    }
}
