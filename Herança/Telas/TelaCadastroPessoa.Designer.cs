namespace Herança.Telas
{
    partial class TelaCadastroPessoa
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
            this.ttbNome = new System.Windows.Forms.TextBox();
            this.ttbCPF = new System.Windows.Forms.MaskedTextBox();
            this.ttbLogradouro = new System.Windows.Forms.TextBox();
            this.ttbNumero = new System.Windows.Forms.TextBox();
            this.ttbBairro = new System.Windows.Forms.TextBox();
            this.ttbCidade = new System.Windows.Forms.TextBox();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.ttbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ttbNome
            // 
            this.ttbNome.BackColor = System.Drawing.Color.White;
            this.ttbNome.Location = new System.Drawing.Point(12, 69);
            this.ttbNome.Name = "ttbNome";
            this.ttbNome.Size = new System.Drawing.Size(299, 23);
            this.ttbNome.TabIndex = 0;
            // 
            // ttbCPF
            // 
            this.ttbCPF.Location = new System.Drawing.Point(317, 69);
            this.ttbCPF.Mask = "000,000,000-00";
            this.ttbCPF.Name = "ttbCPF";
            this.ttbCPF.Size = new System.Drawing.Size(121, 23);
            this.ttbCPF.TabIndex = 1;
            // 
            // ttbLogradouro
            // 
            this.ttbLogradouro.Location = new System.Drawing.Point(12, 125);
            this.ttbLogradouro.Name = "ttbLogradouro";
            this.ttbLogradouro.Size = new System.Drawing.Size(315, 23);
            this.ttbLogradouro.TabIndex = 2;
            // 
            // ttbNumero
            // 
            this.ttbNumero.Location = new System.Drawing.Point(333, 125);
            this.ttbNumero.Name = "ttbNumero";
            this.ttbNumero.Size = new System.Drawing.Size(105, 23);
            this.ttbNumero.TabIndex = 3;
            // 
            // ttbBairro
            // 
            this.ttbBairro.Location = new System.Drawing.Point(12, 176);
            this.ttbBairro.Name = "ttbBairro";
            this.ttbBairro.Size = new System.Drawing.Size(153, 23);
            this.ttbBairro.TabIndex = 4;
            // 
            // ttbCidade
            // 
            this.ttbCidade.Location = new System.Drawing.Point(171, 176);
            this.ttbCidade.Name = "ttbCidade";
            this.ttbCidade.Size = new System.Drawing.Size(140, 23);
            this.ttbCidade.TabIndex = 5;
            // 
            // cbbEstado
            // 
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(317, 176);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(121, 23);
            this.cbbEstado.TabIndex = 6;
            // 
            // ttbTelefone
            // 
            this.ttbTelefone.Location = new System.Drawing.Point(12, 230);
            this.ttbTelefone.Mask = "(00)00000-0000";
            this.ttbTelefone.Name = "ttbTelefone";
            this.ttbTelefone.Size = new System.Drawing.Size(100, 23);
            this.ttbTelefone.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cadastro de Pessoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Logradouro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Número";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Bairro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(171, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cidade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(317, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Estado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Telefone";
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(317, 222);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(105, 37);
            this.btnValidar.TabIndex = 17;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // TelaCadastroPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(451, 335);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ttbTelefone);
            this.Controls.Add(this.cbbEstado);
            this.Controls.Add(this.ttbCidade);
            this.Controls.Add(this.ttbBairro);
            this.Controls.Add(this.ttbNumero);
            this.Controls.Add(this.ttbLogradouro);
            this.Controls.Add(this.ttbCPF);
            this.Controls.Add(this.ttbNome);
            this.Name = "TelaCadastroPessoa";
            this.Text = "TelaCadastroPessoa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox ttbNome;
        private MaskedTextBox ttbCPF;
        private TextBox ttbLogradouro;
        private TextBox ttbNumero;
        private TextBox ttbBairro;
        private TextBox ttbCidade;
        private ComboBox cbbEstado;
        private MaskedTextBox ttbTelefone;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnValidar;
    }
}