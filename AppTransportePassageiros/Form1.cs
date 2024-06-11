using System;
using System.Windows.Forms;
using Repository.Models;

namespace Domain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salvarCadastroBtn_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa
            {
                Cpf = Convert.ToInt64(txtCPFCadastrar.Text),
                Nome = txtNomeCadastrar.Text,
                Endereco = txtEnderecoCadastrar.Text,
                Telefone = Convert.ToInt32(txtTelefoneCadastrar.Text),
                Email = txtEmailCadastrar.Text,
                Sexo = masculinoRadioBtn.Checked ?
                    Sexo.M : Sexo.F,
            };

            cadastrosGrid.Rows[0].Cells[0].Value = pessoa.Nome;
            cadastrosGrid.Rows[0].Cells[1].Value = pessoa.Cpf;
            cadastrosGrid.Rows[0].Cells[2].Value = pessoa.Endereco;
            cadastrosGrid.Rows[0].Cells[3].Value = pessoa.Telefone;
            cadastrosGrid.Rows[0].Cells[4].Value = pessoa.Sexo;
            cadastrosGrid.Rows[0].Cells[5].Value = pessoa.Email;
            cadastrosGrid.Rows.Add();

            PessoaController pessoaController = new PessoaController();
            pessoaController.CreatePessoa(pessoa);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PessoaController pessoaController = new PessoaController();
            var listPessoas = pessoaController.GetAllPessoas();

            foreach (var pessoa in listPessoas)
            {
                cadastrosGrid.Rows[0].Cells[0].Value = pessoa.Nome;
                cadastrosGrid.Rows[0].Cells[1].Value = pessoa.Cpf;
                cadastrosGrid.Rows[0].Cells[2].Value = pessoa.Endereco;
                cadastrosGrid.Rows[0].Cells[3].Value = pessoa.Telefone;
                cadastrosGrid.Rows[0].Cells[4].Value = pessoa.Sexo;
                cadastrosGrid.Rows[0].Cells[5].Value = pessoa.Email;
                cadastrosGrid.Rows.Add();
            }
        }
    }
}
