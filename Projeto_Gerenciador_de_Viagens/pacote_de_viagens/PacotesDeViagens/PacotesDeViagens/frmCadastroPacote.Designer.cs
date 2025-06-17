namespace PacotesDeViagens
{
    partial class frmCadastroPacote
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
            this.dtpDataViagem = new System.Windows.Forms.DateTimePicker();
            this.lblDataViagem = new System.Windows.Forms.Label();
            this.nudQuantNoites = new System.Windows.Forms.NumericUpDown();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHospedagem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudQuantDisponivel = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudValorPacote = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataRegresso = new System.Windows.Forms.DateTimePicker();
            this.CadastrarPacote = new System.Windows.Forms.Button();
            this.rtxDetalhes = new System.Windows.Forms.RichTextBox();
            this.lblDetalhes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantNoites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantDisponivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorPacote)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDataViagem
            // 
            this.dtpDataViagem.CustomFormat = "AM";
            this.dtpDataViagem.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataViagem.Location = new System.Drawing.Point(12, 42);
            this.dtpDataViagem.Name = "dtpDataViagem";
            this.dtpDataViagem.Size = new System.Drawing.Size(150, 20);
            this.dtpDataViagem.TabIndex = 0;
            // 
            // lblDataViagem
            // 
            this.lblDataViagem.AutoSize = true;
            this.lblDataViagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblDataViagem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblDataViagem.Location = new System.Drawing.Point(9, 24);
            this.lblDataViagem.Name = "lblDataViagem";
            this.lblDataViagem.Size = new System.Drawing.Size(120, 16);
            this.lblDataViagem.TabIndex = 1;
            this.lblDataViagem.Text = "DATA DA VIAGEM";
            // 
            // nudQuantNoites
            // 
            this.nudQuantNoites.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudQuantNoites.Location = new System.Drawing.Point(15, 156);
            this.nudQuantNoites.Name = "nudQuantNoites";
            this.nudQuantNoites.Size = new System.Drawing.Size(148, 20);
            this.nudQuantNoites.TabIndex = 6;
            // 
            // txtDestino
            // 
            this.txtDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDestino.Location = new System.Drawing.Point(12, 98);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(149, 20);
            this.txtDestino.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(9, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "DESTINO";
            // 
            // txtHospedagem
            // 
            this.txtHospedagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHospedagem.Location = new System.Drawing.Point(187, 98);
            this.txtHospedagem.Name = "txtHospedagem";
            this.txtHospedagem.Size = new System.Drawing.Size(149, 20);
            this.txtHospedagem.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(184, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "HOSPEDAGEM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(12, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "QUANTIDADE DE NOITES";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(184, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "QUANTIDADE DISPONÍVEL";
            // 
            // nudQuantDisponivel
            // 
            this.nudQuantDisponivel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudQuantDisponivel.Location = new System.Drawing.Point(187, 156);
            this.nudQuantDisponivel.Name = "nudQuantDisponivel";
            this.nudQuantDisponivel.Size = new System.Drawing.Size(148, 20);
            this.nudQuantDisponivel.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(12, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "VALOR DO PACOTE";
            // 
            // nudValorPacote
            // 
            this.nudValorPacote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudValorPacote.Location = new System.Drawing.Point(12, 218);
            this.nudValorPacote.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudValorPacote.Name = "nudValorPacote";
            this.nudValorPacote.Size = new System.Drawing.Size(148, 20);
            this.nudValorPacote.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(184, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "DATA DE REGRESSO";
            // 
            // dtpDataRegresso
            // 
            this.dtpDataRegresso.CustomFormat = "AM";
            this.dtpDataRegresso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataRegresso.Location = new System.Drawing.Point(187, 42);
            this.dtpDataRegresso.Name = "dtpDataRegresso";
            this.dtpDataRegresso.Size = new System.Drawing.Size(150, 20);
            this.dtpDataRegresso.TabIndex = 20;
            // 
            // CadastrarPacote
            // 
            this.CadastrarPacote.BackColor = System.Drawing.Color.DodgerBlue;
            this.CadastrarPacote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CadastrarPacote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CadastrarPacote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.CadastrarPacote.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CadastrarPacote.Location = new System.Drawing.Point(68, 296);
            this.CadastrarPacote.Margin = new System.Windows.Forms.Padding(2);
            this.CadastrarPacote.Name = "CadastrarPacote";
            this.CadastrarPacote.Size = new System.Drawing.Size(232, 27);
            this.CadastrarPacote.TabIndex = 23;
            this.CadastrarPacote.Text = "Cadastrar";
            this.CadastrarPacote.UseVisualStyleBackColor = false;
            this.CadastrarPacote.Click += new System.EventHandler(this.CadastrarPacote_Click);
            // 
            // rtxDetalhes
            // 
            this.rtxDetalhes.Location = new System.Drawing.Point(187, 218);
            this.rtxDetalhes.Name = "rtxDetalhes";
            this.rtxDetalhes.Size = new System.Drawing.Size(150, 56);
            this.rtxDetalhes.TabIndex = 24;
            this.rtxDetalhes.Text = "";
            // 
            // lblDetalhes
            // 
            this.lblDetalhes.AutoSize = true;
            this.lblDetalhes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblDetalhes.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblDetalhes.Location = new System.Drawing.Point(184, 199);
            this.lblDetalhes.Name = "lblDetalhes";
            this.lblDetalhes.Size = new System.Drawing.Size(79, 16);
            this.lblDetalhes.TabIndex = 19;
            this.lblDetalhes.Text = "DETALHES";
            // 
            // frmCadastroPacote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 348);
            this.Controls.Add(this.rtxDetalhes);
            this.Controls.Add(this.CadastrarPacote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDataRegresso);
            this.Controls.Add(this.lblDetalhes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudValorPacote);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudQuantDisponivel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHospedagem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.nudQuantNoites);
            this.Controls.Add(this.lblDataViagem);
            this.Controls.Add(this.dtpDataViagem);
            this.Name = "frmCadastroPacote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pacote de Viagem";
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantNoites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantDisponivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorPacote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDataViagem;
        private System.Windows.Forms.Label lblDataViagem;
        private System.Windows.Forms.NumericUpDown nudQuantNoites;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHospedagem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudQuantDisponivel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudValorPacote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDataRegresso;
        private System.Windows.Forms.Button CadastrarPacote;
        private System.Windows.Forms.RichTextBox rtxDetalhes;
        private System.Windows.Forms.Label lblDetalhes;
    }
}