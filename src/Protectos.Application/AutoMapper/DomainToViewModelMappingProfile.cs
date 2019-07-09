using AutoMapper;
using Protectos.Application.ViewModels.Administradoras;
using Protectos.Domain.Entities.Administradoras;

namespace Protectos.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {

            CreateMap<Administradora, AdministradoraViewModel>();
            CreateMap<AdministradoraEndereco, AdministradoraEnderecoViewModel>().ForMember(dest => dest.EnderecoId, opt => opt.MapFrom(src => src.Id));
            CreateMap<AdministradoraEmail, AdministradoraEmailViewModel>()
                .ForMember(dest => dest.EmailId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.TipoEmail, opt => opt.MapFrom(src => src.TipoEmail));
            CreateMap<AdministradoraTelefone, AdministradoraTelefoneViewModel>().ForMember(dest => dest.TelefoneId, opt => opt.MapFrom(src => src.Id));
            CreateMap<Administradora, AdministradoraCadastroViewModel>();
            CreateMap<AdministradoraEndereco, AdministradoraCadastroViewModel>();
            CreateMap<AdministradoraEmail, AdministradoraCadastroViewModel>();
            CreateMap<AdministradoraTelefone, AdministradoraCadastroViewModel>();
        }
    }
}