using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Speech.Recognition;
using System.Globalization;
using Microsoft.Speech.Synthesis;

namespace Tiresias_V_alfa01
{
  public partial class ucDashboard : MetroFramework.Controls.MetroUserControl
  {
    static CultureInfo ci = new CultureInfo("pt-BR");
    SpeechSynthesizer resposta = new SpeechSynthesizer();

    public ucDashboard()
    {
      InitializeComponent();
      resposta.Volume = 100;
      resposta.Rate = 0;
    }

    private void ucDashboard_Load(object sender, EventArgs e)
    {

    }

    private void mtPartitura_Click(object sender, EventArgs e)
    {
      if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("ucPartitura"))
      {
        ucPartitura uc = new ucPartitura();
        uc.Dock = DockStyle.Fill;
        frmMain.Instance.MetroContainer.Controls.Add(uc);
      }
      frmMain.Instance.MetroContainer.Controls["ucPartitura"].BringToFront();
      frmMain.Instance.MetroContainer.Controls["ucDashboard"].Dispose();
      frmMain.Instance.MetroBack.Visible = true;
    }

    
    private void mtRemoverPartitura_Click(object sender, EventArgs e)
    {
      if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("ucDeletarPartitura"))
      {
        ucDeletarPartitura uc = new ucDeletarPartitura();
        uc.Dock = DockStyle.Fill;
        frmMain.Instance.MetroContainer.Controls.Add(uc);
      }
      frmMain.Instance.MetroContainer.Controls["ucDeletarPartitura"].BringToFront();
      frmMain.Instance.MetroContainer.Controls["ucDashboard"].Dispose();
      frmMain.Instance.MetroBack.Visible = true;
    }

    private void btnPartiturasSalvas_Click(object sender, EventArgs e)
    {
      if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("ucPartiturasSalvas"))
      {
        ucPartiturasSalvas uc = new ucPartiturasSalvas();
        uc.Dock = DockStyle.Fill;
        frmMain.Instance.MetroContainer.Controls.Add(uc);
      }
      frmMain.Instance.MetroContainer.Controls["ucPartiturasSalvas"].BringToFront();
      frmMain.Instance.MetroContainer.Controls["ucDashboard"].Dispose();
      frmMain.Instance.MetroBack.Visible = true;
    }

    private void btnSelecionarPartituraInserirLetra_Click(object sender, EventArgs e)
    {
      if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("ucSelecionarPartituraInserirLetra"))
      {
        ucSelecionarPartituraInserirLetra uc = new ucSelecionarPartituraInserirLetra();
        uc.Dock = DockStyle.Fill;
        frmMain.Instance.MetroContainer.Controls.Add(uc);
      }
      frmMain.Instance.MetroContainer.Controls["ucSelecionarPartituraInserirLetra"].BringToFront();
      frmMain.Instance.MetroContainer.Controls["ucDashboard"].Dispose();
      frmMain.Instance.MetroBack.Visible = true;
    }

    private void mtImprimirPartitura_Click(object sender, EventArgs e)
    {
      if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("ucImprimir"))
      {
        ucImprimir uc = new ucImprimir();
        uc.Dock = DockStyle.Fill;
        frmMain.Instance.MetroContainer.Controls.Add(uc);
      }
      frmMain.Instance.MetroContainer.Controls["ucImprimir"].BringToFront();
      frmMain.Instance.MetroContainer.Controls["ucDashboard"].Dispose();
      frmMain.Instance.MetroBack.Visible = true;
    }

    private void mtInfo_Click(object sender, EventArgs e)
    {
      if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("ucInfo"))
      {
        ucInfo uc = new ucInfo();
        uc.Dock = DockStyle.Fill;
        frmMain.Instance.MetroContainer.Controls.Add(uc);
      }
      frmMain.Instance.MetroContainer.Controls["ucInfo"].BringToFront();
      frmMain.Instance.MetroContainer.Controls["ucDashboard"].Dispose();
      frmMain.Instance.MetroBack.Visible = true;
    }
  }
}
