
namespace HyperTanks
{   namespace Framework
    {
        
    
        public class Map
        {
            public IMapSettings Settings{get; private set;}
            public IMapGenerator Generator {get; private set;}

            
            public Map()
            {

                this.Settings = new MapSettingsDefault();
                this.Generator = new MapGeneratorDefault();
                
            }
            public Map(IMapSettings settings, IMapGenerator generator)
            {

                this.Settings = settings;
                this.Generator = generator;
                
            }
                    
            
            public void Generate()
            {
                Generator.Create(Settings);

            }

        }
    } 
}