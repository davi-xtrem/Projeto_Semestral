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
            // Abrir o formulário de consultas
            QueryForm queryForm = new QueryForm();
            queryForm.ShowDialog();
        }

        private void btnManageLoans_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de gerenciamento de empréstimos
            LoanForm loanForm = new LoanForm();
            loanForm.ShowDialog();
        }

        private void btnManageBooks_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de gerenciamento de livros
            BookForm bookForm = new BookForm();
            bookForm.ShowDialog();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de gerenciamento de usuários
            UserForm userForm = new UserForm();
            userForm.ShowDialog();
        }
    }
}
