using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface;

namespace Model
{
    public class VisitaTecnica
    {
        public string Destino;
        public string Data;
        public string Interesse;

        public VisitaTecnica(string destino, string data, string interesse)
        {
            this.Data = data;
            this.Destino = destino;
            this.Interesse = interesse;
        }
    }
}
