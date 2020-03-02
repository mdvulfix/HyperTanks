
using UnityEngine;
namespace HyperTanks  
{
    

    public abstract class ASpawner: MonoBehaviour
    {
        public abstract void Create(Vector3 position);
    }
}