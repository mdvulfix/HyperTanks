using UnityEngine;

namespace HyperTanks
{
    public class TileBrick: ATile
    {
        public TileBrick()
        {
            SetPosition(Vector2Int.zero);
            SetTileProperties(new TilePropertiesBrick()); 
        }

    }
}