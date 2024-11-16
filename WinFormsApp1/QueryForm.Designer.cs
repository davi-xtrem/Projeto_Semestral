namespace WinFormsApp1
{
    partial class QueryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvResults = new DataGridView();
            btnListAvailablbtnLoadUsersAndLoanseBooks = new Button();
            btnLoadBorrowedBooks = new Button();
            btnLoadAvailableBooks = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // dgvResults
            // 
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Location = new Point(12, 260);
            dgvResults.Name = "dgvResults";
            dgvResults.Size = new Size(589, 150);
            dgvResults.TabIndex = 0;
            // 
            // btnListAvailablbtnLoadUsersAndLoanseBooks
            // 
            btnListAvailablbtnLoadUsersAndLoanseBooks.Location = new Point(12, 123);
            btnListAvailablbtnLoadUsersAndLoanseBooks.Name = "btnListAvailablbtnLoadUsersAndLoanseBooks";
            btnListAvailablbtnLoadUsersAndLoanseBooks.Size = new Size(185, 23);
            btnListAvailablbtnLoadUsersAndLoanseBooks.TabIndex = 1;
            btnListAvailablbtnLoadUsersAndLoanseBooks.Text = "Listar Usuários e Empréstimos";
            btnListAvailablbtnLoadUsersAndLoanseBooks.UseVisualStyleBackColor = true;
            btnListAvailablbtnLoadUsersAndLoanseBooks.Click += btnLoadUsersAndLoans_Click;
            // 
            // btnLoadBorrowedBooks
            // 
            btnLoadBorrowedBooks.Location = new Point(442, 123);
            btnLoadBorrowedBooks.Name = "btnLoadBorrowedBooks";
            btnLoadBorrowedBooks.Size = new Size(159, 23);
            btnLoadBorrowedBooks.TabIndex = 2;
            btnLoadBorrowedBooks.Text = "Listar Livros Emprestados";
            btnLoadBorrowedBooks.UseVisualStyleBackColor = true;
            btnLoadBorrowedBooks.Click += btnLoadBorrowedBooks_Click;
            // 
            // btnLoadAvailableBooks
            // 
            btnLoadAvailableBooks.Location = new Point(221, 123);
            btnLoadAvailableBooks.Name = "btnLoadAvailableBooks";
            btnLoadAvailableBooks.Size = new Size(160, 23);
            btnLoadAvailableBooks.TabIndex = 3;
            btnLoadAvailableBooks.Text = "Listar Livros Disponíveis";
            btnLoadAvailableBooks.UseVisualStyleBackColor = true;
            btnLoadAvailableBooks.Click += btnLoadAvailableBooks_Click;
            // 
            // QueryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 448);
            Controls.Add(btnLoadAvailableBooks);
            Controls.Add(btnLoadBorrowedBooks);
            Controls.Add(btnListAvailablbtnLoadUsersAndLoanseBooks);
            Controls.Add(dgvResults);
            Name = "QueryForm";
            Text = "QueryForm";
            Load += QueryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvResults;
        private Button btnListAvailablbtnLoadUsersAndLoanseBooks;
        private Button btnLoadBorrowedBooks;
        private Button btnLoadAvailableBooks;
    }
}