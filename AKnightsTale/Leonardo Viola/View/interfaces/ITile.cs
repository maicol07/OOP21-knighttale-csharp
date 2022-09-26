using AKnightsTale.SimoneRedighieri.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKnightsTale.Leonardo_Viola.View.interfaces
{
    internal interface ITile : AnimatedEntityView
    {
        
        /// <summary>
        /// Get the index of the tile.
        /// Each tile is assigned a unique index to identify the different tiles.
        /// </summary>
        /// <returns>the tile's index.</returns>
        int GetIndex();
     
        /// <summary>
        /// get the type of the tile.
        /// </summary>
        /// <returns>the tile's type</returns>
        EntityType GetEntityType();
        
        /// <summary>
        /// Set the new width of the tile.
        /// </summary>
        /// <param name="width">the new width</param>
        void SetWidth(double width);
        
        /// <summary>
        /// Set the new height of the tile.
        /// </summary>
        /// <param name="height">the new height</param>
        void SetHeight(double height);
        
        /// <summary>
        /// Set whether the tile should be able to be detected as an obstacle in collisions.
        /// </summary>
        /// <param name="collidable">true if it's collidable, false otherwise</param>
        void SetCollidable(bool collidable);

        /// <summary>
        /// Returns if it is collidable
        /// </summary>
        bool IsCollidable();

        /// <summary>
        /// get the width of the tile.
        /// </summary>
        /// <returns>the tile's width</returns>
        double GetWidth();
        
        /// <summary>
        /// get the height of the tile.
        /// </summary>
        /// <returns>the tile's height</returns>
        double GetHeight();

        void Resize();

        void Reposition();
    }

}
