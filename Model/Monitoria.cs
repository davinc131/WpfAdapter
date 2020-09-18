using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface;

namespace Model
{
    public class Monitoria
    {
        public string Materia { get; set; }
        public string NomeAluno { get; set; }
        public string NomeMonitor { get; set; }
        public string Data { get; set; }
        public string Hora { get; set; }
        public string Sala { get; set; }

        public Monitoria(string materia, string nomeAluno, string nomeMonitor, string data, string hora, string sala)
        {
            this.Materia = materia;
            this.NomeAluno = nomeAluno;
            this.NomeMonitor = nomeMonitor;
            this.Data = data;
            this.Hora = hora;
            this.Sala = sala;
        }
    }
}
