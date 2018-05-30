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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            frmLogin frmL = new frmLogin();
            frmL.ShowDialog();
            if (AtbEstaticos.tipoUsuario.Equals("Usuario"))
            {
                btnUsuario.Enabled = false;
                tsmUsuario.Enabled = false;
            }
            else
            {

            }
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario usuario = new frmCadastroUsuario();
            usuario.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastroEquip equip = new frmCadastroEquip();
            equip.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultarEquipamento consulta = new frmConsultarEquipamento();
            consulta.ShowDialog();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            if (!AtbEstaticos.autorizado)
           {
                this.Close();
           }
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {

        }

        private void tsmSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmUsuario_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario usuario = new frmCadastroUsuario();
            usuario.ShowDialog();
        }

        private void tsmCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastroEquip equip = new frmCadastroEquip();
            equip.ShowDialog();
        }

        private void tsmConsultar_Click(object sender, EventArgs e)
        {
            frmConsultarEquipamento consulta = new frmConsultarEquipamento();
            consulta.ShowDialog();
        }
    }
}
