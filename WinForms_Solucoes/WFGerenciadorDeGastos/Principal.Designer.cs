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
            this.colPK_WFRegistroDebitos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDespesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataDespesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.colPK_WFRegistroDebitos,
            this.colDespesa,
            this.colCategoria,
            this.colPagamento,
            this.colDataDespesa,
            this.colValor});
            this.dtgGastos.Location = new System.Drawing.Point(12, 100);
            this.dtgGastos.MultiSelect = false;
            this.dtgGastos.Name = "dtgGastos";
            this.dtgGastos.RowHeadersVisible = false;
            this.dtgGastos.RowHeadersWidth = 51;
            this.dtgGastos.Size = new System.Drawing.Size(637, 249);
            this.dtgGastos.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Location = new System.Drawing.Point(560, 13);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(89, 75);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cboPagamento
            // 
            this.cboPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPagamento.FormattingEnabled = true;
            this.cboPagamento.Location = new System.Drawing.Point(308, 67);
            this.cboPagamento.Name = "cboPagamento";
            this.cboPagamento.Size = new System.Drawing.Size(196, 21);
            this.cboPagamento.TabIndex = 2;
            // 
            // btnAddPagamento
            // 
            this.btnAddPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPagamento.Location = new System.Drawing.Point(510, 67);
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
            this.btnAddCategoria.Location = new System.Drawing.Point(237, 67);
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
            this.cboCategoria.Location = new System.Drawing.Point(12, 67);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(219, 21);
            this.cboCategoria.TabIndex = 4;
            // 
            // txtDespesa
            // 
            this.txtDespesa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDespesa.Location = new System.Drawing.Point(12, 26);
            this.txtDespesa.Name = "txtDespesa";
            this.txtDespesa.Size = new System.Drawing.Size(348, 20);
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
            this.lblCategoria.Location = new System.Drawing.Point(12, 54);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 8;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblPagamento
            // 
            this.lblPagamento.AutoSize = true;
            this.lblPagamento.Location = new System.Drawing.Point(308, 54);
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
            this.lblValor.Location = new System.Drawing.Point(366, 13);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(54, 13);
            this.lblValor.TabIndex = 12;
            this.lblValor.Text = "Valor (R$)";
            // 
            // txtValor
            // 
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Location = new System.Drawing.Point(369, 26);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(172, 20);
            this.txtValor.TabIndex = 11;
            // 
            // colPK_WFRegistroDebitos
            // 
            this.colPK_WFRegistroDebitos.DataPropertyName = "PK_WFRegistroDebitos";
            this.colPK_WFRegistroDebitos.HeaderText = "PK_WFRegistroDebitos";
            this.colPK_WFRegistroDebitos.MinimumWidth = 2;
            this.colPK_WFRegistroDebitos.Name = "colPK_WFRegistroDebitos";
            this.colPK_WFRegistroDebitos.ReadOnly = true;
            this.colPK_WFRegistroDebitos.Visible = false;
            this.colPK_WFRegistroDebitos.Width = 2;
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
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 383);
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
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dtgGastos);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colPK_WFRegistroDebitos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDespesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataDespesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
    }
}

