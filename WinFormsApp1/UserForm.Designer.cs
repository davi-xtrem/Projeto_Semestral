namespace WinFormsApp1
{
    partial class UserForm
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
            dgvUsers = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(76, 224);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.Size = new Size(450, 150);
            dgvUsers.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(76, 181);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAddUser_Click;
            // 
            // button2
            // 
            button2.Location = new Point(265, 181);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Atualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnUpdateUser_Click;
            // 
            // button3
            // 
            button3.Location = new Point(454, 180);
            button3.Name = "button3";
            button3.Size = new Size(72, 24);
            button3.TabIndex = 3;
            button3.Text = "Excluir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnDeleteUser_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(122, 30);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(159, 23);
            txtNome.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(122, 82);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(159, 23);
            txtEmail.TabIndex = 5;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(133, 128);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(148, 23);
            txtTelefone.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 38);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 7;
            label1.Text = "Nome";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 90);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 8;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 136);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 9;
            label3.Text = "Telefone";
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 407);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvUsers);
            Name = "UserForm";
            Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsers;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}