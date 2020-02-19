
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

            for (int x = 0; x < _width; x++)
            {
                for (int y = 0; y < _height; y++)
                {
                    GameObject _tile = _spawner.InstantiateTile(new Vector3(x, y));
                    //FunctionHandler.CreateSprite(obj: _tile, width: 1, height: 1, layer: 1);
                    
                    
                    _grid[x, y] = _tile.GetComponent<TileBackground>();
                    //grid.Add(gridOfMap2D [x,y]);
                }
            } 
        }
    }
}