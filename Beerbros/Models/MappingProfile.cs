using AutoMapper;
using Beerbros.Web.Models.DTO;

namespace Beerbros.Web.Models
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Rating, RatingDTO>();
            CreateMap<RatingDTO, Rating>();
        }
    }
}
