using Domain;
using Npgsql;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PassageiroRepository : BaseRepository, IPassageiroRepository
    {
        public void Create(Passageiro passageiro)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();

            using (var connection = dbConnection.GetConnection())
            {
                dbConnection.OpenConnection(connection);

                var query = "INSERT INTO PASSAGEIROS (cpf_passag, cartao_cred, bandeira_cartao, cidade_orig) " +
                            "VALUES (@Cpf, @CartaoCred, @BandeiraCartao, @CidadeOrig)";

                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("Cpf", passageiro.Cpf);
                    cmd.Parameters.AddWithValue("CartaoCred", passageiro.CartaoCred);
                    cmd.Parameters.AddWithValue("BandeiraCartao", passageiro.BandeiraCartao);
                    cmd.Parameters.AddWithValue("CidadeOrig", passageiro.CidadeOrig);

                    cmd.ExecuteNonQuery();
                }

                dbConnection.CloseConnection(connection);
            }
        }

        public void Delete(long cpf)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();

            using (var connection = dbConnection.GetConnection())
            {
                dbConnection.OpenConnection(connection);

                // verificar nome da coluna CPF
                var query = "DELETE FROM PASSAGEIROS WHERE cpf_passag = @Cpf";

                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("Cpf", cpf);

                    cmd.ExecuteNonQuery();
                }

                dbConnection.CloseConnection(connection);
            }
        }

        public IEnumerable<Passageiro> Get()
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            List<Passageiro> passageirosList = new List<Passageiro>();

            using (var connection = dbConnection.GetConnection())
            {
                dbConnection.OpenConnection(connection);

                var query = "SELECT * FROM PASSAGEIROS";

                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var passageiro = new Passageiro
                            {
                                Cpf = Convert.ToInt64(reader["cpf_passag"]),
                                CidadeOrig = reader["cidade_orig"].ToString(),
                                CartaoCred = reader["cartao_cred"].ToString(),
                                BandeiraCartao = reader["bandeira_cartao"].ToString()
                            };

                            passageirosList.Add(passageiro);
                        }
                    }
                }

                dbConnection.CloseConnection(connection);
            }

            return passageirosList;
        }

        public Passageiro Get(long cpf)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            var passageiro = new Passageiro();

            using (var connection = dbConnection.GetConnection())
            {
                dbConnection.OpenConnection(connection);

                var query = "SELECT * FROM PASSAGEIROS WHERE cpf_passag = @Cpf";

                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("Cpf", cpf);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            passageiro = new Passageiro
                            {
                                Cpf = Convert.ToInt64(reader["cpf_passag"]),
                                BandeiraCartao = reader["bandeira_cartao"].ToString(),
                                CartaoCred = reader["cartao_cred"].ToString(),
                                CidadeOrig = reader["cidade_orig"].ToString(),
                            };
                        }
                    }
                }

                dbConnection.CloseConnection(connection);
            }

            return passageiro;
        }

        public void Update(Passageiro passageiro)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();

            using (var connection = dbConnection.GetConnection())
            {
                dbConnection.OpenConnection(connection);

                // verificar nome das colunas
                var query = "UPDATE PASSAGEIROS SET cpf_passag = @Cpf, cartao_cred = @CartaoCred, bandeira_cartao = @BandeiraCartao, cidade_orig = @CidadeOrig" +
                            "WHERE cpf_passag = @Cpf";

                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("Cpf", passageiro.Cpf);
                    cmd.Parameters.AddWithValue("CidadeOrig", passageiro.CidadeOrig);
                    cmd.Parameters.AddWithValue("BandeiraCartao", passageiro.BandeiraCartao);
                    cmd.Parameters.AddWithValue("CartaoCred", passageiro.CartaoCred);

                    cmd.ExecuteNonQuery();
                }

                dbConnection.CloseConnection(connection);
            }
        }
    }
}
