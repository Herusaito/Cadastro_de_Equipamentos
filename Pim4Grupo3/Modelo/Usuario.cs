using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim4Grupo3.Modelo
{
    public class Usuario
    {
        private int id;
        private String nome;
        private String login;
        private String senha;
        private String email;
        private String tipousuario;

        public String Tipousuario
        {
            get { return tipousuario; }
            set { tipousuario = value; }
        }


        public String Email
        {
            get { return email; }
            set { email = value; }
        }


        public String Senha
        {
            get { return senha; }
            set { senha = value; }
        }


        public String Login
        {
            get { return login; }
            set { login = value; }
        }


        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}