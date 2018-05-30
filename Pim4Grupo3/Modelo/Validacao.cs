using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim4Grupo3.Modelo
{
    public class Validacao
    {
        private int id;
        private String mensagem;

        public Validacao(List<String> listaDadosUsuario)
        {
            this.mensagem = "";
            try
            {
                if (listaDadosUsuario[1].Length > 50)
                    this.mensagem = "Nome com mais de 50 caracteres \n";
                if (listaDadosUsuario[2].Length > 30)
                    this.mensagem += "Login com mais de 30 caracteres \n";
                if (listaDadosUsuario[3].Length > 30)
                    this.mensagem += "Senha com mais de 30 caracteres \n";
                if (listaDadosUsuario[4].Length > 50)
                    this.mensagem += "E-Mail com mais de 50 caracteres \n";
                if (listaDadosUsuario[5].Length > 15)
                    this.mensagem += "Tipo de Usuario com mais de 15 caracteres \n";
                this.id = Convert.ToInt16(listaDadosUsuario[0]);
            }
            catch (Exception e)
            {
                this.mensagem += "ID inválido";
            }
        }
                
        public String Mensagem
        {
            get { return mensagem; }
            set { mensagem = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}

