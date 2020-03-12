using UnityEngine;

namespace HyperTanks
{    namespace Framework
    {   public class MapGeneratorDefault: MonoBehaviour, IMapGenerator
        {
            
            private int width;                
            private int height;
            private int layer;
            private int AllLayers = 10;
            
            private GameObject mapFolder;
            private ITile[,,] map;
            
            
            public void Generate(IMapSettings settings)
            {
                mapFolder = Functions.CreateObject("MAP");
                map = new ITile[width,height, AllLayers];
                CreateMapLayer<TileBackground>(settings, "Background", 0);

            }
                       
            public void CreateMapLayer<T>(IMapSettings settings, string name, int layer)
            {
            
                width = settings.Resolution.x;
                height = settings.Resolution.y; 
            
                GameObject _mapBackground = Functions.CreateObject(name, mapFolder);
                SpriteRenderer _spriteRenderer = _mapBackground.AddComponent<SpriteRenderer>();
                _spriteRenderer.sprite = Functions.CreateSprite(width: width, height: height);
                _spriteRenderer.sortingOrder = 0;   
                
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        //map [x,y,layer]  =  TileFactory<T>.CreateTile() as ITile;

                    }
                }  

            }


        }

    }
}