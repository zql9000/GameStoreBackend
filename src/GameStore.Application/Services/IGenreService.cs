using GameStore.Application.DTOs;

namespace GameStore.Application.Services
{
    public interface IGenreService
    {
        Task<GenreDto> Create(GenreDto genre);
        Task<GenreDto> Update(GenreDto genre);
        Task<bool> Delete(int genreId);
        GenreDto GetById(int genreId);
        IEnumerable<GenreDto> GetAll();
    }
}
