using UnityEngine;

namespace HyperTanks
{
    public class Tank: AVehicle
    {

        public override void OnUpdate()
        {
            var val = Mathf.Sin(Time.time);
            transform.localScale = Vector3.one * val;

        }


    }
}