namespace WFGerenciadorDeGastos.Telas
{
    partial class CadastrarDespesa
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblDespesa = new System.Windows.Forms.Label();
            this.colPK_GGTipoDespesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDespesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPK_GGTipoDespesa,
            this.colDespesa});
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(420, 151);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(384, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(48, 36);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(327, 12);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(48, 36);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(270, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(48, 36);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Location = new System.Drawing.Point(12, 25);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(240, 20);
            this.txtValor.TabIndex = 0;
            // 
            // lblDespesa
            // 
            this.lblDespesa.Location = new System.Drawing.Point(12, 9);
            this.lblDespesa.Name = "lblDespesa";
            this.lblDespesa.Size = new System.Drawing.Size(240, 13);
            this.lblDespesa.TabIndex = 10;
            this.lblDespesa.Text = "Despesa";
            this.lblDespesa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // colPK_GGTipoDespesa
            // 
            this.colPK_GGTipoDespesa.DataPropertyName = "GGTipoDespesa";
            this.colPK_GGTipoDespesa.HeaderText = "PK_GGTipoDespesa";
            this.colPK_GGTipoDespesa.Name = "colPK_GGTipoDespesa";
            this.colPK_GGTipoDespesa.Visible = false;
            // 
            // colDespesa
            // 
            this.colDespesa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDespesa.DataPropertyName = "Despesa";
            this.colDespesa.HeaderText = "Despesas";
            this.colDespesa.Name = "colDespesa";
            // 
            // CadastrarDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 217);
            this.Controls.Add(this.lblDespesa);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CadastrarDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastrarDespesa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblDespesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPK_GGTipoDespesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDespesa;
    }
}