namespace PacotesDeViagens
{
    partial class frmCadastroCliente
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.NumericSaldo = new System.Windows.Forms.NumericUpDown();
            this.CadastrarCliente = new System.Windows.Forms.Button();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.rbtnOutro = new System.Windows.Forms.RadioButton();
            this.maskCPF = new System.Windows.Forms.MaskedTextBox();
            this.cmbEstados = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSaldo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.Location = new System.Drawing.Point(54, 32);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(154, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(54, 132);
            this.txtLogradouro.Margin = new System.Windows.Forms.Padding(2);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(232, 20);
            this.txtLogradouro.TabIndex = 3;
            this.txtLogradouro.Text = "Rua";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(54, 183);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(2);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(154, 20);
            this.txtCidade.TabIndex = 4;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(54, 232);
            this.txtPais.Margin = new System.Windows.Forms.Padding(2);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(232, 20);
            this.txtPais.TabIndex = 6;
            // 
            // NumericSaldo
            // 
            this.NumericSaldo.Location = new System.Drawing.Point(54, 278);
            this.NumericSaldo.Margin = new System.Windows.Forms.Padding(2);
            this.NumericSaldo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumericSaldo.Name = "NumericSaldo";
            this.NumericSaldo.Size = new System.Drawing.Size(123, 20);
            this.NumericSaldo.TabIndex = 7;
            this.NumericSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TirarSimbolos);
            // 
            // CadastrarCliente
            // 
            this.CadastrarCliente.BackColor = System.Drawing.Color.DodgerBlue;
            this.CadastrarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CadastrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CadastrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.CadastrarCliente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CadastrarCliente.Location = new System.Drawing.Point(54, 320);
            this.CadastrarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.CadastrarCliente.Name = "CadastrarCliente";
            this.CadastrarCliente.Size = new System.Drawing.Size(232, 27);
            this.CadastrarCliente.TabIndex = 8;
            this.CadastrarCliente.Text = "Cadastrar";
            this.CadastrarCliente.UseVisualStyleBackColor = false;
            this.CadastrarCliente.Click += new System.EventHandler(this.CadastrarCliente_Click);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblCpf.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCpf.Location = new System.Drawing.Point(53, 64);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(33, 16);
            this.lblCpf.TabIndex = 9;
            this.lblCpf.Text = "CPF";
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblNomeCompleto.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblNomeCompleto.Location = new System.Drawing.Point(53, 14);
            this.lblNomeCompleto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(124, 16);
            this.lblNomeCompleto.TabIndex = 10;
            this.lblNomeCompleto.Text = "NOME COMPLETO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(228, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "SEXO";
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblLogradouro.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblLogradouro.Location = new System.Drawing.Point(51, 114);
            this.lblLogradouro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(103, 16);
            this.lblLogradouro.TabIndex = 12;
            this.lblLogradouro.Text = "LOGRADOURO";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblCidade.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCidade.Location = new System.Drawing.Point(52, 165);
            this.lblCidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(57, 16);
            this.lblCidade.TabIndex = 13;
            this.lblCidade.Text = "CIDADE";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblEstado.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblEstado.Location = new System.Drawing.Point(213, 165);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(63, 16);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "ESTADO";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblPais.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblPais.Location = new System.Drawing.Point(53, 214);
            this.lblPais.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(37, 16);
            this.lblPais.TabIndex = 15;
            this.lblPais.Text = "PAÍS";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblSaldo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSaldo.Location = new System.Drawing.Point(51, 263);
            this.lblSaldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(52, 16);
            this.lblSaldo.TabIndex = 16;
            this.lblSaldo.Text = "SALDO";
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(231, 36);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(34, 17);
            this.rbtnMasculino.TabIndex = 18;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "M";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Location = new System.Drawing.Point(231, 59);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(31, 17);
            this.rbtnFeminino.TabIndex = 19;
            this.rbtnFeminino.TabStop = true;
            this.rbtnFeminino.Text = "F";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // rbtnOutro
            // 
            this.rbtnOutro.AutoSize = true;
            this.rbtnOutro.Location = new System.Drawing.Point(231, 82);
            this.rbtnOutro.Name = "rbtnOutro";
            this.rbtnOutro.Size = new System.Drawing.Size(51, 17);
            this.rbtnOutro.TabIndex = 20;
            this.rbtnOutro.TabStop = true;
            this.rbtnOutro.Text = "Outro";
            this.rbtnOutro.UseVisualStyleBackColor = true;
            // 
            // maskCPF
            // 
            this.maskCPF.HidePromptOnLeave = true;
            this.maskCPF.Location = new System.Drawing.Point(55, 82);
            this.maskCPF.Margin = new System.Windows.Forms.Padding(2);
            this.maskCPF.Mask = "000,000,000-00";
            this.maskCPF.Name = "maskCPF";
            this.maskCPF.Size = new System.Drawing.Size(154, 20);
            this.maskCPF.TabIndex = 21;
            this.maskCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cmbEstados
            // 
            this.cmbEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstados.FormattingEnabled = true;
            this.cmbEstados.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cmbEstados.Location = new System.Drawing.Point(216, 183);
            this.cmbEstados.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEstados.Name = "cmbEstados";
            this.cmbEstados.Size = new System.Drawing.Size(71, 21);
            this.cmbEstados.TabIndex = 22;
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 367);
            this.Controls.Add(this.cmbEstados);
            this.Controls.Add(this.maskCPF);
            this.Controls.Add(this.rbtnOutro);
            this.Controls.Add(this.rbtnFeminino);
            this.Controls.Add(this.rbtnMasculino);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblLogradouro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNomeCompleto);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.CadastrarCliente);
            this.Controls.Add(this.NumericSaldo);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.txtNome);
            this.Name = "frmCadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.NumericSaldo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.NumericUpDown NumericSaldo;
        private System.Windows.Forms.Button CadastrarCliente;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.RadioButton rbtnOutro;
        private System.Windows.Forms.MaskedTextBox maskCPF;
        private System.Windows.Forms.ComboBox cmbEstados;
    }
}