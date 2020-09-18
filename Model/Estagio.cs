using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface;

namespace Model
{
    public class Estagio
    {
        public string Local { get; set; }
        public string Cargo { get; set; }

        public Estagio(string local, string cargo)
        {
            this.Local = local;
            this.Cargo = cargo;
        }
    }
}
