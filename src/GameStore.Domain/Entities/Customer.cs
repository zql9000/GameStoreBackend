using GameStore.Domain.Base;

namespace GameStore.Domain.Entities
{
    public class Customer : BaseModel
    {
        public string Name { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public int CountryId { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public Country Country { get; set; }
    }
}
