using UnityEngine;

namespace HyperTanks.Framework
{
    public class MapSettingsDefault: IMapSettings
    {
        public Vector2Int Resolution {get; private set;}

        
        public MapSettingsDefault()
        {   
            Resolution = new Vector2Int(100, 100);

        }
    



        public void SetResolution(Vector2Int resolution)
        {
            this.Resolution = resolution;


        }


    }
}