using GameStore.Domain.Base;

namespace GameStore.Domain.Entities
{
    public class Country : BaseModel
    {
        public string Name { get; set; } = string.Empty;
    }
}
