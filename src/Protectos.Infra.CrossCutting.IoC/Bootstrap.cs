using Protectos.Application.ApplicationServices.Administradoras;
using Protectos.Application.Interfaces.Administradoras;
using Protectos.Domain.Entities.Administradoras.Interfaces.Repositories;
using Protectos.Domain.Entities.Administradoras.Interfaces.Services;
using Protectos.Domain.Entities.Administradoras.Services;
using Protectos.Domain.Generics.Interfaces.Services;
using Protectos.Infra.CrossCutting.ExternalService.Services;
using Protectos.Infra.Data.Context;
using Protectos.Infra.Data.Interfaces;
using Protectos.Infra.Data.Repositories.Administradoras;
using Protectos.Infra.Data.UoW;
using SimpleInjector;
namespace Protectos.Infra.CrossCutting.IoC
{
    public class Bootstrap
    {
        public static void Register(Container container)
        {
            //Repositorio            
            container.Register<IAdministradoraRepository, AdministradoraRepository>(Lifestyle.Scoped);
            container.Register<IAdministradoraEnderecoRepository, AdministradoraEnderecoRepository>(Lifestyle.Scoped);
            container.Register<IAdministradoraEmailRepository, AdministradoraEmailRepository>(Lifestyle.Scoped);
            container.Register<IAdministradoraTelefoneRepository, AdministradoraTelefoneRepository>(Lifestyle.Scoped);

            //Application
            container.Register<IAdministradoraApplicationService, AdministradoraApplicationService>(Lifestyle.Scoped);
           

            ///Domain Service
            container.Register<IAdministradoraService, AdministradoraService>(Lifestyle.Scoped);          
            container.Register<IViaCepExternalService, ViaCepExternalService>(Lifestyle.Scoped);

            //UoC
            container.Register<IUnitOfWork, UnitOfWOrk>(Lifestyle.Scoped);
            //Context
            container.Register<ProtectosContext>(Lifestyle.Scoped);

        }
    }
}
