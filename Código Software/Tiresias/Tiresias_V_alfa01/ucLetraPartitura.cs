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
using Tiresias_V_alfa01.appCode;
using Tiresias_V_alfa01.appCode.BLL;

namespace Tiresias_V_alfa01
{
  public partial class ucLetraPartitura : UserControl
  {
    static CultureInfo ci = new CultureInfo("pt-BR");
    SpeechSynthesizer resposta = new SpeechSynthesizer();
    private Pauta pautaMusical = new Pauta(1024);
    Partitura partitura = null;
    private partituraBLL partituraBll = new partituraBLL();

    public ucLetraPartitura()
    {
      InitializeComponent();
      resposta.Volume = 100;
      resposta.Rate = 0;
    }

    private void ucLetraPartitura_Load(object sender, EventArgs e)
    {
      partitura = partituraBll.GetPartitura();
      txtPartitura.Text = partitura.TextoPartitura + "=";
      txtBraille.Text = partitura.BraillePartitura;
      txtLetra.Text = partitura.LetraPartitura;
      txtLetra.Focus();
    }

    private void btnEscutarPartitura_Click(object sender, EventArgs e)
    {
      if (partitura.Pauta != "")
      {
        pautaMusical.limpaVetorNotas();
        pautaMusical.ParseLine(partitura.Pauta);
        pautaMusical.Play();
      }
    }

    private void btnSalvarLetra_Click(object sender, EventArgs e)
    {
      if (txtLetra.Text != "")
      {
        partitura.LetraPartitura = txtLetra.Text;
        bool verifica = partituraBll.AlterarPartitura(partitura);
        if (verifica)
          resposta.SpeakAsync("Projeto Salvo com sucesso.");
        else
          resposta.SpeakAsync("Problemas ao Salvar o Projeto.");
      }
    }

    private void panelPartituras_Paint(object sender, PaintEventArgs e)
    {

    }
  }
}
