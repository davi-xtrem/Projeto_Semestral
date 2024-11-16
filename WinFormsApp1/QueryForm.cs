using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WinFormsApp1.DataAccess;

namespace WinFormsApp1
{
    public partial class QueryForm : Form
    {
        private DatabaseHelper dbHelper;

        public QueryForm()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
        }

        private void QueryForm_Load(object sender, EventArgs e)
        {
            // Opcional: carregar dados iniciais, se necessário.
        }

        private void LoadData(string query)
        {
            try
            {
                // Executa a consulta e carrega os dados no DataGridView
                DataTable dt = dbHelper.ExecuteQuery(query);
                dgvResults.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
            }
        }

        private void btnListBorrowedBooks_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT 
                    Livros.titulo AS Livro,
                    Usuarios.nome AS Usuario,
                    Emprestimos.data_emprestimo AS DataEmprestimo
                FROM Emprestimos
                INNER JOIN Livros ON Emprestimos.id_livro = Livros.id_livro
                INNER JOIN Usuarios ON Emprestimos.id_usuario = Usuarios.id_usuario
                WHERE Emprestimos.data_devolucao IS NULL
                ORDER BY Livros.titulo;";
            LoadData(query);
        }

        private void btnListAvailableBooks_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT 
                    Livros.id_livro AS ID,
                    Livros.titulo AS Livro
                    
                FROM Livros
                LEFT JOIN Emprestimos ON Livros.id_livro = Emprestimos.id_livro 
                    AND Emprestimos.data_devolucao IS NULL
                WHERE Emprestimos.id_livro IS NULL;";
            LoadData(query);
        }

        private void btnLoadBorrowedBooks_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT 
                    Livros.id_livro AS IDLivro,
                    Livros.titulo AS Livro,
                    Usuarios.nome AS UsuarioEmprestado,
                    Emprestimos.data_emprestimo AS DataEmprestimo
                FROM Emprestimos
                INNER JOIN Livros ON Emprestimos.id_livro = Livros.id_livro
                INNER JOIN Usuarios ON Emprestimos.id_usuario = Usuarios.id_usuario
                WHERE Emprestimos.data_devolucao IS NULL
                ORDER BY Livros.titulo;";
            LoadData(query);
        }

        private void btnLoadAvailableBooks_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT 
                    Livros.id_livro AS IDLivro,
                    Livros.titulo AS Livro
                    
                FROM Livros
                LEFT JOIN Emprestimos ON Livros.id_livro = Emprestimos.id_livro 
                    AND Emprestimos.data_devolucao IS NULL
                WHERE Emprestimos.id_livro IS NULL;";
            LoadData(query);
        }

        private void btnLoadUsersAndLoans_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT 
                    Usuarios.id_usuario AS IDUsuario,
                    Usuarios.nome AS Nome,
                    Usuarios.email AS Email,
                    Livros.titulo AS LivroEmprestado,
                    Emprestimos.data_emprestimo AS DataEmprestimo
                FROM Usuarios
                LEFT JOIN Emprestimos ON Usuarios.id_usuario = Emprestimos.id_usuario
                LEFT JOIN Livros ON Emprestimos.id_livro = Livros.id_livro
                ORDER BY Usuarios.nome;";
            LoadData(query);
        }
    }
}
