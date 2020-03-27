
namespace HyperTanks.Framework
{   
    public class ProcessUpdating: Process
    {
        public void Start()
        {
            Messanger.Send("Update process was started");
        
        }
        
        public void Update()
        {
            for (int i = 0; i < Cache.Updatables.Count; i++)
            {
                Cache.Updatables[i].OnUpdate();
            }

        }

        public void FixUpdate()
        {

            // Update some processes...

        }
        
        public void LateUpdate()
        {

            // Update some processes...

        }
    }
}   