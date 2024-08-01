namespace WFGerenciadorDeGastos.Telas
{
    partial class RegistroDespesas
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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.dtpDataDespesa = new System.Windows.Forms.DateTimePicker();
            this.cboDespesa = new System.Windows.Forms.ComboBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblDataDespesa = new System.Windows.Forms.Label();
            this.lblDespesa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Location = new System.Drawing.Point(634, 14);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(77, 40);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtValor
            // 
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Location = new System.Drawing.Point(434, 31);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(181, 20);
            this.txtValor.TabIndex = 3;
            // 
            // dtpDataDespesa
            // 
            this.dtpDataDespesa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDespesa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpDataDespesa.Location = new System.Drawing.Point(310, 31);
            this.dtpDataDespesa.Name = "dtpDataDespesa";
            this.dtpDataDespesa.Size = new System.Drawing.Size(110, 20);
            this.dtpDataDespesa.TabIndex = 2;
            // 
            // cboDespesa
            // 
            this.cboDespesa.FormattingEnabled = true;
            this.cboDespesa.Location = new System.Drawing.Point(12, 30);
            this.cboDespesa.Name = "cboDespesa";
            this.cboDespesa.Size = new System.Drawing.Size(232, 21);
            this.cboDespesa.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Location = new System.Drawing.Point(250, 30);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(35, 21);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "+";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblDataDespesa
            // 
            this.lblDataDespesa.Location = new System.Drawing.Point(310, 14);
            this.lblDataDespesa.Name = "lblDataDespesa";
            this.lblDataDespesa.Size = new System.Drawing.Size(110, 13);
            this.lblDataDespesa.TabIndex = 4;
            this.lblDataDespesa.Text = "Data Despesa";
            this.lblDataDespesa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDespesa
            // 
            this.lblDespesa.Location = new System.Drawing.Point(12, 14);
            this.lblDespesa.Name = "lblDespesa";
            this.lblDespesa.Size = new System.Drawing.Size(232, 13);
            this.lblDespesa.TabIndex = 9;
            this.lblDespesa.Text = "Despesa";
            this.lblDespesa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(434, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Valor";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RegistroDespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 66);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDespesa);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.cboDespesa);
            this.Controls.Add(this.dtpDataDespesa);
            this.Controls.Add(this.lblDataDespesa);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnRegistrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistroDespesas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Despesa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.DateTimePicker dtpDataDespesa;
        private System.Windows.Forms.ComboBox cboDespesa;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblDataDespesa;
        private System.Windows.Forms.Label lblDespesa;
        private System.Windows.Forms.Label label2;
    }
}