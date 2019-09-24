using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiresias_V_alfa01.appCode.DAL;

namespace Tiresias_V_alfa01.appCode.BLL
{
  class partituraBLL
  {
    private partituraDAL partituraDal = new partituraDAL();

    public int InsirirPartitura(Partitura partitura)
    {
      //if (titulo == "") return new Exception 
      return partituraDal.InsirirPartitura(partitura);
    }

    public bool AlterarPartitura(Partitura partitura)
    {
      //if (titulo == "") return new Exception 
      return partituraDal.AlterarPartitura(partitura);
    }

    public List<Partitura> GetAllPartitura()
    {
      //if (titulo == "") return new Exception 
      return partituraDal.GetAllPartitura();
    }

    public bool auxiliar(int aux)
    {
      return partituraDal.auxiliar(aux);
    }

    public Partitura GetPartitura()
    {
      return partituraDal.GetPartitura();
    }

    public bool DeletarPartitura(int id)
    {
      //if (titulo == "") return new Exception 
      return partituraDal.DeletarPartitura(id);
    }
  }
}
