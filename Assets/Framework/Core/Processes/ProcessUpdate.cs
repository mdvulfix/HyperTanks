

namespace HyperTanks
{   namespace Framework
    {   public class ProcessUpdate
        {
            public void OnStart()
            {
            
                Messanger.Send("Update process was started");
            
            
            }
            
            public void OnUpdate()
            {

                // Update some processes...
                for (int i = 0; i < Cache.Updatables.Count; i++)
                {
                    Cache.Updatables[i].UpdateAllUpdatables();
                }
            
        
            
            
            
            }

            public void OnFixUpdate()
            {

                // Update some processes...

            }
            
            public void OnLateUpdate()
            {

                // Update some processes...

            }


            

        }
    }

}   