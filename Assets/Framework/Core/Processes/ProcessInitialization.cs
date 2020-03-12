using UnityEngine;

namespace HyperTanks
{   namespace Framework
    {   public class ProcessInitialization
        {

            public void OnStart()
            {
                // Initialaze some processes...
                Messanger.Send("Initialization process was started");

                // Create scene controller              
                //TODO: Create scene controller

                // Create game controller              
                var gameControl = new GameControl();
                Messanger.Send("Game controller was created");
                
                gameControl.CreateMap();
                
                // Create data controller
                //TODO: Create data controller

                // Create sound controller
                //TODO: Create sound controller

                //


              




            }
        }
    }
}