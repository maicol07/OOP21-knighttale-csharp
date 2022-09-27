using AKnightsTale.Leonardo_Viola.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AKnightsTale.Leonardo_Viola.Controller.interfaces;
using AKnightsTale.MaicolBattistini.Controllers;
using AKnightsTale.MaicolBattistini.Views;

namespace AKnightsTale.Leonardo_Viola.View.interfaces
{
    internal interface IMapView : IView<IMapController, IMapView>
    {
        
        /// <summary>
        /// The tile's Height
        /// </summary>
        double TileHeight { get; }
        
        /// <summary>
        /// The tile's Width
        /// </summary>
        double TileWidth { get; }
        
        /// <summary>
        /// Gets tiles.
        /// </summary>
        /// <returns>a list that contains all the tiles used in the map</returns>
        List<ITile> Tiles { get; }
        
        /*/// <summary>
        /// Gets tiles.
        /// </summary>
        /// <returns>a list that contains all the tiles used in the map</returns>
        List<ITile> GetTiles();*/
        
        
        /*/// <summary>
        /// Gets tile width.
        /// </summary>
        /// <returns>the tile width</returns>
        double GetTileWidth();
        
        /// <summary>
        /// Gets tile height.
        /// </summary>
        /// <returns>the tile height</returns>
        double GetTileHeight();*/
        
        /// <summary>
        /// Gets screen width.
        /// </summary>
        /// <returns>the current width of the game window.</returns>
        double GetScreenWidth();
        
        /// <summary>
        /// Gets screen height.
        /// </summary>
        /// <returns>the current width of the game window.</returns>
        double GetScreenHeight();
        
        /// <summary>
        /// Gets floor.
        /// </summary>
        /// <returns>the tile that represent the floor of the game world.</returns>
        ITile GetFloor();

        
        /// <summary>
        /// Gets tree.
        /// </summary>
        /// <returns>the tile that represent the tree of the game world.</returns>
        ITile GetTree();

        /// <summary>
        /// Delete all the tiles and entities present in the game world.
        /// </summary>
        void ClearMap();

        /// <summary>
        /// Draw tiles or entities in the game world.
        /// </summary>
        /// <param name="tile">The tile to draw</param>
        /// <param name="x">The x coordinate where to draw</param>
        /// <param name="y">The y coordinate where to draw</param>
        void Draw(IEntityView tile, double x, double y);

        /// <summary>
        /// Resize the size of all tiles of the game world.
        /// </summary>
        /// <param name="tileWidth">the new tile's width</param>
        /// <param name="tileHeight">the new tile's height</param>
        void ResizeTiles(double tileWidth, double tileHeight);
        
        /// <summary>
        /// Initialize the game world.
        /// </summary>
        void Init();
        
        /// <summary>
        /// Stop the game when it's finished.
        /// </summary>
        void StopGame();
    }
}
