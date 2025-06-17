namespace PacotesDeViagens
{
    partial class frmCadastroReserva
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
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDPacote = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudQuantidadePacote = new System.Windows.Forms.NumericUpDown();
            this.btnCadastrarReserva = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidadePacote)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblNomeCompleto.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblNomeCompleto.Location = new System.Drawing.Point(58, 23);
            this.lblNomeCompleto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(115, 16);
            this.lblNomeCompleto.TabIndex = 12;
            this.lblNomeCompleto.Text = "CPF DO CLIENTE";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(62, 41);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.MaxLength = 11;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(154, 20);
            this.txtNome.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(58, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "ID DO PACOTE";
            // 
            // txtIDPacote
            // 
            this.txtIDPacote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDPacote.Location = new System.Drawing.Point(62, 89);
            this.txtIDPacote.Name = "txtIDPacote";
            this.txtIDPacote.Size = new System.Drawing.Size(149, 20);
            this.txtIDPacote.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(58, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "QUANTIDADE";
            // 
            // nudQuantidadePacote
            // 
            this.nudQuantidadePacote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudQuantidadePacote.Location = new System.Drawing.Point(62, 133);
            this.nudQuantidadePacote.Name = "nudQuantidadePacote";
            this.nudQuantidadePacote.Size = new System.Drawing.Size(148, 20);
            this.nudQuantidadePacote.TabIndex = 18;
            // 
            // btnCadastrarReserva
            // 
            this.btnCadastrarReserva.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCadastrarReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnCadastrarReserva.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrarReserva.Location = new System.Drawing.Point(26, 173);
            this.btnCadastrarReserva.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastrarReserva.Name = "btnCadastrarReserva";
            this.btnCadastrarReserva.Size = new System.Drawing.Size(232, 27);
            this.btnCadastrarReserva.TabIndex = 21;
            this.btnCadastrarReserva.Text = "Cadastrar Reserva";
            this.btnCadastrarReserva.UseVisualStyleBackColor = false;
            this.btnCadastrarReserva.Click += new System.EventHandler(this.btnCadastrarReserva_Click);
            // 
            // frmCadastroReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 237);
            this.Controls.Add(this.btnCadastrarReserva);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudQuantidadePacote);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIDPacote);
            this.Controls.Add(this.lblNomeCompleto);
            this.Controls.Add(this.txtNome);
            this.Name = "frmCadastroReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroReserva";
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidadePacote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDPacote;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudQuantidadePacote;
        private System.Windows.Forms.Button btnCadastrarReserva;
    }
}