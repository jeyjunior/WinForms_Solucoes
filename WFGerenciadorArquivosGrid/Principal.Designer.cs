namespace WFGerenciadorArquivosGrid
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
            this.dtgArquivos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.colIDArquivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeArquivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIcone = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgArquivos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgArquivos
            // 
            this.dtgArquivos.AllowUserToAddRows = false;
            this.dtgArquivos.AllowUserToResizeColumns = false;
            this.dtgArquivos.AllowUserToResizeRows = false;
            this.dtgArquivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgArquivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDArquivo,
            this.colNomeArquivo,
            this.colIcone});
            this.dtgArquivos.Location = new System.Drawing.Point(12, 78);
            this.dtgArquivos.MultiSelect = false;
            this.dtgArquivos.Name = "dtgArquivos";
            this.dtgArquivos.RowHeadersVisible = false;
            this.dtgArquivos.RowHeadersWidth = 51;
            this.dtgArquivos.Size = new System.Drawing.Size(560, 271);
            this.dtgArquivos.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(485, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // colIDArquivo
            // 
            this.colIDArquivo.DataPropertyName = "IDArquivo";
            this.colIDArquivo.HeaderText = "IDArquivo";
            this.colIDArquivo.MinimumWidth = 2;
            this.colIDArquivo.Name = "colIDArquivo";
            this.colIDArquivo.ReadOnly = true;
            this.colIDArquivo.Visible = false;
            this.colIDArquivo.Width = 2;
            // 
            // colNomeArquivo
            // 
            this.colNomeArquivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNomeArquivo.DataPropertyName = "NomeArquivo";
            this.colNomeArquivo.HeaderText = "NomeArquivo";
            this.colNomeArquivo.Name = "colNomeArquivo";
            this.colNomeArquivo.ReadOnly = true;
            // 
            // colIcone
            // 
            this.colIcone.DataPropertyName = "Icone";
            this.colIcone.HeaderText = "";
            this.colIcone.MinimumWidth = 35;
            this.colIcone.Name = "colIcone";
            this.colIcone.ReadOnly = true;
            this.colIcone.Width = 35;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgArquivos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Principal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.dtgArquivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgArquivos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDArquivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeArquivo;
        private System.Windows.Forms.DataGridViewImageColumn colIcone;
    }
}

