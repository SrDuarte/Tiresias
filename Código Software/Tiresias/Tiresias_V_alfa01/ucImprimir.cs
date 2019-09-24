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
  public partial class ucImprimir : UserControl
  {
    static CultureInfo ci = new CultureInfo("pt-BR");
    SpeechSynthesizer resposta = new SpeechSynthesizer();
    List<Partitura> part = new List<Partitura>();
    Partitura partitura = new Partitura();
    private GerarPDF gerarPDF = new GerarPDF();
    partituraBLL partituraBll = new partituraBLL();

    public ucImprimir()
    {
      InitializeComponent();
    }

    private void ucImprimir_Load(object sender, EventArgs e)
    {
      part = partituraBll.GetAllPartitura();
      int i = 1;
      foreach (Partitura partitura in part)
      {
        Button btnPart = new Button();
        btnPart.AccessibleName = "partitura " + partitura.Titulo;
        btnPart.Text = i + " - " + partitura.Titulo;
        btnPart.Font = new Font("Tahoma", 30, FontStyle.Bold);
        btnPart.Location = new Point(50, i * 65 + 1);
        btnPart.AutoSize = false;
        btnPart.Size = new Size(900, 60);
        btnPart.Name = partitura.Id.ToString();
        btnPart.BackColor = Color.White;
        btnPart.Click += new EventHandler(this.btnPart_Click);
        panelPartituras.Controls.Add(btnPart);
        i++;
      }
    }

    protected void btnPart_Click(object sender, EventArgs e)
    {
      Button part = (sender as Button);
      partituraBll.auxiliar(int.Parse(part.Name));

      partitura = partituraBll.GetPartitura();
      gerarPDF.getPdfPartitura(partitura);
    }
  }
}
