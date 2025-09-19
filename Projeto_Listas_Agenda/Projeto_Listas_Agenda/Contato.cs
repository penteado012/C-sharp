﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Listas_Agenda
{
    internal class Contato
    {
        private string email;
        private string nome;
        private Data dtNasc;
        private List<Telefone> telefones = new List<Telefone>();
        private Telefone telefone;

        public string Email { get => email; set => email = value; }
        public string Nome { get => nome; set => nome = value; }
        internal Data DtNasc { get => dtNasc; set => dtNasc = value; }
        internal List<Telefone> Telefones { get => telefones; set => telefones = value; }

        public Contato()
        {

        }

        public Contato(string Email, string Nome, Data DtNasc)
        {
            this.Email = Email;
            this.Nome = Nome;
            this.DtNasc = DtNasc;
        }

        public int getIdade()
        {
            DateTime hoje = DateTime.Today;
            int idade = hoje.Year - dtNasc.Ano;
            if (hoje.Month < dtNasc.Mes || (hoje.Month == dtNasc.Mes && hoje.Day < dtNasc.Dia))
            {
                idade--;
            }
            return idade;
        }

        public void adicionarTelefone(Telefone t)
        {
            Telefones.Add(t);
        }

        public string getTelefonePrincipal()
        {
            telefone = telefones.FirstOrDefault(t => t.Principal);

            if (telefone.Principal)
                return $"Numero do Telefone: {telefone.Numero}\n Tipo do telefone: {telefone.Tipo}";
            else
                return "Nenhum telefone principal cadastrado";
        }

        public override string ToString()
        {
            return $" Email: {email}\n Nome: {nome}\n Data de Nascimento: {DtNasc.ToString()}\n" +
                $" Idade: {getIdade()}\n {getTelefonePrincipal()}\n";
        }

        public override bool Equals(object obj)
        {
            if (obj == null && !(obj is Contato))
                return false;

            Contato outro = (Contato)obj;

            return this.Email.Equals(outro.Email, StringComparison.OrdinalIgnoreCase);
        }
        public override int GetHashCode()
        {
            return Email != null ? StringComparer.OrdinalIgnoreCase.GetHashCode(Email) : 0;
        }
    }
}
