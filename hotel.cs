using System;
using MySql.Data.MySqlClient;

class Program
{
  static void Main()
  {
    string connectionString = "Server=localhost;Database=gerenciamentos_funcionarios;User Id=root;Password=0507;";

    using (MySqlConnection connection = new MySqlConnection(connectionString))
    {
      try
      {
        connection.Open();

        string query = "SELECT * FROM departamentos";
        string query2 = "SELECT * FROM funcionarios";

        using (MySqlCommand cmd = new MySqlCommand(query, connection))
        {
          using (MySqlDataReader reader = cmd.ExecuteReader())
          {
            while (reader.Read())
            {
              Console.WriteLine($"id_dep: {reader["id_dep"]}, cargo_dep: {reader["cargo_dep"]}");
            }
          }
        }

        using (MySqlCommand cmd2 = new MySqlCommand(query2, connection))
        {
          using (MySqlDataReader reader2 = cmd2.ExecuteReader())
          {
            while (reader2.Read())
            {
              Console.WriteLine($"id: {reader2["id"]}, nome: {reader2["nome"]}, dt_Nascimento: {reader2["dt_Nascimento"]}, cargo: {reader2["cargo"]}, fK_Id_Dep: {reader2["fK_Id_Dep"]}, salario: {reader2["salario"]}");
            }
          }
        }

        Console.WriteLine("Dados exibidos com sucesso!");
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Erro ao conectar ao banco de dados: {ex.Message}");
      }
    }
  }
}