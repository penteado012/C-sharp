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
    public partial class frmCadastroPacote : Form
    {
        List<Pacote> pacotes;
        public frmCadastroPacote(List<Pacote> pacotes)
        {
            InitializeComponent();
            this.pacotes = pacotes;
            
        }

        private void CadastrarPacote_Click(object sender, EventArgs e)
        {
            try
            {
                // Recebendo valor da data da viagem do componente DateTimePicker
                DateTime dataviagem = dtpDataViagem.Value;

                // Validação para não permitir datas anteriores ao dia atual (a data de viagem deve ser a partir de hoje)
                if (dataviagem < DateTime.Now.Date)
                {
                    // Caso a data da viagem seja anterior ao dia atual, exibe uma mensagem de erro e retorna
                    MessageBox.Show("Por favor, selecione uma data a partir de hoje.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Recebendo valor da data do regresso
                DateTime dataregresso = dtpDataRegresso.Value;

                // Validação para não permitir datas anteriores à data de ida (ou seja, a data de regresso não pode ser anterior à data da viagem)
                if (dataregresso < dataviagem)
                {
                    // Caso a data de regresso seja anterior à data da viagem, exibe uma mensagem de erro e retorna
                    MessageBox.Show("A data de regresso não pode ser anterior ou igual à data de ida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validação para garantir que o campo 'Destino' não esteja vazio
                if (string.IsNullOrWhiteSpace(txtDestino.Text))
                {
                    // Caso o campo 'Destino' esteja vazio, exibe uma mensagem de erro e retorna
                    MessageBox.Show("O campo 'Destino' é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validação para garantir que o campo 'Destino' não exceda 50 caracteres
                else if (txtDestino.Text.Length > 50)
                {
                    // Caso o campo 'Destino' tenha mais de 50 caracteres, exibe uma mensagem de erro e retorna
                    MessageBox.Show("O destino não pode ter mais de 50 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validação para garantir que o campo 'Hospedagem' não esteja vazio
                if (string.IsNullOrWhiteSpace(txtHospedagem.Text))
                {
                    // Caso o campo 'Hospedagem' esteja vazio, exibe uma mensagem de erro e retorna
                    MessageBox.Show("O campo 'Hospedagem' é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validação para permitir apenas letras, números, espaços e alguns sinais de pontuação (acentos, til, etc.) no nome da hospedagem
                else if (!System.Text.RegularExpressions.Regex.IsMatch(txtHospedagem.Text, @"^[a-zA-Z0-9\sàáâãäåæçèéêëìíîïòóôõöøùúûüýÿ`'~]+$"))
                {
                    // Caso o nome da hospedagem contenha caracteres inválidos, exibe uma mensagem de erro e retorna
                    MessageBox.Show("O nome da hospedagem deve conter apenas letras, números, espaços e alguns sinais de pontuação (acentos, til, etc.).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validação para garantir que a quantidade de noites seja um número inteiro positivo
                if (nudQuantNoites.Value <= 0)
                {
                    // Caso a quantidade de noites seja menor ou igual a zero, exibe uma mensagem de erro e retorna
                    MessageBox.Show("A quantidade de noites deve ser um número inteiro positivo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validação para garantir que a quantidade de dias disponíveis seja um número positivo
                if (nudQuantDisponivel.Value <= 0)
                {
                    // Caso a quantidade de dias disponíveis seja menor ou igual a zero, exibe uma mensagem de erro e retorna
                    MessageBox.Show("A quantidade de dias disponíveis deve ser um número positivo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validação para garantir que o valor do pacote seja um número positivo
                if (nudValorPacote.Value <= 0)
                {
                    // Caso o valor do pacote seja menor ou igual a zero, exibe uma mensagem de erro e retorna
                    MessageBox.Show("O valor do pacote deve ser um número positivo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validação para garantir que o campo 'Detalhes' não esteja vazio
                if (string.IsNullOrWhiteSpace(rtxDetalhes.Text))
                {
                    // Caso o campo 'Detalhes' esteja vazio, exibe uma mensagem de erro e retorna
                    MessageBox.Show("O campo 'Detalhes' é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validação para garantir que o campo 'Detalhes' não exceda 500 caracteres
                else if (rtxDetalhes.Text.Length > 500)
                {
                    // Caso o campo 'Detalhes' tenha mais de 500 caracteres, exibe uma mensagem de erro e retorna
                    MessageBox.Show("O campo 'Detalhes' não pode exceder 500 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validação para garantir que o campo 'Detalhes' não contenha caracteres não permitidos
                else if (!System.Text.RegularExpressions.Regex.IsMatch(rtxDetalhes.Text, @"^[a-zA-Z0-9\sàáâãäåæçèéêëìíîïòóôõöøùúûüýÿ`'~]+$"))
                {
                    MessageBox.Show("O campo 'Detalhes' pode conter letras, números e espaços, além de acentos e caracteres especiais permitidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tentativa de criar o Pacote
                Pacote novoPacote = new Pacote(
                    dataviagem,
                    dataregresso,
                    nudQuantNoites.Value,
                    nudValorPacote.Value,
                    nudQuantDisponivel.Value,
                    rtxDetalhes.Text,
                    txtDestino.Text,
                    txtHospedagem.Text
                );

                // Adicionando à lista se válido
                pacotes.Add(novoPacote);

                // Exibindo mensagem de sucesso
                MessageBox.Show("Pacote cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpar campos após o cadastro
                LimparCampos();
            }
            catch (ArgumentException ex)
            {
                // Captura de validações da classe Cliente
                MessageBox.Show(ex.Message, "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (FormatException)
            {
                // Tratamento de erro ao converter valores numéricos
                MessageBox.Show("O campo Saldo deve conter um valor numérico válido.", "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // Captura de qualquer outro tipo de exceção
                MessageBox.Show($"Erro inesperado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para limpar os campos do formulário
        private void LimparCampos()
        {
            // Limpar os campos de texto
            txtDestino.Clear();
            txtHospedagem.Clear();
            rtxDetalhes.Clear();

            // Resetar os campos de data
            dtpDataViagem.Value = DateTime.Now;
            dtpDataRegresso.Value = DateTime.Now;

            // Resetar os controles NumericUpDown
            nudQuantNoites.Value = nudQuantNoites.Minimum;
            nudQuantDisponivel.Value = nudQuantDisponivel.Minimum;
            nudValorPacote.Value = nudValorPacote.Minimum;
        }
    }
}