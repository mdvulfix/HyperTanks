using UnityEngine;


namespace HyperTanks
{
    public class TilePropertiesBrick: ITileProperties
    {
        public Color TileColor {get; private set;} 

        public TilePropertiesBrick()
        {
            this.TileColor = Color.red;


        }


    }
}