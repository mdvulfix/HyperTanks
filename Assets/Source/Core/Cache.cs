using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HyperTanks
{
    
    public class Cache : MonoBehaviour
    {
        public static List<Cache> Updatables = new List<Cache>(50);

        private void OnEnable() 
        {
            Updatables.Add(this);
            Debug.Log(gameObject.name + "has been added to cache!" );
        }

        private void OnDisable() 
        {
            Updatables.Remove(this);
        }

        public void UpdateAllUpdatables()
        {  
            OnUpdate();
        }

        public virtual void OnUpdate()
        {

        }

    }

}
