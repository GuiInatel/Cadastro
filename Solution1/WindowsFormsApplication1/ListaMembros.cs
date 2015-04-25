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
    public partial class frmLista : Form
    {
        public frmLista()
        {
            InitializeComponent();
            grpFiltro.Enabled = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtMat.Clear();
            cmbNucleo.ResetText();
            checkInativo.Checked = false;
        }

        private void closeFrm(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            using (frmFisrtPage frm = new frmFisrtPage())
            {
                frm.ShowDialog();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            List<Empresarios> listEmpresarios = new List<Empresarios>();
            List<Empresarios> empresarios = new List<Empresarios>();
            Empresarios emp = new Empresarios();
            List<Lista> listLista = new List<Lista>();
            //Conectando com o banco de dados
            DBConnecting dbconnect = new DBConnecting();
            dbconnect.Initialize();

            listEmpresarios = dbconnect.Select();

            if (grpFiltro.Enabled == true)
            {
                if (txtMat.Text != "")
                {
                    for (int i = 0; i < listEmpresarios.Count; i++)
                    {
                        if (listEmpresarios[i].codigo == int.Parse(txtMat.Text))
                        {
                            empresarios.Add(dbconnect.SelectId(listEmpresarios[i].id));
                            break;
                        }
                    }

                    if (empresarios[0].ativo == true)
                    {
                        listLista.Add(new Lista() { name = empresarios[0].nome, cod = empresarios[0].codigo, nucleo = empresarios[0].setor, ativo = "Ativo" });
                    }
                    else
                    {
                        listLista.Add(new Lista() { name = empresarios[0].nome, cod = empresarios[0].codigo, nucleo = empresarios[0].setor, ativo = "Inativo" });
                    }
                    grvDados.DataSource = listLista;
                    grvDados.Refresh();
                }
                else if(txtNome.Text =="")
                {
                    switch (cmbNucleo.SelectedIndex)
                    {
                        case 0:
                            for (int i = 0; i < listEmpresarios.Count; i++)
                            {
                                if (listEmpresarios[i].setor == "Núcleo de Assuntos Internos")
                                {
                                    
                                    if (listEmpresarios[i].ativo == true)
                                    {
                                        listLista.Add(new Lista() { name = listEmpresarios[i].nome, cod = listEmpresarios[i].codigo, nucleo = listEmpresarios[i].setor, ativo = "Ativo" });
                                    }
                                    else
                                    {
                                        listLista.Add(new Lista() { name = listEmpresarios[i].nome, cod = listEmpresarios[i].codigo, nucleo = listEmpresarios[i].setor, ativo = "Inativo" });
                                    }
                                }
                            }
                            grvDados.DataSource = listLista;
                            break;

                        case 1:
                            for (int i = 0; i < listEmpresarios.Count; i++)
                            {
                                if (listEmpresarios[i].setor == "Núcleo de Gestão do Conhecimento e Treinamento")
                                {
                                    if (listEmpresarios[i].ativo == true)
                                    {
                                        listLista.Add(new Lista() { name = listEmpresarios[i].nome, cod = listEmpresarios[i].codigo, nucleo = listEmpresarios[i].setor, ativo = "Ativo" });
                                    }
                                    else
                                    {
                                        listLista.Add(new Lista() { name = listEmpresarios[i].nome, cod = listEmpresarios[i].codigo, nucleo = listEmpresarios[i].setor, ativo = "Inativo" });
                                    }
                                }
                            }
                            grvDados.DataSource = listLista;

                            break;

                        case 2:
                            for (int i = 0; i < listEmpresarios.Count; i++)
                            {
                                if (listEmpresarios[i].setor == "Núcleo de Projetos Sociais e Pesquisa")
                                {
                                    if (listEmpresarios[i].ativo == true)
                                    {
                                        listLista.Add(new Lista() { name = listEmpresarios[i].nome, cod = listEmpresarios[i].codigo, nucleo = listEmpresarios[i].setor, ativo = "Ativo" });
                                    }
                                    else
                                    {
                                        listLista.Add(new Lista() { name = listEmpresarios[i].nome, cod = listEmpresarios[i].codigo, nucleo = listEmpresarios[i].setor, ativo = "Inativo" });
                                    }
                                }
                            }
                            grvDados.DataSource = listLista;

                            break;

                        case 3:
                            for (int i = 0; i < listEmpresarios.Count; i++)
                            {
                                if (listEmpresarios[i].setor == "Núcleo de Engenharia")
                                {
                                    if (listEmpresarios[i].ativo == true)
                                    {
                                        listLista.Add(new Lista() { name = listEmpresarios[i].nome, cod = listEmpresarios[i].codigo, nucleo = listEmpresarios[i].setor, ativo = "Ativo" });
                                    }
                                    else
                                    {
                                        listLista.Add(new Lista() { name = listEmpresarios[i].nome, cod = listEmpresarios[i].codigo, nucleo = listEmpresarios[i].setor, ativo = "Inativo" });
                                    }
                                }
                            }
                            grvDados.DataSource = listLista;

                            break;

                        default:


                            break;
                    }
                }
                else
                {
                    try
                    {
                        empresarios = dbconnect.SelectNome(txtNome.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao buscar informação:"+ex.Message);
                    }
                    for (int i = 0; i < empresarios.Count; i++)
                    {

                        if (empresarios[i].ativo == true)
                        {
                            listLista.Add(new Lista() { name = empresarios[0].nome, cod = empresarios[0].codigo, nucleo = empresarios[0].setor, ativo = "Ativo" });
                        }
                        else
                        {
                            listLista.Add(new Lista() { name = empresarios[0].nome, cod = empresarios[0].codigo, nucleo = empresarios[0].setor, ativo = "Inativo" });
                        }
                    }
                    grvDados.DataSource = listLista;
                    grvDados.Refresh();

                }

            }
            else
            {

                for (int i = 0; i < listEmpresarios.Count; i++)
                {
                    if (listEmpresarios[i].ativo == true)
                    {
                        listLista.Add(new Lista() { name = listEmpresarios[i].nome, cod = listEmpresarios[i].codigo, nucleo = listEmpresarios[i].setor, ativo = "Ativo" });
                    }
                    else
                    {
                        listLista.Add(new Lista() { name = listEmpresarios[i].nome, cod = listEmpresarios[i].codigo, nucleo = listEmpresarios[i].setor, ativo = "Inativo" });
                    }
                }
                grvDados.DataSource = listLista;
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            grpFiltro.Enabled = !grpFiltro.Enabled;            
        }

        private void btnVizualizar_Click(object sender, EventArgs e)
        {

            try
            {
                this.Hide();
                Program.edicao = false;
                Program.Perfil = (int)grvDados.CurrentRow.Cells[0].Value;

                using (frmGeneral frm = new frmGeneral())
                {
                    frm.perfil();
                    frm.ShowDialog();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um Membro!");
                using (frmLista frm = new frmLista())
                {
                    this.Close();
                    frm.ShowDialog();
                }
            }
            
        }
    }
}
