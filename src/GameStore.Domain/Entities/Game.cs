using GameStore.Domain.Base;

namespace GameStore.Domain.Entities
{
    public class Game : BaseModel
    {
        public int GenreId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Synopsis { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int DeveloperId { get; set; }
    }
}
