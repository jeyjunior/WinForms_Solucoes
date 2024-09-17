namespace WFGerenciadorDeGastos.Telas
{
    partial class CadastroMetodoPagamento
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
            this.dtgPagamento = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtPagamento = new System.Windows.Forms.TextBox();
            this.lblDespesa = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.colPK_WFMetodoPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPagamento)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgPagamento
            // 
            this.dtgPagamento.AllowUserToAddRows = false;
            this.dtgPagamento.AllowUserToDeleteRows = false;
            this.dtgPagamento.AllowUserToResizeColumns = false;
            this.dtgPagamento.AllowUserToResizeRows = false;
            this.dtgPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPagamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPK_WFMetodoPagamento,
            this.colNome});
            this.dtgPagamento.Location = new System.Drawing.Point(12, 118);
            this.dtgPagamento.Name = "dtgPagamento";
            this.dtgPagamento.RowHeadersVisible = false;
            this.dtgPagamento.Size = new System.Drawing.Size(308, 161);
            this.dtgPagamento.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(218, 63);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(48, 36);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(272, 63);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(48, 36);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(12, 63);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(48, 36);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // txtPagamento
            // 
            this.txtPagamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPagamento.Location = new System.Drawing.Point(12, 25);
            this.txtPagamento.Name = "txtPagamento";
            this.txtPagamento.Size = new System.Drawing.Size(308, 20);
            this.txtPagamento.TabIndex = 0;
            // 
            // lblDespesa
            // 
            this.lblDespesa.Location = new System.Drawing.Point(12, 9);
            this.lblDespesa.Name = "lblDespesa";
            this.lblDespesa.Size = new System.Drawing.Size(240, 13);
            this.lblDespesa.TabIndex = 10;
            this.lblDespesa.Text = "Método Pagamento";
            this.lblDespesa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(164, 63);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(48, 36);
            this.btnAlterar.TabIndex = 11;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(110, 63);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(48, 36);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.SteelBlue;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStatus.Location = new System.Drawing.Point(0, 291);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(334, 13);
            this.lblStatus.TabIndex = 13;
            // 
            // colPK_WFMetodoPagamento
            // 
            this.colPK_WFMetodoPagamento.DataPropertyName = "PK_WFMetodoPagamento";
            this.colPK_WFMetodoPagamento.HeaderText = "PK_WFMetodoPagamento";
            this.colPK_WFMetodoPagamento.Name = "colPK_WFMetodoPagamento";
            this.colPK_WFMetodoPagamento.Visible = false;
            // 
            // colNome
            // 
            this.colNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNome.DataPropertyName = "Nome";
            this.colNome.HeaderText = "Pagamento";
            this.colNome.Name = "colNome";
            // 
            // CadastroMetodoPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 304);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.lblDespesa);
            this.Controls.Add(this.txtPagamento);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dtgPagamento);
            this.Name = "CadastroMetodoPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Método de Pagamento";
            ((System.ComponentModel.ISupportInitialize)(this.dtgPagamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgPagamento;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtPagamento;
        private System.Windows.Forms.Label lblDespesa;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPK_WFMetodoPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
    }
}