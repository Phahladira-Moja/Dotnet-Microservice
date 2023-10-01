using AutoMapper;
using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformService.Profiles
{
    public class PlatformsProfile : Profile // Profile is an auto-mapper class
    {
        public PlatformsProfile() 
        {
            // Source -> Target
            // Goes from Platform Model to PlatformReadDto
            CreateMap<Platform, PlatformReadDto>();

            // Goes from PlatformCreateDto to Platform Model
            CreateMap<PlatformCreateDto, Platform>();

        }
    }
}
