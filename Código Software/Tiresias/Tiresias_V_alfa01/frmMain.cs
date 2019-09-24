using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Tiresias_V_alfa01
{
  public partial class frmMain : MetroFramework.Forms.MetroForm
  {
    static CultureInfo ci = new CultureInfo("pt-BR");
    SpeechSynthesizer resposta = new SpeechSynthesizer();

    ucDashboard uc = null;



    static frmMain _instance;

    public frmMain()
    {
      InitializeComponent();
      resposta.Volume = 100;
      resposta.Rate = 1;
    }

    public static frmMain Instance
    {
      get
      {
        if (_instance == null)
        {
          _instance = new frmMain();
        }
        return _instance;
      }

      set
      {
        _instance = value;
      }
    }

    public MetroFramework.Controls.MetroPanel MetroContainer
    {
      get { return mPanel; }
      set { mPanel = value; }
    }

    public MetroFramework.Controls.MetroTile MetroBack
    {
      get { return voltar; }
      set { voltar = value; }
    }

    private void frmMain_Load(object sender, EventArgs e)
    {
      voltar.Visible = false;
      _instance = this;
      uc = new ucDashboard();
      uc.Dock = DockStyle.Fill;
      mPanel.Controls.Add(uc);
    }


    private void voltar_Click(object sender, EventArgs e)
    {
      var result = MessageBox.Show(this, "", "Você tem certeza que deseja voltar ao painel principal?", MessageBoxButtons.YesNo);
      if (result == DialogResult.Yes)
      {
        if (frmMain.Instance.MetroContainer.Controls["ucMusicas"] != null)
        {
          frmMain.Instance.MetroContainer.Controls["ucMusicas"].Dispose();
        }
        if (frmMain.Instance.MetroContainer.Controls["ucPartitura"] != null)
        {
          frmMain.Instance.MetroContainer.Controls["ucPartitura"].Dispose();
        }
        if (frmMain.Instance.MetroContainer.Controls["ucSifras"] != null)
        {
          frmMain.Instance.MetroContainer.Controls["ucSifras"].Dispose();
        }
        if (frmMain.Instance.MetroContainer.Controls["ucPartiturasSalvas"] != null)
        {
          frmMain.Instance.MetroContainer.Controls["ucPartiturasSalvas"].Dispose();
        }
        if (frmMain.Instance.MetroContainer.Controls["ucAuxPartituraSalva"] != null)
        {
          frmMain.Instance.MetroContainer.Controls["ucAuxPartituraSalva"].Dispose();
        }
        if (frmMain.Instance.MetroContainer.Controls["ucLetraPartitura"] != null)
        {
          frmMain.Instance.MetroContainer.Controls["ucLetraPartitura"].Dispose();
        }
        if (frmMain.Instance.MetroContainer.Controls["ucImprimir"] != null)
        {
          frmMain.Instance.MetroContainer.Controls["ucImprimir"].Dispose();
        }
        if (frmMain.Instance.MetroContainer.Controls["ucDeletarPartitura"] != null)
        {
          frmMain.Instance.MetroContainer.Controls["ucDeletarPartitura"].Dispose();
        }
        if (frmMain.Instance.MetroContainer.Controls["ucSelecionarPartituraInserirLetra"] != null)
        {
          frmMain.Instance.MetroContainer.Controls["ucSelecionarPartituraInserirLetra"].Dispose();
        }
        if (frmMain.Instance.MetroContainer.Controls["ucInfo"] != null)
        {
          frmMain.Instance.MetroContainer.Controls["ucInfo"].Dispose();
        }

        uc = new ucDashboard();
        uc.Dock = DockStyle.Fill;
        mPanel.Controls.Add(uc);
        voltar.Visible = false;
      }
    }

    private void frmMain_KeyDown(object sender, KeyEventArgs e)
    {
      if (frmMain.Instance.MetroContainer.Controls["ucDashboard"] == null)
      {
        switch (e.KeyCode)
        {
          case Keys.Escape:
            voltar_Click(sender, e);
            break;
        }
      }
    }
  }
}
