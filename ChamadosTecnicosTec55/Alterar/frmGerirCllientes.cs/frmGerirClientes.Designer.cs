namespace ChamadosTecnicosTec55.Alterar.frmGerirCllientes.cs
{
    partial class frmGerirClientes
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
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_Busca = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_IncluirCli = new System.Windows.Forms.Button();
            this.btn_AlterarCli = new System.Windows.Forms.Button();
            this.btn_ExcluirCli = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(29, 70);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.Size = new System.Drawing.Size(710, 303);
            this.dgvCliente.TabIndex = 0;
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gerir Cliente";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(413, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Busca:";
            // 
            // txb_Busca
            // 
            this.txb_Busca.Location = new System.Drawing.Point(471, 39);
            this.txb_Busca.Multiline = true;
            this.txb_Busca.Name = "txb_Busca";
            this.txb_Busca.Size = new System.Drawing.Size(174, 23);
            this.txb_Busca.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(648, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_IncluirCli
            // 
            this.btn_IncluirCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IncluirCli.Location = new System.Drawing.Point(61, 393);
            this.btn_IncluirCli.Name = "btn_IncluirCli";
            this.btn_IncluirCli.Size = new System.Drawing.Size(152, 45);
            this.btn_IncluirCli.TabIndex = 5;
            this.btn_IncluirCli.Text = "Incluir Cliente";
            this.btn_IncluirCli.UseVisualStyleBackColor = true;
            this.btn_IncluirCli.Click += new System.EventHandler(this.btn_IncluirCli_Click);
            // 
            // btn_AlterarCli
            // 
            this.btn_AlterarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AlterarCli.Location = new System.Drawing.Point(298, 393);
            this.btn_AlterarCli.Name = "btn_AlterarCli";
            this.btn_AlterarCli.Size = new System.Drawing.Size(152, 45);
            this.btn_AlterarCli.TabIndex = 6;
            this.btn_AlterarCli.Text = "Alterar Cliente";
            this.btn_AlterarCli.UseVisualStyleBackColor = true;
            this.btn_AlterarCli.Click += new System.EventHandler(this.btn_AlterarCli_Click);
            // 
            // btn_ExcluirCli
            // 
            this.btn_ExcluirCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExcluirCli.Location = new System.Drawing.Point(545, 393);
            this.btn_ExcluirCli.Name = "btn_ExcluirCli";
            this.btn_ExcluirCli.Size = new System.Drawing.Size(154, 45);
            this.btn_ExcluirCli.TabIndex = 7;
            this.btn_ExcluirCli.Text = "Excluir Cliente";
            this.btn_ExcluirCli.UseVisualStyleBackColor = true;
            this.btn_ExcluirCli.Click += new System.EventHandler(this.btn_ExcluirCli_Click);
            // 
            // frmGerirClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ExcluirCli);
            this.Controls.Add(this.btn_AlterarCli);
            this.Controls.Add(this.btn_IncluirCli);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txb_Busca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCliente);
            this.Name = "frmGerirClientes";
            this.Text = "frmGerirClientes";
            this.Load += new System.EventHandler(this.frmGerirClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_Busca;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_IncluirCli;
        private System.Windows.Forms.Button btn_AlterarCli;
        private System.Windows.Forms.Button btn_ExcluirCli;
    }
}