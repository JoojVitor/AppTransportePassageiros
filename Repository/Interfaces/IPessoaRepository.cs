using Repository.Models;
using System.Collections.Generic;

namespace Repository.Interfaces
{
    public interface IPessoaRepository : IBaseRepository
    {
        IEnumerable<Pessoa> Get();
        Pessoa Get(long id);
        void Delete(long id);
        void Update(Pessoa pessoa);
        void Create(Pessoa pessoa);
    }
}
