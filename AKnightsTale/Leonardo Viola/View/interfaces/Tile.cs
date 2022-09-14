using AKnightsTale.SimoneRedighieri.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKnightsTale.Leonardo_Viola.Model
{
    internal interface Tile : AnimatedEntityView
    {


        /**
            * Get the index of the tile.
            * Each tile is assigned a unique index to identify the different tiles.
            * @return the tile's index.*/
        int getIndex();

        /**
         * get the type of the tile.
         * @return the tile's type*/
        EntityType getEntityType();

        /**
         * set the new width of the tile.
         * @param width the new width*/
        void setWidth(double width);

        /**
         * set the new height of the tile.
         * @param height the new height*/
        void setHeight(double height);

        /**
         * set whether the tile should be able to be detected as an obstacle in collisions.
         * @param collidable true if it's collidable, false otherwise */
        void setCollidable(boolean collidable);

        boolean isCollidable();

        /**
         * get the width of the tile.
         * @return the tile's width*/
        double getWidth();

        /**
         * get the height of the tile.
         * @return the tile's height*/
        double getHeight();

        void resize();

        void reposition();
    }

}
