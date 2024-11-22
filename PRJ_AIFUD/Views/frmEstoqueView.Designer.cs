namespace ProjetoPOOB.Views
{
    partial class frmEstoqueView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstoqueView));
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueAtualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unMedidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoCollectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToOrderColumns = true;
            this.dgvProdutos.AutoGenerateColumns = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nomeProdutoDataGridViewTextBoxColumn,
            this.estoqueAtualDataGridViewTextBoxColumn,
            this.unMedidaDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.precoVendaDataGridViewTextBoxColumn});
            this.dgvProdutos.DataSource = this.produtoCollectionBindingSource;
            this.dgvProdutos.Location = new System.Drawing.Point(63, 73);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(645, 362);
            this.dgvProdutos.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "IdProduto";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            this.nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "NomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.HeaderText = "Produto";
            this.nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            // 
            // estoqueAtualDataGridViewTextBoxColumn
            // 
            this.estoqueAtualDataGridViewTextBoxColumn.DataPropertyName = "EstoqueAtual";
            this.estoqueAtualDataGridViewTextBoxColumn.HeaderText = "Estoque Atual";
            this.estoqueAtualDataGridViewTextBoxColumn.Name = "estoqueAtualDataGridViewTextBoxColumn";
            // 
            // unMedidaDataGridViewTextBoxColumn
            // 
            this.unMedidaDataGridViewTextBoxColumn.DataPropertyName = "UnMedida";
            this.unMedidaDataGridViewTextBoxColumn.HeaderText = "Un Medida";
            this.unMedidaDataGridViewTextBoxColumn.Name = "unMedidaDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // precoVendaDataGridViewTextBoxColumn
            // 
            this.precoVendaDataGridViewTextBoxColumn.DataPropertyName = "PrecoVenda";
            this.precoVendaDataGridViewTextBoxColumn.HeaderText = "Preco de Venda";
            this.precoVendaDataGridViewTextBoxColumn.Name = "precoVendaDataGridViewTextBoxColumn";
            // 
            // produtoCollectionBindingSource
            // 
            this.produtoCollectionBindingSource.DataSource = typeof(ProjetoPOOB.Models.ProdutoCollection);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtPesquisa.Location = new System.Drawing.Point(29, 22);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(272, 30);
            this.txtPesquisa.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnPesquisar.Location = new System.Drawing.Point(307, 17);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(118, 40);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnAlterar.Location = new System.Drawing.Point(555, 17);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(87, 40);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnExcluir.Location = new System.Drawing.Point(650, 17);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(79, 40);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCadastrar.Location = new System.Drawing.Point(431, 17);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(118, 40);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // frmEstoqueView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(741, 468);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.dgvProdutos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEstoqueView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Estoque";
            this.Activated += new System.EventHandler(this.frmEstoqueView_Activated);
            this.Load += new System.EventHandler(this.frmEstoqueView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoCollectionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.BindingSource produtoCollectionBindingSource;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueAtualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unMedidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCadastrar;
    }
}