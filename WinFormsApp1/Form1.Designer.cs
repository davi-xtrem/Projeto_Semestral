﻿namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(66, 202);
            button1.Name = "button1";
            button1.Size = new Size(136, 23);
            button1.TabIndex = 0;
            button1.Text = "Gerenciar Usuários";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnManageUsers_Click;
            // 
            // button2
            // 
            button2.Location = new Point(66, 243);
            button2.Name = "button2";
            button2.Size = new Size(136, 23);
            button2.TabIndex = 1;
            button2.Text = "Gerenciar Livros";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnManageBooks_Click;
            // 
            // button3
            // 
            button3.Location = new Point(66, 287);
            button3.Name = "button3";
            button3.Size = new Size(183, 23);
            button3.TabIndex = 2;
            button3.Text = "Gerenciar Empréstimos";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnManageLoans_Click;
            // 
            // button4
            // 
            button4.Location = new Point(66, 325);
            button4.Name = "button4";
            button4.Size = new Size(136, 23);
            button4.TabIndex = 3;
            button4.Text = "Consultas";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnQuery_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 425);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
