using UnityEngine;

namespace HyperTanks.Framework.Functions
{
    public class Functions: MonoBehaviour
    {
        //Создание игрового объекта на сцене
        public static GameObject CreateObject(string name)
        {        
            return new GameObject(name);
        }
        
        public static Sprite CreateSprite(int width = 1, int height = 1, Color color = default(Color))
        {

            Texture2D texture = new Texture2D (width, height);
        
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    texture.SetPixel(x, y, color);
                }
            }
            
            texture.Apply();
            texture.filterMode = FilterMode.Point;
            
            Rect rect = new Rect(0,0,width, height);
            return Sprite.Create(texture, rect, Vector2.zero, 1,0, SpriteMeshType.FullRect);
        
        }
    }
}