namespace WinFormsApp1
{
    partial class BookForm
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
            dgvBooks = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            txtTitle = new TextBox();
            cbAuthor = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(12, 297);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.Size = new Size(591, 150);
            dgvBooks.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 252);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 1;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAddBook_Click;
            // 
            // button2
            // 
            button2.Location = new Point(252, 252);
            button2.Name = "button2";
            button2.Size = new Size(100, 30);
            button2.TabIndex = 2;
            button2.Text = "Atualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnUpdateBook_Click;
            // 
            // button3
            // 
            button3.Location = new Point(503, 252);
            button3.Name = "button3";
            button3.Size = new Size(100, 30);
            button3.TabIndex = 3;
            button3.Text = "Excluir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnDeleteBook_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 69);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 4;
            label1.Text = "Título";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 148);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 5;
            label2.Text = "Autor";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(55, 69);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(199, 23);
            txtTitle.TabIndex = 6;
            // 
            // cbAuthor
            // 
            cbAuthor.FormattingEnabled = true;
            cbAuthor.Location = new Point(55, 145);
            cbAuthor.Name = "cbAuthor";
            cbAuthor.Size = new Size(199, 23);
            cbAuthor.TabIndex = 10;
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 471);
            Controls.Add(cbAuthor);
            Controls.Add(txtTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvBooks);
            Name = "BookForm";
            Text = "BookForm";
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBooks;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private TextBox txtTitle;
        private ComboBox lblAuthor;
        private ComboBox cbAuthor;
    }
}