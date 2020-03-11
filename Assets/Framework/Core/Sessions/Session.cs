using UnityEngine;

namespace HyperTanks.Framework
{
    public class Session
    {

        private ProcessInitialization processInitialization;
        private ProcessUpdate processUpdate;
        
        
        public Session()
        {
            processInitialization = new ProcessInitialization();
            processUpdate = new ProcessUpdate();

        }


        
        
        public void Start() 
        {

            processInitialization.OnStart();
            processUpdate.OnStart();


        }      
        
        
        public void Update() 
        {
            processUpdate.OnUpdate();
        
        
        }



    }
}