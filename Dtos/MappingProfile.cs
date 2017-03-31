using AutoMapper;
using vega.Models;

namespace vega.Dtos
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeDto>();
            CreateMap<MakeDto, Make>();

            CreateMap<Feature, FeatureDto>();
            CreateMap<FeatureDto, Feature>();

            CreateMap<Model,ModelDto>();
            CreateMap<ModelDto, Model>();
            
        }
    }
}