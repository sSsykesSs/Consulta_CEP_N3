
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.lbCep = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lbRua = new System.Windows.Forms.Label();
            this.lbCidade = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.lbBairro = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.btnTroca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCep
            // 
            this.lbCep.AutoSize = true;
            this.lbCep.Location = new System.Drawing.Point(373, 13);
            this.lbCep.Name = "lbCep";
            this.lbCep.Size = new System.Drawing.Size(73, 13);
            this.lbCep.TabIndex = 0;
            this.lbCep.Text = "Insira um CEP";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(357, 29);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(100, 20);
            this.txtCep.TabIndex = 1;
            this.txtCep.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCep_MaskInputRejected);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(480, 25);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Buscar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lbRua
            // 
            this.lbRua.AutoSize = true;
            this.lbRua.Location = new System.Drawing.Point(229, 140);
            this.lbRua.Name = "lbRua";
            this.lbRua.Size = new System.Drawing.Size(33, 13);
            this.lbRua.TabIndex = 3;
            this.lbRua.Text = "Rua: ";
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Location = new System.Drawing.Point(229, 192);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(46, 13);
            this.lbCidade.TabIndex = 4;
            this.lbCidade.Text = "Cidade: ";
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(229, 218);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(46, 13);
            this.lbEstado.TabIndex = 5;
            this.lbEstado.Text = "Estado: ";
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(229, 164);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(40, 13);
            this.lbBairro.TabIndex = 6;
            this.lbBairro.Text = "Bairro: ";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(315, 132);
            this.txtRua.Name = "txtRua";
            this.txtRua.ReadOnly = true;
            this.txtRua.Size = new System.Drawing.Size(100, 20);
            this.txtRua.TabIndex = 7;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(315, 164);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.ReadOnly = true;
            this.txtBairro.Size = new System.Drawing.Size(100, 20);
            this.txtBairro.TabIndex = 8;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(315, 192);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.ReadOnly = true;
            this.txtCidade.Size = new System.Drawing.Size(100, 20);
            this.txtCidade.TabIndex = 9;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(315, 218);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 10;
            // 
            // btnTroca
            // 
            this.btnTroca.Location = new System.Drawing.Point(480, 54);
            this.btnTroca.Name = "btnTroca";
            this.btnTroca.Size = new System.Drawing.Size(75, 23);
            this.btnTroca.TabIndex = 12;
            this.btnTroca.Text = "Trocar";
            this.btnTroca.UseVisualStyleBackColor = true;
            this.btnTroca.Click += new System.EventHandler(this.btnTroca_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTroca);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.lbBairro);
            this.Controls.Add(this.lbEstado);
            this.Controls.Add(this.lbCidade);
            this.Controls.Add(this.lbRua);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.lbCep);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCep;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lbRua;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Button btnTroca;
    }
}

