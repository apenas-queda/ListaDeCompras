namespace ListaDeCompras
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
            this.pibLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNomedoProduto = new System.Windows.Forms.Label();
            this.txbProduto = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.libCompras = new System.Windows.Forms.ListBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pibLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pibLogo
            // 
            this.pibLogo.Image = global::ListaDeCompras.Properties.Resources.logo;
            this.pibLogo.Location = new System.Drawing.Point(35, 68);
            this.pibLogo.Name = "pibLogo";
            this.pibLogo.Size = new System.Drawing.Size(100, 76);
            this.pibLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibLogo.TabIndex = 0;
            this.pibLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MS Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(214, 68);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(303, 35);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Lista de Compras";
            // 
            // lblNomedoProduto
            // 
            this.lblNomedoProduto.AutoSize = true;
            this.lblNomedoProduto.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomedoProduto.Location = new System.Drawing.Point(32, 153);
            this.lblNomedoProduto.Name = "lblNomedoProduto";
            this.lblNomedoProduto.Size = new System.Drawing.Size(135, 16);
            this.lblNomedoProduto.TabIndex = 2;
            this.lblNomedoProduto.Text = "Nome do Produto:";
            // 
            // txbProduto
            // 
            this.txbProduto.Location = new System.Drawing.Point(35, 188);
            this.txbProduto.Name = "txbProduto";
            this.txbProduto.Size = new System.Drawing.Size(207, 20);
            this.txbProduto.TabIndex = 3;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(35, 293);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(207, 59);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // libCompras
            // 
            this.libCompras.FormattingEnabled = true;
            this.libCompras.Location = new System.Drawing.Point(310, 153);
            this.libCompras.Name = "libCompras";
            this.libCompras.Size = new System.Drawing.Size(466, 199);
            this.libCompras.TabIndex = 5;
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(310, 358);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(207, 59);
            this.btnApagar.TabIndex = 7;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(569, 358);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(207, 59);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar Lista";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(809, 599);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.libCompras);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txbProduto);
            this.Controls.Add(this.lblNomedoProduto);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pibLogo);
            this.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Lista de Compras ::";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pibLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pibLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNomedoProduto;
        private System.Windows.Forms.TextBox txbProduto;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListBox libCompras;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnLimpar;
    }
}

