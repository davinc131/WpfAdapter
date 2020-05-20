using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface;

namespace Model
{
    public class Palestra : AdapterInterface
    {
        public string assunto;
        public string palestrante;
        public string data;

        public Palestra(string assunto, string palestrante, string data)
        {
            this.assunto = assunto;
            this.data = data;
            this.palestrante = palestrante;
        }

        public string getDetalhes()
        {
            return "Assunto: " + assunto + "\n" + "Data: " + data + "\n" + "Palestrante: " + palestrante;
        }

        public string getType()
        {
            return "Palestra";
        }

        override
        public string ToString()
        {
            return assunto + " (" + getType() + ")";
        }
    }
}
