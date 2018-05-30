using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pim4Grupo3.Modelo;

namespace Pim4Grupo3.DAL
{
    public class UsuarioDAO
    {
        Conexao con = new Conexao();
        SqlDataReader dr;
        private String mensagem = "";

        public String CadastrarUsuario(Usuario usuario)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"insert into usuarios 
                            (nome, login, senha, email, tipousuario) 
                            values(@nome, @login, @senha, @email, @tipousuario)";

            cmd.Parameters.AddWithValue("@nome", usuario.Nome);
            cmd.Parameters.AddWithValue("@login", usuario.Login);
            cmd.Parameters.AddWithValue("@senha", usuario.Senha);
            cmd.Parameters.AddWithValue("@email", usuario.Email);
            cmd.Parameters.AddWithValue("@tipousuario", usuario.Tipousuario);

            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.Desconectar();
                this.mensagem = "O Usuario foi cadastrado com sucesso!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro de conexão com o Banco de Dados";
            }
            return this.mensagem;
        }

        public String ExcluirUsuarioPorId(Usuario usuario)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"delete from usuarios
                                where id = @id";

            cmd.Parameters.AddWithValue("@id", usuario.Id);

            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.Desconectar();
                this.mensagem = "O Usuario foi excluído com sucesso!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro de conexão com o Banco de Dados";
            }
            return this.mensagem;
        }

        public String EditarUsuario(Usuario usuario)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"update usuarios
                            set nome = @nome,
                            login = @login,
                            senha = @senha,
                            email = @email,
                            tipousuario = @tipousuario
                            where id = @id";

            cmd.Parameters.AddWithValue("@id", usuario.Id);
            cmd.Parameters.AddWithValue("@nome", usuario.Nome);
            cmd.Parameters.AddWithValue("@login", usuario.Login);
            cmd.Parameters.AddWithValue("@senha", usuario.Senha);
            cmd.Parameters.AddWithValue("@email", usuario.Email);
            cmd.Parameters.AddWithValue("@tipousuario", usuario.Tipousuario);
                      
            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.Desconectar();
                this.mensagem = "O Usuario foi editado com sucesso!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro de conexão com Banco de Dados";
            }
            return this.mensagem;
        }

        public List<Usuario> PesquisarUsuarioPorNome(Usuario usuario)
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select * from usuarios 
                                where nome like @nome";

            cmd.Parameters.AddWithValue("@nome", usuario.Nome + "%");

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Usuario UsuarioLista = new Usuario();
                    UsuarioLista.Id = Convert.ToInt16(dr["id"]);
                    UsuarioLista.Nome = dr["nome"].ToString();
                    UsuarioLista.Login = dr["login"].ToString();
                    UsuarioLista.Senha = dr["senha"].ToString();
                    UsuarioLista.Email = dr["email"].ToString();
                    UsuarioLista.Tipousuario = dr["tipousuario"].ToString();
                    listaUsuarios.Add(UsuarioLista);
                }
                con.Desconectar();
            }
            catch (Exception e)
            {
                this.mensagem = e.ToString();
            }

            return listaUsuarios;
        }
         
        public bool VerificarUsuario (string Login, string Senha, string TipoUsuario)
        {
            SqlCommand cmd = new SqlCommand();
            Boolean resposta = false;
            cmd.CommandText = @"select * from usuarios Where login = @login and senha = @senha and tipousuario = @tipousuario";

            cmd.Parameters.AddWithValue("@login", Login);
            cmd.Parameters.AddWithValue("@senha", Senha);
            cmd.Parameters.AddWithValue("@tipousuario", TipoUsuario);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    resposta = true;
                }
            }

            catch (Exception e)
            {
                resposta = false;                
            }
            return resposta;

        }
    }
}

