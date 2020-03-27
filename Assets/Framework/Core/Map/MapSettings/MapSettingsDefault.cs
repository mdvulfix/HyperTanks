using System;
using System.Collections;
using System.Collections.Generic;

namespace HyperTanks.Framework
{
    public class MapSettingsDefault: IMapSettings
    {


        public List<IData> Data {get; private set;} 
        

        public MapSettingsDefault()
        {   
            var _resolution = new DataMapResolution();
            Data.Add(_resolution);
        }


        public void SetResolution(int width, int height)
        {
            foreach (var _data in Data)
            {
                if (_data.GetType() == typeof(DataMapResolution))
                {
                    var _resolution = _data as DataMapResolution;
                    _resolution.Width = width;
                    _resolution.Height = height;

                }
            }
        }
    }
}