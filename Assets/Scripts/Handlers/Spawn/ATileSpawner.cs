using UnityEngine;
namespace HyperTanks  
{
    

    public abstract class ATileSpawner: ASpawner
    {

        public abstract ITile Instantiate(Vector3 position);

        
        public override void Create(Vector3 position)
        {
            var _tile = Instantiate(position);

        }



    }
}