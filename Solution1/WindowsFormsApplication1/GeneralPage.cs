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
    public partial class frmGeneral : Form
    {
        public static bool check;
        Lista lista = new Lista();

        //Inicialização
        public frmGeneral()
        {
            InitializeComponent();
            frmGeneral_Load();
        }

        void frmGeneral_Load()
        {
            List<Empresarios> empresarios = new List<Empresarios>();
            Empresarios empresario = new Empresarios();

            //Conectando com o banco de dados
            DBConnecting dbconnect = new DBConnecting();
            dbconnect.Initialize();
            empresarios = dbconnect.Select();

            //Esconde ou mostra os botões da função administrador
            if (Program.idLogin == 1)
            {
                menuCadastro.Visible = false;
                addMembros.Visible = false;
                btnEditar.Visible = false;
                btnExcluir.Visible = false;
                btnConfirmar.Visible = false;
            }
            else
            {
                menuCadastro.Visible = true;
                addMembros.Visible = true;
                btnConfirmar.Visible = false;
                btnEditar.Visible = true;
                btnExcluir.Visible = true;
                btnExcluir.Text = "Excluir";
            }

            //Inicializa a tela com os valores do membro de
            if (Program.edicao == true)
            {
                addMembros_Click();
            }
            else
            {
                for (int i = 0; i < empresarios.Count; i++)
                {
                    if (Program.idCadastro == empresarios[i].codigo)
                    {
                        empresario = empresarios[i];
                        break;
                    }
                }

                string[] split = empresario.dataEntrada.ToString().Split(new Char[] {'/',' '});
                txtDiaEntrada.Text = split[1];
                txtMesEntrada.Text = split[0];
                txtAnoEntrada.Text = split[2];
                grpEmpresarial.Enabled = false;
                grpPessoal.Enabled = false;
                txtNome.Text = empresario.nome;
                txtName.Text = empresario.nome;
                txtCurso.Text = empresario.curso;
                txtMatricula.Text = empresario.codigo.ToString();
                txtEnd.Text = empresario.endereco;
                txtEndNum.Text = empresario.endNum.ToString();
                txtEndBairro.Text = empresario.endBairro;
                txtTel.Text = empresario.telefone;
                txtRG.Text = empresario.rg.ToString();
                txtCPF.Text = empresario.cpf;
                txtFaltas.Text = empresario.faltas.ToString();
                profilePicture.ImageLocation = empresario.imagem;
                txtNucleo.Text = empresario.setor;
                txtCargo.Text = empresario.cargo;
                txtProjeto.Text = empresario.atividade;
                txtDep.Text = empresario.dedicatoria;
                profile2.ImageLocation = empresario.imagem;
                rbAdmin.Checked = empresario.login;
                rbInativo.Checked = !empresario.ativo;
                dbAtivo.Checked = empresario.ativo;
                Program.edicao = true;
                check = rbAdmin.Checked;
            }
        }

       
        //Abrir tela de Lista de Membros
        private void listaMembros_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmLista frm = new frmLista())
            {
                frm.ShowDialog();
            }
        }


        //Adicionar Membros
        private void addMembros_Click(object sender, EventArgs e)
        {
            grpPessoal.Enabled = true;
            grpEmpresarial.Enabled = true;
            btnConfirmar.Visible = true;
            txtCurso.Clear();
            txtEnd.Clear();
            rbAdmin.Checked = false;
            txtFaltas.Clear();
            txtMatricula.Clear();
            txtNome.Clear();
            txtTel.Clear();
            txtCargo.Clear();
            txtCPF.Clear();
            txtDep.Clear();
            txtRG.Clear();
            txtProjeto.Clear();
            txtDiaEntrada.Clear();
            txtDiaEntrada.Clear();
            txtDiaSaida.Clear();
            txtMesEntrada.Clear();
            txtMesSaida.Clear();
            txtAnoEntrada.Clear();
            txtAnoSaida.Clear();
            txtName.Clear();
            txtNucleo.Clear();
            btnExcluir.Text = "Cancelar";
            btnConfirmar.Visible = true;
            txtAnoSaida.Enabled = false;
            txtMesSaida.Enabled = false;
            txtDiaSaida.Enabled = false;
            txtEndNum.Clear();
            txtEndBairro.Clear();
            
        }


        //Confirmar membros para serem adicionados
        private void btnConfirma_Click(object sender, EventArgs e)
        {
            DBConnecting dbconnecting = new DBConnecting();
            string total;

            string datain, dataout,ativo = null;

            if (dbAtivo.Checked == true)
            {
                ativo = "1";
            }
            else if (rbInativo.Checked == true)
            {
                ativo = "0";
            }

            if (Program.edicao ==false)
            {
                DateTime datahoje = DateTime.Now;
                datain = datahoje.Year.ToString() + datahoje.Day.ToString() + datahoje.Month.ToString();
                datain = txtAnoEntrada.Text + "-" + txtDiaEntrada.Text + "-" + txtMesEntrada.Text;
                dataout = txtAnoSaida.Text + "-" + txtDiaSaida.Text + "-" + txtMesSaida.Text;


                total = txtNome.Text + "," + int.Parse(txtMatricula.Text) + "," + "qualquercoisa," + txtNucleo.Text + "," + txtCargo.Text + "," + datain + "," +
                    txtDep.Text + "," + txtProjeto.Text + "," + int.Parse(txtRG.Text) + "," + txtCPF.Text + "," + ativo + "," + int.Parse(txtFaltas.Text) + ',' + rbAdmin.Checked.ToString() + "," + txtEnd.Text + "," + txtEndNum.Text + "," + txtEndBairro.Text + "," + txtTel.Text + "," + txtCurso.Text + "," + lista.cod;
                Program.edicao = true;
                dbconnecting.Update(total);

            }
            else
            {
                DateTime datahoje = DateTime.Now;
                datain = datahoje.Year.ToString() + "-" + datahoje.Day.ToString() + "-" + datahoje.Month.ToString();
                dataout = txtAnoEntrada.Text + "-" + txtDiaEntrada.Text + "-" + txtMesEntrada.Text;
                //dataout = txtAnoSaida.Text + "-" + txtDiaSaida.Text + "-" + txtMesSaida.Text;

                total = txtNome.Text + "," + int.Parse(txtMatricula.Text) + "," + "qualquercoisa," + txtNucleo.Text + "," + txtCargo.Text + "," + dataout + "," +
                    txtDep.Text + "," + txtProjeto.Text + "," + int.Parse(txtRG.Text) + "," + txtCPF.Text + "," + ativo + "," + int.Parse(txtFaltas.Text) + ',' + rbAdmin.Checked.ToString() + "," + txtEnd.Text + "," + txtEndNum.Text + "," + txtEndBairro.Text + "," + txtTel.Text + "," + txtCurso.Text + ","+datain;
                dbconnecting.Insert(total);

            }
            Program.edicao = false;
            frmGeneral_Load();
            
        }

        //Editar Membros
        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtDiaSaida.Enabled = rbInativo.Checked;
            txtMesSaida.Enabled = rbInativo.Checked;
            txtAnoSaida.Enabled = rbInativo.Checked;
            lista.cod = int.Parse(txtMatricula.Text);
            Program.edicao = false;
            grpEmpresarial.Enabled = true;
            btnConfirmar.Visible = true;
            grpPessoal.Enabled = true;
        }

        //Adicionar Membros
        private void addMembros_Click()
        {

        }

        //Fechar a Página
        private void frmGeneral_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            using (frmFisrtPage frm = new frmFisrtPage())
            {
                frm.ShowDialog();
            }
        }

        //Excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DBConnecting dbconnecting = new DBConnecting();
            try
            {
                dbconnecting.Delete(int.Parse(txtMatricula.Text));
                MessageBox.Show("Membro exclúido com Sucesso!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir membro: " + ex.Message);
                throw;
            }
            this.Hide();
            using (frmLista frm = new frmLista())
            {
                frm.ShowDialog();
            }
        }

        //
        private void rbInativo_CheckedChanged(object sender, EventArgs e)
        {
            txtDiaSaida.Enabled = rbInativo.Checked;
            txtMesSaida.Enabled = rbInativo.Checked;
            txtAnoSaida.Enabled = rbInativo.Checked;
        }

        public void perfil()
        {
            List<Empresarios> empresarios = new List<Empresarios>();
            Empresarios empresario = new Empresarios();

            //Conectando com o banco de dados
            DBConnecting dbconnect = new DBConnecting();
            dbconnect.Initialize();
            empresarios = dbconnect.Select();

            for (int i = 0; i < empresarios.Count; i++)
            {
                if (Program.Perfil == empresarios[i].codigo)
                {
                    empresario = empresarios[i];
                    break;
                }
            }

            string[] split = empresario.dataEntrada.ToString().Split(new Char[] { '/', ' ' });
            txtDiaEntrada.Text = split[1];
            txtMesEntrada.Text = split[0];
            txtAnoEntrada.Text = split[2];
            grpEmpresarial.Enabled = false;
            grpPessoal.Enabled = false;
            txtNome.Text = empresario.nome;
            txtName.Text = empresario.nome;
            txtCurso.Text = empresario.curso;
            txtMatricula.Text = empresario.codigo.ToString();
            txtEnd.Text = empresario.endereco;
            txtEndNum.Text = empresario.endNum.ToString();
            txtEndBairro.Text = empresario.endBairro;
            txtTel.Text = empresario.telefone;
            txtRG.Text = empresario.rg.ToString();
            txtCPF.Text = empresario.cpf;
            txtFaltas.Text = empresario.faltas.ToString();
            profilePicture.ImageLocation = empresario.imagem;
            txtNucleo.Text = empresario.setor;
            txtCargo.Text = empresario.cargo;
            txtProjeto.Text = empresario.atividade;
            txtDep.Text = empresario.dedicatoria;
            profile2.ImageLocation = empresario.imagem;
            rbAdmin.Checked = empresario.login;
            rbInativo.Checked = !empresario.ativo;
            dbAtivo.Checked = empresario.ativo;
            Program.edicao = true;
            check = rbAdmin.Checked;
        }

    }  
}
