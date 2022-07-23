using GameStore.Domain.Base;

namespace GameStore.Domain.Entities
{
    public class Purchase : BaseModel
    {
        public int GameId { get; set; }
        public int CustomerId { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }

        public Game Game { get; set; }
        public Customer Customer { get; set; }
    }
}
