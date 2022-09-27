using AKnightsTale.SimoneRedighieri.model;

namespace AKnightsTale.LeonardoViola.View.interfaces
{
    internal interface ITile : IAnimatedEntityView
    {
        
        /// <summary>
        /// The tile's index
        /// </summary>
        int Index { get; }
        
        /// <summary>
        /// The Width
        /// </summary>
        double Width { get; set; }
        
        /// <summary>
        /// The Height
        /// </summary>
        double Height { get; set; }
        
        /*/// <summary>
        /// Get the index of the tile.
        /// Each tile is assigned a unique index to identify the different tiles.
        /// </summary>
        /// <returns>the tile's index.</returns>
        int GetIndex();*/
     
        /// <summary>
        /// get the type of the tile.
        /// </summary>
        /// <returns>the tile's type</returns>
        EntityType GetEntityType();

        /// <summary>
        /// The type of tile.
        /// </summary>
        bool Collidable { get; set; }
        
        /// <summary>
        /// Resize the tile.
        /// </summary>
        void Resize();

        /// <summary>
        /// Reposition the tile.
        /// </summary>
        void Reposition();
    }

}
