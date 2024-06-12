using Repository.Models;
using System.Collections.Generic;

namespace Repository.Interfaces
{
    interface IVeiculoRepository : IBaseRepository
    {
        IEnumerable<Veiculo> Get();
        Veiculo Get(string id);
        void Delete(string id);
        void Update(Veiculo veiculo);
        void Create(Veiculo veiculo);
    }
}
