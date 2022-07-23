using GameStore.Domain.Base;

namespace GameStore.Domain.Entities
{
    public class Developer : BaseModel
    {
        public string Name { get; set; } = string.Empty;
    }
}
