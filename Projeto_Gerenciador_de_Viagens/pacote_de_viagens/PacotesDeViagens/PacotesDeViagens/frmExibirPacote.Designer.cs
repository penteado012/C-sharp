namespace PacotesDeViagens
{
    partial class frmExibirPacote
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
            this.lvwCadastroPacote = new System.Windows.Forms.ListView();
            this.IdColuna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataColuna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NoitesDisponiveis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValorColuna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DisponibilidadeColuna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DetalhesColuna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvwCadastroPacote
            // 
            this.lvwCadastroPacote.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdColuna,
            this.DataColuna,
            this.NoitesDisponiveis,
            this.ValorColuna,
            this.DisponibilidadeColuna,
            this.DetalhesColuna});
            this.lvwCadastroPacote.HideSelection = false;
            this.lvwCadastroPacote.LabelWrap = false;
            this.lvwCadastroPacote.Location = new System.Drawing.Point(24, 35);
            this.lvwCadastroPacote.Margin = new System.Windows.Forms.Padding(2);
            this.lvwCadastroPacote.MultiSelect = false;
            this.lvwCadastroPacote.Name = "lvwCadastroPacote";
            this.lvwCadastroPacote.Size = new System.Drawing.Size(401, 185);
            this.lvwCadastroPacote.TabIndex = 0;
            this.lvwCadastroPacote.UseCompatibleStateImageBehavior = false;
            this.lvwCadastroPacote.View = System.Windows.Forms.View.Details;
            // 
            // IdColuna
            // 
            this.IdColuna.Text = "ID";
            this.IdColuna.Width = 35;
            // 
            // DataColuna
            // 
            this.DataColuna.Text = "Data";
            this.DataColuna.Width = 47;
            // 
            // NoitesDisponiveis
            // 
            this.NoitesDisponiveis.Text = "Noites";
            // 
            // ValorColuna
            // 
            this.ValorColuna.Text = "Valor";
            // 
            // DisponibilidadeColuna
            // 
            this.DisponibilidadeColuna.Text = "Disponibilidade";
            this.DisponibilidadeColuna.Width = 112;
            // 
            // DetalhesColuna
            // 
            this.DetalhesColuna.Text = "Detalhes";
            this.DetalhesColuna.Width = 81;
            // 
            // frmExibirPacote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 264);
            this.Controls.Add(this.lvwCadastroPacote);
            this.Name = "frmExibirPacote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExibirPacote";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwCadastroPacote;
        private System.Windows.Forms.ColumnHeader IdColuna;
        private System.Windows.Forms.ColumnHeader DataColuna;
        private System.Windows.Forms.ColumnHeader NoitesDisponiveis;
        private System.Windows.Forms.ColumnHeader ValorColuna;
        private System.Windows.Forms.ColumnHeader DisponibilidadeColuna;
        private System.Windows.Forms.ColumnHeader DetalhesColuna;
    }
}