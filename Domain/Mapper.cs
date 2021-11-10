using AutoMapper;
using Entities;
using Models;

namespace Domain
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            // Each member in the destination either needs to be mapped from the source, 
            // Or explicitly set to ignore it.  In this case, Id and Name are mapped, 
            // but Created is ignored as there is no equivalent in the source.
            CreateMap<Team, TeamEntity>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.TeamId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.TeamName))
                .ForMember(dest => dest.Created, opt => opt.Ignore());

            // If you were to comment out this mapping of individual, the above mapping would
            // error out as it would not know how to map the object.
            CreateMap<Individual, IndividualEntity>()
                .ForMember(dest => dest.Created, opt => opt.Ignore());
        }

    }
}
