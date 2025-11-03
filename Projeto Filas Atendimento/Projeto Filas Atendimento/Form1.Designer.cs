namespace Projeto_Filas_Atendimento
{
    partial class Form1
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
            this.btnGerarSenha = new System.Windows.Forms.Button();
            this.lvListaSenha = new System.Windows.Forms.ListView();
            this.btnListarSenha = new System.Windows.Forms.Button();
            this.lblQtdeGuiche = new System.Windows.Forms.Label();
            this.lblNumeroQtdeGuiche = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblNomeGuichê = new System.Windows.Forms.Label();
            this.txtGuiche = new System.Windows.Forms.TextBox();
            this.btnChamar = new System.Windows.Forms.Button();
            this.LvGuichesChamam = new System.Windows.Forms.ListView();
            this.btnListarAtendimentos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGerarSenha
            // 
            this.btnGerarSenha.Location = new System.Drawing.Point(80, 37);
            this.btnGerarSenha.Name = "btnGerarSenha";
            this.btnGerarSenha.Size = new System.Drawing.Size(75, 23);
            this.btnGerarSenha.TabIndex = 0;
            this.btnGerarSenha.Text = "Gerar";
            this.btnGerarSenha.UseVisualStyleBackColor = true;
            this.btnGerarSenha.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lvListaSenha
            // 
            this.lvListaSenha.HideSelection = false;
            this.lvListaSenha.Location = new System.Drawing.Point(13, 66);
            this.lvListaSenha.Name = "lvListaSenha";
            this.lvListaSenha.Size = new System.Drawing.Size(211, 193);
            this.lvListaSenha.TabIndex = 1;
            this.lvListaSenha.UseCompatibleStateImageBehavior = false;
            this.lvListaSenha.View = System.Windows.Forms.View.List;
            // 
            // btnListarSenha
            // 
            this.btnListarSenha.Location = new System.Drawing.Point(52, 265);
            this.btnListarSenha.Name = "btnListarSenha";
            this.btnListarSenha.Size = new System.Drawing.Size(137, 27);
            this.btnListarSenha.TabIndex = 0;
            this.btnListarSenha.Text = "Listar Senhas";
            this.btnListarSenha.UseVisualStyleBackColor = true;
            this.btnListarSenha.Click += new System.EventHandler(this.btnListarSenha_Click);
            // 
            // lblQtdeGuiche
            // 
            this.lblQtdeGuiche.AutoSize = true;
            this.lblQtdeGuiche.Location = new System.Drawing.Point(267, 127);
            this.lblQtdeGuiche.Name = "lblQtdeGuiche";
            this.lblQtdeGuiche.Size = new System.Drawing.Size(70, 13);
            this.lblQtdeGuiche.TabIndex = 2;
            this.lblQtdeGuiche.Text = "Qtde guichês";
            // 
            // lblNumeroQtdeGuiche
            // 
            this.lblNumeroQtdeGuiche.AutoSize = true;
            this.lblNumeroQtdeGuiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroQtdeGuiche.Location = new System.Drawing.Point(285, 153);
            this.lblNumeroQtdeGuiche.Name = "lblNumeroQtdeGuiche";
            this.lblNumeroQtdeGuiche.Size = new System.Drawing.Size(29, 31);
            this.lblNumeroQtdeGuiche.TabIndex = 2;
            this.lblNumeroQtdeGuiche.Text = "0";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(258, 187);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(89, 26);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblNomeGuichê
            // 
            this.lblNomeGuichê.AutoSize = true;
            this.lblNomeGuichê.Location = new System.Drawing.Point(390, 47);
            this.lblNomeGuichê.Name = "lblNomeGuichê";
            this.lblNomeGuichê.Size = new System.Drawing.Size(44, 13);
            this.lblNomeGuichê.TabIndex = 2;
            this.lblNomeGuichê.Text = "Guichê:";
            // 
            // txtGuiche
            // 
            this.txtGuiche.Location = new System.Drawing.Point(440, 44);
            this.txtGuiche.MaxLength = 2;
            this.txtGuiche.Name = "txtGuiche";
            this.txtGuiche.Size = new System.Drawing.Size(51, 20);
            this.txtGuiche.TabIndex = 3;
            this.txtGuiche.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnChamar
            // 
            this.btnChamar.Location = new System.Drawing.Point(517, 39);
            this.btnChamar.Name = "btnChamar";
            this.btnChamar.Size = new System.Drawing.Size(87, 29);
            this.btnChamar.TabIndex = 0;
            this.btnChamar.Text = "Chamar";
            this.btnChamar.UseVisualStyleBackColor = true;
            this.btnChamar.Click += new System.EventHandler(this.btnChamar_Click);
            // 
            // LvGuichesChamam
            // 
            this.LvGuichesChamam.HideSelection = false;
            this.LvGuichesChamam.Location = new System.Drawing.Point(379, 74);
            this.LvGuichesChamam.Name = "LvGuichesChamam";
            this.LvGuichesChamam.Size = new System.Drawing.Size(300, 166);
            this.LvGuichesChamam.TabIndex = 1;
            this.LvGuichesChamam.UseCompatibleStateImageBehavior = false;
            this.LvGuichesChamam.View = System.Windows.Forms.View.List;
            // 
            // btnListarAtendimentos
            // 
            this.btnListarAtendimentos.Location = new System.Drawing.Point(440, 246);
            this.btnListarAtendimentos.Name = "btnListarAtendimentos";
            this.btnListarAtendimentos.Size = new System.Drawing.Size(191, 27);
            this.btnListarAtendimentos.TabIndex = 0;
            this.btnListarAtendimentos.Text = "Listar Atendimentos";
            this.btnListarAtendimentos.UseVisualStyleBackColor = true;
            this.btnListarAtendimentos.Click += new System.EventHandler(this.btnListarAtendimentos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 330);
            this.Controls.Add(this.txtGuiche);
            this.Controls.Add(this.lblNumeroQtdeGuiche);
            this.Controls.Add(this.lblNomeGuichê);
            this.Controls.Add(this.lblQtdeGuiche);
            this.Controls.Add(this.LvGuichesChamam);
            this.Controls.Add(this.lvListaSenha);
            this.Controls.Add(this.btnChamar);
            this.Controls.Add(this.btnListarAtendimentos);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnListarSenha);
            this.Controls.Add(this.btnGerarSenha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerarSenha;
        private System.Windows.Forms.ListView lvListaSenha;
        private System.Windows.Forms.Button btnListarSenha;
        private System.Windows.Forms.Label lblQtdeGuiche;
        private System.Windows.Forms.Label lblNumeroQtdeGuiche;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblNomeGuichê;
        private System.Windows.Forms.TextBox txtGuiche;
        private System.Windows.Forms.Button btnChamar;
        private System.Windows.Forms.ListView LvGuichesChamam;
        private System.Windows.Forms.Button btnListarAtendimentos;
    }
}