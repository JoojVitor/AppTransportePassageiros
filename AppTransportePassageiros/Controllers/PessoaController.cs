using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class PessoaController
    {
        public void CreatePessoa(Pessoa pessoa)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();

            using (var connection = dbConnection.GetConnection())
            {
                dbConnection.OpenConnection(connection);

                var query = "INSERT INTO PESSOAS (cpf_pessoa, nome, endereco, telefone, sexo, email) " +
                            "VALUES (@Cpf, @Nome, @Endereco, @Telefone, @Sexo, @Email)";

                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("Cpf", pessoa.Cpf);
                    cmd.Parameters.AddWithValue("Nome", pessoa.Nome);
                    cmd.Parameters.AddWithValue("Endereco", pessoa.Endereco);
                    cmd.Parameters.AddWithValue("Telefone", pessoa.Telefone);
                    cmd.Parameters.AddWithValue("Sexo", pessoa.Sexo.ToString());
                    cmd.Parameters.AddWithValue("Email", pessoa.Email);

                    cmd.ExecuteNonQuery();
                }

                dbConnection.CloseConnection(connection);
            }
        }

        public List<Pessoa> GetAllPessoas()
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            List<Pessoa> pessoaList = new List<Pessoa>();

            using (var connection = dbConnection.GetConnection())
            {
                dbConnection.OpenConnection(connection);

                var query = "SELECT * FROM PESSOAS";

                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var pessoa = new Pessoa
                            {
                                Cpf = Convert.ToInt64(reader["cpf_pessoa"]),
                                Nome = reader["nome"].ToString(),
                                Email = reader["email"].ToString(),
                                Endereco = reader["endereco"].ToString(),
                                Sexo = (Sexo)Enum.Parse(typeof(Sexo), reader["sexo"].ToString()),
                                Telefone = Convert.ToInt32(reader["telefone"])
                            };

                            pessoaList.Add(pessoa);
                        }
                    }
                }

                dbConnection.CloseConnection(connection);
            }

            return pessoaList;
        }

        public Pessoa GetPessoa(long cpf)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            var pessoa = new Pessoa();

            using (var connection = dbConnection.GetConnection())
            {
                dbConnection.OpenConnection(connection);

                var query = "SELECT * FROM PESSOAS WHERE cpf_pessoa = @Cpf";

                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("Cpf", cpf);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            pessoa = new Pessoa
                            {
                                Cpf = Convert.ToInt64(reader["cpf_pessoa"]),
                                Nome = reader["nome"].ToString(),
                                Email = reader["email"].ToString(),
                                Endereco = reader["endereco"].ToString(),
                                Sexo = (Sexo)Enum.Parse(typeof(Sexo), reader["sexo"].ToString()),
                                Telefone = Convert.ToInt32(reader["telefone"])
                            };
                        }
                    }
                }

                dbConnection.CloseConnection(connection);
            }

            return pessoa;
        }

        public void UpdatePessoa(Pessoa pessoa)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();

            using (var connection = dbConnection.GetConnection())
            {
                dbConnection.OpenConnection(connection);

                var query = "UPDATE PESSOAS SET nome = @Nome, endereco = @Endereco," +
                            "telefone = @Telefone, sexo = @Sexo, email = @Email" +
                            "WHERE cpf_pessoa = @Cpf";

                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("Cpf", pessoa.Cpf);
                    cmd.Parameters.AddWithValue("Nome", pessoa.Nome);
                    cmd.Parameters.AddWithValue("Endereco", pessoa.Endereco);
                    cmd.Parameters.AddWithValue("Telefone", pessoa.Telefone);
                    cmd.Parameters.AddWithValue("Sexo", pessoa.Sexo.ToString());
                    cmd.Parameters.AddWithValue("Email", pessoa.Email);

                    cmd.ExecuteNonQuery();
                }

                dbConnection.CloseConnection(connection);
            }
        }

        public void DeletePessoa(long cpf)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();

            using (var connection = dbConnection.GetConnection())
            {
                dbConnection.OpenConnection(connection);

                var query = "DELETE FROM PESSOAS WHERE cpf_pessoa = @Cpf";

                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("Cpf", cpf);

                    cmd.ExecuteNonQuery();
                }

                dbConnection.CloseConnection(connection);
            }
        }
    }
}
