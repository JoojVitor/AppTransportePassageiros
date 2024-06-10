using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public class PessoaRepository : BaseRepository, IPessoaRepository
    {
        public PessoaRepository() { }

        public IEnumerable<Pessoa> Get()
        {
            throw new NotImplementedException();
        }

        public Pessoa Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
