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
using System.Speech.Synthesis;
using System.Globalization;

namespace Tiresias_V_alfa01
{
  public partial class ucPartiturasSalvas : UserControl
  {
    static CultureInfo ci = new CultureInfo("pt-BR");
    SpeechSynthesizer resposta = new SpeechSynthesizer();
    List<Partitura> part = new List<Partitura>();
    private partituraBLL partituraBLL = new partituraBLL();

    public ucPartiturasSalvas()
    {
      InitializeComponent();
    }

    private void ucPartiturasSalvas_Load(object sender, EventArgs e)
    {
      part = partituraBLL.GetAllPartitura();
      int i = 1;
      foreach (Partitura partitura in part)
      {
        Button btnPart = new Button();
        btnPart.AccessibleName = "partitura " + partitura.Titulo;
        btnPart.Text =  i + " - " + partitura.Titulo;
        btnPart.Font = new Font("Tahoma", 30, FontStyle.Bold);
        btnPart.Location = new Point(50, i * 65 + 1);
        btnPart.AutoSize = false;
        btnPart.Size = new Size(900,60);
        btnPart.Name = partitura.Id.ToString();
        btnPart.BackColor = Color.White;
        btnPart.Click += new EventHandler(this.btnPart_Click);
        panelPartituras.Controls.Add(btnPart);
        i++;
      }
    }

    protected void btnPart_Click(object sender, EventArgs e)
    {
      Button partitura = (sender as Button);
      partituraBLL.auxiliar(int.Parse(partitura.Name));

      if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("ucAuxPartituraSalva"))
      {
        ucAuxPartituraSalva uc = new ucAuxPartituraSalva();
        uc.Dock = DockStyle.Fill;
        frmMain.Instance.MetroContainer.Controls.Add(uc);
      }
      frmMain.Instance.MetroContainer.Controls["ucAuxPartituraSalva"].BringToFront();
      frmMain.Instance.MetroContainer.Controls["ucPartiturasSalvas"].Dispose();
      frmMain.Instance.MetroBack.Visible = true;
    }

  }
}
