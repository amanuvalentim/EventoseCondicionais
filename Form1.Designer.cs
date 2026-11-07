namespace EventoseCondicionais
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
            txtNome = new TextBox();
            txtAnoNascimento = new TextBox();
            txtAnoUltimoAniversario = new TextBox();
            btnIdentificarCategoria = new Button();
            textBox4 = new TextBox();
            Label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblCategoriaDoAluno = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(145, 37);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(431, 23);
            txtNome.TabIndex = 0;
            // 
            // txtAnoNascimento
            // 
            txtAnoNascimento.Location = new Point(197, 139);
            txtAnoNascimento.Name = "txtAnoNascimento";
            txtAnoNascimento.Size = new Size(100, 23);
            txtAnoNascimento.TabIndex = 1;
            txtAnoNascimento.TextChanged += txtAnoNascimento_TextChanged;
            txtAnoNascimento.KeyDown += txtAnoNascimento_KeyDown;
            // 
            // txtAnoUltimoAniversario
            // 
            txtAnoUltimoAniversario.Location = new Point(476, 139);
            txtAnoUltimoAniversario.Name = "txtAnoUltimoAniversario";
            txtAnoUltimoAniversario.Size = new Size(100, 23);
            txtAnoUltimoAniversario.TabIndex = 2;
            txtAnoUltimoAniversario.KeyDown += txtAnoUltimoAniversario_KeyDown;
            // 
            // btnIdentificarCategoria
            // 
            btnIdentificarCategoria.Location = new Point(145, 247);
            btnIdentificarCategoria.Name = "btnIdentificarCategoria";
            btnIdentificarCategoria.Size = new Size(194, 23);
            btnIdentificarCategoria.TabIndex = 3;
            btnIdentificarCategoria.Text = "Identificar Categoria";
            btnIdentificarCategoria.UseVisualStyleBackColor = true;
            btnIdentificarCategoria.Click += btnIdentificarCategoria_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Yellow;
            textBox4.Location = new Point(476, 247);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 4;
            textBox4.TextAlign = HorizontalAlignment.Center;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(85, 40);
            Label1.Name = "Label1";
            Label1.Size = new Size(40, 15);
            Label1.TabIndex = 5;
            Label1.Text = "&Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 142);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 6;
            label2.Text = "Ano nascimento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(340, 142);
            label3.Name = "label3";
            label3.Size = new Size(130, 15);
            label3.TabIndex = 7;
            label3.Text = "Ano ultimo aniversario:";
            // 
            // lblCategoriaDoAluno
            // 
            lblCategoriaDoAluno.AutoSize = true;
            lblCategoriaDoAluno.Location = new Point(409, 251);
            lblCategoriaDoAluno.Name = "lblCategoriaDoAluno";
            lblCategoriaDoAluno.Size = new Size(0, 15);
            lblCategoriaDoAluno.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCategoriaDoAluno);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Label1);
            Controls.Add(textBox4);
            Controls.Add(btnIdentificarCategoria);
            Controls.Add(txtAnoUltimoAniversario);
            Controls.Add(txtAnoNascimento);
            Controls.Add(txtNome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtAnoNascimento;
        private TextBox txtAnoUltimoAniversario;
        private Button btnIdentificarCategoria;
        private TextBox textBox4;
        private Label Label1;
        private Label label2;
        private Label label3;
        private Label lblCategoriaDoAluno;
    }
}
