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
            this.colIDArquivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeArquivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIcone = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnImagens = new System.Windows.Forms.Button();
            this.btnBaixar = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
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
            this.dtgArquivos.Location = new System.Drawing.Point(12, 56);
            this.dtgArquivos.MultiSelect = false;
            this.dtgArquivos.Name = "dtgArquivos";
            this.dtgArquivos.RowHeadersVisible = false;
            this.dtgArquivos.RowHeadersWidth = 51;
            this.dtgArquivos.Size = new System.Drawing.Size(560, 293);
            this.dtgArquivos.TabIndex = 0;
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
            // btnImagens
            // 
            this.btnImagens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImagens.Location = new System.Drawing.Point(440, 15);
            this.btnImagens.Name = "btnImagens";
            this.btnImagens.Size = new System.Drawing.Size(97, 23);
            this.btnImagens.TabIndex = 1;
            this.btnImagens.Text = "Pesquisar";
            this.btnImagens.UseVisualStyleBackColor = true;
            this.btnImagens.Click += new System.EventHandler(this.btnImagens_Click);
            // 
            // btnBaixar
            // 
            this.btnBaixar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaixar.Location = new System.Drawing.Point(548, 15);
            this.btnBaixar.Name = "btnBaixar";
            this.btnBaixar.Size = new System.Drawing.Size(24, 23);
            this.btnBaixar.TabIndex = 2;
            this.btnBaixar.UseVisualStyleBackColor = true;
            this.btnBaixar.Click += new System.EventHandler(this.btnBaixar_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuery.Location = new System.Drawing.Point(12, 16);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(413, 20);
            this.txtQuery.TabIndex = 3;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.btnBaixar);
            this.Controls.Add(this.btnImagens);
            this.Controls.Add(this.dtgArquivos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Principal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.dtgArquivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgArquivos;
        private System.Windows.Forms.Button btnImagens;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDArquivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeArquivo;
        private System.Windows.Forms.DataGridViewImageColumn colIcone;
        private System.Windows.Forms.Button btnBaixar;
        private System.Windows.Forms.TextBox txtQuery;
    }
}

