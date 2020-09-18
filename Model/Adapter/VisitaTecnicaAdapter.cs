using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Adapter
{
  public class VisitaTecnicaAdapter : VisitaTecnica, AdapterInterface
  {
    public VisitaTecnicaAdapter(string destino, string data, string interesse) : base(destino, data, interesse)
    {

    }
    public string getDetalhes()
    {
      return "Destino: " + Destino + "\n" + "Data: " + Data + "\n" + "Interesse: " + Interesse;
    }

    public string getType()
    {
      return "Visita Técnica";
    }

    override
    public string ToString()
    {
      return Destino + " (" + getType() + ")";
    }
  }
}
