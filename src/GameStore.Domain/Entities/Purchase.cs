using GameStore.Domain.Base;

namespace GameStore.Domain.Entities
{
    public class Purchase : BaseModel
    {
        public int GameId { get; set; }
        public int UserId { get; set; }
        public DateOnly Date { get; set; }
        public decimal Price { get; set; }
    }
}
