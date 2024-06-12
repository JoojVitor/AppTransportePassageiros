using Repository.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Controllers
{
    public class ViagemController
    {
        readonly ViagemRepository _viagemRepository = new ViagemRepository();

        public void CreateViagem(Viagem viagem)
        {
            _viagemRepository.Create(viagem);
        }

        public List<Viagem> GetAllViagens()
        {
            return _viagemRepository.Get().ToList();
        }

        public Viagem GetViagem(long id)
        {
            return _viagemRepository.Get(id);
        }

        public void UpdateViagem(Viagem viagem)
        {
            _viagemRepository.Update(viagem);
        }

        public void DeleteViagem(long id)
        {
            _viagemRepository.Delete(id);
        }
    }
}
