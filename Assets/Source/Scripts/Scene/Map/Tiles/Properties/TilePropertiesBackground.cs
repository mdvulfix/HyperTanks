using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace HyperTanks
{
    public class TilePropertiesBackground: ITileProperties
    {
        public Color TileColor {get; private set;} 
       
        
        public TilePropertiesBackground()
        {
            this.TileColor = Color.green;

        }


    }
}