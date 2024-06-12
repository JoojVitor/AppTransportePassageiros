using Npgsql;
using Repository.Interfaces;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Repository
{
    public class VeiculoRepository : BaseRepository, IVeiculoRepository
    {
        public void Create(Veiculo veiculo)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();

            using (var connection = dbConnection.GetConnection())
            {
                dbConnection.OpenConnection(connection);

                var query = "INSERT INTO VEICULO(placa, marca, modelo, ano_fabric, capacidade_pass, cor, tipo_combust, potencia_motor) " +
                    "VALUES (@placa, @marca, @modelo, @ano_fabric, @capacidade_pass, @cor, @tipo_combust, @potencia_motor);";

                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("placa", veiculo.Placa);
                    cmd.Parameters.AddWithValue("marca", veiculo.Marca);
                    cmd.Parameters.AddWithValue("modelo", veiculo.Modelo);
                    cmd.Parameters.AddWithValue("ano_fabric", veiculo.AnoFabric);
                    cmd.Parameters.AddWithValue("capacidade_pass", veiculo.CapacidadePass);
                    cmd.Parameters.AddWithValue("cor", veiculo.Cor);
                    cmd.Parameters.AddWithValue("tipo_combust", veiculo.TipoCombust);
                    cmd.Parameters.AddWithValue("potencia_motor", veiculo.PotenciaMotor);

                    cmd.ExecuteNonQuery();
                }

                dbConnection.CloseConnection(connection);
            }
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Veiculo> Get()
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            List<Veiculo> veiculoList = new List<Veiculo>();

            using (var connection = dbConnection.GetConnection())
            {
                dbConnection.OpenConnection(connection);

                var query = "SELECT * FROM VEICULO";

                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var veiculo = new Veiculo
                            {
                                Placa = reader["placa"].ToString(),
                                Marca = reader["marca"].ToString(),
                                Modelo = reader["modelo"].ToString(),
                                AnoFabric = Convert.ToInt32(reader["ano_fabric"]),
                                CapacidadePass = Convert.ToInt32(reader["capacidade_pass"].ToString()),
                                Cor = reader["cor"].ToString(),
                                TipoCombust = reader["tipo_combust"].ToString(),
                                PotenciaMotor = Convert.ToInt32(reader["potencia_motor"].ToString())
                            };
                            veiculoList.Add(veiculo);
                        }
                    }
                }

                dbConnection.CloseConnection(connection);
            }

            return veiculoList;
        }

        public Veiculo Get(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(Veiculo veiculo)
        {
            throw new NotImplementedException();
        }
    }
}
