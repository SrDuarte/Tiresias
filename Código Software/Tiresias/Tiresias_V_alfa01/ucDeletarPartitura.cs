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
using System.Globalization;
using System.Speech.Synthesis;
using Tiresias_V_alfa01.appCode.BLL;

namespace Tiresias_V_alfa01
{
  public partial class ucDeletarPartitura : UserControl
  {
    static CultureInfo ci = new CultureInfo("pt-BR");
    SpeechSynthesizer resposta = new SpeechSynthesizer();
    List<Partitura> part = new List<Partitura>();
    partituraBLL partituraBll = new partituraBLL();

    public ucDeletarPartitura()
    {
      InitializeComponent();
    }

    private void ucDeletarPartitura_Load(object sender, EventArgs e)
    {
      gerarBotoes();

    }

    protected void btnPart_Click(object sender, EventArgs e)
    {
      var result = MessageBox.Show(this, "", "Você tem certeza que deseja remover?", MessageBoxButtons.YesNo);
      if (result == DialogResult.Yes)
      {
        Button part = (sender as Button);
        bool verifica = partituraBll.DeletarPartitura(int.Parse(part.Name));
        if (verifica)
          resposta.SpeakAsync("Removido com Sucesso.");
        else
          resposta.SpeakAsync("Problemas ao remover.");

        panelPartituras.Controls.Clear();
        gerarBotoes();
      }
    }

    private void gerarBotoes()
    {
      part = partituraBll.GetAllPartitura();
      if (part.Count > 0)
      {
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
      else
        resposta.SpeakAsync("você não tem partituras salvas.");
    }
  }
}
