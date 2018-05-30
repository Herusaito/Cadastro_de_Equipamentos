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
    public partial class frmCadastroUsuario : Form
    {
        public frmCadastroUsuario()
        {
            InitializeComponent();
            tsmUsuario.Enabled = false;
            txbNome.MaxLength = 50;
            txbLogin.MaxLength = 30;
            txbSenha.MaxLength = 30;
            txbEmail.MaxLength = 50;            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            List<String> listaDadosUsuario = new List<string>();
            listaDadosUsuario.Add("0");
            listaDadosUsuario.Add(txbNome.Text);
            listaDadosUsuario.Add("");
            listaDadosUsuario.Add("");
            listaDadosUsuario.Add("");
            listaDadosUsuario.Add("");          
            Controle controle = new Controle();
            controle.PesquisarUsuarioPorNome(listaDadosUsuario);

            if (AtbEstaticos.estListaUsuarios.Count() == 0)
            {
                MessageBox.Show("Não existem Usuarios com este nome");
            }

            if (AtbEstaticos.estListaUsuarios.Count() == 1)
            {
                PreecherForm();
            }

            if (AtbEstaticos.estListaUsuarios.Count() > 1)
            {
                frmVisualizarUsuario frmS = new frmVisualizarUsuario();
                frmS.ShowDialog();
                PreecherForm();
            }
        }

        private void PreecherForm()
        {
            Usuario usuario = new Usuario();
            usuario = AtbEstaticos.estListaUsuarios[0];
            txbId.Text = usuario.Id.ToString();
            txbNome.Text = usuario.Nome;
            txbLogin.Text = usuario.Login;
            txbSenha.Text = usuario.Senha;
            txbEmail.Text = usuario.Email;
            cmbPermicao.Text = usuario.Tipousuario;
        }

        private void limparTextBoxes(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = String.Empty;
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {            
            String[] dados = { "0", txbNome.Text, txbLogin.Text, txbSenha.Text, txbEmail.Text, cmbPermicao.Text };
            List<String> listaDadosUsuario = new List<string>(dados);
            Controle controle = new Controle();
            controle.CadastrarUsuario(listaDadosUsuario);
            MessageBox.Show(controle.Mensagem);            
            limparTextBoxes(this.Controls);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            String[] dados = { txbId.Text, txbNome.Text, txbLogin.Text, txbSenha.Text, txbEmail.Text, cmbPermicao.Text };
            List<String> listaDadosUsuarios = new List<string>(dados);
            Controle controle = new Controle();
            controle.ExcluirUsuarioPorId(listaDadosUsuarios);
            MessageBox.Show(controle.Mensagem);
            limparTextBoxes(this.Controls);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {            
            String[] dados = { txbId.Text, txbNome.Text, txbLogin.Text, txbSenha.Text, txbEmail.Text, cmbPermicao.Text };
            List<String> listaDadosUsuarios = new List<string>(dados);
            Controle controle = new Controle();
            controle.EditarUsuario(listaDadosUsuarios);
            MessageBox.Show(controle.Mensagem);            
            limparTextBoxes(this.Controls);
        }

        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void txbConfirmaSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void tsmUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
