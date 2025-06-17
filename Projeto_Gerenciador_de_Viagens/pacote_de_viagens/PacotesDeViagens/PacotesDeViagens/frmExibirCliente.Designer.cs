namespace PacotesDeViagens
{
    partial class frmExibirCliente
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
            this.listViewClientes = new System.Windows.Forms.ListView();
            this.CpfColuna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomeColuna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SexoColuna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LograColuna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CidadeColuna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EstadoColuna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PaisColuna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SaldoColuna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewClientes
            // 
            this.listViewClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CpfColuna,
            this.NomeColuna,
            this.SexoColuna,
            this.LograColuna,
            this.CidadeColuna,
            this.EstadoColuna,
            this.PaisColuna,
            this.SaldoColuna});
            this.listViewClientes.HideSelection = false;
            this.listViewClientes.Location = new System.Drawing.Point(9, 14);
            this.listViewClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewClientes.MultiSelect = false;
            this.listViewClientes.Name = "listViewClientes";
            this.listViewClientes.Size = new System.Drawing.Size(729, 349);
            this.listViewClientes.TabIndex = 0;
            this.listViewClientes.UseCompatibleStateImageBehavior = false;
            this.listViewClientes.View = System.Windows.Forms.View.Details;
            // 
            // CpfColuna
            // 
            this.CpfColuna.Text = "CPF";
            this.CpfColuna.Width = 128;
            // 
            // NomeColuna
            // 
            this.NomeColuna.Text = "Nome";
            this.NomeColuna.Width = 101;
            // 
            // SexoColuna
            // 
            this.SexoColuna.Text = "Sexo";
            this.SexoColuna.Width = 76;
            // 
            // LograColuna
            // 
            this.LograColuna.Text = "Logradouro";
            this.LograColuna.Width = 87;
            // 
            // CidadeColuna
            // 
            this.CidadeColuna.Text = "Cidade";
            this.CidadeColuna.Width = 78;
            // 
            // EstadoColuna
            // 
            this.EstadoColuna.Text = "Estado";
            this.EstadoColuna.Width = 87;
            // 
            // PaisColuna
            // 
            this.PaisColuna.Text = "País";
            this.PaisColuna.Width = 78;
            // 
            // SaldoColuna
            // 
            this.SaldoColuna.Text = "Saldo";
            this.SaldoColuna.Width = 81;
            // 
            // frmExibirCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 377);
            this.Controls.Add(this.listViewClientes);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmExibirCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes Cadastrados";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewClientes;
        private System.Windows.Forms.ColumnHeader CpfColuna;
        private System.Windows.Forms.ColumnHeader NomeColuna;
        private System.Windows.Forms.ColumnHeader SexoColuna;
        private System.Windows.Forms.ColumnHeader LograColuna;
        private System.Windows.Forms.ColumnHeader CidadeColuna;
        private System.Windows.Forms.ColumnHeader EstadoColuna;
        private System.Windows.Forms.ColumnHeader PaisColuna;
        private System.Windows.Forms.ColumnHeader SaldoColuna;
    }
}