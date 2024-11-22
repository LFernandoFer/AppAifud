namespace ProjetoPOOB.Views
{
    partial class frmFuncionarioColecao
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionarioColecao));
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionarioCollectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioCollectionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.AutoGenerateColumns = false;
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nomeDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.funcaoDataGridViewTextBoxColumn,
            this.turnoDataGridViewTextBoxColumn,
            this.dtNascimentoDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn});
            this.dgvFuncionarios.DataSource = this.funcionarioCollectionsBindingSource;
            this.dgvFuncionarios.Location = new System.Drawing.Point(1, 72);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvFuncionarios.Size = new System.Drawing.Size(724, 296);
            this.dgvFuncionarios.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtPesquisa.Location = new System.Drawing.Point(1, 12);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(224, 30);
            this.txtPesquisa.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnPesquisar.Location = new System.Drawing.Point(231, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(121, 30);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCadastrar.Location = new System.Drawing.Point(358, 12);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(109, 30);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnAlterar.Location = new System.Drawing.Point(473, 12);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(109, 30);
            this.btnAlterar.TabIndex = 4;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnExcluir.Location = new System.Drawing.Point(588, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(94, 30);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            // 
            // funcaoDataGridViewTextBoxColumn
            // 
            this.funcaoDataGridViewTextBoxColumn.DataPropertyName = "Funcao";
            this.funcaoDataGridViewTextBoxColumn.HeaderText = "Funcao";
            this.funcaoDataGridViewTextBoxColumn.Name = "funcaoDataGridViewTextBoxColumn";
            // 
            // turnoDataGridViewTextBoxColumn
            // 
            this.turnoDataGridViewTextBoxColumn.DataPropertyName = "Turno";
            this.turnoDataGridViewTextBoxColumn.HeaderText = "Turno";
            this.turnoDataGridViewTextBoxColumn.Name = "turnoDataGridViewTextBoxColumn";
            // 
            // dtNascimentoDataGridViewTextBoxColumn
            // 
            this.dtNascimentoDataGridViewTextBoxColumn.DataPropertyName = "DtNascimento";
            this.dtNascimentoDataGridViewTextBoxColumn.HeaderText = "DtNascimento";
            this.dtNascimentoDataGridViewTextBoxColumn.Name = "dtNascimentoDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            // 
            // funcionarioCollectionsBindingSource
            // 
            this.funcionarioCollectionsBindingSource.DataSource = typeof(ProjetoPOOB.Models.FuncionarioCollections);
            // 
            // frmFuncionarioColecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(725, 380);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.dgvFuncionarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFuncionarioColecao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Funcionários ";
            this.Activated += new System.EventHandler(this.frmFuncionarioColecao_Activated);
            this.Load += new System.EventHandler(this.frmFuncionarioColecao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioCollectionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.BindingSource funcionarioCollectionsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
    }
}