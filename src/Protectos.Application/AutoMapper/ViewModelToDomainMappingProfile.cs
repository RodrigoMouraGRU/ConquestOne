using AutoMapper;
using Protectos.Application.ViewModels.Administradoras;
using Protectos.Domain.Entities.Administradoras;

namespace Protectos.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {          

            CreateMap<AdministradoraViewModel, Administradora>();
            CreateMap<AdministradoraEnderecoViewModel, AdministradoraEndereco>();
            CreateMap<AdministradoraEmailViewModel, AdministradoraEmail>();
            CreateMap<AdministradoraTelefoneViewModel, AdministradoraTelefone>();
            CreateMap<AdministradoraCadastroViewModel, Administradora>();
            CreateMap<AdministradoraCadastroViewModel, AdministradoraEndereco>();
            CreateMap<AdministradoraCadastroViewModel, AdministradoraEmail>();
            CreateMap<AdministradoraCadastroViewModel, AdministradoraTelefone>();          
        }
    }
}