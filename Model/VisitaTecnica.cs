using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface;

namespace Model
{
    public class VisitaTecnica : AdapterInterface
    {
        public string destino;
        public string data;
        public string interesse;

        public VisitaTecnica(string destino, string data, string interesse)
        {
            this.data = data;
            this.destino = destino;
            this.interesse = interesse;
        }
        public string getDetalhes()
        {
            return "Destino: " + destino + "\n" + "Data: " + data + "\n" + "Interesse: " + interesse;
        }

        public string getType()
        {
            return "Visita Técnica";
        }

        override
        public string ToString()
        {
            return destino + " (" + getType() + ")";
        }
    }
}
