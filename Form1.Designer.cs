namespace Calculadora
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
            btnSoma = new Button();
            btnLimpa = new Button();
            btnEncerrar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtnumero2 = new TextBox();
            txtnumero1 = new TextBox();
            btnSubtrai = new Button();
            btnDivide = new Button();
            btnMultiplica = new Button();
            btnPorcentagem = new Button();
            SuspendLayout();
            // 
            // btnSoma
            // 
            btnSoma.Location = new Point(108, 82);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(75, 23);
            btnSoma.TabIndex = 3;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnLimpa
            // 
            btnLimpa.Location = new Point(270, 53);
            btnLimpa.Name = "btnLimpa";
            btnLimpa.Size = new Size(75, 22);
            btnLimpa.TabIndex = 9;
            btnLimpa.Text = "Limpar";
            btnLimpa.UseVisualStyleBackColor = true;
            btnLimpa.Click += btnLimpa_Click;
            // 
            // btnEncerrar
            // 
            btnEncerrar.Location = new Point(270, 24);
            btnEncerrar.Name = "btnEncerrar";
            btnEncerrar.Size = new Size(75, 22);
            btnEncerrar.TabIndex = 8;
            btnEncerrar.Text = "Fechar";
            btnEncerrar.UseVisualStyleBackColor = true;
            btnEncerrar.Click += btnEncerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 27);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 3;
            label1.Text = "Digite o 1º Número:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 57);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 4;
            label2.Text = "Digite o 2º Número:";
            // 
            // txtnumero2
            // 
            txtnumero2.Location = new Point(164, 53);
            txtnumero2.Name = "txtnumero2";
            txtnumero2.Size = new Size(100, 23);
            txtnumero2.TabIndex = 2;
            txtnumero2.TextAlign = HorizontalAlignment.Center;
            txtnumero2.TextChanged += txtnumero2_TextChanged;
            txtnumero2.KeyPress += txtnumero2_KeyPress;
            // 
            // txtnumero1
            // 
            txtnumero1.Location = new Point(164, 24);
            txtnumero1.Name = "txtnumero1";
            txtnumero1.Size = new Size(100, 23);
            txtnumero1.TabIndex = 1;
            txtnumero1.TextAlign = HorizontalAlignment.Center;
            txtnumero1.TextChanged += txtnumero1_TextChanged;
            txtnumero1.KeyPress += txtnumero1_KeyPress;
            // 
            // btnSubtrai
            // 
            btnSubtrai.Location = new Point(189, 82);
            btnSubtrai.Name = "btnSubtrai";
            btnSubtrai.Size = new Size(75, 23);
            btnSubtrai.TabIndex = 4;
            btnSubtrai.Text = "-";
            btnSubtrai.UseVisualStyleBackColor = true;
            btnSubtrai.Click += btnSubtrai_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(189, 111);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(75, 23);
            btnDivide.TabIndex = 6;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnMultiplica
            // 
            btnMultiplica.Location = new Point(108, 111);
            btnMultiplica.Name = "btnMultiplica";
            btnMultiplica.Size = new Size(75, 23);
            btnMultiplica.TabIndex = 5;
            btnMultiplica.Text = "*";
            btnMultiplica.UseVisualStyleBackColor = true;
            btnMultiplica.Click += btnMultiplica_Click;
            // 
            // btnPorcentagem
            // 
            btnPorcentagem.Location = new Point(270, 82);
            btnPorcentagem.Name = "btnPorcentagem";
            btnPorcentagem.Size = new Size(75, 23);
            btnPorcentagem.TabIndex = 7;
            btnPorcentagem.Text = "%";
            btnPorcentagem.UseVisualStyleBackColor = true;
            btnPorcentagem.Click += btnPorcentagem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 142);
            Controls.Add(btnPorcentagem);
            Controls.Add(btnMultiplica);
            Controls.Add(btnDivide);
            Controls.Add(btnSubtrai);
            Controls.Add(txtnumero1);
            Controls.Add(txtnumero2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEncerrar);
            Controls.Add(btnLimpa);
            Controls.Add(btnSoma);
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSoma;
        private Button btnLimpa;
        private Button btnEncerrar;
        private Label label1;
        private Label label2;
        private TextBox txtnumero2;
        private TextBox txtnumero1;
        private Button btnSubtrai;
        private Button btnDivide;
        private Button btnMultiplica;
        private Button btnPorcentagem;
    }
}
