namespace ProjetoPOOB
{
    partial class frmCadProdutoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadProdutoView));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeProd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskPreco = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.mskEstoque = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUnMedida = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbRestaurante = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNomeProd
            // 
            this.txtNomeProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtNomeProd.Location = new System.Drawing.Point(12, 52);
            this.txtNomeProd.Name = "txtNomeProd";
            this.txtNomeProd.Size = new System.Drawing.Size(243, 38);
            this.txtNomeProd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preço";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtDescricao.Location = new System.Drawing.Point(305, 52);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(391, 316);
            this.txtDescricao.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(453, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descrição";
            // 
            // mskPreco
            // 
            this.mskPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.mskPreco.Location = new System.Drawing.Point(12, 131);
            this.mskPreco.Mask = "$00,00";
            this.mskPreco.Name = "mskPreco";
            this.mskPreco.PromptChar = ' ';
            this.mskPreco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskPreco.Size = new System.Drawing.Size(243, 38);
            this.mskPreco.TabIndex = 2;
            this.mskPreco.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnSalvar.Location = new System.Drawing.Point(350, 394);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(104, 43);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Estoque";
            // 
            // mskEstoque
            // 
            this.mskEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.mskEstoque.HidePromptOnLeave = true;
            this.mskEstoque.Location = new System.Drawing.Point(12, 217);
            this.mskEstoque.Mask = "0000000";
            this.mskEstoque.Name = "mskEstoque";
            this.mskEstoque.PromptChar = ' ';
            this.mskEstoque.Size = new System.Drawing.Size(243, 38);
            this.mskEstoque.TabIndex = 4;
            this.mskEstoque.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskEstoque.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label5.Location = new System.Drawing.Point(12, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Un. Medida";
            // 
            // txtUnMedida
            // 
            this.txtUnMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtUnMedida.Location = new System.Drawing.Point(12, 307);
            this.txtUnMedida.Name = "txtUnMedida";
            this.txtUnMedida.Size = new System.Drawing.Size(243, 38);
            this.txtUnMedida.TabIndex = 5;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnAtualizar.Location = new System.Drawing.Point(499, 394);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(154, 43);
            this.btnAtualizar.TabIndex = 8;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Location = new System.Drawing.Point(73, 394);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(0, 13);
            this.txtId.TabIndex = 9;
            this.txtId.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label6.Location = new System.Drawing.Point(12, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "Restaurante";
            // 
            // cmbRestaurante
            // 
            this.cmbRestaurante.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cmbRestaurante.FormattingEnabled = true;
            this.cmbRestaurante.Location = new System.Drawing.Point(12, 404);
            this.cmbRestaurante.Name = "cmbRestaurante";
            this.cmbRestaurante.Size = new System.Drawing.Size(243, 33);
            this.cmbRestaurante.TabIndex = 12;
            // 
            // frmCadProdutoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(717, 479);
            this.Controls.Add(this.cmbRestaurante);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txtUnMedida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mskEstoque);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.mskPreco);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeProd);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadProdutoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCadProduto";
            this.Load += new System.EventHandler(this.frmCadProdutoView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskPreco;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskEstoque;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUnMedida;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbRestaurante;
    }
}