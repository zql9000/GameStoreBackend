using AutoMapper;
using GameStore.Application.DTOs;
using GameStore.Domain.Entities;

namespace GameStore.Application.Support.Helpers
{
    public class GenreMap : Profile
    {
        public GenreMap()
        {
            CreateMap<GenreDto, Genre>();
            CreateMap<Genre, GenreDto>();
        }
    }
}
