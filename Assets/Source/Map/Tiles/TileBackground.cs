using UnityEngine;

namespace HyperTanks
{
    public class TileBackground: ATiles, ITile
    {
               
        public ITileProperties TileProperties {get; private set;}

        public TileBackground(Vector2Int position)
        {
            this.Position = position;
            this.TileProperties = new TilePropertiesDefault();
        }
    }
}