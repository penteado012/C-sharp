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
    public partial class frmExibirPacote : Form
    {
        List<Pacote> pacotes;
        public frmExibirPacote(List<Pacote> pacotes)
        {
            InitializeComponent();
            this.pacotes = pacotes;

            foreach (Pacote pacote in pacotes)
            {
                ListViewItem item = new ListViewItem(pacote.ID.ToString());
                item.SubItems.Add(pacote.Data.ToString());
                item.SubItems.Add(pacote.QuantidadeDeNoites.ToString());
                item.SubItems.Add(pacote.Valor.ToString());
                item.SubItems.Add(pacote.QuantidadeDisponivel.ToString());
                item.SubItems.Add(pacote.Detalhes);
                lvwCadastroPacote.Items.Add(item);
            }
        }        
    }
}