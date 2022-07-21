using GameStore.Domain.Base;

namespace GameStore.Domain.Entities
{
    public class Developer : BaseModel
    {
        public string Description { get; set; } = string.Empty;
    }
}
