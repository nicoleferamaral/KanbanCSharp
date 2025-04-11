using System.Windows.Forms;
using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace GerenciadorDeTarefas
{
    class DAO
    {
        public MySqlConnection conexao;

        public DAO()
        {
            conexao = new MySqlConnection("server=localhost;Database=tintCsharp;Uid=root;password=");
            try
            {
                conexao.Open();//tentando conectar com o banco 
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado\n" + erro);
            }
        }// Fim do construtor

        // Os status podem ser: fazer, fazendo e feito
        public void Inserir(string titulo, string descricao, DateTime dataVencimento, string prioridade, string status)
        {
            var query = $"INSERT INTO Tarefa(Titulo, Descricao, DataVencimento, Prioridade, Status) VALUES('{titulo}', '{descricao}', '{dataVencimento.ToString("yyyy-MM-dd")}', '{prioridade}', '{status.ToLower()}')";
            var sql = new MySqlCommand(query, conexao);
            sql.ExecuteNonQuery();
        }

        public void AtualizarStatusTarefa(int id, string novoStatus)
        {
            var query = $"UPDATE Tarefa SET Status = '{novoStatus}' WHERE Id = {id}";
            var sql = new MySqlCommand(query, conexao);
            sql.ExecuteNonQuery();
        }

        public void DeletarTarefa(int id)
        {
            var query = $"DELETE FROM Tarefa WHERE Id = {id}";
            var sql = new MySqlCommand(query, conexao);
            sql.ExecuteNonQuery();
        }

        public Tarefa ObterTarefaPorId(int id)
        {
            var query = $"SELECT * FROM Tarefa WHERE Id = {id}";
            var sql = new MySqlCommand(query, conexao);

            var tarefa = new Tarefa();

            using (var resultado = sql.ExecuteReader())
            {
                while (resultado.Read())
                {
                    tarefa = new Tarefa()
                    {
                        Id = resultado.GetInt32("Id"),
                        Titulo = resultado.GetString("Titulo"),
                        Descricao = resultado.GetString("Descricao"),
                        Prioridade = resultado.GetString("Prioridade"),
                        Status = resultado.GetString("status"),
                        DataVencimento = resultado.GetDateTime("DataVencimento"),
                    };
                }
            }

            return tarefa;
        }

        public List<Tarefa> ObterTarefasPorStatus(string status)
        {
            var query = $"SELECT * FROM Tarefa WHERE Status = '{status.ToLower()}'";
            var sql = new MySqlCommand(query, conexao);

            var tarefas = new List<Tarefa>();

            using (var resultado = sql.ExecuteReader())
            {
                while (resultado.Read())
                {
                    var tarefa = new Tarefa()
                    {
                        Id = resultado.GetInt32("Id"),
                        Titulo = resultado.GetString("Titulo"),
                        Descricao = resultado.GetString("Descricao"),
                        Prioridade = resultado.GetString("Prioridade"),
                        Status = resultado.GetString("status"),
                        DataVencimento = resultado.GetDateTime("DataVencimento"),
                    };

                    tarefas.Add(tarefa);
                }    
            }

            return tarefas;
        }

        public string AtualizarTarefa(int id, string titulo, string descricao, DateTime dataVencimento, string prioridade, string status)
        {

            string query = $"UPDATE Tarefa SET Titulo = '{titulo}', Descricao = '{descricao}', DataVencimento = '{dataVencimento.ToString("yyyy-MM-dd")}', Prioridade = '{prioridade}', Status = '{status.ToLower()}' WHERE Id = {id}";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + "Atualizado!";
            return resultado;
        }

        public List<Tarefa> FiltrarTarefas(string status, string prioridade, string titulo, DateTime? data)
            {
                List<Tarefa> resultado = new List<Tarefa>();

                using (var conexao = new MySqlConnection("server=localhost;database=tintCsharp;uid=root;pwd="))
                {
                    conexao.Open();
                    string query = "SELECT * FROM Tarefa WHERE 1=1";

                    if (status != "Todos")
                        query += " AND Status = @status";

                    if (prioridade != "Todas")
                        query += " AND Prioridade = @prioridade";

                    if (!string.IsNullOrWhiteSpace(titulo))
                        query += " AND Titulo LIKE @titulo";

                    if (data.HasValue)
                        query += " AND DATE(DataVencimento) = @data";

                    var comando = new MySqlCommand(query, conexao);

                    if (status != "Todos")
                        comando.Parameters.AddWithValue("@status", status);

                    if (prioridade != "Todas")
                        comando.Parameters.AddWithValue("@prioridade", prioridade);

                    if (!string.IsNullOrWhiteSpace(titulo))
                        comando.Parameters.AddWithValue("@titulo", "%" + titulo + "%");

                    if (data.HasValue)
                        comando.Parameters.AddWithValue("@data", data.Value.ToString("yyyy-MM-dd"));

                using (var reader = comando.ExecuteReader())
                {
                        while (reader.Read())
                        {
                            resultado.Add(new Tarefa
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Titulo = reader["Titulo"].ToString(),
                                Descricao = reader["Descricao"].ToString(),
                                Status = reader["Status"].ToString(),
                                Prioridade = reader["Prioridade"].ToString(),
                                DataVencimento = Convert.ToDateTime(reader["DataVencimento"])
                            });
                        }
                    }
                }

                return resultado;
            }

}

}
