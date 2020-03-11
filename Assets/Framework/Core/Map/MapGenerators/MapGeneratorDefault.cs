using UnityEngine;

namespace HyperTanks
{    namespace Framework
    {   public class MapGeneratorDefault: IMapGenerator
        {
            public ITile[,] grid;
            
            
            public void Create(IMapSettings settings)
            {
                
                var _width = settings.Resolution.x;
                var _height = settings.Resolution.y;
                
                // Создаем карту;
                GameObject _map;
                _map = Functions.CreateObject("Map");
                SpriteRenderer _spriteRenderer = _map.AddComponent<SpriteRenderer>();
                _spriteRenderer.sprite = Functions.CreateSprite(width: _width, height: _height);
                _spriteRenderer.sortingOrder = 0;   
                
                for (int y = 0; y < _height; y++)
                {
                    for (int x = 0; x < _width; x++)
                    {
                        grid [x,y]  = new TileBackground(new Vector3(x, y));

                    }
                }  
            }


        }

    }
}