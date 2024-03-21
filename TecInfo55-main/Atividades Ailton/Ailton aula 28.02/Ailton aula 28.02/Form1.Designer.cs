namespace Ailton_aula_28._02
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
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btn_Subtração = new System.Windows.Forms.Button();
            this.btn_Soma = new System.Windows.Forms.Button();
            this.textbox_Algoritmo1 = new System.Windows.Forms.TextBox();
            this.textbox_Algoritmo2 = new System.Windows.Forms.TextBox();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMensagem
            // 
            this.lblMensagem.BackColor = System.Drawing.Color.Transparent;
            this.lblMensagem.Font = new System.Drawing.Font("Agency FB", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.Black;
            this.lblMensagem.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblMensagem.Location = new System.Drawing.Point(-3, -1);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(309, 77);
            this.lblMensagem.TabIndex = 2;
            this.lblMensagem.Text = "Calculadorassa foda";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Subtração
            // 
            this.btn_Subtração.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Subtração.Location = new System.Drawing.Point(149, 342);
            this.btn_Subtração.Name = "btn_Subtração";
            this.btn_Subtração.Size = new System.Drawing.Size(132, 56);
            this.btn_Subtração.TabIndex = 1;
            this.btn_Subtração.Text = "-";
            this.btn_Subtração.UseVisualStyleBackColor = true;
            this.btn_Subtração.Click += new System.EventHandler(this.btn_Exibir_Click);
            // 
            // btn_Soma
            // 
            this.btn_Soma.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Soma.Location = new System.Drawing.Point(12, 342);
            this.btn_Soma.Name = "btn_Soma";
            this.btn_Soma.Size = new System.Drawing.Size(131, 56);
            this.btn_Soma.TabIndex = 3;
            this.btn_Soma.Text = "+";
            this.btn_Soma.UseVisualStyleBackColor = true;
            this.btn_Soma.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textbox_Algoritmo1
            // 
            this.textbox_Algoritmo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Algoritmo1.Location = new System.Drawing.Point(12, 113);
            this.textbox_Algoritmo1.Name = "textbox_Algoritmo1";
            this.textbox_Algoritmo1.Size = new System.Drawing.Size(111, 38);
            this.textbox_Algoritmo1.TabIndex = 5;
            this.textbox_Algoritmo1.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // textbox_Algoritmo2
            // 
            this.textbox_Algoritmo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Algoritmo2.Location = new System.Drawing.Point(170, 113);
            this.textbox_Algoritmo2.Name = "textbox_Algoritmo2";
            this.textbox_Algoritmo2.Size = new System.Drawing.Size(111, 38);
            this.textbox_Algoritmo2.TabIndex = 6;
            this.textbox_Algoritmo2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Resultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Resultado.Location = new System.Drawing.Point(78, 207);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(146, 53);
            this.lbl_Resultado.TabIndex = 8;
            this.lbl_Resultado.Click += new System.EventHandler(this.lbl_Resultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.textbox_Algoritmo2);
            this.Controls.Add(this.textbox_Algoritmo1);
            this.Controls.Add(this.btn_Soma);
            this.Controls.Add(this.btn_Subtração);
            this.Controls.Add(this.lblMensagem);
            this.Name = "Form1";
            this.Text = "frm_início";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btn_Subtração;
        private System.Windows.Forms.Button btn_Soma;
        private System.Windows.Forms.TextBox textbox_Algoritmo1;
        private System.Windows.Forms.TextBox textbox_Algoritmo2;
        private System.Windows.Forms.Label lbl_Resultado;
    }
}

