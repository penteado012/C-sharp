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
    public partial class frmCadastroCliente : Form
    {
        List<Cliente> clientes;

        public frmCadastroCliente(List<Cliente> clientes)
        {
            InitializeComponent();
            this.clientes = clientes;
        }

        private void CadastrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                // Captura o CPF digitado
                string cpf = maskCPF.Text;

                // Remove os caracteres da máscara (pontos e traço)
                cpf = cpf.Replace(".", "").Replace("-", "");

                // Valida se o CPF está completamente preenchido
                if (cpf.Length != 11 || !long.TryParse(cpf, out _))
                {
                    throw new Exception("Por favor, preencha o CPF corretamente (11 números, formato 000.000.000-00).");
                }

                // Verifica se todos os dígitos do CPF são iguais
                if (new string(cpf[0], cpf.Length) == cpf)
                {
                    throw new Exception("CPF inválido! Todos os números não podem ser iguais.");
                }

                // Cálculo do primeiro dígito verificador
                int soma = 0;
                for (int i = 0; i < 9; i++)
                    soma += (cpf[i] - '0') * (10 - i);

                int resto = soma % 11;
                int digito1 = resto < 2 ? 0 : 11 - resto;

                // Cálculo do segundo dígito verificador
                soma = 0;
                for (int i = 0; i < 10; i++)
                    soma += (cpf[i] - '0') * (11 - i);

                resto = soma % 11;
                int digito2 = resto < 2 ? 0 : 11 - resto;

                // Verifica se os dígitos calculados conferem
                if (cpf[9] - '0' != digito1 || cpf[10] - '0' != digito2)
                {
                    throw new Exception("CPF inválido! Verifique os números informados.");
                }

                // Valida o nome (deve conter pelo menos dois nomes)
                string nome = txtNome.Text.Trim();
                int espacos = nome.Split(' ').Length - 1;

                if (espacos < 1) // Se houver menos de um sobrenome
                {
                    throw new Exception("Por favor, insira o nome completo (nome e sobrenome).");
                }

                // testa se logradouro é valido, necessário add o fixo "rua" e complemento 
                string logradouro = txtLogradouro.Text.Trim();
                int space = logradouro.Split(' ').Length - 1;
                if (space < 1)
                {
                    throw new Exception("Por favor, insira um logradouro valido!");
                }
                if (logradouro.Length < 4)
                {
                    throw new Exception("Insira um logradouro que tenha pelo menos 5 caracteres!");
                }

                // Obtendo o valor do campo "Sexo" com base nos RadioButtons
                string sexo = ObterSexoSelecionado();

                if (string.IsNullOrEmpty(sexo))
                {
                    MessageBox.Show("Por favor, selecione uma opção para o campo 'Sexo'.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tentativa de criar o cliente
                Cliente novoCliente = new Cliente(
                    maskCPF.Text,
                    txtNome.Text,
                    sexo,
                    txtLogradouro.Text,
                    txtCidade.Text,
                    cmbEstados.Text,
                    txtPais.Text,
                    Convert.ToDouble(NumericSaldo.Value)
                );

                // Adicionando à lista se válido
                clientes.Add(novoCliente);

                // Exibindo mensagem de sucesso
                MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        // Método para limpar os campos após cadastro
        private void LimparCampos()
        {
            maskCPF.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtLogradouro.Text = string.Empty;
            txtCidade.Text = string.Empty;
            cmbEstados.Text = string.Empty;
            txtPais.Text = string.Empty;
            NumericSaldo.Value = 0;

            // Resetando os RadioButtons
            rbtnMasculino.Checked = false;
            rbtnFeminino.Checked = false;
            rbtnOutro.Checked = false;
        }

        // Método para obter o sexo selecionado pelos RadioButtons
        private string ObterSexoSelecionado()
        {
            if (rbtnMasculino.Checked)
            {
                return "M";
            }
            else if (rbtnFeminino.Checked)
            {
                return "F";
            }
            else if (rbtnOutro.Checked)
            {
                return "Outro";
            }
            return null;
        }

        private void TirarSimbolos(object sender, KeyPressEventArgs e)
        {
            //Validação para permitir apenas números e backspace:
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                // Cancela a tecla pressionada
                e.Handled = true;
            }
        }

        //Validação para que não seja possível digitar um número no nome
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada é um número (0-9)
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Impede que o número seja digitado
            }
        }
    }
}