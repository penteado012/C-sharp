using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacotesDeViagens
{
    public class Pacote
    {
        private int _id;
        private DateTime _data;
        private DateTime _regresso;
        private int _quantidadeDeNoites;
        private double _valor;
        private int _quantidadeDisponivel;
        private string _detalhes;
        private string _destino;
        private string _hospedagem;
        private static int ultimoId = 0;

        
        public int ID
        {
            get { return _id; }
            private set { _id = value; } 
        }


        // Variável que busca a data atual do computador do usuário
        DateTime DataAtual = DateTime.Now.Date;
        
        public DateTime Data
        {
            get { return _data; }
            set
            {
                if (value < DataAtual)
                {
                    throw new ArgumentException("Data inválida! Selecione uma data posterior ou igual à data de hoje.");
                }
                _data = value;
            }
        }

        public DateTime DataRegresso
        {
            get { return _regresso; }
            set
            {
                if (value < DataAtual)
                {
                    throw new ArgumentException("Data inválida! Selecione uma data posterior ou igual à data de hoje.");
                }
                _regresso = value;
            }
        }

        public int QuantidadeDeNoites
        {
            get { return _quantidadeDeNoites; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Dados Inválidos! Insira a quantidade de noites do pacote.");
                }
                _quantidadeDeNoites = value;
            }
        }
        public double Valor
        {
            get { return _valor; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Valor Inválido! Insira um valor positivo.");
                }
                _valor = value;
            }
        }
        public int QuantidadeDisponivel
        {
            get { return _quantidadeDisponivel; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Dados Inválidos! Digite um número positivo.");
                }
                _quantidadeDisponivel = value;
            }
        }

        // Propriedade Detalhes
        public string Detalhes
        {
            get { return _detalhes; }
            set
            {
                // Verifica se o campo Detalhes está vazio ou contém apenas espaços
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O campo 'Detalhes' é obrigatório.");
                }
                // Verifica se o campo Detalhes contém mais de 500 caracteres
                if (value.Length > 500)
                {
                    throw new ArgumentException("O campo 'Detalhes' não pode exceder 500 caracteres.");
                }
                _detalhes = value;
            }
        }

        // Propriedade Destino
        public string Destino
        {
            get { return _destino; }
            set
            {
                // Verifica se o campo Destino está vazio ou contém apenas espaços
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O campo 'Destino' é obrigatório.");
                }
                // Verifica se o campo Destino tem mais de 50 caracteres
                if (value.Length > 50)
                {
                    throw new ArgumentException("O destino não pode ter mais de 50 caracteres.");
                }
                _destino = value;
            }
        }

        // Propriedade Hospedagem
        public string Hospedagem
        {
            get { return _hospedagem; }
            set
            {
                // Verifica se o campo Hospedagem está vazio ou contém apenas espaços
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O campo 'Hospedagem' é obrigatório.");
                }
                // Verifica se o nome da Hospedagem contém caracteres válidos (letras, números, acentos, etc.)
                if (!System.Text.RegularExpressions.Regex.IsMatch(value, @"^[a-zA-Z0-9\sàáâãäåæçèéêëìíîïòóôõöøùúûüýÿ`'~]+$"))
                {
                    throw new ArgumentException("O nome da hospedagem deve conter apenas letras, números, espaços e alguns sinais de pontuação (acentos, til, etc.).");
                }
                _hospedagem = value;
            }
        }


        //Construtor para receber Cadastro Pacote
        public Pacote(DateTime Data, DateTime Regresso, Decimal QuantidadedeNoites, Decimal Valor, Decimal QuantidadeDisponivel, string Detalhes, string Destino, string Hospedagem)
        {
            ID = ++ultimoId;
            this.Data = Data;
            this.DataRegresso = Regresso;
            this.QuantidadeDeNoites = Convert.ToInt16(QuantidadedeNoites);
            this.Valor = Convert.ToInt16(Valor);
            this.QuantidadeDisponivel = Convert.ToInt16(QuantidadeDisponivel);
            this.Detalhes = Detalhes;
            this.Destino = Destino;
            this.Hospedagem = Hospedagem;
        }
    }
}
