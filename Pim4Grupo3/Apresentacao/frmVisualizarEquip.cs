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
    public partial class frmVisualizarEquip : Form
    {
        public frmVisualizarEquip()
        {
            InitializeComponent();
            InicializarDGV();
        }

        private void InicializarDGV()
        {
            dgvVisualizar.Columns.Add("id", "ID");
            dgvVisualizar.Columns.Add("ativofixo", "ATIVO FIXO");
            dgvVisualizar.Columns.Add("tipoequipamento", "TIPO DO EQUIPAMENTO");
            dgvVisualizar.Columns.Add("descricaoequipamento", "DESCRIÇÃO DO EQUIPAMENTO");
            dgvVisualizar.Columns.Add("dataequipamento", "DATA DO EQUIPAMENTO");
            dgvVisualizar.Columns.Add("serialnumber", "SERIAL NUMBER");
            dgvVisualizar.Columns.Add("statuss", "STATUS");
            dgvVisualizar.Rows.Clear();
            foreach (Equipamento equipamento in AtbEstaticos.estListaEquipamentos)
            {
                dgvVisualizar.Rows.Add(equipamento.Id, equipamento.Ativofixo, equipamento.Tipoequipamento, equipamento.Descricaoequipamento, equipamento.Dataequipamento, equipamento.Serialnumber, equipamento.Statuss);
            }
        }
        private void frmVisualizarEquip_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisaId_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            AtbEstaticos.estListaEquipamentos.Clear();
            Equipamento equipamento = new Equipamento();
            equipamento.Id = Convert.ToInt16(dgvVisualizar.SelectedRows[0].Cells[0].Value.ToString());
            equipamento.Ativofixo = dgvVisualizar.SelectedRows[0].Cells[1].Value.ToString();
            equipamento.Tipoequipamento = dgvVisualizar.SelectedRows[0].Cells[2].Value.ToString();
            equipamento.Descricaoequipamento = dgvVisualizar.SelectedRows[0].Cells[3].Value.ToString();
            equipamento.Dataequipamento = dgvVisualizar.SelectedRows[0].Cells[4].Value.ToString();
            equipamento.Serialnumber = dgvVisualizar.SelectedRows[0].Cells[5].Value.ToString();
            equipamento.Statuss = dgvVisualizar.SelectedRows[0].Cells[6].Value.ToString();
            AtbEstaticos.estListaEquipamentos.Add(equipamento);
            this.Close();
        }

        private void dgvVisualizar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
