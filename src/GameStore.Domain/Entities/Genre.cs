using GameStore.Domain.Base;

namespace GameStore.Domain.Entities
{
    public class Genre : BaseModel
    {
        public string Description { get; set; } = string.Empty;
    }
}
