using Pim4Grupo3.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim4Grupo3.DAL
{
    public class EquipamentoDAO
    {
        Conexao con = new Conexao();
        SqlDataReader dr;
        private String mensagem = "";

        public String CadastrarEquipamento(Equipamento equipamento)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"insert into equipamentos 
                            (ativofixo, tipoequipamento, descricaoequipamento, dataequipamento, serialnumber, statuss, datapreventiva) 
                            values(@ativofixo, @tipoequipamento, @descricaoequipamento, @dataequipamento, @serialnumber, @statuss, @datapreventiva)";

            cmd.Parameters.AddWithValue("@ativofixo", equipamento.Ativofixo);
            cmd.Parameters.AddWithValue("@tipoequipamento", equipamento.Tipoequipamento);
            cmd.Parameters.AddWithValue("@descricaoequipamento", equipamento.Descricaoequipamento);
            cmd.Parameters.AddWithValue("@dataequipamento", equipamento.Dataequipamento);
            cmd.Parameters.AddWithValue("@serialnumber", equipamento.Serialnumber);
            cmd.Parameters.AddWithValue("@statuss", equipamento.Statuss);
            cmd.Parameters.AddWithValue("@datapreventiva", equipamento.Datapreventiva);


            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.Desconectar();
                this.mensagem = "O Equipamento foi cadastrado com sucesso!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro de conexão com o Banco de Dados";
            }
            return this.mensagem;
        }

        public String ExcluirEquipamentoPorId(Equipamento equipamento)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"delete from equipamentos
                                where id = @id";

            cmd.Parameters.AddWithValue("@id", equipamento.Id);

            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.Desconectar();
                this.mensagem = "O Equipamento foi excluído com sucesso!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro de conexão com o Banco de Dados";
            }
            return this.mensagem;
        }

        public String EditarEquipamento(Equipamento equipamento)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = @"update equipamentos set
                            ativofixo = @ativofixo, 
                            tipoequipamento = @tipoequipamento, 
                            descricaoequipamento = @descricaoequipamento, 
                            dataequipamento = @dataequipamento, 
                            serialnumber = @serialnumber,
                            statuss = @statuss,
                            datapreventiva = @datapreventiva 
                            where id = @id";

            cmd.Parameters.AddWithValue("@id", equipamento.Id);
            cmd.Parameters.AddWithValue("@ativofixo", equipamento.Ativofixo);
            cmd.Parameters.AddWithValue("@tipoequipamento", equipamento.Tipoequipamento);
            cmd.Parameters.AddWithValue("@descricaoequipamento", equipamento.Descricaoequipamento);
            cmd.Parameters.AddWithValue("@dataequipamento", equipamento.Dataequipamento);
            cmd.Parameters.AddWithValue("@serialnumber", equipamento.Serialnumber);
            cmd.Parameters.AddWithValue("@statuss", equipamento.Statuss);
            cmd.Parameters.AddWithValue("@datapreventiva", equipamento.Datapreventiva);
            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.Desconectar();
                this.mensagem = "O Equipamento foi editado com sucesso!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro de conexão com Banco de Dados";
            }
            return this.mensagem;
        }

        public List<Equipamento> PesquisarEquipamentoPorAtivofixo(Equipamento equipamento)
        {
            List<Equipamento> listaEquipamentos = new List<Equipamento>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select * from equipamentos 
                            where ativofixo like @ativofixo";

            cmd.Parameters.AddWithValue("@ativofixo", equipamento.Ativofixo + "%");

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Equipamento EquipamentoLista = new Equipamento();
                    EquipamentoLista.Id = Convert.ToInt16(dr["id"]);
                    EquipamentoLista.Ativofixo = dr["ativofixo"].ToString();
                    EquipamentoLista.Tipoequipamento = dr["tipoequipamento"].ToString();
                    EquipamentoLista.Descricaoequipamento = dr["descricaoequipamento"].ToString();
                    EquipamentoLista.Dataequipamento = dr["dataequipamento"].ToString();
                    EquipamentoLista.Serialnumber = dr["serialnumber"].ToString();
                    EquipamentoLista.Statuss = dr["statuss"].ToString();
                    EquipamentoLista.Datapreventiva = dr["datapreventiva"].ToString();
                    listaEquipamentos.Add(EquipamentoLista);
                }
                con.Desconectar();
            }
            catch (Exception e)
            {
                this.mensagem = e.ToString();
            }

            return listaEquipamentos;
        }

        public List<Equipamento> PesquisarEquipamentoPorStatus(Equipamento equipamento)
        {
            List<Equipamento> listaEquipamentos = new List<Equipamento>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select * from equipamentos 
                                where statuss like @statuss";

            cmd.Parameters.AddWithValue("@statuss", equipamento.Statuss + "%");

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Equipamento EquipamentoLista = new Equipamento();
                    EquipamentoLista.Id = Convert.ToInt16(dr["id"]);
                    EquipamentoLista.Ativofixo = dr["ativofixo"].ToString();
                    EquipamentoLista.Tipoequipamento = dr["tipoequipamento"].ToString();
                    EquipamentoLista.Descricaoequipamento = dr["descricaoequipamento"].ToString();
                    EquipamentoLista.Dataequipamento = dr["dataequipamento"].ToString();
                    EquipamentoLista.Serialnumber = dr["serialnumber"].ToString();
                    EquipamentoLista.Statuss = dr["statuss"].ToString();
                    EquipamentoLista.Datapreventiva = dr["datapreventiva"].ToString();
                    listaEquipamentos.Add(EquipamentoLista);
                }
                con.Desconectar();
            }
            catch (Exception e)
            {
                this.mensagem = e.ToString();
            }

            return listaEquipamentos;
        }
    }
}