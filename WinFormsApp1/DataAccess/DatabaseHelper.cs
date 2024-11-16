using System.Data;
using MySql.Data.MySqlClient;

namespace WinFormsApp1.DataAccess
{
    public class DatabaseHelper
    {
        private MySqlConnection connection;

        // Construtor que inicializa a conexão
        public DatabaseHelper()
        {
            // Substitua pela sua string de conexão do MySQL
            string connectionString = "server=localhost;database=biblioteca;user=root;password=admin";
            connection = new MySqlConnection(connectionString);
        }

        // Método para obter a conexão
        public MySqlConnection GetConnection()
        {
            return connection;
        }

        // Método para abrir a conexão
        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        // Método para fechar a conexão
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public DataTable ExecuteQuery(string query, MySqlParameter[] parameters = null)
        {
            try
            {
                OpenConnection();
                using (var cmd = new MySqlCommand(query, connection))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    var adapter = new MySqlDataAdapter(cmd);
                    var table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
            finally
            {
                CloseConnection();
            }
        }

        public void ExecuteNonQuery(string query, MySqlParameter[] parameters = null)
        {
            try
            {
                OpenConnection();
                using (var cmd = new MySqlCommand(query, connection))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                CloseConnection();
            }
        }

        // Método ExecuteScalar adicionado
        public object ExecuteScalar(string query, MySqlParameter[] parameters = null)
        {
            try
            {
                OpenConnection();
                using (var cmd = new MySqlCommand(query, connection))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    return cmd.ExecuteScalar();  // Retorna o valor da primeira coluna da primeira linha
                }
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
