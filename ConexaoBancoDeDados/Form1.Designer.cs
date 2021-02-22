
namespace ConexaoBancoDeDados
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
            this.dtview = new System.Windows.Forms.DataGridView();
            this.btsalvar = new System.Windows.Forms.Button();
            this.btatualizar = new System.Windows.Forms.Button();
            this.lbnome = new System.Windows.Forms.Label();
            this.lbcpf = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.txpesquisar = new System.Windows.Forms.MaskedTextBox();
            this.lbpesquisar = new System.Windows.Forms.Label();
            this.btpesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtview)).BeginInit();
            this.SuspendLayout();
            // 
            // dtview
            // 
            this.dtview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtview.Location = new System.Drawing.Point(12, 263);
            this.dtview.Name = "dtview";
            this.dtview.Size = new System.Drawing.Size(776, 331);
            this.dtview.TabIndex = 0;
            this.dtview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtview_CellContentClick);
            // 
            // btsalvar
            // 
            this.btsalvar.Location = new System.Drawing.Point(518, 208);
            this.btsalvar.Name = "btsalvar";
            this.btsalvar.Size = new System.Drawing.Size(132, 31);
            this.btsalvar.TabIndex = 1;
            this.btsalvar.Text = "Salvar";
            this.btsalvar.UseVisualStyleBackColor = true;
            this.btsalvar.Click += new System.EventHandler(this.btsalvar_Click);
            // 
            // btatualizar
            // 
            this.btatualizar.Location = new System.Drawing.Point(656, 208);
            this.btatualizar.Name = "btatualizar";
            this.btatualizar.Size = new System.Drawing.Size(132, 31);
            this.btatualizar.TabIndex = 2;
            this.btatualizar.Text = "Atualizar";
            this.btatualizar.UseVisualStyleBackColor = true;
            this.btatualizar.Click += new System.EventHandler(this.btatualizar_Click);
            // 
            // lbnome
            // 
            this.lbnome.AutoSize = true;
            this.lbnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnome.Location = new System.Drawing.Point(7, 163);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(86, 25);
            this.lbnome.TabIndex = 3;
            this.lbnome.Text = "Nome: ";
            // 
            // lbcpf
            // 
            this.lbcpf.AutoSize = true;
            this.lbcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcpf.Location = new System.Drawing.Point(7, 208);
            this.lbcpf.Name = "lbcpf";
            this.lbcpf.Size = new System.Drawing.Size(64, 25);
            this.lbcpf.TabIndex = 4;
            this.lbcpf.Text = "CPF:";
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(82, 160);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(706, 31);
            this.txtnome.TabIndex = 5;
            // 
            // txtcpf
            // 
            this.txtcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcpf.Location = new System.Drawing.Point(82, 205);
            this.txtcpf.Mask = "000.000.000-00";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(166, 31);
            this.txtcpf.TabIndex = 6;
            // 
            // txpesquisar
            // 
            this.txpesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txpesquisar.Location = new System.Drawing.Point(137, 81);
            this.txpesquisar.Mask = "000.000.000-00";
            this.txpesquisar.Name = "txpesquisar";
            this.txpesquisar.Size = new System.Drawing.Size(166, 31);
            this.txpesquisar.TabIndex = 8;
            // 
            // lbpesquisar
            // 
            this.lbpesquisar.AutoSize = true;
            this.lbpesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpesquisar.Location = new System.Drawing.Point(7, 84);
            this.lbpesquisar.Name = "lbpesquisar";
            this.lbpesquisar.Size = new System.Drawing.Size(124, 25);
            this.lbpesquisar.TabIndex = 7;
            this.lbpesquisar.Text = "Pesquisar:";
            this.lbpesquisar.Click += new System.EventHandler(this.label1_Click);
            // 
            // btpesquisar
            // 
            this.btpesquisar.Location = new System.Drawing.Point(320, 81);
            this.btpesquisar.Name = "btpesquisar";
            this.btpesquisar.Size = new System.Drawing.Size(132, 31);
            this.btpesquisar.TabIndex = 9;
            this.btpesquisar.Text = "Pesquisar";
            this.btpesquisar.UseVisualStyleBackColor = true;
            this.btpesquisar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 606);
            this.Controls.Add(this.btpesquisar);
            this.Controls.Add(this.txpesquisar);
            this.Controls.Add(this.lbpesquisar);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lbcpf);
            this.Controls.Add(this.lbnome);
            this.Controls.Add(this.btatualizar);
            this.Controls.Add(this.btsalvar);
            this.Controls.Add(this.dtview);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtview;
        private System.Windows.Forms.Button btsalvar;
        private System.Windows.Forms.Button btatualizar;
        private System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.Label lbcpf;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.MaskedTextBox txpesquisar;
        private System.Windows.Forms.Label lbpesquisar;
        private System.Windows.Forms.Button btpesquisar;
    }
}

