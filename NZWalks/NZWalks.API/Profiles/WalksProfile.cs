using AutoMapper;

namespace NZWalks.API.Profiles
{
    public class WalksProfile : Profile
    {
        public WalksProfile()
        {
            CreateMap<Models.Domain.Walk, Models.DTO.Walk>();
            // use this only if variable names don't match   .ForMember(dest => dest.Id, options => options.MapFrom(src => src.Id));

        }
    }
}
