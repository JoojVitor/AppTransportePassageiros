using System.Collections.Generic;
using Domain;

namespace Repository.Interfaces
{
    public interface IPessoaRepository : IBaseRepository
    {
        IEnumerable<Pessoa> Get();
        Pessoa Get(int id);
    }
}
