using Repository.Models;
using System.Collections.Generic;

namespace Repository.Interfaces
{
    interface IViagemRepository : IBaseRepository
    {
        IEnumerable<Viagem> Get();
        Viagem Get(long id);
        void Delete(long id);
        void Update(Viagem viagem);
        void Create(Viagem viagem);
    }
}
