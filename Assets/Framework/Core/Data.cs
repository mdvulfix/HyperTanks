using UnityEngine;
namespace HyperTanks.Framework
{
    public class Data : MonoBehaviour, ICache
    {
        public void OnEnable()
        {
            Cache.Updatables.Add(this);
        }
        
        public void OnDisable()
        {
            Cache.Updatables.Add(this);
        }

        public void OnUpdate()
        {
            DataUpdate();
        }
        
        public virtual void DataUpdate()
        {

        }


    }
}
