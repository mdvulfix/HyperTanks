
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HyperTanks
{
    public class SpawnHandler: MonoBehaviour
    {
        
        public GameObject _Tile;
        
        
        //public GameObject [] TilePrefabs;

        public GameObject InstantiateTile(Vector3 position)
        {
            
            GameObject _tile = null;
            /*
            foreach (GameObject prefab in TilePrefabs)
            {
                if(prefab.GetComponent<TileBackground>() != null)
                {
                    _tile = Instantiate(prefab, Vector2.zero, Quaternion.identity);
                    break;
                }

            }
            */

            _tile = Instantiate(_Tile, position, Quaternion.identity);
            _tile.transform.parent = this.transform;
            return _tile;
        }
        

    }
}