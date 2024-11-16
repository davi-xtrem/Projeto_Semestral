using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WinFormsApp1.DataAccess;

namespace WinFormsApp1
{
    public partial class LoanForm : Form
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();

        public LoanForm()
        {
            InitializeComponent();
            LoadUsers();
            LoadAvailableBooks();
            LoadLoanedBooks();
            LoadLoansToDataGrid();
        }

        private void LoanForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
            LoadAvailableBooks();
            LoadLoanedBooks();
            LoadLoansToDataGrid();
        }

        private void LoadUsers()
        {
            try
            {
                string query = "SELECT id_usuario, nome FROM usuarios";
                MySqlCommand cmd = new MySqlCommand(query, dbHelper.GetConnection());

                dbHelper.OpenConnection();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dbHelper.CloseConnection();

                cmbUsers.DataSource = dt;
                cmbUsers.DisplayMember = "nome"; // Mostra o nome no ComboBox
                cmbUsers.ValueMember = "id_usuario"; // Define o ID como valor
                cmbUsers.SelectedIndex = -1; // Não selecionar nenhum item inicialmente
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar usuários: " + ex.Message);
            }
            finally
            {
                dbHelper.CloseConnection();
            }
        }

        private void LoadAvailableBooks()
        {
            try
            {
                string query = "SELECT id_livro, titulo FROM livros WHERE status = 'disponível'";
                MySqlCommand cmd = new MySqlCommand(query, dbHelper.GetConnection());

                dbHelper.OpenConnection();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dbHelper.CloseConnection();

                cmbBooksAvailable.DataSource = dt;
                cmbBooksAvailable.DisplayMember = "titulo";
                cmbBooksAvailable.ValueMember = "id_livro";
                cmbBooksAvailable.SelectedIndex = -1; // Nenhum item selecionado inicialmente
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar livros disponíveis: " + ex.Message);
            }
            finally
            {
                dbHelper.CloseConnection();
            }
        }

        private void LoadLoanedBooks()
        {
            try
            {
                string query = @"
            SELECT emprestimos.id_livro, livros.titulo 
            FROM emprestimos
            INNER JOIN livros ON emprestimos.id_livro = livros.id_livro
            WHERE emprestimos.data_devolucao IS NULL";

                MySqlCommand cmd = new MySqlCommand(query, dbHelper.GetConnection());

                dbHelper.OpenConnection();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dbHelper.CloseConnection();

                cmbBooksLoaned.DataSource = dt;
                cmbBooksLoaned.DisplayMember = "titulo";
                cmbBooksLoaned.ValueMember = "id_livro";
                cmbBooksLoaned.SelectedIndex = -1; // Nenhum item selecionado inicialmente
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar livros emprestados: " + ex.Message);
            }
            finally
            {
                dbHelper.CloseConnection();
            }
        }

        private void LoadLoansToDataGrid()
        {
            try
            {
                string query = @"
            SELECT 
                emprestimos.id_emprestimo AS 'ID Empréstimo',
                usuarios.nome AS 'Usuário',
                livros.titulo AS 'Livro',
                emprestimos.data_emprestimo AS 'Data do Empréstimo',
                emprestimos.data_devolucao AS 'Data de Devolução'
            FROM emprestimos
            INNER JOIN usuarios ON emprestimos.id_usuario = usuarios.id_usuario
            INNER JOIN livros ON emprestimos.id_livro = livros.id_livro";

                MySqlCommand cmd = new MySqlCommand(query, dbHelper.GetConnection());

                dbHelper.OpenConnection();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dbHelper.CloseConnection();

                dgvLoans.DataSource = dt; // Atribua o DataTable ao DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados de empréstimos: " + ex.Message);
            }
            finally
            {
                dbHelper.CloseConnection();
            }
        }

        private void btnRegisterLoan_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbUsers.SelectedValue == null || cmbBooksAvailable.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, selecione um usuário e um livro disponível.");
                    return;
                }

                int userId = Convert.ToInt32(cmbUsers.SelectedValue);
                int bookId = Convert.ToInt32(cmbBooksAvailable.SelectedValue);

                string query = @"
            INSERT INTO emprestimos (id_usuario, id_livro, data_emprestimo) 
            VALUES (@id_usuario, @id_livro, @data_emprestimo)";

                MySqlCommand cmd = new MySqlCommand(query, dbHelper.GetConnection());
                cmd.Parameters.AddWithValue("@id_usuario", userId);
                cmd.Parameters.AddWithValue("@id_livro", bookId);
                cmd.Parameters.AddWithValue("@data_emprestimo", DateTime.Now);

                dbHelper.OpenConnection();
                cmd.ExecuteNonQuery();
                dbHelper.CloseConnection();

                // Atualizar os ComboBoxes
                LoadAvailableBooks();
                LoadLoanedBooks();

                MessageBox.Show("Empréstimo registrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar empréstimo: " + ex.Message);
            }
            finally
            {
                dbHelper.CloseConnection();
            }
        }

        private void btnRegisterReturn_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbBooksLoaned.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, selecione um livro emprestado para registrar a devolução.");
                    return;
                }

                int bookId = Convert.ToInt32(cmbBooksLoaned.SelectedValue);

                string updateLoanQuery = @"
            UPDATE emprestimos 
            SET data_devolucao = @data_devolucao 
            WHERE id_livro = @id_livro AND data_devolucao IS NULL";

                MySqlCommand updateLoanCmd = new MySqlCommand(updateLoanQuery, dbHelper.GetConnection());
                updateLoanCmd.Parameters.AddWithValue("@data_devolucao", DateTime.Now);
                updateLoanCmd.Parameters.AddWithValue("@id_livro", bookId);

                dbHelper.OpenConnection();
                updateLoanCmd.ExecuteNonQuery();

                string updateBookQuery = "UPDATE livros SET status = 'disponível' WHERE id_livro = @id_livro";
                MySqlCommand updateBookCmd = new MySqlCommand(updateBookQuery, dbHelper.GetConnection());
                updateBookCmd.Parameters.AddWithValue("@id_livro", bookId);
                updateBookCmd.ExecuteNonQuery();

                dbHelper.CloseConnection();

                // Atualizar os ComboBoxes
                LoadAvailableBooks();
                LoadLoanedBooks();

                MessageBox.Show("Devolução registrada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar devolução: " + ex.Message);
            }
            finally
            {
                dbHelper.CloseConnection();
            }

        }
    }
}
