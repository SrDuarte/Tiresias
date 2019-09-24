namespace Tiresias_V_alfa01
{
  partial class ucPartitura
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPartitura));
      this.txtPartitura = new System.Windows.Forms.TextBox();
      this.panelPrincipal = new MetroFramework.Controls.MetroPanel();
      this.btnHabilitaSalvarPartitura = new MetroFramework.Controls.MetroTile();
      this.btnEscutarPartitura = new MetroFramework.Controls.MetroTile();
      this.btnDeletarNota = new MetroFramework.Controls.MetroTile();
      this.btnAddNovaNota = new MetroFramework.Controls.MetroTile();
      this.panelAddNota = new MetroFramework.Controls.MetroPanel();
      this.btnCancelarAddNota = new MetroFramework.Controls.MetroTile();
      this.btnAddNota = new MetroFramework.Controls.MetroTile();
      this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
      this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
      this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
      this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
      this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
      this.ddlTempo = new MetroFramework.Controls.MetroComboBox();
      this.ddlAcidente = new MetroFramework.Controls.MetroComboBox();
      this.ddlNota = new MetroFramework.Controls.MetroComboBox();
      this.ddlCompasso = new MetroFramework.Controls.MetroComboBox();
      this.ddlClave = new MetroFramework.Controls.MetroComboBox();
      this.panelSalvarPartitura = new MetroFramework.Controls.MetroPanel();
      this.txtSalvarPartitura = new System.Windows.Forms.TextBox();
      this.btnCancelarSalvar = new MetroFramework.Controls.MetroTile();
      this.btnSalvarPartitura = new MetroFramework.Controls.MetroTile();
      this.txtBraille = new System.Windows.Forms.TextBox();
      this.panelPrincipal.SuspendLayout();
      this.panelAddNota.SuspendLayout();
      this.panelSalvarPartitura.SuspendLayout();
      this.SuspendLayout();
      // 
      // txtPartitura
      // 
      this.txtPartitura.AccessibleDescription = " ";
      this.txtPartitura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtPartitura.Enabled = false;
      this.txtPartitura.Font = new System.Drawing.Font("Lassus", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtPartitura.ForeColor = System.Drawing.Color.Black;
      this.txtPartitura.Location = new System.Drawing.Point(56, 107);
      this.txtPartitura.Multiline = true;
      this.txtPartitura.Name = "txtPartitura";
      this.txtPartitura.Size = new System.Drawing.Size(871, 228);
      this.txtPartitura.TabIndex = 0;
      // 
      // panelPrincipal
      // 
      this.panelPrincipal.Controls.Add(this.btnHabilitaSalvarPartitura);
      this.panelPrincipal.Controls.Add(this.btnEscutarPartitura);
      this.panelPrincipal.Controls.Add(this.btnDeletarNota);
      this.panelPrincipal.Controls.Add(this.btnAddNovaNota);
      this.panelPrincipal.HorizontalScrollbarBarColor = true;
      this.panelPrincipal.HorizontalScrollbarHighlightOnWheel = false;
      this.panelPrincipal.HorizontalScrollbarSize = 10;
      this.panelPrincipal.Location = new System.Drawing.Point(56, 19);
      this.panelPrincipal.Name = "panelPrincipal";
      this.panelPrincipal.Size = new System.Drawing.Size(871, 85);
      this.panelPrincipal.TabIndex = 1;
      this.panelPrincipal.VerticalScrollbarBarColor = true;
      this.panelPrincipal.VerticalScrollbarHighlightOnWheel = false;
      this.panelPrincipal.VerticalScrollbarSize = 10;
      // 
      // btnHabilitaSalvarPartitura
      // 
      this.btnHabilitaSalvarPartitura.AccessibleDescription = "salvar partitura";
      this.btnHabilitaSalvarPartitura.AccessibleName = "salvar partitura";
      this.btnHabilitaSalvarPartitura.ActiveControl = null;
      this.btnHabilitaSalvarPartitura.Location = new System.Drawing.Point(287, 3);
      this.btnHabilitaSalvarPartitura.Name = "btnHabilitaSalvarPartitura";
      this.btnHabilitaSalvarPartitura.Size = new System.Drawing.Size(89, 79);
      this.btnHabilitaSalvarPartitura.Style = MetroFramework.MetroColorStyle.Teal;
      this.btnHabilitaSalvarPartitura.TabIndex = 3;
      this.btnHabilitaSalvarPartitura.TileImage = global::Tiresias_V_alfa01.Properties.Resources.salvarPartitura;
      this.btnHabilitaSalvarPartitura.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.btnHabilitaSalvarPartitura.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
      this.btnHabilitaSalvarPartitura.UseSelectable = true;
      this.btnHabilitaSalvarPartitura.UseTileImage = true;
      this.btnHabilitaSalvarPartitura.Click += new System.EventHandler(this.btnHabilitaSalvarPartitura_Click);
      // 
      // btnEscutarPartitura
      // 
      this.btnEscutarPartitura.AccessibleDescription = "escutar toda partitura";
      this.btnEscutarPartitura.AccessibleName = "escutar toda partitura";
      this.btnEscutarPartitura.ActiveControl = null;
      this.btnEscutarPartitura.Location = new System.Drawing.Point(193, 3);
      this.btnEscutarPartitura.Name = "btnEscutarPartitura";
      this.btnEscutarPartitura.Size = new System.Drawing.Size(89, 79);
      this.btnEscutarPartitura.Style = MetroFramework.MetroColorStyle.Teal;
      this.btnEscutarPartitura.TabIndex = 2;
      this.btnEscutarPartitura.TileImage = global::Tiresias_V_alfa01.Properties.Resources.audio;
      this.btnEscutarPartitura.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.btnEscutarPartitura.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
      this.btnEscutarPartitura.UseSelectable = true;
      this.btnEscutarPartitura.UseTileImage = true;
      this.btnEscutarPartitura.Click += new System.EventHandler(this.btnEscutarPartitura_Click);
      // 
      // btnDeletarNota
      // 
      this.btnDeletarNota.AccessibleDescription = "excluir compasso";
      this.btnDeletarNota.AccessibleName = "excluir compasso";
      this.btnDeletarNota.ActiveControl = null;
      this.btnDeletarNota.Location = new System.Drawing.Point(98, 3);
      this.btnDeletarNota.Name = "btnDeletarNota";
      this.btnDeletarNota.Size = new System.Drawing.Size(89, 79);
      this.btnDeletarNota.Style = MetroFramework.MetroColorStyle.Teal;
      this.btnDeletarNota.TabIndex = 1;
      this.btnDeletarNota.TileImage = ((System.Drawing.Image)(resources.GetObject("btnDeletarNota.TileImage")));
      this.btnDeletarNota.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.btnDeletarNota.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
      this.btnDeletarNota.UseSelectable = true;
      this.btnDeletarNota.UseTileImage = true;
      this.btnDeletarNota.Click += new System.EventHandler(this.btnDeletarNota_Click);
      // 
      // btnAddNovaNota
      // 
      this.btnAddNovaNota.AccessibleDescription = "Adicionar nova nota musical";
      this.btnAddNovaNota.AccessibleName = "Adicionar nova nota musical";
      this.btnAddNovaNota.ActiveControl = null;
      this.btnAddNovaNota.Location = new System.Drawing.Point(3, 3);
      this.btnAddNovaNota.Name = "btnAddNovaNota";
      this.btnAddNovaNota.Size = new System.Drawing.Size(89, 79);
      this.btnAddNovaNota.Style = MetroFramework.MetroColorStyle.Teal;
      this.btnAddNovaNota.TabIndex = 0;
      this.btnAddNovaNota.TileImage = ((System.Drawing.Image)(resources.GetObject("btnAddNovaNota.TileImage")));
      this.btnAddNovaNota.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.btnAddNovaNota.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
      this.btnAddNovaNota.UseSelectable = true;
      this.btnAddNovaNota.UseTileImage = true;
      this.btnAddNovaNota.Click += new System.EventHandler(this.btnAddNovaNota_Click);
      // 
      // panelAddNota
      // 
      this.panelAddNota.BackColor = System.Drawing.Color.Silver;
      this.panelAddNota.Controls.Add(this.btnCancelarAddNota);
      this.panelAddNota.Controls.Add(this.btnAddNota);
      this.panelAddNota.Controls.Add(this.metroLabel5);
      this.panelAddNota.Controls.Add(this.metroLabel4);
      this.panelAddNota.Controls.Add(this.metroLabel3);
      this.panelAddNota.Controls.Add(this.metroLabel2);
      this.panelAddNota.Controls.Add(this.metroLabel1);
      this.panelAddNota.Controls.Add(this.ddlTempo);
      this.panelAddNota.Controls.Add(this.ddlAcidente);
      this.panelAddNota.Controls.Add(this.ddlNota);
      this.panelAddNota.Controls.Add(this.ddlCompasso);
      this.panelAddNota.Controls.Add(this.ddlClave);
      this.panelAddNota.HorizontalScrollbarBarColor = true;
      this.panelAddNota.HorizontalScrollbarHighlightOnWheel = false;
      this.panelAddNota.HorizontalScrollbarSize = 10;
      this.panelAddNota.Location = new System.Drawing.Point(56, 475);
      this.panelAddNota.Name = "panelAddNota";
      this.panelAddNota.Size = new System.Drawing.Size(871, 85);
      this.panelAddNota.TabIndex = 2;
      this.panelAddNota.VerticalScrollbarBarColor = true;
      this.panelAddNota.VerticalScrollbarHighlightOnWheel = false;
      this.panelAddNota.VerticalScrollbarSize = 10;
      this.panelAddNota.Visible = false;
      // 
      // btnCancelarAddNota
      // 
      this.btnCancelarAddNota.AccessibleDescription = "cancelar inserção nota";
      this.btnCancelarAddNota.AccessibleName = "cancelar inserção nota";
      this.btnCancelarAddNota.ActiveControl = null;
      this.btnCancelarAddNota.Location = new System.Drawing.Point(761, 6);
      this.btnCancelarAddNota.Name = "btnCancelarAddNota";
      this.btnCancelarAddNota.Size = new System.Drawing.Size(89, 76);
      this.btnCancelarAddNota.Style = MetroFramework.MetroColorStyle.Teal;
      this.btnCancelarAddNota.TabIndex = 6;
      this.btnCancelarAddNota.TileImage = ((System.Drawing.Image)(resources.GetObject("btnCancelarAddNota.TileImage")));
      this.btnCancelarAddNota.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.btnCancelarAddNota.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
      this.btnCancelarAddNota.UseSelectable = true;
      this.btnCancelarAddNota.UseTileImage = true;
      this.btnCancelarAddNota.Click += new System.EventHandler(this.btnCancelarAddNota_Click);
      // 
      // btnAddNota
      // 
      this.btnAddNota.AccessibleDescription = "adicionar nota";
      this.btnAddNota.AccessibleName = "adicionar nota";
      this.btnAddNota.ActiveControl = null;
      this.btnAddNota.Location = new System.Drawing.Point(666, 6);
      this.btnAddNota.Name = "btnAddNota";
      this.btnAddNota.Size = new System.Drawing.Size(89, 76);
      this.btnAddNota.Style = MetroFramework.MetroColorStyle.Teal;
      this.btnAddNota.TabIndex = 5;
      this.btnAddNota.TileImage = global::Tiresias_V_alfa01.Properties.Resources.addNota;
      this.btnAddNota.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.btnAddNota.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
      this.btnAddNota.UseSelectable = true;
      this.btnAddNota.UseTileImage = true;
      this.btnAddNota.Click += new System.EventHandler(this.btnAddNota_Click);
      // 
      // metroLabel5
      // 
      this.metroLabel5.AutoSize = true;
      this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
      this.metroLabel5.Location = new System.Drawing.Point(538, 15);
      this.metroLabel5.Name = "metroLabel5";
      this.metroLabel5.Size = new System.Drawing.Size(62, 25);
      this.metroLabel5.TabIndex = 3;
      this.metroLabel5.Text = "Tempo";
      // 
      // metroLabel4
      // 
      this.metroLabel4.AutoSize = true;
      this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
      this.metroLabel4.Location = new System.Drawing.Point(408, 15);
      this.metroLabel4.Name = "metroLabel4";
      this.metroLabel4.Size = new System.Drawing.Size(78, 25);
      this.metroLabel4.TabIndex = 3;
      this.metroLabel4.Text = "Acidente";
      // 
      // metroLabel3
      // 
      this.metroLabel3.AutoSize = true;
      this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
      this.metroLabel3.Location = new System.Drawing.Point(278, 15);
      this.metroLabel3.Name = "metroLabel3";
      this.metroLabel3.Size = new System.Drawing.Size(49, 25);
      this.metroLabel3.TabIndex = 3;
      this.metroLabel3.Text = "Nota";
      // 
      // metroLabel2
      // 
      this.metroLabel2.AutoSize = true;
      this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
      this.metroLabel2.Location = new System.Drawing.Point(144, 15);
      this.metroLabel2.Name = "metroLabel2";
      this.metroLabel2.Size = new System.Drawing.Size(91, 25);
      this.metroLabel2.TabIndex = 3;
      this.metroLabel2.Text = "Compasso";
      // 
      // metroLabel1
      // 
      this.metroLabel1.AutoSize = true;
      this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
      this.metroLabel1.Location = new System.Drawing.Point(19, 15);
      this.metroLabel1.Name = "metroLabel1";
      this.metroLabel1.Size = new System.Drawing.Size(53, 25);
      this.metroLabel1.TabIndex = 3;
      this.metroLabel1.Text = "Clave";
      // 
      // ddlTempo
      // 
      this.ddlTempo.AccessibleDescription = "selecione o tempo";
      this.ddlTempo.AccessibleName = "selecione o tempo";
      this.ddlTempo.FormattingEnabled = true;
      this.ddlTempo.ItemHeight = 23;
      this.ddlTempo.Items.AddRange(new object[] {
            "SEMIBREVE",
            "MINIMA",
            "SEMIMINIMA",
            "COLCHEIA",
            "PAUSA DE SEMIBREVE",
            "PAUSA DE MINIMA",
            "PAUSA DE SEMIMININA",
            "PAUSA DE COLCHEIA"});
      this.ddlTempo.Location = new System.Drawing.Point(536, 47);
      this.ddlTempo.Name = "ddlTempo";
      this.ddlTempo.Size = new System.Drawing.Size(115, 29);
      this.ddlTempo.TabIndex = 4;
      this.ddlTempo.UseSelectable = true;
      this.ddlTempo.SelectedIndexChanged += new System.EventHandler(this.ddlTempo_SelectedIndexChanged);
      this.ddlTempo.Enter += new System.EventHandler(this.ddlTempo_Enter);
      // 
      // ddlAcidente
      // 
      this.ddlAcidente.AccessibleDescription = "selecione o acidente";
      this.ddlAcidente.AccessibleName = "selecione o acidente";
      this.ddlAcidente.FormattingEnabled = true;
      this.ddlAcidente.ItemHeight = 23;
      this.ddlAcidente.Items.AddRange(new object[] {
            "VAZIO",
            "BEMOL"});
      this.ddlAcidente.Location = new System.Drawing.Point(405, 47);
      this.ddlAcidente.Name = "ddlAcidente";
      this.ddlAcidente.Size = new System.Drawing.Size(115, 29);
      this.ddlAcidente.TabIndex = 3;
      this.ddlAcidente.UseSelectable = true;
      this.ddlAcidente.SelectedIndexChanged += new System.EventHandler(this.ddlAcidente_SelectedIndexChanged);
      this.ddlAcidente.Enter += new System.EventHandler(this.ddlAcidente_Enter);
      // 
      // ddlNota
      // 
      this.ddlNota.AccessibleDescription = "selecione a nota";
      this.ddlNota.AccessibleName = "selecione a nota";
      this.ddlNota.FormattingEnabled = true;
      this.ddlNota.ItemHeight = 23;
      this.ddlNota.Items.AddRange(new object[] {
            "DÓ",
            "RÉ",
            "MI",
            "FÁ",
            "SOL",
            "LA",
            "SI",
            "DÓ/OITAVA",
            "RÉ/OITAVA",
            "MI/OITAVA",
            "FÁ/OITAVA",
            "SOL/OITAVA",
            "LA/OITAVA",
            "SI/OITAVA"});
      this.ddlNota.Location = new System.Drawing.Point(276, 47);
      this.ddlNota.Name = "ddlNota";
      this.ddlNota.Size = new System.Drawing.Size(115, 29);
      this.ddlNota.TabIndex = 2;
      this.ddlNota.UseSelectable = true;
      this.ddlNota.SelectedIndexChanged += new System.EventHandler(this.ddlNota_SelectedIndexChanged);
      this.ddlNota.Enter += new System.EventHandler(this.ddlNota_Enter);
      // 
      // ddlCompasso
      // 
      this.ddlCompasso.AccessibleDescription = "selecione o compasso";
      this.ddlCompasso.AccessibleName = "selecione o compasso";
      this.ddlCompasso.FormattingEnabled = true;
      this.ddlCompasso.ItemHeight = 23;
      this.ddlCompasso.Items.AddRange(new object[] {
            "QUATERNÁRIO 4/4"});
      this.ddlCompasso.Location = new System.Drawing.Point(143, 47);
      this.ddlCompasso.Name = "ddlCompasso";
      this.ddlCompasso.Size = new System.Drawing.Size(118, 29);
      this.ddlCompasso.TabIndex = 1;
      this.ddlCompasso.UseSelectable = true;
      this.ddlCompasso.SelectedIndexChanged += new System.EventHandler(this.ddlCompasso_SelectedIndexChanged);
      this.ddlCompasso.Enter += new System.EventHandler(this.ddlCompasso_Enter);
      // 
      // ddlClave
      // 
      this.ddlClave.AccessibleDescription = "selecione a clave da partitura";
      this.ddlClave.AccessibleName = "selecione a clave da partitura";
      this.ddlClave.FormattingEnabled = true;
      this.ddlClave.ItemHeight = 23;
      this.ddlClave.Items.AddRange(new object[] {
            "SOL"});
      this.ddlClave.Location = new System.Drawing.Point(14, 47);
      this.ddlClave.Name = "ddlClave";
      this.ddlClave.Size = new System.Drawing.Size(115, 29);
      this.ddlClave.TabIndex = 0;
      this.ddlClave.UseSelectable = true;
      this.ddlClave.SelectedIndexChanged += new System.EventHandler(this.ddlClave_SelectedIndexChanged);
      this.ddlClave.Enter += new System.EventHandler(this.ddlClave_Enter);
      // 
      // panelSalvarPartitura
      // 
      this.panelSalvarPartitura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panelSalvarPartitura.Controls.Add(this.txtSalvarPartitura);
      this.panelSalvarPartitura.Controls.Add(this.btnCancelarSalvar);
      this.panelSalvarPartitura.Controls.Add(this.btnSalvarPartitura);
      this.panelSalvarPartitura.Enabled = false;
      this.panelSalvarPartitura.HorizontalScrollbarBarColor = true;
      this.panelSalvarPartitura.HorizontalScrollbarHighlightOnWheel = false;
      this.panelSalvarPartitura.HorizontalScrollbarSize = 10;
      this.panelSalvarPartitura.Location = new System.Drawing.Point(56, 7);
      this.panelSalvarPartitura.Name = "panelSalvarPartitura";
      this.panelSalvarPartitura.Size = new System.Drawing.Size(869, 85);
      this.panelSalvarPartitura.TabIndex = 1;
      this.panelSalvarPartitura.VerticalScrollbarBarColor = true;
      this.panelSalvarPartitura.VerticalScrollbarHighlightOnWheel = false;
      this.panelSalvarPartitura.VerticalScrollbarSize = 10;
      this.panelSalvarPartitura.Visible = false;
      // 
      // txtSalvarPartitura
      // 
      this.txtSalvarPartitura.AccessibleDescription = "digite o nome para sua partitura";
      this.txtSalvarPartitura.AccessibleName = "digite o nome para sua partitura";
      this.txtSalvarPartitura.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtSalvarPartitura.Location = new System.Drawing.Point(12, 11);
      this.txtSalvarPartitura.Name = "txtSalvarPartitura";
      this.txtSalvarPartitura.Size = new System.Drawing.Size(640, 67);
      this.txtSalvarPartitura.TabIndex = 0;
      this.txtSalvarPartitura.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSalvarPartitura_KeyDown);
      // 
      // btnCancelarSalvar
      // 
      this.btnCancelarSalvar.AccessibleDescription = "cancelar salvar partitura";
      this.btnCancelarSalvar.AccessibleName = "cancelar salvar partitura";
      this.btnCancelarSalvar.ActiveControl = null;
      this.btnCancelarSalvar.Location = new System.Drawing.Point(768, 3);
      this.btnCancelarSalvar.Name = "btnCancelarSalvar";
      this.btnCancelarSalvar.Size = new System.Drawing.Size(89, 79);
      this.btnCancelarSalvar.Style = MetroFramework.MetroColorStyle.Teal;
      this.btnCancelarSalvar.TabIndex = 6;
      this.btnCancelarSalvar.TileImage = ((System.Drawing.Image)(resources.GetObject("btnCancelarSalvar.TileImage")));
      this.btnCancelarSalvar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.btnCancelarSalvar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
      this.btnCancelarSalvar.UseSelectable = true;
      this.btnCancelarSalvar.UseTileImage = true;
      this.btnCancelarSalvar.Click += new System.EventHandler(this.btnCancelarSalvar_Click);
      // 
      // btnSalvarPartitura
      // 
      this.btnSalvarPartitura.AccessibleDescription = "Salvar partitura";
      this.btnSalvarPartitura.AccessibleName = "Salvar partitura";
      this.btnSalvarPartitura.ActiveControl = null;
      this.btnSalvarPartitura.Location = new System.Drawing.Point(673, 3);
      this.btnSalvarPartitura.Name = "btnSalvarPartitura";
      this.btnSalvarPartitura.Size = new System.Drawing.Size(89, 79);
      this.btnSalvarPartitura.Style = MetroFramework.MetroColorStyle.Teal;
      this.btnSalvarPartitura.TabIndex = 1;
      this.btnSalvarPartitura.TileImage = global::Tiresias_V_alfa01.Properties.Resources.salvarPartitura;
      this.btnSalvarPartitura.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.btnSalvarPartitura.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
      this.btnSalvarPartitura.UseSelectable = true;
      this.btnSalvarPartitura.UseTileImage = true;
      this.btnSalvarPartitura.Click += new System.EventHandler(this.btnSalvarPartitura_Click);
      // 
      // txtBraille
      // 
      this.txtBraille.AccessibleDescription = " ";
      this.txtBraille.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtBraille.Enabled = false;
      this.txtBraille.Font = new System.Drawing.Font("Night Braille", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.txtBraille.ForeColor = System.Drawing.Color.Black;
      this.txtBraille.Location = new System.Drawing.Point(56, 341);
      this.txtBraille.Multiline = true;
      this.txtBraille.Name = "txtBraille";
      this.txtBraille.Size = new System.Drawing.Size(871, 128);
      this.txtBraille.TabIndex = 0;
      // 
      // ucPartitura
      // 
      this.AccessibleDescription = "janela de criação de partitura";
      this.AccessibleName = "janela de criação de partitura";
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoScroll = true;
      this.Controls.Add(this.txtPartitura);
      this.Controls.Add(this.panelSalvarPartitura);
      this.Controls.Add(this.panelAddNota);
      this.Controls.Add(this.panelPrincipal);
      this.Controls.Add(this.txtBraille);
      this.Name = "ucPartitura";
      this.Size = new System.Drawing.Size(981, 579);
      this.Load += new System.EventHandler(this.ucPartitura_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ucPartitura_KeyDown);
      this.panelPrincipal.ResumeLayout(false);
      this.panelAddNota.ResumeLayout(false);
      this.panelAddNota.PerformLayout();
      this.panelSalvarPartitura.ResumeLayout(false);
      this.panelSalvarPartitura.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtPartitura;
    private MetroFramework.Controls.MetroPanel panelPrincipal;
    private MetroFramework.Controls.MetroTile btnEscutarPartitura;
    private MetroFramework.Controls.MetroTile btnDeletarNota;
    private MetroFramework.Controls.MetroTile btnAddNovaNota;
    private MetroFramework.Controls.MetroPanel panelAddNota;
    private MetroFramework.Controls.MetroTile btnAddNota;
    private MetroFramework.Controls.MetroLabel metroLabel1;
    private MetroFramework.Controls.MetroComboBox ddlAcidente;
    private MetroFramework.Controls.MetroComboBox ddlNota;
    private MetroFramework.Controls.MetroComboBox ddlCompasso;
    private MetroFramework.Controls.MetroComboBox ddlClave;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox ddlTempo;
    private MetroFramework.Controls.MetroTile btnCancelarAddNota;
    private MetroFramework.Controls.MetroPanel panelSalvarPartitura;
    private System.Windows.Forms.TextBox txtSalvarPartitura;
    private MetroFramework.Controls.MetroTile btnSalvarPartitura;
    private MetroFramework.Controls.MetroTile btnHabilitaSalvarPartitura;
    private MetroFramework.Controls.MetroTile btnCancelarSalvar;
    private System.Windows.Forms.TextBox txtBraille;
  }
}
