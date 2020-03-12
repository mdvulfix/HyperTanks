using UnityEngine;

namespace HyperTanks.Framework
{
    public class MapSettingsDefault: IMapSettings
    {
        public int Width {get; private set;}
        public int Height {get; private set;}

        
        public MapSettingsDefault()
        {   
            SetResolution(10, 10); 
        }
    

        public void SetResolution(int width, int height)
        {
            this.Width = width;
            this.Height = height;


        }


    }
}