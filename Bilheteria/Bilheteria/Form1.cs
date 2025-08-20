using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bilheteria
{
    public partial class Form1 : Form
    {
        const int fileiras = 15;
        const int poltronasPorFileira = 40;
        PictureBox[,] poltronas = new PictureBox[fileiras, poltronasPorFileira];
        bool[,] selecionadas = new bool[fileiras, poltronasPorFileira];

        Label lblFaturamento;
        Label lblSelecionadas;
        Button btnFaturamento;
        Button btnReservar;

        public Form1()
        {
            InitializeComponent();
            CriarMapaTeatro();
            CriarComponentesExtras();
        }

        private void CriarMapaTeatro()
        {
            int startX = 20;
            int startY = 20;
            int espacamentoX = 25;
            int espacamentoY = 25;

            for (int i = 0; i < fileiras; i++)
            {
                char letra = (char)('A' + fileiras - 1 - i); // de A embaixo a O em cima
                for (int j = 0; j < poltronasPorFileira; j++)
                {
                    int numero = poltronasPorFileira - j; // da direita pra esquerda

                    PictureBox pb = new PictureBox();
                    pb.Width = 20;
                    pb.Height = 20;
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Image = Properties.Resources.poltronaPreta; // vaga
                    pb.Location = new Point(startX + j * espacamentoX, startY + i * espacamentoY);

                    int preco = (i < 5) ? 50 : (i < 10) ? 30 : 15;
                    pb.Tag = new object[] { false, preco, $"{letra}{numero}" };

                    pb.Click += SelecionarPoltrona;

                    poltronas[i, j] = pb;
                    this.Controls.Add(pb);
                }
            }
        }

        private void CriarComponentesExtras()
        {
            lblFaturamento = new Label();
            lblFaturamento.Text = "Faturamento: R$ 0,00";
            lblFaturamento.Location = new Point(20, 450);
            lblFaturamento.AutoSize = true;
            this.Controls.Add(lblFaturamento);

            lblSelecionadas = new Label();
            lblSelecionadas.Text = "Selecionadas: ";
            lblSelecionadas.Location = new Point(20, 470);
            lblSelecionadas.AutoSize = true;
            this.Controls.Add(lblSelecionadas);

            btnFaturamento = new Button();
            btnFaturamento.Text = "Faturamento";
            btnFaturamento.Location = new Point(200, 445);
            btnFaturamento.Click += MostrarFaturamento;
            this.Controls.Add(btnFaturamento);

            btnReservar = new Button();
            btnReservar.Text = "Reservar";
            btnReservar.Location = new Point(300, 445);
            btnReservar.Click += ConfirmarReserva;
            this.Controls.Add(btnReservar);
        }

        private void SelecionarPoltrona(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            var dados = (object[])pb.Tag;

            bool ocupada = (bool)dados[0];
            string numeracao = (string)dados[2];

            if (ocupada) return; // não pode selecionar poltrona já reservada

            // encontrar índices i e j
            int i = -1, j = -1;
            for (int x = 0; x < fileiras; x++)
            {
                for (int y = 0; y < poltronasPorFileira; y++)
                {
                    if (poltronas[x, y] == pb)
                    {
                        i = x;
                        j = y;
                        break;
                    }
                }
                if (i != -1) break;
            }

            // alterna seleção
            selecionadas[i, j] = !selecionadas[i, j];
            pb.Image = selecionadas[i, j] ? Properties.Resources.poltronaVermelha : Properties.Resources.poltronaPreta;

            // Atualiza label
            string lista = "";
            for (int x = 0; x < fileiras; x++)
            {
                for (int y = 0; y < poltronasPorFileira; y++)
                {
                    if (selecionadas[x, y])
                    {
                        var tag = (object[])poltronas[x, y].Tag;
                        lista += (string)tag[2] + " ";
                    }
                }
            }
            lblSelecionadas.Text = "Selecionadas: " + lista;
        }

        private void ConfirmarReserva(object sender, EventArgs e)
        {
            if (lblSelecionadas.Text == "Selecionadas: ") return;

            var result = MessageBox.Show("Deseja realmente reservar as poltronas selecionadas?",
                                         "Confirmar Reserva",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < fileiras; i++)
                {
                    for (int j = 0; j < poltronasPorFileira; j++)
                    {
                        if (selecionadas[i, j])
                        {
                            var dados = (object[])poltronas[i, j].Tag;
                            int preco = (int)dados[1];
                            string numeracao = (string)dados[2];

                            poltronas[i, j].Tag = new object[] { true, preco, numeracao };
                            poltronas[i, j].Image = Properties.Resources.poltronaVermelha; // ocupada definitiva
                            selecionadas[i, j] = false;
                        }
                    }
                }
                lblSelecionadas.Text = "Selecionadas: ";
            }
        }

        private void MostrarFaturamento(object sender, EventArgs e)
        {
            int total = 0;
            int qtd = 0;

            for (int i = 0; i < fileiras; i++)
            {
                for (int j = 0; j < poltronasPorFileira; j++)
                {
                    var dados = (object[])poltronas[i, j].Tag;
                    bool ocupada = (bool)dados[0];
                    int preco = (int)dados[1];

                    if (ocupada)
                    {
                        qtd++;
                        total += preco;
                    }
                }
            }

            lblFaturamento.Text = $"Qtde ocupados: {qtd} | Valor: R$ {total},00";
        }
    }
}
