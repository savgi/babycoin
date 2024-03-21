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
            this.cb_droplist = new System.Windows.Forms.ComboBox();
            this.tb_Digiteumtexto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_PosLista = new System.Windows.Forms.Label();
            this.lbl_TextSelec = new System.Windows.Forms.Label();
            this.lbl_TotItens = new System.Windows.Forms.Label();
            this.btn_Adic = new System.Windows.Forms.Button();
            this.btn_Elimin = new System.Windows.Forms.Button();
            this.btn_LimpList = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_droplist
            // 
            this.cb_droplist.FormattingEnabled = true;
            this.cb_droplist.Location = new System.Drawing.Point(26, 85);
            this.cb_droplist.Name = "cb_droplist";
            this.cb_droplist.Size = new System.Drawing.Size(762, 21);
            this.cb_droplist.TabIndex = 1;
            this.cb_droplist.SelectedIndexChanged += new System.EventHandler(this.cb_droplist_SelectedIndexChanged);
            // 
            // tb_Digiteumtexto
            // 
            this.tb_Digiteumtexto.Location = new System.Drawing.Point(142, 12);
            this.tb_Digiteumtexto.Name = "tb_Digiteumtexto";
            this.tb_Digiteumtexto.Size = new System.Drawing.Size(646, 20);
            this.tb_Digiteumtexto.TabIndex = 0;
            this.tb_Digiteumtexto.TextChanged += new System.EventHandler(this.tb_Digiteumtexto_TextChanged);
            this.tb_Digiteumtexto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Digiteumtexto_KeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite um texto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Estilo DropdwonList";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Posição na lista:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Texto selecionado:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total de itens:";
            // 
            // lbl_PosLista
            // 
            this.lbl_PosLista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_PosLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PosLista.Location = new System.Drawing.Point(164, 146);
            this.lbl_PosLista.Name = "lbl_PosLista";
            this.lbl_PosLista.Size = new System.Drawing.Size(141, 34);
            this.lbl_PosLista.TabIndex = 8;
            this.lbl_PosLista.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbl_TextSelec
            // 
            this.lbl_TextSelec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_TextSelec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TextSelec.Location = new System.Drawing.Point(164, 194);
            this.lbl_TextSelec.Name = "lbl_TextSelec";
            this.lbl_TextSelec.Size = new System.Drawing.Size(501, 34);
            this.lbl_TextSelec.TabIndex = 9;
            // 
            // lbl_TotItens
            // 
            this.lbl_TotItens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_TotItens.Location = new System.Drawing.Point(164, 241);
            this.lbl_TotItens.Name = "lbl_TotItens";
            this.lbl_TotItens.Size = new System.Drawing.Size(100, 34);
            this.lbl_TotItens.TabIndex = 10;
            // 
            // btn_Adic
            // 
            this.btn_Adic.Location = new System.Drawing.Point(691, 146);
            this.btn_Adic.Name = "btn_Adic";
            this.btn_Adic.Size = new System.Drawing.Size(101, 34);
            this.btn_Adic.TabIndex = 11;
            this.btn_Adic.Text = "Adicionar";
            this.btn_Adic.UseVisualStyleBackColor = true;
            this.btn_Adic.Click += new System.EventHandler(this.btn_Adic_Click);
            // 
            // btn_Elimin
            // 
            this.btn_Elimin.Location = new System.Drawing.Point(691, 194);
            this.btn_Elimin.Name = "btn_Elimin";
            this.btn_Elimin.Size = new System.Drawing.Size(101, 34);
            this.btn_Elimin.TabIndex = 12;
            this.btn_Elimin.Text = "Eliminar";
            this.btn_Elimin.UseVisualStyleBackColor = true;
            this.btn_Elimin.Click += new System.EventHandler(this.btn_Elimin_Click);
            // 
            // btn_LimpList
            // 
            this.btn_LimpList.Location = new System.Drawing.Point(691, 241);
            this.btn_LimpList.Name = "btn_LimpList";
            this.btn_LimpList.Size = new System.Drawing.Size(101, 35);
            this.btn_LimpList.TabIndex = 13;
            this.btn_LimpList.Text = "Limpar toda a lista";
            this.btn_LimpList.UseVisualStyleBackColor = true;
            this.btn_LimpList.Click += new System.EventHandler(this.btn_LimpList_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(691, 291);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 34);
            this.button4.TabIndex = 14;
            this.button4.Text = "Limpar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(691, 338);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 31);
            this.button5.TabIndex = 15;
            this.button5.Text = "Sair";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_LimpList);
            this.Controls.Add(this.btn_Elimin);
            this.Controls.Add(this.btn_Adic);
            this.Controls.Add(this.lbl_TotItens);
            this.Controls.Add(this.lbl_TextSelec);
            this.Controls.Add(this.lbl_PosLista);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Digiteumtexto);
            this.Controls.Add(this.cb_droplist);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_droplist;
        private System.Windows.Forms.TextBox tb_Digiteumtexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_PosLista;
        private System.Windows.Forms.Label lbl_TextSelec;
        private System.Windows.Forms.Label lbl_TotItens;
        private System.Windows.Forms.Button btn_Adic;
        private System.Windows.Forms.Button btn_Elimin;
        private System.Windows.Forms.Button btn_LimpList;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

