using Repository.Models;
using System.Collections.Generic;

namespace Repository.Interfaces
{
    interface IProprietarioRepository : IBaseRepository
    {
        IEnumerable<Proprietario> Get();
        Proprietario Get(long id);
        void Delete(long id);
        void Update(Proprietario proprietario);
        void Create(Proprietario proprietario);
    }
}
