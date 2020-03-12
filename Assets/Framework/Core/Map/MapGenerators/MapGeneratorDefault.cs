using UnityEngine;

namespace HyperTanks
{    namespace Framework
    {   public class MapGeneratorDefault: IMapGenerator
        {
            
            private int layer;
            private int allLayers = 10;
            
            private GameObject mapFolder;
            private ATile[,,] map;
            
            
            public void Generate(IMapSettings settings)
            {
                mapFolder = Functions.CreateObject("MAP");
                map = new ATile[settings.Width, settings.Height, allLayers];
                CreateMapLayer<TileBackground>(settings, "Background", 0);

            }
                       
            
            private void CreateMapLayer<T>(IMapSettings settings, string name, int layer) where T: ATile, new()
            {
                
                for (int y = 0; y < settings.Height; y++)
                {
                    for (int x = 0; x < settings.Width; x++)
                    {
                        GameObject _mapBackground = Functions.CreateObject(name + " " + x.ToString() + ":" + y.ToString(), mapFolder);
                        SpriteRenderer _spriteRenderer = _mapBackground.AddComponent<SpriteRenderer>();
                        _spriteRenderer.sprite = Functions.CreateSprite(1, 1, Color.blue);
                        _spriteRenderer.sortingOrder = layer;   

                        T _tile = _mapBackground.AddComponent<T>();
                        _tile.SetPosition(new Vector2Int(x, y));
                        _mapBackground.transform.localPosition = (Vector3Int)_tile.Position;
                        map [x,y,layer]  =  _tile;
                    }
                }  
            }
        }
    }
}