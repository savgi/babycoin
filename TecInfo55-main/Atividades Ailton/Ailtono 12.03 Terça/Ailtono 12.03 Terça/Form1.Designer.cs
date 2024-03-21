namespace Ailtono_12._03_Terça
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
            this.checkBox_Negrito = new System.Windows.Forms.CheckBox();
            this.txbPalavra = new System.Windows.Forms.TextBox();
            this.checkBox_Itálico = new System.Windows.Forms.CheckBox();
            this.checkBox_Vermelho = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBox_Negrito
            // 
            this.checkBox_Negrito.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Negrito.Location = new System.Drawing.Point(209, 85);
            this.checkBox_Negrito.Name = "checkBox_Negrito";
            this.checkBox_Negrito.Size = new System.Drawing.Size(161, 28);
            this.checkBox_Negrito.TabIndex = 2;
            this.checkBox_Negrito.Text = "Negrito";
            this.checkBox_Negrito.UseVisualStyleBackColor = true;
            this.checkBox_Negrito.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txbPalavra
            // 
            this.txbPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPalavra.Location = new System.Drawing.Point(209, 44);
            this.txbPalavra.Multiline = true;
            this.txbPalavra.Name = "txbPalavra";
            this.txbPalavra.Size = new System.Drawing.Size(293, 35);
            this.txbPalavra.TabIndex = 3;
            this.txbPalavra.TextChanged += new System.EventHandler(this.txb_TextChanged);
            // 
            // checkBox_Itálico
            // 
            this.checkBox_Itálico.AutoSize = true;
            this.checkBox_Itálico.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Itálico.Location = new System.Drawing.Point(209, 119);
            this.checkBox_Itálico.Name = "checkBox_Itálico";
            this.checkBox_Itálico.Size = new System.Drawing.Size(60, 20);
            this.checkBox_Itálico.TabIndex = 4;
            this.checkBox_Itálico.Text = "Itálico";
            this.checkBox_Itálico.UseVisualStyleBackColor = true;
            this.checkBox_Itálico.CheckedChanged += new System.EventHandler(this.checkBox_Itálico_CheckedChanged);
            // 
            // checkBox_Vermelho
            // 
            this.checkBox_Vermelho.AutoSize = true;
            this.checkBox_Vermelho.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Vermelho.Location = new System.Drawing.Point(209, 145);
            this.checkBox_Vermelho.Name = "checkBox_Vermelho";
            this.checkBox_Vermelho.Size = new System.Drawing.Size(82, 20);
            this.checkBox_Vermelho.TabIndex = 5;
            this.checkBox_Vermelho.Text = "Vermelho";
            this.checkBox_Vermelho.UseVisualStyleBackColor = true;
            this.checkBox_Vermelho.CheckedChanged += new System.EventHandler(this.checkBox_Vermelho_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox_Vermelho);
            this.Controls.Add(this.checkBox_Itálico);
            this.Controls.Add(this.txbPalavra);
            this.Controls.Add(this.checkBox_Negrito);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox_Negrito;
        private System.Windows.Forms.TextBox txbPalavra;
        private System.Windows.Forms.CheckBox checkBox_Itálico;
        private System.Windows.Forms.CheckBox checkBox_Vermelho;
    }
}

