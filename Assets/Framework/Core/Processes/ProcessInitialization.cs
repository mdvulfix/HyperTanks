using UnityEngine;

namespace HyperTanks
{   namespace Framework
    {   public class ProcessInitialization
        {

            public void OnStart()
            {
                // Initialaze some processes...
                Messanger.Send("Initialization process was started");

                // Create map
                var _map = new Map();




            }
        }
    }
}