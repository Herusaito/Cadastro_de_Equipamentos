using Pim4Grupo3.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using Pim4Grupo3.Modelo;

namespace Pim4Grupo3.Apresentacao
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txbSenha.PasswordChar = '*';
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            UsuarioDAO consulta = new UsuarioDAO();
            if (consulta.VerificarUsuario(txbUsuario.Text, txbSenha.Text, cmbTipoUsuario.Text))
            {
                AtbEstaticos.autorizado = true;
                AtbEstaticos.tipoUsuario = cmbTipoUsuario.Text;
                this.Close();
            }
            else
            {
                AtbEstaticos.autorizado = false;
                MessageBox.Show("Login ou Senha Invalidos");
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void llbSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRecuperarSenha recSenha = new frmRecuperarSenha();
            recSenha.ShowDialog();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
