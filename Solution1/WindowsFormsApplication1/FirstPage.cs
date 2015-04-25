using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmFisrtPage : Form
    {
        public frmFisrtPage()
        {
            InitializeComponent();
            if (Program.idLogin == 0)
            {
                menuOpcoes.Visible = true;
                addMembros.Visible = true;
            }
            else
            {
                menuOpcoes.Visible = false;
                addMembros.Visible = false;
            }
        }

        private void listarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void frmFisrtPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            using (frmLogin frmLogin = new frmLogin())
            {
                frmLogin.ShowDialog();
            }
        }

        private void adicionarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmGeneral frm = new frmGeneral())
            {
                frm.ShowDialog();
            }
        }

        private void addMembros_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.edicao = true;
            using (frmGeneral generalPage = new frmGeneral())
            {
                generalPage.ShowDialog();
            }
        }

        private void listaMembros_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmLista frmlista = new frmLista())
            {
                frmlista.ShowDialog();
            }
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //teste commit
            this.Hide();
            Program.edicao = false;
            using (frmGeneral generalPage = new frmGeneral())
            {
                generalPage.ShowDialog();
            }
        }
    }
}
