
using UnityEngine;
namespace HyperTanks  
{
    

    public class TileSpawnerBackground: ATileSpawner
    {

        static GameObject prefab = Resources.Load("Assets/Prefabs/Tiles/TileBackground.prefab") as GameObject;
        
        public override ITile Instantiate(Vector3 position)
        {
            var _tile = MonoBehaviour.Instantiate(prefab, position, Quaternion.identity).gameObject;
            var _tileClass = _tile.GetComponent<ITile>() as TileBackground;
            return _tileClass;
        }
        



    }
}