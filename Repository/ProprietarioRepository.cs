using Repository.Interfaces;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    class ProprietarioRepository : BaseRepository, IProprietarioRepository
    {
        public void Create(Proprietario proprietario)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Proprietario> Get()
        {
            throw new NotImplementedException();
        }

        public Proprietario Get(long id)
        {
            throw new NotImplementedException();
        }

        public void Update(Proprietario proprietario)
        {
            throw new NotImplementedException();
        }
    }
}
