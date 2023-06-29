namespace Natação
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
            txtProfessor = new Label();
            txt = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            txtAula = new TextBox();
            label4 = new Label();
            label1 = new Label();
            btnCadastrar = new Button();
            txtMarcacaoDeAula = new DateTimePicker();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtProfessor
            // 
            txtProfessor.AutoSize = true;
            txtProfessor.Location = new Point(41, 124);
            txtProfessor.Name = "txtProfessor";
            txtProfessor.Size = new Size(56, 15);
            txtProfessor.TabIndex = 0;
            txtProfessor.Text = "Professor";
            // 
            // txt
            // 
            txt.Location = new Point(41, 155);
            txt.Name = "txt";
            txt.Size = new Size(100, 23);
            txt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 181);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(41, 210);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 243);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 4;
            label3.Text = "Aula";
            // 
            // txtAula
            // 
            txtAula.Location = new Point(41, 275);
            txtAula.Name = "txtAula";
            txtAula.Size = new Size(100, 23);
            txtAula.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 218);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 310);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 7;
            label1.Text = "Marcação de aula";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(678, 415);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 9;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // txtMarcacaoDeAula
            // 
            txtMarcacaoDeAula.Location = new Point(41, 339);
            txtMarcacaoDeAula.Name = "txtMarcacaoDeAula";
            txtMarcacaoDeAula.Size = new Size(200, 23);
            txtMarcacaoDeAula.TabIndex = 10;
            txtMarcacaoDeAula.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(287, 26);
            label5.Name = "label5";
            label5.Size = new Size(188, 25);
            label5.TabIndex = 11;
            label5.Text = "Olá! Seja Bem Vindo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(txtMarcacaoDeAula);
            Controls.Add(btnCadastrar);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(txtAula);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txt);
            Controls.Add(txtProfessor);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtProfessor;
        private TextBox txt;
        private Label label2;
        private TextBox txtNome;
        private Label label3;
        private TextBox txtAula;
        private Label label4;
        private Label label1;
        private Button btnCadastrar;
        private DateTimePicker txtMarcacaoDeAula;
        private Label label5;
    }
}