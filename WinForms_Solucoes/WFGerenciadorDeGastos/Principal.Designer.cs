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
            this.dtgGastos = new System.Windows.Forms.DataGridView();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.colPK_GGDespesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDespesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dtgGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGastos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPK_GGDespesa,
            this.colDespesa,
            this.colDataDespesa,
            this.colValor});
            this.dtgGastos.Location = new System.Drawing.Point(12, 56);
            this.dtgGastos.MultiSelect = false;
            this.dtgGastos.Name = "dtgGastos";
            this.dtgGastos.RowHeadersVisible = false;
            this.dtgGastos.RowHeadersWidth = 51;
            this.dtgGastos.Size = new System.Drawing.Size(560, 293);
            this.dtgGastos.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Location = new System.Drawing.Point(12, 15);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(97, 23);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // colPK_GGDespesa
            // 
            this.colPK_GGDespesa.DataPropertyName = "PK_GGDespesa";
            this.colPK_GGDespesa.HeaderText = "PK_GGDespesa";
            this.colPK_GGDespesa.MinimumWidth = 2;
            this.colPK_GGDespesa.Name = "colPK_GGDespesa";
            this.colPK_GGDespesa.ReadOnly = true;
            this.colPK_GGDespesa.Visible = false;
            this.colPK_GGDespesa.Width = 2;
            // 
            // colDespesa
            // 
            this.colDespesa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDespesa.DataPropertyName = "Despesa";
            this.colDespesa.HeaderText = "Despesa";
            this.colDespesa.Name = "colDespesa";
            this.colDespesa.ReadOnly = true;
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
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dtgGastos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Principal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.dtgGastos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgGastos;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPK_GGDespesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDespesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataDespesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
    }
}

