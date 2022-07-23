using System.ComponentModel.DataAnnotations;

namespace GameStore.Application.DTOs
{
    public class GenreDto
    {
        [Required(ErrorMessage = "La descripción es obligatoria")]
        [MinLength(3, ErrorMessage = "La descripción debe poseer un minimo de 3 caracteres")]
        public string Description { get; set; } = string.Empty;
    }
}
