using UnityEngine;

namespace HyperTanks
{
    public abstract class ATile: MonoBehaviour
    {
        public Vector2Int Position {get; protected set;}
        public ITileProperties TileProperties {get; private set;}

        public ATile()
        {
            SetPosition(Vector2Int.zero);
            SetTileProperties(new TilePropertiesDefault()); 
        }
        
        public void SetPosition(Vector2Int position)
        {
            this.Position = position;
        }
        public void SetTileProperties(ITileProperties properties)
        {
            this.TileProperties = properties;
        }
    }
}