using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTransportePassageiros
{
    class PassageiroController
    {
        public void CreatePassageiro(Passageiro passageiro)
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
    }
}
