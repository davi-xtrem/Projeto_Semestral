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
    public partial class UserForm : Form
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();
        public UserForm()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            string query = "SELECT * FROM Usuarios";
            DataTable dt = dbHelper.ExecuteQuery(query);
            dgvUsers.DataSource = dt;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Usuarios (nome, email, telefone) VALUES (@nome, @email, @telefone)";
            var parameters = new MySqlParameter[]
            {
            new MySqlParameter("@nome", txtNome.Text),
            new MySqlParameter("@email", txtEmail.Text),
            new MySqlParameter("@telefone", txtTelefone.Text)
            };
            dbHelper.ExecuteNonQuery(query, parameters);
            LoadUsers();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Usuarios SET nome = @nome, email = @email, telefone = @telefone WHERE id_usuario = @id";
            var parameters = new MySqlParameter[]
            {
            new MySqlParameter("@nome", txtNome.Text),
            new MySqlParameter("@email", txtEmail.Text),
            new MySqlParameter("@telefone", txtTelefone.Text),
            new MySqlParameter("@id", Convert.ToInt32(dgvUsers.CurrentRow.Cells["id_usuario"].Value))
            };
            dbHelper.ExecuteNonQuery(query, parameters);
            LoadUsers();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Usuarios WHERE id_usuario = @id";
            var parameters = new MySqlParameter[]
            {
            new MySqlParameter("@id", Convert.ToInt32(dgvUsers.CurrentRow.Cells["id_usuario"].Value))
            };
            dbHelper.ExecuteNonQuery(query, parameters);
            LoadUsers();
        }
    }
}
