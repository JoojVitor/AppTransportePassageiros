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
            PessoaController pessoaController = new PessoaController();

            return pessoaController.GetAllPessoas();
        }

        public Pessoa Get(long cpf)
        {
            PessoaController pessoaController = new PessoaController();

            return pessoaController.GetPessoa(cpf);
        }
    }
}
