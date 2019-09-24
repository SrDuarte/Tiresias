using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Speech.Synthesis;

namespace Tiresias_V_alfa01
{
  public partial class ucInfo : UserControl
  {

    static CultureInfo ci = new CultureInfo("pt-BR");
    SpeechSynthesizer resposta = new SpeechSynthesizer();

    public ucInfo()
    {
      InitializeComponent();
      resposta.Volume = 100;
      resposta.Rate = 0;
    }

    private void ucInfo_Load(object sender, EventArgs e)
    {
      resposta.SpeakAsync("software tirésias, sistema de musicografia braile. Projeto desenvolvido para o trabalho de conclusão de curso do curso de ciência da computação, faculdade unifenas. desenvolvedores, cleiton de sousa, douglas tibúrcio, rafael duarte. orientadores, professor mestre francisco donizeti vieira luz , e professor mestre celso de avila ramos.");
    }
  }
}
