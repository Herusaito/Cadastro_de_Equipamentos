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
    public partial class frmConsultarEquipamento : Form
    {
        public frmConsultarEquipamento()
        {
            InitializeComponent();
            tsmConsultar.Enabled = false;
            txbAtivo.MaxLength = 50;
            cmbTipo.MaxLength = 30;
            txbDescricao.MaxLength = 250;            
            txbSerial.MaxLength = 50;
            cmbStatus.MaxLength = 20;
            if (AtbEstaticos.tipoUsuario.Equals("Usuario"))
            {
                btnExcluir.Enabled = false;
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

        private void btnPesquisarAtivo_Click(object sender, EventArgs e)
        {
            List<String> listaDadosEquipamento = new List<string>();
            listaDadosEquipamento.Add("0");
            listaDadosEquipamento.Add(txbAtivo.Text);
            listaDadosEquipamento.Add("");
            listaDadosEquipamento.Add("");
            listaDadosEquipamento.Add("");
            listaDadosEquipamento.Add("");
            listaDadosEquipamento.Add("");
            Controle controle = new Controle();
            controle.PesquisarEquipamentoPorAtivoFixo(listaDadosEquipamento);

            if (AtbEstaticos.estListaEquipamentos.Count() == 0)
            {
                MessageBox.Show("Não existem Equipamento com este ativo fixo");
            }

            if (AtbEstaticos.estListaEquipamentos.Count() == 1)
            {
                PreecherForm();
            }

            if (AtbEstaticos.estListaEquipamentos.Count() > 1)
            {
                frmVisualizarEquip frmS = new frmVisualizarEquip();
                frmS.ShowDialog();
                PreecherForm();
            }
        }

        private void PreecherForm()
        {
            Equipamento equipamento = new Equipamento();
            equipamento = AtbEstaticos.estListaEquipamentos[0];
            txbId.Text = equipamento.Id.ToString();
            txbAtivo.Text = equipamento.Ativofixo;
            cmbTipo.Text = equipamento.Tipoequipamento;
            txbDescricao.Text = equipamento.Descricaoequipamento;
            mtxbAquisicao.Text = equipamento.Dataequipamento;
            txbSerial.Text = equipamento.Serialnumber;
            cmbStatus.Text = equipamento.Statuss;
            mtxbPreventiva.Text = equipamento.Datapreventiva;
        }

        private void btnPesquisarStatus_Click(object sender, EventArgs e)
        {
            List<String> listaDadosEquipamentos = new List<string>();
            listaDadosEquipamentos.Add("0");
            listaDadosEquipamentos.Add("");
            listaDadosEquipamentos.Add("");
            listaDadosEquipamentos.Add("");
            listaDadosEquipamentos.Add("");
            listaDadosEquipamentos.Add("");
            listaDadosEquipamentos.Add(cmbStatus.Text);
            listaDadosEquipamentos.Add("");
            Controle controle = new Controle();
            controle.PesquisarEquipamentoPorStatus(listaDadosEquipamentos);

            if (AtbEstaticos.estListaEquipamentos.Count() == 0)
            {
                MessageBox.Show("Não existem Equipamento com este ativo fixo");
            }

            if (AtbEstaticos.estListaEquipamentos.Count() == 1)
            {
                PreecherForm();
            }

            if (AtbEstaticos.estListaEquipamentos.Count() > 1)
            {
                frmVisualizarEquip frmS = new frmVisualizarEquip();
                frmS.ShowDialog();
                PreecherForm();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            String[] dados = { txbId.Text, txbAtivo.Text, cmbTipo.Text, txbDescricao.Text, mtxbAquisicao.Text, txbSerial.Text, cmbStatus.Text, mtxbPreventiva.Text };
            List<String> listaDadosEquipamentos = new List<string>(dados);

            Controle controle = new Controle();
            controle.EditarEquipamento(listaDadosEquipamentos);
            MessageBox.Show(controle.Mensagem);
            limpatela();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            String[] dados = { txbId.Text, txbAtivo.Text, cmbTipo.Text, txbDescricao.Text, mtxbAquisicao.Text, txbSerial.Text, cmbStatus.Text, mtxbPreventiva.Text };
            List<String> listaDadosEquipamentos = new List<string>(dados);

            Modelo.Controle controle = new Modelo.Controle();
            controle.ExcluirEquipamentoPorId(listaDadosEquipamentos);
            MessageBox.Show(controle.Mensagem);
            limpatela();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mtxbPreventiva_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void frmConsultarEquipamento_Load(object sender, EventArgs e)
        {

        }

        private void tsmSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmConsultar_Click(object sender, EventArgs e)
        {

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
    }
}


