
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HyperTanks
{
    public class FunctionHandler: MonoBehaviour
    {
        //Создание игрового объекта на сцене
        public static GameObject CreateObject(string name, string parent = null)
        {
                    
            GameObject obj = new GameObject(name);
            if (parent != null)
                obj.transform.parent = GameObject.Find(parent).transform;
      

            return obj;
        }
        
        public static void CreateSprite(GameObject obj, int width = 1, int height = 1, Color color = default(Color), int layer = 0)
        {
            SpriteRenderer objSR = obj.AddComponent<SpriteRenderer>();
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
            objSR.sprite =  Sprite.Create(texture, rect, Vector2.zero, 1,0, SpriteMeshType.FullRect);
            objSR.sortingOrder = layer;           
        }
    }
}