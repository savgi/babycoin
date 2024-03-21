namespace Ailton_11._03
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPosLis = new System.Windows.Forms.Label();
            this.lbTexSelec = new System.Windows.Forms.Label();
            this.lbTotItens = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnElimi = new System.Windows.Forms.Button();
            this.btnLimparTodos = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.tbDigiteTexto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite um texto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Posição na lista:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-3, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Texto selecionado:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total de itens:";
            // 
            // lbPosLis
            // 
            this.lbPosLis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbPosLis.Location = new System.Drawing.Point(128, 352);
            this.lbPosLis.Name = "lbPosLis";
            this.lbPosLis.Size = new System.Drawing.Size(628, 23);
            this.lbPosLis.TabIndex = 2;
            // 
            // lbTexSelec
            // 
            this.lbTexSelec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTexSelec.Location = new System.Drawing.Point(127, 385);
            this.lbTexSelec.Name = "lbTexSelec";
            this.lbTexSelec.Size = new System.Drawing.Size(628, 23);
            this.lbTexSelec.TabIndex = 3;
            this.lbTexSelec.Click += new System.EventHandler(this.lbTexSelec_Click);
            // 
            // lbTotItens
            // 
            this.lbTotItens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTotItens.Location = new System.Drawing.Point(128, 419);
            this.lbTotItens.Name = "lbTotItens";
            this.lbTotItens.Size = new System.Drawing.Size(628, 23);
            this.lbTotItens.TabIndex = 4;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(762, 272);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnElimi
            // 
            this.btnElimi.Location = new System.Drawing.Point(762, 301);
            this.btnElimi.Name = "btnElimi";
            this.btnElimi.Size = new System.Drawing.Size(75, 23);
            this.btnElimi.TabIndex = 6;
            this.btnElimi.Text = "Eliminar";
            this.btnElimi.UseVisualStyleBackColor = true;
            this.btnElimi.Click += new System.EventHandler(this.btnElimi_Click);
            // 
            // btnLimparTodos
            // 
            this.btnLimparTodos.Location = new System.Drawing.Point(762, 330);
            this.btnLimparTodos.Name = "btnLimparTodos";
            this.btnLimparTodos.Size = new System.Drawing.Size(75, 45);
            this.btnLimparTodos.TabIndex = 7;
            this.btnLimparTodos.Text = "Limpar todos os itens";
            this.btnLimparTodos.UseVisualStyleBackColor = true;
            this.btnLimparTodos.Click += new System.EventHandler(this.btnLimparTodos_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(762, 381);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(762, 414);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 24);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(16, 44);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(739, 290);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // tbDigiteTexto
            // 
            this.tbDigiteTexto.Location = new System.Drawing.Point(128, 21);
            this.tbDigiteTexto.Name = "tbDigiteTexto";
            this.tbDigiteTexto.Size = new System.Drawing.Size(628, 20);
            this.tbDigiteTexto.TabIndex = 1;
            this.tbDigiteTexto.TextChanged += new System.EventHandler(this.tbDigiteTexto_TextChanged);
            this.tbDigiteTexto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDigiteTexto_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 450);
            this.Controls.Add(this.tbDigiteTexto);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnLimparTodos);
            this.Controls.Add(this.btnElimi);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lbTotItens);
            this.Controls.Add(this.lbTexSelec);
            this.Controls.Add(this.lbPosLis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbPosLis;
        private System.Windows.Forms.Label lbTexSelec;
        private System.Windows.Forms.Label lbTotItens;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnElimi;
        private System.Windows.Forms.Button btnLimparTodos;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox tbDigiteTexto;
    }
}

