using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacotesDeViagens
{
    public partial class frmCadastroReserva : Form
    {
        List<Reserva> reservas;
        List<Pacote> pacotes;
        List<Cliente> clientes;
        public frmCadastroReserva(List<Reserva> reservas, List<Pacote> pacotes, List<Cliente> clientes)
        {
            InitializeComponent();
            this.reservas = reservas;
            this.pacotes = pacotes;
            this.clientes = clientes;
        }

        private void btnCadastrarReserva_Click(object sender, EventArgs e)
        {
            try
            {
                // Captura o CPF do cliente
                string cpfCliente = txtNome.Text.Trim();

                // Validação para verificar se o CPF do cliente existe na lista de clientes
                var cliente = clientes.FirstOrDefault(c => c.CPF == cpfCliente);
                if (cliente == null)
                {
                    MessageBox.Show("Cliente não encontrado. Verifique o CPF.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Captura o ID do pacote
                int idPacote;
                if (!int.TryParse(txtIDPacote.Text, out idPacote))
                {
                    MessageBox.Show("ID do pacote inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Verifica se o pacote com o ID informado existe
                var pacote = pacotes.FirstOrDefault(p => p.ID == idPacote);
                if (pacote == null)
                {
                    MessageBox.Show("Pacote não encontrado. Verifique o ID do pacote.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Captura a quantidade de pacotes desejados
                int quantidadePacotes = (int)nudQuantidadePacote.Value;

                // Verifica se a quantidade de pacotes disponíveis é suficiente
                if (pacote.QuantidadeDisponivel < quantidadePacotes)
                {
                    MessageBox.Show("Não há pacotes suficientes disponíveis para esta reserva.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Cria uma lista de pacotes para a reserva (quantidade de pacotes desejados)
                List<Pacote> pacotesReserva = new List<Pacote>();
                for (int i = 0; i < quantidadePacotes; i++)
                {
                    pacotesReserva.Add(pacote);  // Adiciona o mesmo pacote para a quantidade desejada
                }

                // Criação da reserva
                int idReserva = reservas.Count > 0 ? reservas.Max(r => r.Id) + 1 : 1;  // Gerando um ID único para a reserva
                Reserva novaReserva = new Reserva(idReserva, "Pendente", pacotesReserva, cpfCliente)
                {
                    CpfCliente = cpfCliente
                };

                // Adiciona a reserva à lista
                reservas.Add(novaReserva);

                // Atualiza a quantidade de pacotes disponíveis no pacote original após a reserva
                pacote.QuantidadeDisponivel -= quantidadePacotes;  // Decrementa a quantidade disponível

                // Exibe mensagem de sucesso
                MessageBox.Show("Reserva cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpar os campos após o cadastro
                LimparCampos();
            }
            catch (Exception ex)
            {
                // Caso ocorra algum erro
                MessageBox.Show($"Erro ao cadastrar reserva: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void LimparCampos()
        {
            // Limpar os campos de texto
            txtNome.Clear();
            txtIDPacote.Clear();
            nudQuantidadePacote.Value = 1;
        }
    }    
}