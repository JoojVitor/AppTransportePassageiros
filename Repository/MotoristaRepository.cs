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
    public class MotoristaRepository : BaseRepository, IMotoristaRepository
    {
        public void Create(Motorista motorista)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();

            using (var connection = dbConnection.GetConnection())
            {
                dbConnection.OpenConnection(connection);

                var query = "INSERT INTO MOTORISTAS(cpf_motorista, cnh, banco_mot, agencia_mot, conta_mot) " +
                    "VALUES (@cpf_motorista, @cnh, @banco_mot, @agencia_mot, @conta_mot);";

                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("cpf_motorista", motorista.Cpf);
                    cmd.Parameters.AddWithValue("cnh", motorista.Cnh);
                    cmd.Parameters.AddWithValue("banco_mot", motorista.Banco);
                    cmd.Parameters.AddWithValue("agencia_mot", motorista.Agencia);
                    cmd.Parameters.AddWithValue("conta_mot", motorista.Conta);

                    cmd.ExecuteNonQuery();
                }

                dbConnection.CloseConnection(connection);
            }
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Motorista> Get()
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            List<Motorista> motoristasList = new List<Motorista>();

            using (var connection = dbConnection.GetConnection())
            {
                dbConnection.OpenConnection(connection);

                var query = "SELECT * FROM MOTORISTAS";

                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Motorista motorista = new Motorista
                            {
                                Cpf = Convert.ToInt64(reader["cpf_motorista"]),
                                Cnh = reader["cnh"].ToString(),
                                Banco = Convert.ToInt32(reader["banco_mot"].ToString()),
                                Agencia = Convert.ToInt32(reader["agencia_mot"].ToString()),
                                Conta = Convert.ToInt32(reader["conta_mot"].ToString())
                            };

                            motoristasList.Add(motorista);
                        }
                    }
                }

                dbConnection.CloseConnection(connection);
            }

            return motoristasList;
        }

        public Motorista Get(long id)
        {
            throw new NotImplementedException();
        }

        public void Update(Motorista motorista)
        {
            throw new NotImplementedException();
        }
    }
}
