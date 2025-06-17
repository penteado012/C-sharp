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
{//testando git 22/12/
    public partial class frmPrincipal : Form
    {
        // FORMULÁRIOS DE CADASTRO
        frmCadastroPacote FrmCadastroPacoteObj;
        List<Pacote> pacotes = new List<Pacote>();

        frmCadastroCliente FrmCadastroClienteObj;
        List<Cliente> clientes = new List<Cliente>();

        frmCadastroReserva FrmCadastroReservaObj;
        List<Reserva> reservas = new List<Reserva>();

        // FORMULÁRIOS DE EXIBIÇÃO
        frmExibirPacote FrmExibirPacoteObj;
        frmExibirCliente FrmExibirClienteObj;
        frmExibirReserva FrmExibirReservaObj;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        // FORMULÁRIOS DE CADASTRO

        private void pacoteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (FrmCadastroPacoteObj == null || FrmCadastroPacoteObj.IsDisposed)
            {
                FrmCadastroPacoteObj = new frmCadastroPacote(pacotes);
                FrmCadastroPacoteObj.MdiParent = this;
                FrmCadastroPacoteObj.Show();
            }
            else
            {
                FrmCadastroPacoteObj.Activate();
            }
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (FrmCadastroClienteObj == null || FrmCadastroClienteObj.IsDisposed)
            {
                FrmCadastroClienteObj = new frmCadastroCliente(clientes);
                FrmCadastroClienteObj.MdiParent = this;
                FrmCadastroClienteObj.Show();
            }
            else
            {
                FrmCadastroClienteObj.Activate();
            }
        }

        private void reservaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (FrmCadastroReservaObj == null || FrmCadastroReservaObj.IsDisposed)
            {
                FrmCadastroReservaObj = new frmCadastroReserva(reservas, pacotes, clientes);
                FrmCadastroReservaObj.MdiParent = this;
                FrmCadastroReservaObj.Show();
            }
            else
            {
                FrmCadastroReservaObj.Activate();
            }
        }

        // FORMULÁRIOS DE EXIBIÇÃO

        private void pacoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmExibirPacoteObj == null || FrmExibirPacoteObj.IsDisposed)
            {
                FrmExibirPacoteObj = new frmExibirPacote(pacotes);
                FrmExibirPacoteObj.MdiParent = this;
                FrmExibirPacoteObj.Show();
            }
            else
            {
                FrmExibirPacoteObj.Activate();
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmExibirClienteObj == null || FrmExibirClienteObj.IsDisposed)
            {
                FrmExibirClienteObj = new frmExibirCliente(clientes);
                FrmExibirClienteObj.MdiParent = this;
                FrmExibirClienteObj.Show();
            }
            else
            {
                FrmExibirClienteObj.Activate();
            }
        }

        private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmExibirReservaObj == null || FrmExibirReservaObj.IsDisposed)
            {
                FrmExibirReservaObj = new frmExibirReserva(reservas, clientes, pacotes);
                FrmExibirReservaObj.MdiParent = this;
                FrmExibirReservaObj.Show();
            }
            else
            {
                FrmExibirReservaObj.Activate();
            }
        }
    }
}