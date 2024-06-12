using System;
using System.Collections.Generic;
using System.Linq;
using Repository;
using Repository.Models;

namespace Domain.Controllers
{
    public class PassageiroController
    {
        readonly PassageiroRepository _passageiroRepository = new PassageiroRepository();

        public void CreatePassageiro(Passageiro passageiro)
        {
            _passageiroRepository.Create(passageiro);
        }

        public List<Passageiro> GetAllPassageiros()
        {
           return _passageiroRepository.Get().ToList();
        }

        public Passageiro GetPassageiro(long cpf)
        {
            return _passageiroRepository.Get(cpf);
        }

        public void UpdatePassageiro(Passageiro passageiro)
        {
            _passageiroRepository.Update(passageiro);
        }

        public void DeletePassageiro(long cpf)
        {
            _passageiroRepository.Delete(cpf);
        }
    }
}
