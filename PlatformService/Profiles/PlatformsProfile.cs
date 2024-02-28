using AutoMapper;
using PlatformServices.Dtos;
using PlatformServices.Models;

namespace PlatformServices.Profiles
{
  public class PlatformsProfile : Profile
  {
    public PlatformsProfile()
    {
      // Source -> Target
      CreateMap<Platform, PlatformReadDto>();
      
      // Target -> Source
      CreateMap<PlatformCreateDto, Platform>();
    }
  }
}