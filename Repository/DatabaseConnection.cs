using System;
using Npgsql;

public class DatabaseConnection
{
    private readonly string _connectionString;

    public DatabaseConnection()
    {
        _connectionString = $"Host=localhost;Port=5432;Database=DBTRANSPORTEPASSAGEIROS;Username=postgres;Password=123";
    }

    public NpgsqlConnection GetConnection()
    {
        return new NpgsqlConnection(_connectionString);
    }

    public void OpenConnection(NpgsqlConnection connection)
    {
        try
        {
            connection.Open();
            Console.WriteLine("Connection opened successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error opening connection: {ex.Message}");
        }
    }

    public void CloseConnection(NpgsqlConnection connection)
    {
        try
        {
            connection.Close();
            Console.WriteLine("Connection closed successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error closing connection: {ex.Message}");
        }
    }
}