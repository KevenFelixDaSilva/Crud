
namespace Crud_1._0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCadastrarTela = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPerfil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrarTela
            // 
            this.btnCadastrarTela.Location = new System.Drawing.Point(321, 117);
            this.btnCadastrarTela.Name = "btnCadastrarTela";
            this.btnCadastrarTela.Size = new System.Drawing.Size(179, 58);
            this.btnCadastrarTela.TabIndex = 10;
            this.btnCadastrarTela.Text = "Cadastrar";
            this.btnCadastrarTela.UseVisualStyleBackColor = true;
            this.btnCadastrarTela.Click += new System.EventHandler(this.btnCadastrarTela_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(321, 204);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(180, 58);
            this.btnExibir.TabIndex = 9;
            this.btnExibir.Text = "Consultar";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(748, 348);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnPerfil
            // 
            this.btnPerfil.Location = new System.Drawing.Point(322, 292);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(179, 58);
            this.btnPerfil.TabIndex = 11;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.btnCadastrarTela);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCadastrarTela;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPerfil;
    }
}

