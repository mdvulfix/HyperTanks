using UnityEngine;

namespace HyperTanks
{
    public class TileBrick: ATiles, ITile
    {
        
        public ITileProperties TileProperties {get; private set;}

        public TileBrick()
        {
            this.TileProperties = new TilePropertiesBrick();
        }

        private void Awake() 
        {
            
            SpriteRenderer _sr = transform.GetComponent<SpriteRenderer>();
            _sr.color = TileProperties.TileColor;

        }


    }
}