
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace HyperTanks
{
    public class Map : MonoBehaviour
    {
        public static GameObject Instance {get; private set;}  
        public static TileBackground[,] Grid {get; private set;}  
        
        public static GameObject[] Prefabs;
        
        
        //Экран переменных
        [SerializeField] private int width;
        [SerializeField] private int height;
        
        private ISettings settings;
        private IGenerators generator;

        private void Awake() 
        {
            
            Instance = transform.gameObject;

            settings = new SettingsDefault();
             
            Grid = new TileBackground[settings.Width, settings.Height];
            
            width = settings.Width;
            height = settings.Height;

            generator = new GeneratorDefault(settings);
            generator.Generate();


        }
        
        public static GameObject[] GetPrefab()
        {
            return Prefabs;

        }







    }


}