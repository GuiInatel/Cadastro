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
    
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            List<Empresarios> listEmpresarios = new List<Empresarios>();

            DBConnecting dbconnect = new DBConnecting();
            dbconnect.Initialize();
            

            int Tamanho;
            int index;

            listEmpresarios = dbconnect.Select();
            Tamanho = listEmpresarios.Count();
            index = cmbLogin.SelectedIndex;

            for (int i = 0; i < Tamanho + 1; i++)
            {
                if (i<Tamanho)
                {
                    if (int.Parse(txtMat.Text)==listEmpresarios[i].codigo)
                    {
                        if (index==0)
                        {
                            if (true ==listEmpresarios[i].login)
                            {
                                Program.idCadastro = listEmpresarios[i].codigo;
                                Program.idLogin = index;
                                this.Hide();
                                using (frmFisrtPage frm = new frmFisrtPage())
                                {
                                    frm.ShowDialog();
                                }
                                break;
                            }
                        }
                        else
                        {
                            Program.idCadastro = listEmpresarios[i].codigo;
                            Program.idLogin = index;
                            this.Hide();
                            using (frmFisrtPage frm = new frmFisrtPage())
                            {
                                frm.ShowDialog();
                            }
                            break;
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Login Incorreto");
                }
            }
        }
    }
}