using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim4Grupo3.Modelo
{
    public class Equipamento
    {
        private int id;
        private String ativofixo;
        private String tipoequipamento;
        private String descricaoequipamento;
        private String dataequipamento;
        private String serialnumber;
        private String statuss;
        private String datapreventiva;

        public String Datapreventiva
        {
            get { return datapreventiva; }
            set { datapreventiva = value; }
        }


        public String Statuss
        {
            get { return statuss; }
            set { statuss = value; }
        }

        public String Serialnumber
        {
            get { return serialnumber; }
            set { serialnumber = value; }
        }

        public String Dataequipamento
        {
            get { return dataequipamento; }
            set { dataequipamento = value; }
        }

        public String Descricaoequipamento
        {
            get { return descricaoequipamento; }
            set { descricaoequipamento = value; }
        }

        public String Tipoequipamento
        {
            get { return tipoequipamento; }
            set { tipoequipamento = value; }
        }

        public String Ativofixo
        {
            get { return ativofixo; }
            set { ativofixo = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
