
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HyperTanks
{
    public class SpawnHandler: MonoBehaviour
    {
 
        public void CreateBackgroundTiles()
        {
            var spawner = new TileSpawnerBackground();
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    var _tile = spawner.Instantiate(new Vector3(x, y));

                }
            }

        }
        

    }
}