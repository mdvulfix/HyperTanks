using System.Collections.Generic;

namespace HyperTanks.Framework
{
    
    
    public static class TileFactory<T> where T: Tile, new()
    {
        public static T CreateTile()
        {
            T tile = new T();
            return tile;
        }
    }
}