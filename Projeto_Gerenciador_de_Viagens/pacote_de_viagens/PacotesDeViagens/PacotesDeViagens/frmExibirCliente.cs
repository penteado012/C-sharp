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
    public partial class frmExibirCliente : Form
    {
        List<Cliente> clientes;
        public frmExibirCliente(List<Cliente> clientes)
        {
            InitializeComponent();
            this.clientes = clientes;

            foreach (Cliente cliente in clientes)
            {
                ListViewItem item = new ListViewItem(cliente.CPF);
                item.SubItems.Add(cliente.Nome);
                item.SubItems.Add(cliente.Sexo);
                item.SubItems.Add(cliente.Logradouro);
                item.SubItems.Add(cliente.Cidade);
                item.SubItems.Add(cliente.Estado);
                item.SubItems.Add(cliente.Pais);
                item.SubItems.Add(cliente.Saldo.ToString("N2"));

                // Adicionar o item ao ListView
                listViewClientes.Items.Add(item);

            }
        }

       
    }


    }
