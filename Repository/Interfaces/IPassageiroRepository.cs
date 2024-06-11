using System;
using System.Collections.Generic;
using Repository.Models;

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
