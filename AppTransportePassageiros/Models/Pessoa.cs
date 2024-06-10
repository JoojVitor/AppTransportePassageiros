using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public enum Sexo
    {
        M,  // Masculino
        F   // Feminino
    }

    public class Pessoa
    {
        public long Cpf { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public int? Telefone { get; set; }
        public Sexo? Sexo { get; set; }
        public string Email { get; set; }
    }
}
