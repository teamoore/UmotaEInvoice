using AutoMapper;
using UmotaEFaturaWeb.Shared.ModelDto;
using UmotaEInvoice.Server.Data.Models;

namespace UmotaEFaturaWeb.Server.Services.Extensions
{
    public static class ConfigureMappingExtension
    {
        public static IServiceCollection ConfigureMapping(this IServiceCollection service)
        {
            var mappingConfig = new MapperConfiguration(mc => { mc.AddProfile(new MappingProfile()); });

            IMapper mapper = mappingConfig.CreateMapper();

            service.AddSingleton(mapper);

            return service;
        }
    }

    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            AllowNullDestinationValues = true;
            AllowNullCollections = true;

            CreateMap<SisKullanici, SisKullaniciDto>().ReverseMap();
            CreateMap<SisFirmaDonemYetki, SisFirmaDonemYetkiDto>().ReverseMap();
        }
    }
}
