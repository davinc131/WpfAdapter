using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface;

namespace Model
{
    public class Monitoria : AdapterInterface
    {
        public string materia { get; set; }
        public string nomeAluno { get; set; }
        public string nomeMonitor { get; set; }
        public string data { get; set; }
        public string hora { get; set; }
        public string sala { get; set; }

        public Monitoria(string materia, string nomeAluno, string nomeMonitor, string data, string hora, string sala)
        {
            this.materia = materia;
            this.nomeAluno = nomeAluno;
            this.nomeMonitor = nomeMonitor;
            this.data = data;
            this.hora = hora;
            this.sala = sala;
        }

        public string getDetalhes()
        {
            return "Materia: " + materia + "\n" + "Aluno: " + nomeAluno + "\n" + "Monitor: " + nomeMonitor + "\n" + "Data: " + data + "\n" + "Hora: " + hora + "\n" + "Sala: " + sala;
        }

        public string getType()
        {
            return "Monitoria";
        }

        override
        public string ToString()
        {
            return materia + " (" + getType() + ")";
        }
    }
}
