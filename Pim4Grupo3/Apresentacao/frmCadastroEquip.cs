using Pim4Grupo3.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim4Grupo3.Apresentacao
{
    public partial class frmCadastroEquip : Form
    {
        public frmCadastroEquip()
        {
            InitializeComponent();
            tsmCadastrar.Enabled = false;            
            txbAtivo.MaxLength = 50;
            cmbTipo.MaxLength = 30;
            txbDescricao.MaxLength = 250;
            txbSerial.MaxLength = 50;
            cmbStatus.MaxLength = 20;
            if (AtbEstaticos.tipoUsuario.Equals("Usuario"))
            {              
                tsmUsuario.Enabled = false;
            }
            else
            {

            }


        }

        private void limpatela()
        {
            txbAtivo.Text = (" ");
            cmbTipo.Text = ("");
            txbDescricao.Text = ("");
            mtxbAquisicao.Text = ("");            
            txbSerial.Text = ("");
            cmbStatus.Text = ("");
            mtxbPreventiva.Text = ("");            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            String[] dados = { "0", txbAtivo.Text, cmbTipo.Text, txbDescricao.Text, mtxbAquisicao.Text, txbSerial.Text, cmbStatus.Text, mtxbPreventiva.Text };
            List<String> listaDadosEquipamentos = new List<string>(dados);
            Controle controle = new Controle();
            controle.CadastrarEquipamento(listaDadosEquipamentos);
            MessageBox.Show(controle.Mensagem);
            limpatela();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmCadastroEquip_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tsmSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmConsultar_Click(object sender, EventArgs e)
        {
            frmConsultarEquipamento consulta = new frmConsultarEquipamento();
            consulta.ShowDialog();
        }

        private void tsmCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void tsmUsuario_Click(object sender, EventArgs e)
        {
            
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void tsmUsuario_Click_1(object sender, EventArgs e)
        {
            frmCadastroUsuario usuario = new frmCadastroUsuario();
            usuario.ShowDialog();
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
