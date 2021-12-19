namespace GlobalSQL
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.consultarButton = new System.Windows.Forms.Button();
            this.listaConsulta = new System.Windows.Forms.ListView();
            this.Processo = new System.Windows.Forms.ColumnHeader();
            this.Fornecedor = new System.Windows.Forms.ColumnHeader();
            this.Valor = new System.Windows.Forms.ColumnHeader();
            this.DataVencimento = new System.Windows.Forms.ColumnHeader();
            this.DataProrrogamento = new System.Windows.Forms.ColumnHeader();
            this.DataPagamento = new System.Windows.Forms.ColumnHeader();
            this.ContaPaga = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // consultarButton
            // 
            this.consultarButton.Location = new System.Drawing.Point(12, 12);
            this.consultarButton.Name = "consultarButton";
            this.consultarButton.Size = new System.Drawing.Size(116, 23);
            this.consultarButton.TabIndex = 0;
            this.consultarButton.Text = "Consultar";
            this.consultarButton.UseVisualStyleBackColor = true;
            this.consultarButton.Click += new System.EventHandler(this.consultarButton_Click);
            // 
            // listaConsulta
            // 
            this.listaConsulta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Processo,
            this.Fornecedor,
            this.Valor,
            this.DataVencimento,
            this.DataProrrogamento,
            this.DataPagamento,
            this.ContaPaga});
            this.listaConsulta.Location = new System.Drawing.Point(12, 41);
            this.listaConsulta.Name = "listaConsulta";
            this.listaConsulta.Size = new System.Drawing.Size(880, 358);
            this.listaConsulta.TabIndex = 1;
            this.listaConsulta.UseCompatibleStateImageBehavior = false;
            this.listaConsulta.View = System.Windows.Forms.View.Details;
            // 
            // Processo
            // 
            this.Processo.Text = "Processo";
            this.Processo.Width = 80;
            // 
            // Fornecedor
            // 
            this.Fornecedor.Text = "Fornecedor";
            this.Fornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Fornecedor.Width = 150;
            // 
            // Valor
            // 
            this.Valor.Text = "Valor";
            this.Valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Valor.Width = 150;
            // 
            // DataVencimento
            // 
            this.DataVencimento.Text = "Data Vencimento";
            this.DataVencimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataVencimento.Width = 130;
            // 
            // DataProrrogamento
            // 
            this.DataProrrogamento.Text = "Data Prorrogamento";
            this.DataProrrogamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataProrrogamento.Width = 130;
            // 
            // DataPagamento
            // 
            this.DataPagamento.Text = "Data Pagamento";
            this.DataPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataPagamento.Width = 130;
            // 
            // ContaPaga
            // 
            this.ContaPaga.Text = "Conta Paga";
            this.ContaPaga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ContaPaga.Width = 100;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 411);
            this.Controls.Add(this.listaConsulta);
            this.Controls.Add(this.consultarButton);
            this.MaximumSize = new System.Drawing.Size(920, 450);
            this.MinimumSize = new System.Drawing.Size(920, 450);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button consultarButton;
        private ListView listaConsulta;
        private ColumnHeader Processo;
        private ColumnHeader Fornecedor;
        private ColumnHeader Valor;
        private ColumnHeader DataVencimento;
        private ColumnHeader DataProrrogamento;
        private ColumnHeader DataPagamento;
        private ColumnHeader ContaPaga;
    }
}