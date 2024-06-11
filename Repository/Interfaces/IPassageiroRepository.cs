using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IPassageiroRepository : IBaseRepository
    {
        IEnumerable<Passageiro> Get();
        Passageiro Get(long id);
        void Delete(long id);
        void Update(Passageiro passageiro);
        void Create(Passageiro passageiro);
    }
}
