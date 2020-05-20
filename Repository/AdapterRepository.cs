using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface;
using Model;

namespace Repository
{
    public class AdapterRepository
    {
        public List<AdapterInterface> listaDeDados { get; set; }

        public AdapterRepository()
        {
            listaDeDados = new List<AdapterInterface>();
            CarregarLista();
        }

        private void CarregarLista()
        {
            AdapterInterface estagio1 = new Estagio("Sindicato das empresas varejistas de Goiás", "Auxiliar Administrativo");
            AdapterInterface monitoria1 = new Monitoria("Padrões de Porjeto", "Ricardo Silva Alencar", "José Gomes Silva", "03/06/2020", "21:00", "201");
            AdapterInterface palestra1 = new Palestra("A TI em tempos de Covid-19", "Edjalma Queiroz", "20/05/2020");
            AdapterInterface visista1 = new VisitaTecnica("Faculdade Senai Fatesg", "15/05/2020", "Manutenção das máquinas da sala 101");

            listaDeDados.Add(estagio1);
            listaDeDados.Add(monitoria1);
            listaDeDados.Add(palestra1);
            listaDeDados.Add(visista1);
        }
    }
}
