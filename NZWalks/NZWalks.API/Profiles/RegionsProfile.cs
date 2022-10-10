using AutoMapper;

namespace NZWalks.API.Profiles
{
    public class RegionsProfile : Profile
    {
        public RegionsProfile()
        {
            CreateMap<Models.Domain.Region, Models.DTO.Region>();
             // use this only if variable names don't match   .ForMember(dest => dest.Id, options => options.MapFrom(src => src.Id));

        }
    }
}
