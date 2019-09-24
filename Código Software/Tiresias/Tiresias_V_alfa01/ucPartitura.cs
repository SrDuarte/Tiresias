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
using Tiresias_V_alfa01.appCode.BLL;
using Tiresias_V_alfa01.appCode;

namespace Tiresias_V_alfa01
{
  public partial class ucPartitura : UserControl
  {
    static CultureInfo ci = new CultureInfo("pt-BR");
    SpeechSynthesizer resposta = new SpeechSynthesizer();

    private Boolean isClave = true;
    private string compasso = "";
    private partituraBLL partituraBLL = new partituraBLL();
    private retornaSimbolos retornaSimbolos = new retornaSimbolos();
    private Pauta pautaMusical = new Pauta(1024);
    Partitura partitura = null;
    private double tempoCompasso = 4;
    List<double> Listacompasso = new List<double>();
    List<string> ListaPauta = new List<string>();
    string pauta = "";

    public ucPartitura()
    {
      InitializeComponent();
      resposta.Volume = 100;
      resposta.Rate = 0;
    }

    private void ucPartitura_Load(object sender, EventArgs e)
    {
      isClave = true;
      btnAddNovaNota.Focus();
    }

    private void btnAddNovaNota_Click(object sender, EventArgs e)
    {
      inserirNovaNota();
    }


    private void inserirNovaNota()
    {
      panelPrincipal.Enabled = false;
      panelAddNota.Visible = true;
      if (isClave)
      {
        ddlClave.Enabled = true;
        ddlCompasso.Enabled = true;
        ddlNota.Enabled = false;
        ddlAcidente.Enabled = false;
        ddlTempo.Enabled = false;
        ddlClave.SelectedIndex = 0;
        ddlCompasso.SelectedIndex = 0;
        ddlClave.Focus();
      }
      else
      {
        ddlClave.Enabled = false;
        ddlCompasso.Enabled = false;
        ddlNota.Enabled = true;
        ddlAcidente.Enabled = true;
        ddlTempo.Enabled = true;
        ddlNota.SelectedIndex = 0;
        ddlAcidente.SelectedIndex = 0;
        ddlTempo.SelectedIndex = 0;
        ddlNota.Focus();
      }
    }

    private void ddlClave_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void ddlCompasso_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void ddlNota_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void ddlAcidente_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (ddlAcidente.SelectedIndex == 0)
      {
        List<string> lista = new List<string>();

        lista.Add("SEMIBREVE");
        lista.Add("MINIMA");
        lista.Add("SEMIMINIMA");
        lista.Add("COLCHEIA");
        lista.Add("PAUSA DE SEMIBREVE");
        lista.Add("PAUSA DE MINIMA");
        lista.Add("PAUSA DE SEMIMININA");
        lista.Add("PAUSA DE COLCHEIA");


        ddlTempo.DataSource = lista;

      }
      if (ddlAcidente.SelectedIndex == 1)
      {
        List<string> lista = new List<string>();

        lista.Add("SEMIBREVE");
        lista.Add("MINIMA");
        lista.Add("SEMIMINIMA");
        lista.Add("COLCHEIA");
        ddlTempo.DataSource = lista;
      }
    }

    private void ddlTempo_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void ddlClave_Enter(object sender, EventArgs e)
    {
      ddlClave.DroppedDown = true;
    }

    private void ddlCompasso_Enter(object sender, EventArgs e)
    {
      ddlCompasso.DroppedDown = true;
    }

    private void ddlNota_Enter(object sender, EventArgs e)
    {
      ddlNota.DroppedDown = true;
    }

    private void ddlAcidente_Enter(object sender, EventArgs e)
    {
      ddlAcidente.DroppedDown = true;
    }

    private void ddlTempo_Enter(object sender, EventArgs e)
    {
      ddlTempo.DroppedDown = true;
    }

    private void btnAddNota_Click(object sender, EventArgs e)
    {
      adicionarNota();

    }

    private void adicionarNota()
    {
      if (isClave)
      {
        string retornoFuncao = retornaSimbolos.getClave(ddlClave.SelectedItem + "#" + ddlCompasso.SelectedItem);
        string[] split = retornoFuncao.Split('#');
        if (split.Length > 0)
        {
          txtPartitura.Text = split[0];
          txtBraille.Text = split[1];
        }
      }
      else
      {
        string retornoFuncao = retornaSimbolos.getNota(ddlNota.SelectedItem + "#" + ddlAcidente.SelectedItem + "#" + ddlTempo.SelectedItem);
        string[] split = retornoFuncao.Split('#');
        if (split.Length > 0)
        {
          double auxCompasso = double.Parse(split[0]);

          if (tempoCompasso >= auxCompasso)
          {
            txtPartitura.Text += split[1];
            
            if (ddlTempo.SelectedIndex > 3)
            {
              pauta += ddlTempo.SelectedItem.ToString().Replace(" ","") + "," + (ddlNota.SelectedIndex > 6 ? 6 : 5) + "," + ddlTempo.SelectedItem.ToString().Replace(" ", "") + " ";
            }
            else
            {
              pauta += ddlNota.SelectedItem.ToString() + ddlAcidente.SelectedItem.ToString() + ","+ (ddlNota.SelectedIndex > 6 ? 6 : 5) + "," + ddlTempo.SelectedItem.ToString().Replace(" ", "") + " ";
            }
            tempoCompasso -= auxCompasso;
          }
          else
          {
            switch (tempoCompasso)
            {
              case 0.5:
                pauta += "PAUSADECOLCHEIA,5,COLCHEIA ";
                txtPartitura.Text += "7";
                tempoCompasso -= 0.5;
                break;

              case 1:
                pauta += "PAUSADESEMIMINIMA,5,SEMIMINIMA ";
                txtPartitura.Text += "8";
                tempoCompasso -= 1;
                break;

              case 1.5:
                pauta += "PAUSADESEMIMINIMA,5,SEMIMINIMA PAUSADECOLCHEIA,5,COLCHEIA ";
                txtPartitura.Text += "78";
                tempoCompasso -= 1.5;
                break;

              case 2:
                pauta += "PAUSADEMINIMA,5,MINIMA ";
                txtPartitura.Text += "9";
                tempoCompasso -= 2;
                break;

              case 2.5:
                pauta += "PAUSADEMINIMA,5,MINIMA PAUSADECOLCHEIA,5,COLCHEIA ";
                txtPartitura.Text += "97";
                tempoCompasso -= 2.5;
                break;

              case 3:
                pauta += "PAUSADEMINIMA,5,MINIMA PAUSADESEMIMINIMA,5,SEMIMINIMA ";
                txtPartitura.Text += "98";
                tempoCompasso -= 3;
                break;
              case 3.5:
                pauta += "PAUSADEMINIMA,5,MINIMA PAUSADESEMIMINIMA,5,SEMIMINIMA PAUSADECOLCHEIA,5,COLCHEIA ";
                txtPartitura.Text += "987";
                tempoCompasso -= 3.5;
                break;
              case 0:
                
                break;
            }
            pauta = pauta.Substring(0, pauta.Length - 1);
            ListaPauta.Add(pauta);
            pauta = "";
            Listacompasso.Add(tempoCompasso);
            txtPartitura.Text += "-" + split[1];
            if (ddlTempo.SelectedIndex > 3)
            {
              pauta += ddlTempo.SelectedItem.ToString().Replace(" ", "") + "," + (ddlNota.SelectedIndex > 6 ? 6 : 5) + "," + ddlTempo.SelectedItem.ToString().Replace(" ", "") + " ";
            }
            else
            {
              pauta += ddlNota.SelectedItem.ToString() + ddlAcidente.SelectedItem.ToString() + "," + (ddlNota.SelectedIndex > 6 ? 6 : 5) + "," + ddlTempo.SelectedItem.ToString().Replace(" ", "") + " ";
            }
            tempoCompasso = 4 - auxCompasso;
          }
          if (tempoCompasso == 0)
          {
            pauta = pauta.Substring(0, pauta.Length - 1);
            ListaPauta.Add(pauta);
            pauta = "";
            Listacompasso.Add(tempoCompasso);
            txtPartitura.Text += "-";
            tempoCompasso = 4;
          }
          txtBraille.Text += split[2];

          
        }
        
      }
      if (txtPartitura.Text.Length > 0)
      {
        isClave = false;
      }
      recolheDropDown();
    }
    private void btnHabilitaSalvarPartitura_Click(object sender, EventArgs e)
    {
      if (partitura != null)
      {
        UpdatePartitura();
      }
      else
      {
        panelPrincipal.Visible = false;
        panelSalvarPartitura.Enabled = true;
        panelSalvarPartitura.Visible = true;
        txtSalvarPartitura.Focus();
      }
    }
    private void btnSalvarPartitura_Click(object sender, EventArgs e)
    {
      if (txtSalvarPartitura.Text.Length > 2)
      {
        SalvarPartitura();
        panelPrincipal.Visible = true;
        panelSalvarPartitura.Enabled = false;
        panelSalvarPartitura.Visible = false;
        txtSalvarPartitura.Text = "";
        btnAddNovaNota.Focus();
      }
      else
      {
        resposta.SpeakAsync("o nome da partitura deve contem no minímo 3 letras");
        txtSalvarPartitura.Focus();
      }
    }

    private void txtSalvarPartitura_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        if (txtSalvarPartitura.Text.Length > 2)
        {
          SalvarPartitura();
          panelPrincipal.Visible = true;
          panelSalvarPartitura.Enabled = false;
          panelSalvarPartitura.Visible = false;
          txtSalvarPartitura.Text = "";
          btnAddNovaNota.Focus();
        }
        else
        {
          resposta.SpeakAsync("o nome da partitura deve contem no minímo 3 letras");
          txtSalvarPartitura.Focus();
        }
      }
    }

    private void SalvarPartitura()
    {
      partitura = new Partitura();
      carregaDados();
      int retorno = partituraBLL.InsirirPartitura(partitura);
      if (retorno > 0)
      {
        partitura.Id = retorno;
        resposta.Speak("Projeto Salvo com sucesso.");
      }
      else
        resposta.Speak("Problemas ao Salvar o Projeto.");
    }
    private void UpdatePartitura()
    {
      carregaDados();
      bool verifica = partituraBLL.AlterarPartitura(partitura);
      if (verifica)
        resposta.Speak("Projeto Salvo com sucesso.");
      else
        resposta.Speak("Problemas ao Salvar o Projeto.");
    }
    private void carregaDados()
    {
      partitura.Titulo = txtSalvarPartitura.Text;
      partitura.Compasso = compasso;
      partitura.TextoPartitura = txtPartitura.Text;
      partitura.BraillePartitura = txtBraille.Text;
      partitura.LetraPartitura = "";
      if (tempoCompasso != 4)
      {
        pauta = pauta.Substring(0, pauta.Length - 1);
        ListaPauta.Add(pauta);
      }
      string auxPauta = "";
      if (ListaPauta.Count > 0)
      {
        for (int i = 0; i < ListaPauta.Count; i++)
        {
          auxPauta += i == ListaPauta.Count - 1 ? ListaPauta[i].ToString() : (ListaPauta[i].ToString() + " ");
        }
      }
      partitura.Pauta = auxPauta;
    }

    private void ucPartitura_KeyDown(object sender, KeyEventArgs e)
    {

      if (e.Control && e.KeyCode == Keys.S)
        SalvarPartitura();
    }

    private void btnDeletarNota_Click(object sender, EventArgs e)
    {
      deletarTempo();
    }

    private void deletarTempo()
    {
      if (tempoCompasso != 4)
      {
        Listacompasso.Add(tempoCompasso);
        ListaPauta.Add(pauta);
        pauta = "";
      }
      if (Listacompasso.Count == 0)
      {
        txtPartitura.Text = "";
        txtBraille.Text = "";
        pauta = "";
        ListaPauta.Clear();
        Listacompasso.Clear();
        tempoCompasso = 4;
      }
      if (Listacompasso.Count == 1)
      {
        txtPartitura.Text = "`4";
        txtBraille.Text = "ãíl";
        Listacompasso.Clear();
        ListaPauta.Clear();
        pauta = "";
        tempoCompasso = 4;
      }
      if (Listacompasso.Count > 1 )
      {
        string letra = txtPartitura.Text.Substring(txtPartitura.Text.Length - 1);
        if (letra == "-")
        {
          txtPartitura.Text = txtPartitura.Text.Substring(0, txtPartitura.Text.Length - 1);
        }
        letra = txtPartitura.Text.Substring(txtPartitura.Text.Length - 1);
        int totalBrailleRemovido = 0;
        while (letra != "-")
        {
          txtPartitura.Text = txtPartitura.Text.Substring(0, txtPartitura.Text.Length - 1);
          letra = txtPartitura.Text.Substring(txtPartitura.Text.Length - 1);
          totalBrailleRemovido++;
        }
        txtBraille.Text = txtBraille.Text.Substring(0, txtBraille.Text.Length - totalBrailleRemovido);
        Listacompasso.RemoveAt(Listacompasso.Count - 1);
        ListaPauta.RemoveAt(ListaPauta.Count - 1);
        pauta = "";
        tempoCompasso = 4;
      }


      if (txtPartitura.Text.Length == 0)
      {
        isClave = true;
      }
    }

    private void btnCancelarAddNota_Click(object sender, EventArgs e)
    {
      recolheDropDown();
    }

    private void recolheDropDown()
    {
      panelPrincipal.Enabled = true;
      panelAddNota.Visible = false;
      ddlClave.DroppedDown = false;
      ddlCompasso.DroppedDown = false;
      ddlNota.DroppedDown = false;
      ddlAcidente.DroppedDown = false;
      ddlTempo.DroppedDown = false;
      btnAddNovaNota.Focus();
    }

    private void btnCancelarSalvar_Click(object sender, EventArgs e)
    {
      panelPrincipal.Visible = true;
      panelSalvarPartitura.Enabled = false;
      panelSalvarPartitura.Visible = false;
      txtSalvarPartitura.Text = "";
      btnAddNovaNota.Focus();
    }

    private void btnEscutarPartitura_Click(object sender, EventArgs e)
    {
      if (ListaPauta.Count > 0)
      {
        pautaMusical.limpaVetorNotas();
        foreach (string pauta in ListaPauta)
        {
          pautaMusical.ParseLine(pauta);
        }
        pautaMusical.Play();
      }
    }
  }
}
