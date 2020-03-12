using UnityEngine;

namespace HyperTanks
{   namespace Framework
    {
        
        public class Session: MonoBehaviour
        {

            private ProcessInitialization processInitialization;
            private ProcessUpdate processUpdate;
            //private ProcessClose processClose;
            
            
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
}