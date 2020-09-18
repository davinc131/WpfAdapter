using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Adapter
{
  public class MonitoriaAdapter: Monitoria, AdapterInterface
  {
    public MonitoriaAdapter(string materia, string nomeAluno, string nomeMonitor, string data, string hora, string sala)
      :base(materia, nomeAluno, nomeMonitor, data, hora, sala)
    {

    }
    public string getDetalhes()
    {
      return "Materia: " + Materia + "\n" + "Aluno: " + NomeAluno + "\n" + "Monitor: " + NomeMonitor + "\n" + "Data: " + Data + "\n" + "Hora: " + Hora + "\n" + "Sala: " + Sala;
    }

    public string getType()
    {
      return "Monitoria";
    }

    override
    public string ToString()
    {
      return Materia + " (" + getType() + ")";
    }
  }
}
