using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface;

namespace Model
{
    public class Estagio : AdapterInterface
    {
        public string local { get; set; }
        public string cargo { get; set; }

        public Estagio(string local, string cargo)
        {
            this.local = local;
            this.cargo = cargo;
        }

        public string getDetalhes()
        {
            return "Local: " + local + "\n" + "Cargo: " + cargo;
        }

        public string getType()
        {
            return "Estágio";
        }

        override
        public string ToString()
        {
            return local + " ( " + getType() + ")";
        }
    }
}
