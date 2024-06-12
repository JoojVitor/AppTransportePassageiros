using Npgsql;
using Repository.Interfaces;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ViagemRepository : BaseRepository, IViagemRepository
    {
        public void Create(Viagem viagem)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();

            using (var connection = dbConnection.GetConnection())
            {
                dbConnection.OpenConnection(connection);

                var query = "INSERT INTO public.viagem(cpf_pass_viagem, cpf_mot_viag, " +
                    "placa_veic_viag, local_orig_viag, local_dest_viag, dt_hora_inicio, " +
                    "dt_hora_fim, qtde_pass, forma_pagto, valor_pagto, cancelam_mot, cancelam_pass) " +
                    "VALUES (@cpf_pass_viagem, @cpf_mot_viag, " +
                    "@placa_veic_viag, @local_orig_viag, @local_dest_viag, @dt_hora_inicio, " +
                    "@dt_hora_fim, @qtde_pass, @forma_pagto, @valor_pagto, @cancelam_mot, @cancelam_pass);";

                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("cpf_pass_viagem", viagem.Passageiro.Cpf);
                    cmd.Parameters.AddWithValue("cpf_mot_viag", viagem.Motorista.Cpf);
                    cmd.Parameters.AddWithValue("placa_veic_viag", viagem.Veiculo.Placa);
                    cmd.Parameters.AddWithValue("local_orig_viag", viagem.LocalOrigem);
                    cmd.Parameters.AddWithValue("local_dest_viag", viagem.LocalDestino);
                    cmd.Parameters.AddWithValue("dt_hora_inicio", DateTime.Parse(viagem.DtHoraInicio.ToString()));
                    cmd.Parameters.AddWithValue("dt_hora_fim", DateTime.Parse(viagem.DtHoraFim.ToString()));
                    cmd.Parameters.AddWithValue("qtde_pass", viagem.QtdePass);
                    cmd.Parameters.AddWithValue("forma_pagto", viagem.FormaPagto.CodPagto);
                    cmd.Parameters.AddWithValue("valor_pagto", viagem.ValorPagto);
                    cmd.Parameters.AddWithValue("cancelam_mot", viagem.CancelamMotorista.ToString());
                    cmd.Parameters.AddWithValue("cancelam_pass", viagem.CancelamPassageiro.ToString());

                    cmd.ExecuteNonQuery();
                }

                dbConnection.CloseConnection(connection);
            }
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Viagem> Get()
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            List<Viagem> viagemList = new List<Viagem>();

            using (var connection = dbConnection.GetConnection())
            {
                dbConnection.OpenConnection(connection);

                var query = "SELECT * FROM VIAGEM";

                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Viagem viagem = new Viagem
                            {
                                Passageiro = new Passageiro
                                {
                                    Cpf = Convert.ToInt64(reader["cpf_pass_viagem"])
                                },
                                Motorista = new Motorista
                                {
                                    Cpf = Convert.ToInt64(reader["cpf_mot_viag"])
                                },
                                Veiculo = new Veiculo
                                {
                                    Placa = reader["placa_veic_viag"].ToString()
                                },
                                LocalOrigem = reader["local_orig_viag"].ToString(),
                                LocalDestino = reader["local_dest_viag"].ToString(),
                                DtHoraInicio = DateTime.Parse(reader["dt_hora_inicio"].ToString()),
                                DtHoraFim = DateTime.Parse(reader["dt_hora_fim"].ToString()),
                                CancelamMotorista = Cancelamento.N,
                                CancelamPassageiro = Cancelamento.N,
                                FormaPagto = new TipoPagamento
                                {
                                    CodPagto = Convert.ToInt32(reader["forma_pagto"].ToString())
                                },
                                QtdePass = Convert.ToInt32(reader["qtde_pass"].ToString()),
                                ValorPagto = Convert.ToDecimal(reader["valor_pagto"].ToString())
                            };

                            switch (viagem.FormaPagto.CodPagto)
                            {
                                case 1:
                                    viagem.FormaPagto.DescPagto = "Dinheiro";
                                    break;

                                case 2:
                                    viagem.FormaPagto.DescPagto = "Pix";
                                    break;

                                case 3:
                                    viagem.FormaPagto.DescPagto = "Cartão";
                                    break;
                            }

                            viagemList.Add(viagem);
                        }
                    }
                }

                dbConnection.CloseConnection(connection);
            }

            return viagemList;
        }

        public Viagem Get(long id)
        {
            throw new NotImplementedException();
        }

        public void Update(Viagem viagem)
        {
            throw new NotImplementedException();
        }
    }
}
