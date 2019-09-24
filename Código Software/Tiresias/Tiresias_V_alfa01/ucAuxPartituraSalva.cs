using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tiresias_V_alfa01.appCode;
using Tiresias_V_alfa01.appCode.BLL;
using System.IO.Ports;
using System.IO;

namespace Tiresias_V_alfa01
{
  public partial class ucAuxPartituraSalva : UserControl
  {
    public ucAuxPartituraSalva()
    {
      InitializeComponent();
    }

    Partitura partitura = new Partitura();
    partituraBLL partituraBll = new partituraBLL();
    retornaSimbolos simbolos = new retornaSimbolos();
    private Pauta pautaMusical = new Pauta(1024);


    private void btnExecutarDispositivoAudio_Click(object sender, EventArgs e)
    {
      if (partitura.Pauta != "")
      {
        pautaMusical.limpaVetorNotas();
        pautaMusical.ParseLine(partitura.Pauta);
        pautaMusical.Play();
      }
    }

    private void ucAuxPartituraSalva_Load(object sender, EventArgs e)
    {
      partitura = partituraBll.GetPartitura();
      txtPartitura.Text = partitura.TextoPartitura + "=";
      txtBraille.Text = partitura.BraillePartitura;
      txtLetra.Text = partitura.LetraPartitura;
      btnExecutarDispositivoAudio.Focus();
    }

    private void btnExecutarDispositivoBraille_Click(object sender, EventArgs e)
    {
      try
      {
        string selectedPort = "COM4";
        SerialPort serialPort1 = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
        serialPort1.Open();
        if (serialPort1.IsOpen)
        {
          string braille = simbolos.traduzBraille(partitura.BraillePartitura);
          serialPort1.WriteLine(braille);
        }
        serialPort1.Close();
      }
      catch (Exception)
      {
       MessageBox.Show(this, "", "Problemas ao conectar com o sistema embarcado, Favor Verifique.", MessageBoxButtons.OK);
      }


      
    }
  }
}
