using UnityEngine;

namespace HyperTanks
{
    public class TileBackground: ATiles, ITile
    {
               
        public ITileProperties TileProperties {get; private set;}

        public TileBackground(Vector3 position)
        {
            this.Position = position;
            this.TileProperties = new TilePropertiesDefault();
        }

        private void Start() 
        {
            
            transform.position = this.Position;

        }


    }
}