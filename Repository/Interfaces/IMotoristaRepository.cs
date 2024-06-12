using Repository.Models;
using System.Collections.Generic;

namespace Repository.Interfaces
{
    interface IMotoristaRepository : IBaseRepository
    {
        IEnumerable<Motorista> Get();
        Motorista Get(long id);
        void Delete(long id);
        void Update(Motorista motorista);
        void Create(Motorista motorista);
    }
}
