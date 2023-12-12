using System;
using System.Data;
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


        string query3 = @"
                SELECT 
                    nome AS 'Nome do Funcionário',
                    cargo_dep AS 'Cargo do Funcionário',
                    salario AS 'Salário',
                    SUM(qt_venda) AS 'Total de vendas dos ultimos 3 meses',
                    ROUND(SUM(qt_venda) / 3, 2) AS 'Média de vendas dos ultimos 3 meses',
                    ROUND(salario / (SUM(qt_venda) / 3), 2) AS 'Calculo do salario por venda'
                FROM
                    funcionarios
                JOIN
                    departamentos ON fk_id_dep = id_dep
                JOIN
                    venda ON funcionarios.id = venda.fk_id_fun
                WHERE
                    salario > 3000
                GROUP BY
                    nome, cargo_dep, salario;";

        using MySqlCommand cmd = new MySqlCommand(query3, connection);
        using MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

        DataSet dataSet = new DataSet();
        adapter.Fill(dataSet, "Resultado");

        DataTable dataTable = dataSet.Tables["Resultado"];

        foreach (DataRow row in dataTable.Rows)
        {
          Console.WriteLine($"Nome do Funcionário: {row["Nome do Funcionário"]}");
          Console.WriteLine($"Cargo do Funcionário: {row["Cargo do Funcionário"]}");
          Console.WriteLine($"Salário: {row["Salário"]}");
          Console.WriteLine($"Total de vendas dos ultimos 3 meses: {row["Total de vendas dos ultimos 3 meses"]}");
          Console.WriteLine($"Média de vendas dos ultimos 3 meses: {row["Média de vendas dos ultimos 3 meses"]}");
          Console.WriteLine($"Calculo do salario por venda: {row["Calculo do salario por venda"]}");
          Console.WriteLine();
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Erro: {ex.Message}");
      }
    }
  }

}
