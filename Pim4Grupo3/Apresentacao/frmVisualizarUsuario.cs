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
    public partial class frmVisualizarUsuario : Form
    {
        public frmVisualizarUsuario()
        {
            InitializeComponent();
            InicializarDGV();
        }
        private void InicializarDGV()
        {
            dgvVisualizar.Columns.Add("id", "ID");
            dgvVisualizar.Columns.Add("nome", "NOME");
            dgvVisualizar.Columns.Add("login", "LOGIN");
            dgvVisualizar.Columns.Add("senha", "SENHA");
            dgvVisualizar.Columns.Add("email", "E-MAIL");
            dgvVisualizar.Columns.Add("tipousuario", "TIPO DE USUARIO");
            dgvVisualizar.Rows.Clear();
            foreach (Usuario usuario in AtbEstaticos.estListaUsuarios)
            {
                dgvVisualizar.Rows.Add(usuario.Id, usuario.Nome, usuario.Login, usuario.Senha, usuario.Email, usuario.Tipousuario);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            AtbEstaticos.estListaUsuarios.Clear();
            Usuario usuario = new Usuario();
            usuario.Id = Convert.ToInt16(dgvVisualizar.SelectedRows[0].Cells[0].Value.ToString());
            usuario.Nome = dgvVisualizar.SelectedRows[0].Cells[1].Value.ToString();
            usuario.Login = dgvVisualizar.SelectedRows[0].Cells[2].Value.ToString();
            usuario.Senha = dgvVisualizar.SelectedRows[0].Cells[3].Value.ToString();
            usuario.Email = dgvVisualizar.SelectedRows[0].Cells[4].Value.ToString();
            usuario.Tipousuario = dgvVisualizar.SelectedRows[0].Cells[5].Value.ToString();


            AtbEstaticos.estListaUsuarios.Add(usuario);
            this.Close();
        }

        private void dgvVisualizar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void frmVisualizarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
