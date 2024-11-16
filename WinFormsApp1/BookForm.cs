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
    public partial class BookForm : Form
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();

        public BookForm()
        {
            InitializeComponent();
            LoadBooks();
            LoadAuthors();
        }

        private void LoadBooks()
        {
            string query = "SELECT Livros.id_livro, Livros.titulo, Autores.nome AS autor FROM Livros JOIN Autores ON Livros.id_autor = Autores.id_autor";
            DataTable dt = dbHelper.ExecuteQuery(query);
            dgvBooks.DataSource = dt;
        }

        private void LoadAuthors()
        {
            string query = "SELECT * FROM Autores";
            DataTable dt = dbHelper.ExecuteQuery(query);
            cbAuthor.DataSource = dt;
            cbAuthor.DisplayMember = "nome";
            cbAuthor.ValueMember = "id_autor";
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Livros (titulo, id_autor) VALUES (@titulo, @id_autor)";
            var parameters = new MySqlParameter[]
            {
            new MySqlParameter("@titulo", txtTitle.Text),
            new MySqlParameter("@id_autor", cbAuthor.SelectedValue)
            };
            dbHelper.ExecuteNonQuery(query, parameters);
            LoadBooks();
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Livros SET titulo = @titulo, id_autor = @id_autor WHERE id_livro = @id";
            var parameters = new MySqlParameter[]
            {
            new MySqlParameter("@titulo", txtTitle.Text),
            new MySqlParameter("@id_autor", cbAuthor.SelectedValue),
            new MySqlParameter("@id", Convert.ToInt32(dgvBooks.CurrentRow.Cells["id_livro"].Value))
            };
            dbHelper.ExecuteNonQuery(query, parameters);
            LoadBooks();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Livros WHERE id_livro = @id";
            var parameters = new MySqlParameter[]
            {
            new MySqlParameter("@id", Convert.ToInt32(dgvBooks.CurrentRow.Cells["id_livro"].Value))
            };
            dbHelper.ExecuteNonQuery(query, parameters);
            LoadBooks();
        }
    }
}
