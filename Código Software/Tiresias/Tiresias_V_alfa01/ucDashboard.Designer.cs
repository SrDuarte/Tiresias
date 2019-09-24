namespace Tiresias_V_alfa01
{
  partial class ucDashboard
  {
    /// <summary> 
    /// Variável de designer necessária.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Limpar os recursos que estão sendo usados.
    /// </summary>
    /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código gerado pelo Designer de Componentes

    /// <summary> 
    /// Método necessário para suporte ao Designer - não modifique 
    /// o conteúdo deste método com o editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDashboard));
      this.mtPartitura = new MetroFramework.Controls.MetroTile();
      this.btnPartiturasSalvas = new MetroFramework.Controls.MetroTile();
      this.mtRemoverPartitura = new MetroFramework.Controls.MetroTile();
      this.mtImprimirPartitura = new MetroFramework.Controls.MetroTile();
      this.btnSelecionarPartituraInserirLetra = new MetroFramework.Controls.MetroTile();
      this.mtInfo = new MetroFramework.Controls.MetroTile();
      this.SuspendLayout();
      // 
      // mtPartitura
      // 
      this.mtPartitura.AccessibleDescription = "criar nova partitura";
      this.mtPartitura.AccessibleName = "criar nova partitura";
      this.mtPartitura.ActiveControl = null;
      this.mtPartitura.Location = new System.Drawing.Point(139, 106);
      this.mtPartitura.Name = "mtPartitura";
      this.mtPartitura.Size = new System.Drawing.Size(226, 109);
      this.mtPartitura.Style = MetroFramework.MetroColorStyle.Teal;
      this.mtPartitura.TabIndex = 0;
      this.mtPartitura.Text = "Criar Nova Partitura";
      this.mtPartitura.TileImage = global::Tiresias_V_alfa01.Properties.Resources.partitura;
      this.mtPartitura.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.mtPartitura.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
      this.mtPartitura.UseSelectable = true;
      this.mtPartitura.UseTileImage = true;
      this.mtPartitura.Click += new System.EventHandler(this.mtPartitura_Click);
      // 
      // btnPartiturasSalvas
      // 
      this.btnPartiturasSalvas.AccessibleDescription = "executar partitura";
      this.btnPartiturasSalvas.AccessibleName = "executar partitura";
      this.btnPartiturasSalvas.ActiveControl = null;
      this.btnPartiturasSalvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(213)))), ((int)(((byte)(125)))));
      this.btnPartiturasSalvas.Location = new System.Drawing.Point(255, 221);
      this.btnPartiturasSalvas.Name = "btnPartiturasSalvas";
      this.btnPartiturasSalvas.Size = new System.Drawing.Size(110, 110);
      this.btnPartiturasSalvas.Style = MetroFramework.MetroColorStyle.Teal;
      this.btnPartiturasSalvas.TabIndex = 2;
      this.btnPartiturasSalvas.Text = "Executar Part";
      this.btnPartiturasSalvas.TileImage = global::Tiresias_V_alfa01.Properties.Resources.braille;
      this.btnPartiturasSalvas.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.btnPartiturasSalvas.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
      this.btnPartiturasSalvas.UseSelectable = true;
      this.btnPartiturasSalvas.UseTileImage = true;
      this.btnPartiturasSalvas.Click += new System.EventHandler(this.btnPartiturasSalvas_Click);
      // 
      // mtRemoverPartitura
      // 
      this.mtRemoverPartitura.AccessibleDescription = "remover partitura";
      this.mtRemoverPartitura.AccessibleName = "remover partitura";
      this.mtRemoverPartitura.ActiveControl = null;
      this.mtRemoverPartitura.Location = new System.Drawing.Point(255, 337);
      this.mtRemoverPartitura.Name = "mtRemoverPartitura";
      this.mtRemoverPartitura.Size = new System.Drawing.Size(110, 110);
      this.mtRemoverPartitura.Style = MetroFramework.MetroColorStyle.Teal;
      this.mtRemoverPartitura.TabIndex = 4;
      this.mtRemoverPartitura.Text = "Remover Part";
      this.mtRemoverPartitura.TileImage = global::Tiresias_V_alfa01.Properties.Resources.removerNota;
      this.mtRemoverPartitura.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.mtRemoverPartitura.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
      this.mtRemoverPartitura.UseSelectable = true;
      this.mtRemoverPartitura.UseTileImage = true;
      this.mtRemoverPartitura.Click += new System.EventHandler(this.mtRemoverPartitura_Click);
      // 
      // mtImprimirPartitura
      // 
      this.mtImprimirPartitura.AccessibleDescription = "imprimir partitura";
      this.mtImprimirPartitura.AccessibleName = "imprimir partitura";
      this.mtImprimirPartitura.ActiveControl = null;
      this.mtImprimirPartitura.Location = new System.Drawing.Point(139, 337);
      this.mtImprimirPartitura.Name = "mtImprimirPartitura";
      this.mtImprimirPartitura.Size = new System.Drawing.Size(110, 110);
      this.mtImprimirPartitura.Style = MetroFramework.MetroColorStyle.Teal;
      this.mtImprimirPartitura.TabIndex = 3;
      this.mtImprimirPartitura.Text = "Imprimir Part";
      this.mtImprimirPartitura.TileImage = global::Tiresias_V_alfa01.Properties.Resources.imprimirPartitura;
      this.mtImprimirPartitura.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.mtImprimirPartitura.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
      this.mtImprimirPartitura.UseSelectable = true;
      this.mtImprimirPartitura.UseTileImage = true;
      this.mtImprimirPartitura.Click += new System.EventHandler(this.mtImprimirPartitura_Click);
      // 
      // btnSelecionarPartituraInserirLetra
      // 
      this.btnSelecionarPartituraInserirLetra.AccessibleDescription = "inserir letra a uma partitura";
      this.btnSelecionarPartituraInserirLetra.AccessibleName = "inserir letra a uma partitura";
      this.btnSelecionarPartituraInserirLetra.ActiveControl = null;
      this.btnSelecionarPartituraInserirLetra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(213)))), ((int)(((byte)(125)))));
      this.btnSelecionarPartituraInserirLetra.Location = new System.Drawing.Point(139, 221);
      this.btnSelecionarPartituraInserirLetra.Name = "btnSelecionarPartituraInserirLetra";
      this.btnSelecionarPartituraInserirLetra.Size = new System.Drawing.Size(110, 110);
      this.btnSelecionarPartituraInserirLetra.Style = MetroFramework.MetroColorStyle.Teal;
      this.btnSelecionarPartituraInserirLetra.TabIndex = 1;
      this.btnSelecionarPartituraInserirLetra.Text = "Inserir Letra";
      this.btnSelecionarPartituraInserirLetra.TileImage = global::Tiresias_V_alfa01.Properties.Resources.addNota;
      this.btnSelecionarPartituraInserirLetra.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.btnSelecionarPartituraInserirLetra.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
      this.btnSelecionarPartituraInserirLetra.UseSelectable = true;
      this.btnSelecionarPartituraInserirLetra.UseTileImage = true;
      this.btnSelecionarPartituraInserirLetra.Click += new System.EventHandler(this.btnSelecionarPartituraInserirLetra_Click);
      // 
      // mtInfo
      // 
      this.mtInfo.AccessibleDescription = "infomações do software";
      this.mtInfo.AccessibleName = "infomações do software";
      this.mtInfo.ActiveControl = null;
      this.mtInfo.Location = new System.Drawing.Point(139, 453);
      this.mtInfo.Name = "mtInfo";
      this.mtInfo.Size = new System.Drawing.Size(110, 110);
      this.mtInfo.Style = MetroFramework.MetroColorStyle.Teal;
      this.mtInfo.TabIndex = 5;
      this.mtInfo.Text = "Sobre";
      this.mtInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.mtInfo.TileImage = global::Tiresias_V_alfa01.Properties.Resources.info;
      this.mtInfo.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.mtInfo.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
      this.mtInfo.UseSelectable = true;
      this.mtInfo.UseTileImage = true;
      this.mtInfo.Click += new System.EventHandler(this.mtInfo_Click);
      // 
      // ucDashboard
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoScroll = true;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.Controls.Add(this.mtInfo);
      this.Controls.Add(this.mtPartitura);
      this.Controls.Add(this.btnSelecionarPartituraInserirLetra);
      this.Controls.Add(this.btnPartiturasSalvas);
      this.Controls.Add(this.mtRemoverPartitura);
      this.Controls.Add(this.mtImprimirPartitura);
      this.DoubleBuffered = true;
      this.Name = "ucDashboard";
      this.Size = new System.Drawing.Size(882, 574);
      this.Load += new System.EventHandler(this.ucDashboard_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private MetroFramework.Controls.MetroTile mtPartitura;
    private MetroFramework.Controls.MetroTile btnPartiturasSalvas;
    private MetroFramework.Controls.MetroTile mtRemoverPartitura;
    private MetroFramework.Controls.MetroTile mtImprimirPartitura;
    private MetroFramework.Controls.MetroTile btnSelecionarPartituraInserirLetra;
    private MetroFramework.Controls.MetroTile mtInfo;
  }
}
