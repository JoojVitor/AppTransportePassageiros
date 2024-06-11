using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
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

            object[] param = new object[6];

            param[0] = pessoa.Nome;
            param[1] = pessoa.Cpf;
            param[2] = pessoa.Endereco;
            param[3] = pessoa.Telefone;
            param[4] = pessoa.Sexo;
            param[5] = pessoa.Email;

            cadastrosGrid.Rows.Insert(0, param);

            PessoaController pessoaController = new PessoaController();
            pessoaController.CreatePessoa(pessoa);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PessoaController pessoaController = new PessoaController();
            List<Pessoa> listPessoas = pessoaController.GetAllPessoas();

            foreach (Pessoa pessoa in listPessoas)
            {
                cadastrosGrid.Rows.Add(
                    pessoa.Nome,
                    pessoa.Cpf,
                    pessoa.Endereco,
                    pessoa.Telefone,
                    pessoa.Sexo,
                    pessoa.Email
                );
            }
        }

        private void excluirCadastroBtn_Click(object sender, EventArgs e)
        {
            PessoaController pessoaController = new PessoaController();
            
            foreach (DataGridViewRow row in cadastrosGrid.SelectedRows)
            {
                if (row.Selected)
                {
                    long pessoaCPF = Convert.ToInt64(row.Cells[1].Value);

                    cadastrosGrid.Rows.RemoveAt(row.Index);

                    pessoaController.DeletePessoa(pessoaCPF);
                }
            }
        }

        private void editarCadastroBtn_Click(object sender, EventArgs e)
        {
            PessoaController pessoaController = new PessoaController();
            List<Pessoa> changedRows = new List<Pessoa>();

            foreach (DataGridViewRow row in cadastrosGrid.Rows)
            {
                if (row.Tag != null && row.Tag.ToString() == "Alterado")
                {
                    Pessoa pessoa = new Pessoa
                    {
                        Nome = row.Cells[0].Value.ToString(),
                        Cpf = Convert.ToInt64(row.Cells[1].Value),
                        Endereco = row.Cells[2].Value.ToString(),
                        Telefone = Convert.ToInt32(row.Cells[3].Value),
                        Sexo = (Sexo?)Enum.Parse(typeof(Sexo), row.Cells[4].Value.ToString()),
                        Email = row.Cells[5].Value.ToString(),
                    };

                    changedRows.Add(pessoa);
                    pessoaController.UpdatePessoa(pessoa);
                }

                cadastrosGrid.Update();
            }
        }

        private void cadastrosGrid_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (cadastrosGrid.Rows[e.RowIndex].Tag == null)
            {
                cadastrosGrid.Rows[e.RowIndex].Tag = "Alterado";
            }
        }

        private void txtCPFCadastrar_Validated(object sender, EventArgs e)
        {
            if (txtCPFCadastrar.Text.Length == 0) return;

            PessoaController pessoaController = new PessoaController();
            Pessoa pessoa = pessoaController.GetPessoa(Convert.ToInt64(txtCPFCadastrar.Text));

            if (pessoa.Cpf != 0)
            {
                txtNomeCadastrar.Text = pessoa.Nome;
                txtTelefoneCadastrar.Text = pessoa.Telefone.ToString();
                txtEnderecoCadastrar.Text = pessoa.Endereco;
                txtEmailCadastrar.Text = pessoa.Email;

                if (pessoa.Sexo == Sexo.M)
                {
                    masculinoRadioBtn.Checked = true;
                } else
                {
                    femininoRadioBtn.Checked = true;
                }

                txtNomeCadastrar.Enabled = false;
                txtTelefoneCadastrar.Enabled = false;
                txtEnderecoCadastrar.Enabled = false;
                txtEmailCadastrar.Enabled = false;
                masculinoRadioBtn.Enabled = false;
                femininoRadioBtn.Enabled = false;

                return;
            }

            txtNomeCadastrar.Text = string.Empty;
            txtTelefoneCadastrar.Text = string.Empty;
            txtEnderecoCadastrar.Text = string.Empty;
            txtEmailCadastrar.Text = string.Empty;

            txtNomeCadastrar.Enabled = true;
            txtTelefoneCadastrar.Enabled = true;
            txtEnderecoCadastrar.Enabled = true;
            txtEmailCadastrar.Enabled = true;
            masculinoRadioBtn.Enabled = true;
            femininoRadioBtn.Enabled = true;
        }
    }
}
