using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Tiresias_V_alfa01.appCode
{
  class Pauta
  {
    private List<Nota> notas = new List<Nota>();

    private int SEMIBREVE;
    private int MINIMA;
    private int SEMIMINIMA;
    private int COLCHEIA;

    public Pauta(int tempo)
    {

      SEMIBREVE = tempo;
      MINIMA = SEMIBREVE / 2;
      SEMIMINIMA = MINIMA / 2;
      COLCHEIA = SEMIMINIMA / 2;
    }

    public void ParseLine(string linha)
    {

      foreach (var c in linha.Split(' '))
      {

        var temp = c.Split(',');
        var freq = getFrequencia(temp[0], int.Parse(temp[1]));
        var dur = getDuration(temp[2]);
        notas.Add(new Nota(freq, dur, double.Parse(temp[1])));
      }
    }

    public void Play()
    {

      foreach (Nota n in notas)
      {

        if (n.TomNota == 0)
        {
          Thread.Sleep((int)n.DuracaoNota);
        }
        else
        {
          Console.Beep((int)n.TomNota, (int)n.DuracaoNota);
        }
      }
    }

    public void limpaVetorNotas()
    {
      notas.Clear();
    }

    protected struct Nota
    {

      int valorTom;
      double valorDuracao;
      double oitav;

      public Nota(int frequencia, double tempo, double oitava)
      {

        valorTom = frequencia;
        valorDuracao = tempo;
        oitav = oitava;
      }

      public int TomNota { get { return valorTom; } }
      public double Oitava { get { return oitav; } }
      public double DuracaoNota { get { return valorDuracao; } }

    }

    private double getDuration(string inp)
    {

      switch (inp)
      {

        case "SEMIBREVE":
        case "4":
          return SEMIBREVE;

        case "MINIMA":
        case "2":
          return MINIMA;

        case "SEMIMINIMA":
        case "1":
          return SEMIMINIMA;

        case "COLCHEIA":
        case "0.5":
          return COLCHEIA;

        case "PAUSADESEMIBREVE":
          return SEMIBREVE;

        case "PAUSADEMINIMA":
          return MINIMA;

        case "PAUSADESEMIMINIMA":
          return SEMIMINIMA;

        case "PAUSADECOLCHEIA":
          return COLCHEIA;

        default:
          return 0;
      }
    }

    private int getFrequencia(string nota, double oitava)
    {

      Double output = 0;

      if (oitava < 0.5 || oitava > 6) return 0;

      switch (oitava)
      {
        case 5:
          switch (nota)
          {
            case "DÓVAZIO":
              output = 523.3;
              break;
            case "DÓBEMOL":
              output = 554.4;
              break;
            case "RÉVAZIO":
              output = 587.3;
              break;
            case "RÉBEMOL":
              output = 622.3;
              break;
            case "MIVAZIO":
              output = 659.3;
              break;
            case "MIBEMOL":
              output = 659.3;
              break;
            case "FÁVAZIO":
              output = 698.5;
              break;
            case "FÁBEMOL":
              output = 740.0;
              break;
            case "SOLVAZIO":
              output = 784.0;
              break;
            case "SOLBEMOL":
              output = 830.6;
              break;
            case "LAVAZIO":
              output = 880.0;
              break;
            case "LABEMOL":
              output = 932.3;
              break;
            case "SIVAZIO":
              output = 987.8;
              break;
            case "SIBEMOL":
              output = 987.8;
              break;
            case "PAUSADESEMIBREVE":
              output = 0;
              break;
            case "PAUSADEMINIMA":
              output = 0;
              break;
            case "PAUSADESEMIMINIMA":
              output = 0;
              break;
            case "PAUSADECOLCHEIA":
              output = 0;
              break;
          }
          break;

        case 6:
          switch (nota)
          {
            case "DÓ/OITAVAVAZIO":
              output = 1047;
              break;
            case "DO/OITAVABEMOL":
              output = 1109;
              break;
            case "RÉ/OITAVAVAZIO":
              output = 1175;
              break;
            case "RÉ/OITAVABEMOL":
              output = 1245;
              break;
            case "MI/OITAVAVAZIO":
              output = 1319;
              break;
            case "MI/OITAVABEMOL":
              output = 1319;
              break;
            case "FÁ/OITAVAVAZIO":
              output = 1397;
              break;
            case "FÁ/OITAVABEMOL":
              output = 1480;
              break;
            case "SOL/OITAVAVAZIO":
              output = 1568;
              break;
            case "SOL/OITAVABEMOL":
              output = 1661;
              break;
            case "LA/OITAVAVAZIO":
              output = 1760;
              break;
            case "LA/OITAVABEMOL":
              output = 1865;
              break;
            case "SI/OITAVAVAZIO":
              output = 1976;
              break;
            case "SI/OITAVABEMOL":
              output = 1976;
              break;
            case "PAUSADESEMIBREVE":
              output = 0;
              break;
            case "PAUSADEMINIMA":
              output = 0;
              break;
            case "PAUSADESEMIMINIMA":
              output = 0;
              break;
            case "PAUSADECOLCHEIA":
              output = 0;
              break;
          }
          break;


      }
      return (int)output;
    }

  }
}
