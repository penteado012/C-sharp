using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PacotesDeViagens
{
    public class Cliente
    {
        private string _cpf;
        private string _nome;
        private string _sexo;
        private string _logradouro;
        private string _cidade;
        private string _estado;
        private string _pais;
        private double _saldo;

        public string CPF
        {
            get { return _cpf; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !Regex.IsMatch(value, @"^\d{11}$"))
                {
                    throw new ArgumentException("CPF inválido. Deve conter exatamente 11 dígitos numéricos.");
                }
                _cpf = value;
            }
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentException("Nome inválido. Deve conter pelo menos 3 caracteres.");
                }
                _nome = value;
            }
        }

        public string Sexo
        {
            get { return _sexo; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || (value != "M" && value != "F" && value != "Outro"))
                {
                    throw new ArgumentException("Sexo inválido. Deve ser 'M', 'F' ou 'Outro'.");
                }
                _sexo = value;
            }
        }

        public string Logradouro
        {
            get { return _logradouro; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Logradouro não pode ser vazio ou nulo.");
                }
                _logradouro = value;
            }
        }

        public string Cidade
        {
            get { return _cidade; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Cidade não pode ser vazia ou nula.");
                }
                _cidade = value;
            }
        }

        public string Estado
        {
            get { return _estado; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length != 2)
                {
                    throw new ArgumentException("Estado inválido. Deve conter exatamente 2 caracteres (sigla).");
                }
                _estado = value.ToUpper();
            }
        }

        public string Pais
        {
            get { return _pais; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("País não pode ser vazio ou nulo.");
                }
                _pais = value;
            }
        }

        public double Saldo
        {
            get { return _saldo; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Saldo não pode ser negativo.");
                }
                _saldo = value;
            }
        }

        public Cliente(string CPF, string Nome, string Sexo, string Logradouro, string Cidade, string Estado, string Pais, double Saldo)
        {
            this.CPF = CPF;
            this.Nome = Nome;
            this.Sexo = Sexo;
            this.Logradouro = Logradouro;
            this.Cidade = Cidade;
            this.Estado = Estado;
            this.Pais = Pais;
            this.Saldo = Saldo;
        }

        public bool AdicionarSaldo(double valor)
        {
            if (valor <= 0)
            {
                return false;
            }
            _saldo += valor;
            return true;
        }

        public bool DescontarSaldo(double valor)
        {
            if (valor <= 0 || valor > _saldo)
            {
                return false;
            }
            _saldo -= valor;
            return true;
        }
    }
}
