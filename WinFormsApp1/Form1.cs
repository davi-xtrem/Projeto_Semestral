namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            // Abrir o formul�rio de consultas
            QueryForm queryForm = new QueryForm();
            queryForm.ShowDialog();
        }

        private void btnManageLoans_Click(object sender, EventArgs e)
        {
            // Abrir o formul�rio de gerenciamento de empr�stimos
            LoanForm loanForm = new LoanForm();
            loanForm.ShowDialog();
        }

        private void btnManageBooks_Click(object sender, EventArgs e)
        {
            // Abrir o formul�rio de gerenciamento de livros
            BookForm bookForm = new BookForm();
            bookForm.ShowDialog();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            // Abrir o formul�rio de gerenciamento de usu�rios
            UserForm userForm = new UserForm();
            userForm.ShowDialog();
        }
    }
}
