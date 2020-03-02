namespace HyperTanks
{
    public class SettingsDefault: ASettings, ISettings
    {

        public int Height {get; private set;}
        public int Width {get; private set;}
        
        public SettingsDefault()
        {

            Height = 10;
            Width = 10;

        }


    }
}