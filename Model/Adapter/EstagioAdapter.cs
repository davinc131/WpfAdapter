using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Adapter
{
  public class EstagioAdapter: Estagio, AdapterInterface
  {
    public EstagioAdapter(string local, string cargo) : base(local, cargo) { }
    public string getDetalhes()
    {
      return "Local: " + Local + "\n" + "Cargo: " + Cargo;
    }

    public string getType()
    {
      return "Estágio";
    }

    override
    public string ToString()
    {
      return Local + " ( " + getType() + ")";
    }
  }
}
