using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim4Grupo3.Modelo
{
    public class Controle
    {
        private String mensagem;

        public void CadastrarUsuario(List<String> listaDadosUsuario)
        {
            Validacao validacao = new Validacao(listaDadosUsuario);
            if (validacao.Mensagem.Equals(""))
            {
                Usuario usuario = new Usuario();
                usuario.Id = 0;
                usuario.Nome = listaDadosUsuario[1];
                usuario.Login = listaDadosUsuario[2];
                usuario.Senha = listaDadosUsuario[3];
                usuario.Email = listaDadosUsuario[4];
                usuario.Tipousuario = listaDadosUsuario[5];
                DAL.UsuarioDAO usuarioDAO = new DAL.UsuarioDAO();
                this.mensagem = usuarioDAO.CadastrarUsuario(usuario);
            }
            else
            {
                this.mensagem = validacao.Mensagem;
            }
        }

        public void EditarUsuario(List<String> listaDadosUsuario)
        {
            Validacao validacao = new Validacao(listaDadosUsuario);
            if (validacao.Mensagem.Equals(""))
            {
                Usuario usuario = new Usuario();
                usuario.Id = validacao.Id;
                usuario.Nome = listaDadosUsuario[1];
                usuario.Login = listaDadosUsuario[2];
                usuario.Senha = listaDadosUsuario[3];
                usuario.Email = listaDadosUsuario[4];
                DAL.UsuarioDAO usuarioDAO = new DAL.UsuarioDAO();
                this.mensagem = usuarioDAO.EditarUsuario(usuario);
            }
            else
            {
                this.mensagem = validacao.Mensagem;
            }
        }

        public void ExcluirUsuarioPorId(List<String> listaDadosUsuario)
        {
            Validacao validacao = new Validacao(listaDadosUsuario);
            if (validacao.Mensagem.Equals(""))
            {
                Usuario usuario = new Usuario();
                usuario.Id = validacao.Id;
                DAL.UsuarioDAO usuarioDAO = new DAL.UsuarioDAO();
                this.mensagem = usuarioDAO.ExcluirUsuarioPorId(usuario);
            }
            else
            {
                this.mensagem = validacao.Mensagem;
            }
        }

        public void PesquisarUsuarioPorNome(List<String> listaDadosUsuario)
        {
            Validacao validacao = new Validacao(listaDadosUsuario);
            if (validacao.Mensagem.Equals(""))
            {
                DAL.UsuarioDAO usuarioDAO = new DAL.UsuarioDAO();
                Usuario usuario = new Usuario();
                usuario.Nome = listaDadosUsuario[1];
                AtbEstaticos.estListaUsuarios = usuarioDAO.PesquisarUsuarioPorNome(usuario);
            }
            else
            {
                this.mensagem = validacao.Mensagem;
            }
        }

        public void CadastrarEquipamento(List<String> listaDadosEquipamento)
        {
            try
            {
                Equipamento equipamento = new Equipamento();
                equipamento.Id = 0;
                equipamento.Ativofixo = listaDadosEquipamento[1];
                equipamento.Tipoequipamento = listaDadosEquipamento[2];
                equipamento.Descricaoequipamento = listaDadosEquipamento[3];
                equipamento.Dataequipamento = listaDadosEquipamento[4];
                equipamento.Serialnumber = listaDadosEquipamento[5];
                equipamento.Statuss = listaDadosEquipamento[6];
                equipamento.Datapreventiva = listaDadosEquipamento[7];
                DAL.EquipamentoDAO EquipamentoDAO = new DAL.EquipamentoDAO();
                this.mensagem = EquipamentoDAO.CadastrarEquipamento(equipamento);
            }
            catch (Exception)
            {
                this.mensagem = "Ocorreu um Erro";
            }
        }

        public void EditarEquipamento(List<String> listaDadosEquipamento)
        {
            try
            {
                Equipamento equipamento = new Equipamento();
                equipamento.Id = Convert.ToInt16(listaDadosEquipamento[0]);
                equipamento.Ativofixo = listaDadosEquipamento[1];
                equipamento.Tipoequipamento = listaDadosEquipamento[2];
                equipamento.Descricaoequipamento = listaDadosEquipamento[3];
                equipamento.Dataequipamento = listaDadosEquipamento[4];
                equipamento.Serialnumber = listaDadosEquipamento[5];
                equipamento.Statuss = listaDadosEquipamento[6];
                equipamento.Datapreventiva = listaDadosEquipamento[7];
                DAL.EquipamentoDAO equipamentoDAO = new DAL.EquipamentoDAO();
                this.mensagem = equipamentoDAO.EditarEquipamento(equipamento);
            }
            catch (Exception)
            {
                this.mensagem = "Ocorreu um Erro";
            }
        }

        public void ExcluirEquipamentoPorId(List<String> listaDadosEquipamento)
        {
            try
            {
                Equipamento equipamento = new Equipamento();
                equipamento.Id = Convert.ToInt16(listaDadosEquipamento[0]);
                DAL.EquipamentoDAO equipamentoDAO = new DAL.EquipamentoDAO();
                this.mensagem = equipamentoDAO.ExcluirEquipamentoPorId(equipamento);
            }
            catch (Exception)
            {
                this.mensagem = "Ocorreu um Erro";
            }
        }

        public void PesquisarEquipamentoPorAtivoFixo(List<String> listaDadosEquipamento)
        {
            try
            {
                DAL.EquipamentoDAO equipamentoDAO = new DAL.EquipamentoDAO();
                Equipamento equipamento = new Equipamento();
                equipamento.Ativofixo = listaDadosEquipamento[1];
                AtbEstaticos.estListaEquipamentos = equipamentoDAO.PesquisarEquipamentoPorAtivofixo(equipamento);
            }
            catch (Exception e)
            {
                this.mensagem = "Ocorreu um Erro";
            }
        }

        public void PesquisarEquipamentoPorStatus(List<String> listaDadosEquipamento)
        {
            try
            {
                DAL.EquipamentoDAO equipamentoDAO = new DAL.EquipamentoDAO();
                Equipamento equipamento = new Equipamento();
                equipamento.Statuss = listaDadosEquipamento[6];
                AtbEstaticos.estListaEquipamentos = equipamentoDAO.PesquisarEquipamentoPorStatus(equipamento);
            }
            catch (Exception)
            {
                this.mensagem = "Ocorreu um Erro";
            }
        }
        public String Mensagem
        {
            get { return mensagem; }
            set { mensagem = value; }
        }
    }
}