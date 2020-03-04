using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HyperTanks.Framework.Functions;

namespace HyperTanks.Map.Generators
{
    public class MapGenerationDefault
    {

        public static int Width = 10;
        public static int Height = 10;

        public static ITile[,] grid = new ITile[Width, Height];

        void Generate(int width, int height, int layer)
        {
            // Создаем карту;
            GameObject _map;
            _map = Functions.CreateObject("Map");
            _map.AddComponent<SpriteRenderer>();
            _map.GetComponent<SpriteRenderer>().sprite = Functions.CreateSprite(width: width, height: height);
            _map.GetComponent<SpriteRenderer>().sortingOrder = layer;   
            
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    grid [x,y]  = new TileBackground(new Vector3(x, y));

                }
            }  
        }
    }
}