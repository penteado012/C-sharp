using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Filas_Atendimento
{
    public partial class Form1 : Form
    {
        Senhas senhas = new Senhas();
        Guiche guiche = new Guiche();
        Guiches guiches = new Guiches();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {            
            senhas.gerar();
            MessageBox.Show("Senha Gerada com Sucesso!");
        }

        private void btnListarSenha_Click(object sender, EventArgs e)
        {            
            lvListaSenha.Items.Clear();
            foreach (Senha s in senhas.FilaSenhas)
            {
                lvListaSenha.Items.Add(s.dadosParciais());
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int idGuiche = guiches.ListaGuiches.Count + 1;
            Guiche novoguichee = new Guiche(idGuiche);
            guiches.adicionar(novoguichee);
            lblNumeroQtdeGuiche.Text = guiches.ListaGuiches.Count.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // ignora o caractere
            }
        }

        private void btnChamar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtGuiche.Text, out int guicheDigitado))
            {
                MessageBox.Show("Digite um número válido para o guichê!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ( Convert.ToInt32(txtGuiche.Text) < 1 || Convert.ToInt32(txtGuiche.Text) > Convert.ToInt32(lblNumeroQtdeGuiche.Text))
            {
                MessageBox.Show("Digite um número válido para o guichê!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (guiche.chamar(senhas.FilaSenhas))
            {
                MessageBox.Show("Senha chamada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nenhuma senha disponível na fila!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnListarAtendimentos_Click(object sender, EventArgs e)
        {
            LvGuichesChamam.Items.Clear();
            foreach (Senha s in guiche.Atendimentos)
            {
                LvGuichesChamam.Items.Add(s.dadosCompletos());
            }
        }
    }
}
