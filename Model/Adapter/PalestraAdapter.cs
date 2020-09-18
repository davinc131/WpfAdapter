using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Adapter
{
  public class PalestraAdapter: Palestra, AdapterInterface
  {
    public PalestraAdapter(string assunto, string palestrante, string data) : base(assunto, palestrante, data)
    {

    }
    public string getDetalhes()
    {
      return "Assunto: " + Assunto + "\n" + "Data: " + Data + "\n" + "Palestrante: " + Palestrante;
    }

    public string getType()
    {
      return "Palestra";
    }

    override
    public string ToString()
    {
      return Assunto + " (" + getType() + ")";
    }
  }
}
