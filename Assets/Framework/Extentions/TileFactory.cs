namespace HyperTanks.Framework
{
    public static class TileFactory<T> where T: ATile, new()
    {
        public static T Create()
        {
            return new T();
        }
    }
}