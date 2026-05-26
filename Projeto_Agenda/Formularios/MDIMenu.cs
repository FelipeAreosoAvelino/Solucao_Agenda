using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Agenda.Formularios
{
    public partial class MDIMenu : Form
    {
        public MDIMenu()
        {
            InitializeComponent();
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadPessoas frmCadPessoas= new frmCadPessoas();
            frmCadPessoas.MdiParent = this;
            frmCadPessoas.Show();
        }

        private void consultarPessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaPessoas frmConsultaPessoas = new frmConsultaPessoas();
            frmConsultaPessoas.MdiParent = this;
            frmConsultaPessoas.Show();
        }
    }
}
