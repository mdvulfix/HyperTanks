
namespace HyperTanks
{   namespace Framework
    {
        public class GameControl
        {
            //Create map
            public void CreateMap()
            {
                var _map = new Map();
                _map.Generate();

            } 
        }
    }
}