using UnityEngine;

namespace HyperTanks.Framework
{
    public class ProcessorUpdate : AProcessor
    {

        public void Update() 
        {
            for (int i = 0; i < Cache.Updatables.Count; i++)
            {
                Cache.Updatables[i].UpdateAllUpdatables();
            }

        }


    }
}