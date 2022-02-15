
namespace BuscaCep
{
    partial class Frm_BuscaCep
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Cep = new System.Windows.Forms.Label();
            this.msk_Cep = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Uf = new System.Windows.Forms.Label();
            this.lbl_Localidade = new System.Windows.Forms.Label();
            this.lbl_Bairro = new System.Windows.Forms.Label();
            this.lbl_Logradouro = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.txt_Logradouro = new System.Windows.Forms.TextBox();
            this.txt_Bairro = new System.Windows.Forms.TextBox();
            this.txt_Localidade = new System.Windows.Forms.TextBox();
            this.txt_Uf = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Cep
            // 
            this.lbl_Cep.AutoSize = true;
            this.lbl_Cep.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cep.Location = new System.Drawing.Point(15, 36);
            this.lbl_Cep.Name = "lbl_Cep";
            this.lbl_Cep.Size = new System.Drawing.Size(237, 16);
            this.lbl_Cep.TabIndex = 0;
            this.lbl_Cep.Text = "Digite o CEP do endereço desejado:";
            // 
            // msk_Cep
            // 
            this.msk_Cep.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_Cep.ForeColor = System.Drawing.SystemColors.WindowText;
            this.msk_Cep.Location = new System.Drawing.Point(255, 29);
            this.msk_Cep.Mask = "00,000-000";
            this.msk_Cep.Name = "msk_Cep";
            this.msk_Cep.Size = new System.Drawing.Size(126, 29);
            this.msk_Cep.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Uf);
            this.groupBox1.Controls.Add(this.txt_Localidade);
            this.groupBox1.Controls.Add(this.txt_Bairro);
            this.groupBox1.Controls.Add(this.txt_Logradouro);
            this.groupBox1.Controls.Add(this.lbl_Uf);
            this.groupBox1.Controls.Add(this.lbl_Localidade);
            this.groupBox1.Controls.Add(this.lbl_Bairro);
            this.groupBox1.Controls.Add(this.lbl_Logradouro);
            this.groupBox1.Location = new System.Drawing.Point(19, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 165);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados retornados:";
            // 
            // lbl_Uf
            // 
            this.lbl_Uf.AutoSize = true;
            this.lbl_Uf.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Uf.Location = new System.Drawing.Point(10, 130);
            this.lbl_Uf.Name = "lbl_Uf";
            this.lbl_Uf.Size = new System.Drawing.Size(33, 16);
            this.lbl_Uf.TabIndex = 0;
            this.lbl_Uf.Text = "UF: ";
            // 
            // lbl_Localidade
            // 
            this.lbl_Localidade.AutoSize = true;
            this.lbl_Localidade.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Localidade.Location = new System.Drawing.Point(10, 98);
            this.lbl_Localidade.Name = "lbl_Localidade";
            this.lbl_Localidade.Size = new System.Drawing.Size(87, 16);
            this.lbl_Localidade.TabIndex = 0;
            this.lbl_Localidade.Text = "Localidade: ";
            // 
            // lbl_Bairro
            // 
            this.lbl_Bairro.AutoSize = true;
            this.lbl_Bairro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bairro.Location = new System.Drawing.Point(10, 64);
            this.lbl_Bairro.Name = "lbl_Bairro";
            this.lbl_Bairro.Size = new System.Drawing.Size(55, 16);
            this.lbl_Bairro.TabIndex = 0;
            this.lbl_Bairro.Text = "Bairro: ";
            // 
            // lbl_Logradouro
            // 
            this.lbl_Logradouro.AutoSize = true;
            this.lbl_Logradouro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Logradouro.Location = new System.Drawing.Point(10, 32);
            this.lbl_Logradouro.Name = "lbl_Logradouro";
            this.lbl_Logradouro.Size = new System.Drawing.Size(90, 16);
            this.lbl_Logradouro.TabIndex = 0;
            this.lbl_Logradouro.Text = "Logradouro: ";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(9, 79);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(372, 42);
            this.btn_Buscar.TabIndex = 3;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(215, 298);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(124, 47);
            this.btn_Sair.TabIndex = 4;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(65, 299);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(124, 47);
            this.btn_Limpar.TabIndex = 5;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // txt_Logradouro
            // 
            this.txt_Logradouro.Location = new System.Drawing.Point(106, 31);
            this.txt_Logradouro.Name = "txt_Logradouro";
            this.txt_Logradouro.ReadOnly = true;
            this.txt_Logradouro.Size = new System.Drawing.Size(233, 20);
            this.txt_Logradouro.TabIndex = 1;
            // 
            // txt_Bairro
            // 
            this.txt_Bairro.Location = new System.Drawing.Point(106, 63);
            this.txt_Bairro.Name = "txt_Bairro";
            this.txt_Bairro.ReadOnly = true;
            this.txt_Bairro.Size = new System.Drawing.Size(233, 20);
            this.txt_Bairro.TabIndex = 1;
            // 
            // txt_Localidade
            // 
            this.txt_Localidade.Location = new System.Drawing.Point(106, 97);
            this.txt_Localidade.Name = "txt_Localidade";
            this.txt_Localidade.ReadOnly = true;
            this.txt_Localidade.Size = new System.Drawing.Size(233, 20);
            this.txt_Localidade.TabIndex = 1;
            // 
            // txt_Uf
            // 
            this.txt_Uf.Location = new System.Drawing.Point(106, 129);
            this.txt_Uf.Name = "txt_Uf";
            this.txt_Uf.ReadOnly = true;
            this.txt_Uf.Size = new System.Drawing.Size(233, 20);
            this.txt_Uf.TabIndex = 1;
            // 
            // Frm_BuscaCep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 369);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.msk_Cep);
            this.Controls.Add(this.lbl_Cep);
            this.Name = "Frm_BuscaCep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de CEP";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Cep;
        private System.Windows.Forms.MaskedTextBox msk_Cep;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Logradouro;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Label lbl_Bairro;
        private System.Windows.Forms.Label lbl_Uf;
        private System.Windows.Forms.Label lbl_Localidade;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.TextBox txt_Uf;
        private System.Windows.Forms.TextBox txt_Localidade;
        private System.Windows.Forms.TextBox txt_Bairro;
        private System.Windows.Forms.TextBox txt_Logradouro;
    }
}

