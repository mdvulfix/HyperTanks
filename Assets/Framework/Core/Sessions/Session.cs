using UnityEngine;

namespace HyperTanks
{   namespace Framework
    {
        
        public class Session: MonoBehaviour
        {

            private ProcessInitialization processInitialization;
            private ProcessUpdating processUpdating;
            //private ProcessClose processClose;
            
            
            public Session()
            {
                processInitialization = new ProcessInitialization();
                processUpdating = new ProcessUpdating();

            }


            
            
            public void Start() 
            {

                processInitialization.OnStart();



            }      
            
        }
    }   
}