using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using Repository.Models;
using Domain.Controllers;
using System.Linq;

namespace Domain
{
    public partial class Form1 : Form
    {
        bool _origemValidated = false;
        bool _destinoValidated = false;

        Motorista _motorista = new Motorista();
        Veiculo _veiculo = new Veiculo();

        public Form1()
        {
            InitializeComponent();
        }

        private void salvarCadastroBtn_Click(object sender, EventArgs e)
        {
            PessoaController pessoaController = new PessoaController();
            PassageiroController passageiroController = new PassageiroController();
            ViagemController viagemController = new ViagemController();

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

            Passageiro passageiro = new Passageiro
            {
                Cpf = Convert.ToInt64(txtCPFCadastrar.Text),
                BandeiraCartao = "VISA",
                CartaoCred = txtCartaoCreditoCadastrar.Text,
                CidadeOrig = txtCidadeOrigemCadastrar.Text
            };

            TipoPagamento tipoPagamento = new TipoPagamento();

            switch (cbFormaPagamentoCadastrar.Text)
            {
                case "Dinheiro":
                    tipoPagamento = new TipoPagamento
                    {
                        CodPagto = 1,
                        DescPagto = cbFormaPagamentoCadastrar.Text
                    };
                break;

                case "Pix":
                    tipoPagamento = new TipoPagamento
                    {
                        CodPagto = 2,
                        DescPagto = cbFormaPagamentoCadastrar.Text
                    };
                break;

                case "Cartão":
                    tipoPagamento = new TipoPagamento
                    {
                        CodPagto = 3,
                        DescPagto = cbFormaPagamentoCadastrar.Text
                    };
                break;
            }           

            Viagem viagem = new Viagem
            {
                Passageiro = passageiro,
                Motorista = _motorista,
                Veiculo = _veiculo,
                LocalOrigem = txtLocalOrigemCadastrar.Text,
                LocalDestino = txtLocalDestinoCadastrar.Text,
                DtHoraInicio = DateTime.UtcNow,
                DtHoraFim = DateTime.UtcNow.AddMinutes(15),
                CancelamMotorista = Cancelamento.N,
                CancelamPassageiro = Cancelamento.N,
                FormaPagto = tipoPagamento,
                QtdePass = 1,
                ValorPagto = Convert.ToDecimal(txtValorCadastrar.Text)
            };  

            Pessoa consultaPessoa = pessoaController.GetPessoa(Convert.ToInt64(txtCPFCadastrar.Text));

            if (consultaPessoa.Cpf == 0)
            {
                pessoaController.CreatePessoa(pessoa);
                passageiroController.CreatePassageiro(passageiro);

                object[] param = new object[6];

                param[0] = pessoa.Nome;
                param[1] = pessoa.Cpf;
                param[2] = pessoa.Endereco;
                param[3] = pessoa.Telefone;
                param[4] = pessoa.Sexo;
                param[5] = pessoa.Email;

                cadastrosGrid.Rows.Insert(0, param);
            }

            viagemController.CreateViagem(viagem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ViagemController viagemController = new ViagemController();
            PessoaController pessoaController = new PessoaController();
            VeiculoController veiculoController = new VeiculoController();

            List<Pessoa> listPessoas = pessoaController.GetAllPessoas();
            List<Viagem> listViagens = viagemController.GetAllViagens();
            List<Veiculo> listVeiculos = veiculoController.GetAllVeiculo();

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

            foreach (Viagem viagem in listViagens)
            {
                historicoGrid.Rows.Add(
                    viagem.Motorista.Cpf,
                    viagem.Passageiro.Cpf,
                    viagem.Veiculo.Placa,
                    viagem.LocalOrigem,
                    viagem.LocalDestino,
                    viagem.DtHoraInicio,
                    viagem.DtHoraFim,
                    viagem.QtdePass,
                    viagem.FormaPagto.CodPagto,
                    viagem.ValorPagto,
                    viagem.CancelamMotorista.ToString()
                );
            }

            foreach (Veiculo veiculo in listVeiculos)
            {
                veiculosGrid.Rows.Add(
                    veiculo.Placa,
                    veiculo.Marca,
                    veiculo.Modelo,
                    veiculo.AnoFabric,
                    veiculo.CapacidadePass,
                    veiculo.Cor,
                    veiculo.TipoCombust,
                    veiculo.PotenciaMotor
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

        private void txtLocalOrigemCadastrar_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLocalOrigemCadastrar.Text))
            {
                txtValorCadastrar.Text = string.Empty;
                _origemValidated = false;
                return;
            }

            _origemValidated = true;
            FillValue();
        }

        private void txtLocalDestinoCadastrar_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLocalDestinoCadastrar.Text))
            {
                txtValorCadastrar.Text = string.Empty;
                _destinoValidated = false;
                return;
            }

            _destinoValidated = true;
            FillValue();
        }

        private void FillValue()
        {
            if (_destinoValidated && _origemValidated && string.IsNullOrEmpty(txtValorCadastrar.Text))
            {
                Random rnd = new Random();

                decimal valor = Convert.ToDecimal(rnd.Next(8, 50) + rnd.NextDouble());
                txtValorCadastrar.Text = valor.ToString("0.00");
            }
        }

        private void btnBuscarMotorista_Click(object sender, EventArgs e)
        {
            MotoristaController motoristaController = new MotoristaController();
            PessoaController pessoaController = new PessoaController();
            VeiculoController veiculoController = new VeiculoController();

            Random rnd = new Random();
            List<Motorista> listMotoristas = motoristaController.GetAllMotorista();
            _motorista = listMotoristas[rnd.Next(0, 5)];

            List<Veiculo> listVeiculo = veiculoController.GetAllVeiculo();
            _veiculo = listVeiculo[rnd.Next(0, 3)];

            Pessoa pessoa = pessoaController.GetPessoa(_motorista.Cpf);

            txtNomeMotorista.Text = pessoa.Nome;
            txtPlacaVeiculo.Text = _veiculo.Placa;
            txtMarcaVeiculo.Text = _veiculo.Marca;
            txtModeloVeiculo.Text = _veiculo.Modelo;
        }

        private void pesquisarHistBtn_Click(object sender, EventArgs e)
        {
            List<Viagem> listViagens = new List<Viagem>();

            foreach (DataGridViewRow row in historicoGrid.Rows)
            {
                Viagem viagem = new Viagem
                {
                    Motorista = new Motorista { Cpf = Convert.ToInt64(row.Cells[0].Value.ToString()) },
                    Passageiro = new Passageiro { Cpf = Convert.ToInt64(row.Cells[1].Value.ToString()) },
                    Veiculo = new Veiculo { Placa = row.Cells[2].Value.ToString() },
                    LocalOrigem = row.Cells[3].Value.ToString(),
                    LocalDestino = row.Cells[4].Value.ToString(),
                    DtHoraInicio = DateTime.Parse(row.Cells[5].Value.ToString()),
                    DtHoraFim = DateTime.Parse(row.Cells[6].Value.ToString()),
                    QtdePass = Convert.ToInt32(row.Cells[7].Value.ToString()),
                    FormaPagto = new TipoPagamento { CodPagto = Convert.ToInt32(row.Cells[8].Value.ToString()) },
                    ValorPagto = Convert.ToDecimal(row.Cells[9].Value.ToString()),
                    CancelamMotorista = (Cancelamento)Enum.Parse(typeof(Cancelamento), row.Cells[10].Value.ToString())
                };

                listViagens.Add(viagem);
            }

            IEnumerable<Viagem> viagensFiltradas = new List<Viagem>();

            if (chkDatas.Checked)
            {
                viagensFiltradas = listViagens.Where(v => v.DtHoraInicio >= DateTime.Parse(dataInicialHistorico.Text) && v.DtHoraFim <= DateTime.Parse(dataFinalHistorico.Text));
            }

            foreach (Viagem viagem in viagensFiltradas)
            {
                historicoGrid.Rows.Add(
                    viagem.Motorista.Cpf,
                    viagem.Passageiro.Cpf,
                    viagem.Veiculo.Placa,
                    viagem.LocalOrigem,
                    viagem.LocalDestino,
                    viagem.DtHoraInicio,
                    viagem.DtHoraFim,
                    viagem.QtdePass,
                    viagem.FormaPagto.CodPagto,
                    viagem.ValorPagto,
                    viagem.CancelamMotorista.ToString()
                );
            }
        }
    }
}
