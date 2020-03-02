
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace HyperTanks
{
    public class GeneratorDefault: IGenerators
    {

        public ISettings MapSettings {get; private set;}

        public GeneratorDefault(ISettings settings)
        {
            this.MapSettings = settings;

        }

        public void Generate()
        {

            GameObject _map = Map.Instance;
            TileBackground[,] _grid  = Map.Grid;
            
            int _width = MapSettings.Width;
            int _height = MapSettings.Height;
            
            FunctionHandler.CreateSprite(obj: _map, width: _width, height: _height, layer: 0);
            SpawnHandler _spawner = Object.FindObjectOfType<SpawnHandler>();
            _spawner.CreateBackgroundTiles();
   
        }
    }
}