using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiresias_V_alfa01.appCode
{
  class Partitura
  {
    private int id;
    private string titulo;
    private string compasso;
    private string textoPartitura;
    private string pauta;
    private string braillePartitura;
    private string letraPartitura;

    public int Id { get => id; set => id = value; }
    public string Titulo { get => titulo; set => titulo = value; }
    public string Compasso { get => compasso; set => compasso = value; }
    public string TextoPartitura { get => textoPartitura; set => textoPartitura = value; }
    public string Pauta { get => pauta; set => pauta = value; }
    public string BraillePartitura { get => braillePartitura; set => braillePartitura = value; }
    public string LetraPartitura { get => letraPartitura; set => letraPartitura = value; }
  }
}
