using AutoMapper;
using GameStore.Application.DTOs;
using GameStore.Domain.Base;
using GameStore.Domain.Entities;
using GameStore.Domain.Repositories;

namespace GameStore.Application.Services.Implementation
{
    public class GenreService : IGenreService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGenreRepository _genreRepository;
        private readonly IMapper _mapper;

        public GenreService(IUnitOfWork unitOfWork,
            IGenreRepository genreRepository,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _genreRepository = genreRepository;
            _mapper = mapper;
        }

        public async Task<GenreDto> Create(GenreDto genreData)
        {
            GenreDto? createdGenre = null;

            var genre = _mapper.Map<Genre>(genreData);
            _genreRepository.Add(genre);

            await _unitOfWork.CompleteAsync();

            createdGenre = _mapper.Map<GenreDto>(genre);

            return createdGenre;
        }

        public Task<bool> Delete(int genreId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GenreDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public GenreDto GetById(int genreId)
        {
            throw new NotImplementedException();
        }

        public Task<GenreDto> Update(GenreDto genre)
        {
            throw new NotImplementedException();
        }
    }
}
