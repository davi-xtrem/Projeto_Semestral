namespace WinFormsApp1
{
    partial class LoanForm
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
            dgvLoans = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbUsers = new ComboBox();
            cmbBooksAvailable = new ComboBox();
            cmbBooksLoaned = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLoans).BeginInit();
            SuspendLayout();
            // 
            // dgvLoans
            // 
            dgvLoans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoans.Location = new Point(12, 159);
            dgvLoans.Name = "dgvLoans";
            dgvLoans.Size = new Size(711, 150);
            dgvLoans.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(81, 130);
            button1.Name = "button1";
            button1.Size = new Size(148, 23);
            button1.TabIndex = 1;
            button1.Text = "Registrar Empréstimo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnRegisterLoan_Click;
            // 
            // button2
            // 
            button2.Location = new Point(510, 130);
            button2.Name = "button2";
            button2.Size = new Size(131, 23);
            button2.TabIndex = 2;
            button2.Text = "Registrar Devolução";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnRegisterReturn_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(160, 85);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(148, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(575, 83);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(148, 23);
            dateTimePicker2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 7;
            label1.Text = "Selecione um Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 8;
            label2.Text = "Livros Disponiveís";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 91);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 9;
            label3.Text = "Empréstimo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(427, 85);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 10;
            label4.Text = "Devolução";
            // 
            // cmbUsers
            // 
            cmbUsers.FormattingEnabled = true;
            cmbUsers.Location = new Point(160, 27);
            cmbUsers.Name = "cmbUsers";
            cmbUsers.Size = new Size(148, 23);
            cmbUsers.TabIndex = 11;
            // 
            // cmbBooksAvailable
            // 
            cmbBooksAvailable.FormattingEnabled = true;
            cmbBooksAvailable.Location = new Point(160, 56);
            cmbBooksAvailable.Name = "cmbBooksAvailable";
            cmbBooksAvailable.Size = new Size(148, 23);
            cmbBooksAvailable.TabIndex = 12;
            // 
            // cmbBooksLoaned
            // 
            cmbBooksLoaned.FormattingEnabled = true;
            cmbBooksLoaned.Location = new Point(575, 27);
            cmbBooksLoaned.Name = "cmbBooksLoaned";
            cmbBooksLoaned.Size = new Size(148, 23);
            cmbBooksLoaned.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(427, 35);
            label5.Name = "label5";
            label5.Size = new Size(109, 15);
            label5.TabIndex = 15;
            label5.Text = "Livros Emprestados";
            // 
            // LoanForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 321);
            Controls.Add(label5);
            Controls.Add(cmbBooksLoaned);
            Controls.Add(cmbBooksAvailable);
            Controls.Add(cmbUsers);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvLoans);
            Name = "LoanForm";
            Text = "LoanForm";
            ((System.ComponentModel.ISupportInitialize)dgvLoans).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLoans;
        private Button button1;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbUsers;
        private ComboBox cmbBooksAvailable;
        private ComboBox cmbBooksLoaned;
        private Label label5;
    }
}