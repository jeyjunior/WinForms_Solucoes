namespace WFGerenciadorDeGastos
{
    partial class Principal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgGastos = new System.Windows.Forms.DataGridView();
            this.colPK_WFRegistroDebito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDespesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataDespesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cboPagamento = new System.Windows.Forms.ComboBox();
            this.btnAddPagamento = new System.Windows.Forms.Button();
            this.btnAddCategoria = new System.Windows.Forms.Button();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.txtDespesa = new System.Windows.Forms.TextBox();
            this.lblDespesa = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPagamento = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.tbnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGastos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgGastos
            // 
            this.dtgGastos.AllowUserToAddRows = false;
            this.dtgGastos.AllowUserToResizeColumns = false;
            this.dtgGastos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgGastos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGastos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPK_WFRegistroDebito,
            this.colDespesa,
            this.colCategoria,
            this.colPagamento,
            this.colDataDespesa,
            this.colValor});
            this.dtgGastos.Location = new System.Drawing.Point(12, 110);
            this.dtgGastos.MultiSelect = false;
            this.dtgGastos.Name = "dtgGastos";
            this.dtgGastos.RowHeadersVisible = false;
            this.dtgGastos.RowHeadersWidth = 51;
            this.dtgGastos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgGastos.Size = new System.Drawing.Size(643, 239);
            this.dtgGastos.TabIndex = 0;
            this.dtgGastos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgGastos_CellContentClick);
            this.dtgGastos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgGastos_CellContentDoubleClick);
            this.dtgGastos.SelectionChanged += new System.EventHandler(this.dtgGastos_SelectionChanged);
            // 
            // colPK_WFRegistroDebito
            // 
            this.colPK_WFRegistroDebito.DataPropertyName = "PK_WFRegistroDebito";
            this.colPK_WFRegistroDebito.HeaderText = "PK_WFRegistroDebito";
            this.colPK_WFRegistroDebito.MinimumWidth = 2;
            this.colPK_WFRegistroDebito.Name = "colPK_WFRegistroDebito";
            this.colPK_WFRegistroDebito.ReadOnly = true;
            this.colPK_WFRegistroDebito.Visible = false;
            this.colPK_WFRegistroDebito.Width = 2;
            // 
            // colDespesa
            // 
            this.colDespesa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDespesa.DataPropertyName = "Despesa";
            this.colDespesa.HeaderText = "Despesa";
            this.colDespesa.Name = "colDespesa";
            this.colDespesa.ReadOnly = true;
            // 
            // colCategoria
            // 
            this.colCategoria.DataPropertyName = "Categoria";
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            // 
            // colPagamento
            // 
            this.colPagamento.DataPropertyName = "Pagamento";
            this.colPagamento.HeaderText = "Tipo de Pagamento";
            this.colPagamento.MinimumWidth = 100;
            this.colPagamento.Name = "colPagamento";
            this.colPagamento.ReadOnly = true;
            this.colPagamento.Width = 120;
            // 
            // colDataDespesa
            // 
            this.colDataDespesa.DataPropertyName = "DataDespesa";
            this.colDataDespesa.HeaderText = "Data da Despesa";
            this.colDataDespesa.MinimumWidth = 120;
            this.colDataDespesa.Name = "colDataDespesa";
            this.colDataDespesa.Width = 120;
            // 
            // colValor
            // 
            this.colValor.DataPropertyName = "Valor";
            this.colValor.HeaderText = "Valor";
            this.colValor.Name = "colValor";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Location = new System.Drawing.Point(471, 69);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(89, 34);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cboPagamento
            // 
            this.cboPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPagamento.FormattingEnabled = true;
            this.cboPagamento.Location = new System.Drawing.Point(517, 26);
            this.cboPagamento.Name = "cboPagamento";
            this.cboPagamento.Size = new System.Drawing.Size(103, 21);
            this.cboPagamento.TabIndex = 2;
            // 
            // btnAddPagamento
            // 
            this.btnAddPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPagamento.Location = new System.Drawing.Point(626, 25);
            this.btnAddPagamento.Name = "btnAddPagamento";
            this.btnAddPagamento.Size = new System.Drawing.Size(29, 21);
            this.btnAddPagamento.TabIndex = 3;
            this.btnAddPagamento.Text = "+";
            this.btnAddPagamento.UseVisualStyleBackColor = true;
            this.btnAddPagamento.Click += new System.EventHandler(this.btnAddPagamento_Click);
            // 
            // btnAddCategoria
            // 
            this.btnAddCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategoria.Location = new System.Drawing.Point(479, 26);
            this.btnAddCategoria.Name = "btnAddCategoria";
            this.btnAddCategoria.Size = new System.Drawing.Size(29, 21);
            this.btnAddCategoria.TabIndex = 5;
            this.btnAddCategoria.Text = "+";
            this.btnAddCategoria.UseVisualStyleBackColor = true;
            this.btnAddCategoria.Click += new System.EventHandler(this.btnAddCategoria_Click);
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(332, 27);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(141, 21);
            this.cboCategoria.TabIndex = 4;
            // 
            // txtDespesa
            // 
            this.txtDespesa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDespesa.Location = new System.Drawing.Point(12, 28);
            this.txtDespesa.Name = "txtDespesa";
            this.txtDespesa.Size = new System.Drawing.Size(193, 20);
            this.txtDespesa.TabIndex = 6;
            // 
            // lblDespesa
            // 
            this.lblDespesa.AutoSize = true;
            this.lblDespesa.Location = new System.Drawing.Point(12, 13);
            this.lblDespesa.Name = "lblDespesa";
            this.lblDespesa.Size = new System.Drawing.Size(49, 13);
            this.lblDespesa.TabIndex = 7;
            this.lblDespesa.Text = "Despesa";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(329, 13);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 8;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblPagamento
            // 
            this.lblPagamento.AutoSize = true;
            this.lblPagamento.Location = new System.Drawing.Point(514, 13);
            this.lblPagamento.Name = "lblPagamento";
            this.lblPagamento.Size = new System.Drawing.Size(61, 13);
            this.lblPagamento.TabIndex = 9;
            this.lblPagamento.Text = "Pagamento";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.SteelBlue;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStatus.Location = new System.Drawing.Point(0, 370);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(667, 13);
            this.lblStatus.TabIndex = 10;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(211, 13);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(54, 13);
            this.lblValor.TabIndex = 12;
            this.lblValor.Text = "Valor (R$)";
            // 
            // txtValor
            // 
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Location = new System.Drawing.Point(211, 28);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(109, 20);
            this.txtValor.TabIndex = 11;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Location = new System.Drawing.Point(566, 70);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(89, 33);
            this.btnPesquisar.TabIndex = 13;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(10, 70);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(89, 34);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Location = new System.Drawing.Point(376, 69);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(89, 34);
            this.btnAlterar.TabIndex = 15;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // tbnLimpar
            // 
            this.tbnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbnLimpar.Location = new System.Drawing.Point(281, 70);
            this.tbnLimpar.Name = "tbnLimpar";
            this.tbnLimpar.Size = new System.Drawing.Size(89, 34);
            this.tbnLimpar.TabIndex = 16;
            this.tbnLimpar.Text = "Limpar";
            this.tbnLimpar.UseVisualStyleBackColor = true;
            this.tbnLimpar.Click += new System.EventHandler(this.tbnLimpar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 383);
            this.Controls.Add(this.tbnLimpar);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblPagamento);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblDespesa);
            this.Controls.Add(this.txtDespesa);
            this.Controls.Add(this.btnAddCategoria);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.btnAddPagamento);
            this.Controls.Add(this.cboPagamento);
            this.Controls.Add(this.dtgGastos);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnRegistrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Principal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgGastos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgGastos;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cboPagamento;
        private System.Windows.Forms.Button btnAddPagamento;
        private System.Windows.Forms.Button btnAddCategoria;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.TextBox txtDespesa;
        private System.Windows.Forms.Label lblDespesa;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPagamento;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPK_WFRegistroDebito;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDespesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataDespesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.Button tbnLimpar;
    }
}

