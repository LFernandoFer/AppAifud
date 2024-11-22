namespace ProjetoPOOB
{
    partial class frmCadClienteView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadClienteView));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtNome.Location = new System.Drawing.Point(19, 51);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(308, 30);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label3.Location = new System.Drawing.Point(352, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtEndereco.Location = new System.Drawing.Point(359, 128);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(308, 30);
            this.txtEndereco.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label4.Location = new System.Drawing.Point(352, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 39);
            this.label4.TabIndex = 6;
            this.label4.Text = "Endereço";
            // 
            // mskCPF
            // 
            this.mskCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.mskCPF.Location = new System.Drawing.Point(19, 126);
            this.mskCPF.Mask = "000,000,000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(308, 38);
            this.mskCPF.TabIndex = 2;
            this.mskCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.mskTelefone.Location = new System.Drawing.Point(365, 51);
            this.mskTelefone.Mask = "(99) 00000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(308, 38);
            this.mskTelefone.TabIndex = 3;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnSalvar.Location = new System.Drawing.Point(381, 210);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(101, 49);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label5.Location = new System.Drawing.Point(12, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(325, 39);
            this.label5.TabIndex = 11;
            this.label5.Text = "Data de Nascimento";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(19, 221);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(308, 38);
            this.dtpNascimento.TabIndex = 5;
            this.dtpNascimento.Value = new System.DateTime(2024, 10, 31, 0, 0, 0, 0);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnAtualizar.Location = new System.Drawing.Point(514, 210);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(137, 49);
            this.btnAtualizar.TabIndex = 12;
            this.btnAtualizar.Text = "Alterar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Location = new System.Drawing.Point(410, 182);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(0, 13);
            this.txtId.TabIndex = 13;
            this.txtId.Visible = false;
            // 
            // frmCadClienteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(685, 289);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadClienteView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastrar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label txtId;
    }
}