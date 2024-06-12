using Repository.Models;
using Repository;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Controllers
{
    public class MotoristaController
    {
        readonly MotoristaRepository _motoristaRepository = new MotoristaRepository();

        public void CreateMotorista(Motorista motorista)
        {
            _motoristaRepository.Create(motorista);
        }

        public List<Motorista> GetAllMotorista()
        {
            return _motoristaRepository.Get().ToList();
        }

        public Motorista GetMotorista(long cpf)
        {
            return _motoristaRepository.Get(cpf);
        }

        public void UpdateMotorista(Motorista motorista)
        {
            _motoristaRepository.Update(motorista);
        }

        public void DeleteMotorista(long cpf)
        {
            _motoristaRepository.Delete(cpf);
        }
    }
}
