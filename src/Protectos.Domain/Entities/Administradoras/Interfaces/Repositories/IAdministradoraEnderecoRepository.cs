using Protectos.Domain.Generics.Interfaces;
using System;

namespace Protectos.Domain.Entities.Administradoras.Interfaces.Repositories
{

    public interface IAdministradoraEnderecoRepository : IRepository<AdministradoraEndereco>
    {
        AdministradoraEndereco AdministradoraObterIdAdministradora(Guid adminitradoraId);
    }
}