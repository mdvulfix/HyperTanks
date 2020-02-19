using UnityEngine;


namespace HyperTanks
{
    public class TilePropertiesDefault: ITileProperties
    {
        public Color TileColor {get; private set;} 

        public TilePropertiesDefault()
        {
            this.TileColor = Color.black;


        }


    }
}