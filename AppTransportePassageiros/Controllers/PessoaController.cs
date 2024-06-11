using System;
using System.Collections.Generic;
using System.Linq;
using Repository;
using Repository.Models;

namespace Domain
{
    public class PessoaController
    {
        readonly PessoaRepository _pessoaRepository = new PessoaRepository();

        public void CreatePessoa(Pessoa pessoa)
        {
            _pessoaRepository.Create(pessoa);
        }

        public List<Pessoa> GetAllPessoas()
        {
            return _pessoaRepository.Get().ToList();
        }

        public Pessoa GetPessoa(long cpf)
        {
            return _pessoaRepository.Get(cpf);
        }

        public void UpdatePessoa(Pessoa pessoa)
        {
            _pessoaRepository.Update(pessoa);
        }

        public void DeletePessoa(long cpf)
        {
            _pessoaRepository.Delete(cpf);
        }
    }
}
