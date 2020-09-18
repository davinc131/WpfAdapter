using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface;

namespace Model
{
    public class Palestra
    {
        public string Assunto;
        public string Palestrante;
        public string Data;

        public Palestra(string assunto, string palestrante, string data)
        {
            this.Assunto = assunto;
            this.Data = data;
            this.Palestrante = palestrante;
        }
    }
}
