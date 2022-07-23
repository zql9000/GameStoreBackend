using GameStore.Application.Support.Helpers;

namespace GameStore.Application.Support
{
    public class AutoMapperConfig
    {
        public static Type[] RegisterMappings()
        {
            return new Type[]
            {
                typeof(GenreMap)
            };
        }
    }
}
