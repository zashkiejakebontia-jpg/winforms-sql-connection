namespace TestWins.Model;

//dotnet add package MySql.Data
using MySql.Data.MySqlClient;

public class ConnectionSql
{
    private readonly string _connectionString = "server=localhost;port=3306;database=student;uid=root;pwd=";
        private MySqlConnection _conn;

    public MySqlConnection connectSql()
    {

        Console.WriteLine("Connecting to DB");

        _conn = new MySqlConnection(_connectionString);

        Console.WriteLine(_conn == null ? "Datbase Connection Failed" : "Database connection successful");

        return _conn;
    }
}