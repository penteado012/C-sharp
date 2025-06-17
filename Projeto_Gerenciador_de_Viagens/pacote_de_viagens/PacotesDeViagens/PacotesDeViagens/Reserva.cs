using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PacotesDeViagens
{
    public class Reserva
    {
        private int _id;
        private string _status;
        private List<Pacote> _pacotes;
        private string _cpfCliente;

        public int Id { get { return _id; } set { _id = value; } }
        public string Status { get { return _status; } set { _status = value; } }
        public List<Pacote> Pacotes { get { return _pacotes; } set { _pacotes = value; } }
        public string CpfCliente
        {
            get { return _cpfCliente; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !Regex.IsMatch(value, @"^\d{11}$"))
                {
                    throw new ArgumentException("CPF inválido. Deve conter exatamente 11 dígitos numéricos.");
                }
                _cpfCliente = value;
            }
        }

        public Reserva(int id, string status, List<Pacote> pacotes, string cpfCliente)
        {
            Id = id;
            Status = status;
            Pacotes = pacotes;
            CpfCliente = cpfCliente;
        }

        // Método para calcular o valor total da reserva
        public double CalcularValorTotal()
        {
            double valorTotal = 0;

            foreach (var pacote in Pacotes)
            {
                valorTotal += pacote.Valor;
            }

            return valorTotal;
        }

        // Método para confirmar a reserva
        public string ConfirmarReserva(List<Cliente> clientes)
        {
            // Localiza o cliente associado à reserva pelo CPF
            Cliente cliente = clientes.FirstOrDefault(c => c.CPF == this.CpfCliente);

            if (cliente == null)
            {
                return "Cliente associado à reserva não encontrado.";
            }

            // Calcula o valor total da reserva
            double valorTotalReserva = CalcularValorTotal();

            // Verifica se o cliente possui saldo suficiente
            if (cliente.Saldo < valorTotalReserva)
            {
                return "Saldo insuficiente para confirmar a reserva.";
            }

            // Deduz o valor da reserva do saldo do cliente
            cliente.Saldo -= valorTotalReserva;             
            // Atualiza o status da reserva para "Confirmada"
            this.Status = "Confirmada";

            return $"Reserva confirmada com sucesso!\nCliente: {cliente.Nome}\nSaldo atualizado: R$ {cliente.Saldo:F2}";
        }

        //Método para cancelar a reserva
        public string CancelarReserva(List<Cliente> clientes)
        {
            // Verifica se o status da reserva é "Pendente"
            if (this.Status != "Pendente")
            {
                return "Somente reservas com status 'Pendente' podem ser canceladas.";
            }

            // Localiza o cliente associado à reserva pelo CPF
            Cliente cliente = clientes.FirstOrDefault(c => c.CPF == this.CpfCliente);

            if (cliente == null)
            {
                return "Cliente associado à reserva não encontrado.";
            }

            // Atualiza o status da reserva para "Cancelada"
            this.Status = "Cancelada";

            return "Reserva cancelada com sucesso!";
        }

    }
}
