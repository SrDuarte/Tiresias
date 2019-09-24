namespace Tiresias_V_alfa01
{
  partial class ucLetraPartitura
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
      this.panelPartituras = new System.Windows.Forms.Panel();
      this.txtBraille = new System.Windows.Forms.TextBox();
      this.txtLetra = new System.Windows.Forms.TextBox();
      this.btnSalvarLetra = new MetroFramework.Controls.MetroTile();
      this.btnEscutarPartitura = new MetroFramework.Controls.MetroTile();
      this.txtPartitura = new System.Windows.Forms.TextBox();
      this.panelPartituras.SuspendLayout();
      this.SuspendLayout();
      // 
      // panelPartituras
      // 
      this.panelPartituras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panelPartituras.Controls.Add(this.txtBraille);
      this.panelPartituras.Controls.Add(this.txtLetra);
      this.panelPartituras.Controls.Add(this.btnSalvarLetra);
      this.panelPartituras.Controls.Add(this.btnEscutarPartitura);
      this.panelPartituras.Controls.Add(this.txtPartitura);
      this.panelPartituras.Location = new System.Drawing.Point(14, 3);
      this.panelPartituras.Name = "panelPartituras";
      this.panelPartituras.Size = new System.Drawing.Size(920, 548);
      this.panelPartituras.TabIndex = 2;
      this.panelPartituras.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPartituras_Paint);
      // 
      // txtBraille
      // 
      this.txtBraille.AccessibleDescription = " ";
      this.txtBraille.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtBraille.Enabled = false;
      this.txtBraille.Font = new System.Drawing.Font("Night Braille", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.txtBraille.ForeColor = System.Drawing.Color.Black;
      this.txtBraille.Location = new System.Drawing.Point(13, 406);
      this.txtBraille.Multiline = true;
      this.txtBraille.Name = "txtBraille";
      this.txtBraille.Size = new System.Drawing.Size(892, 108);
      this.txtBraille.TabIndex = 8;
      // 
      // txtLetra
      // 
      this.txtLetra.AccessibleDescription = "insira a letra";
      this.txtLetra.AccessibleName = "insira a letra";
      this.txtLetra.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
      this.txtLetra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtLetra.Location = new System.Drawing.Point(13, 85);
      this.txtLetra.Multiline = true;
      this.txtLetra.Name = "txtLetra";
      this.txtLetra.Size = new System.Drawing.Size(892, 103);
      this.txtLetra.TabIndex = 2;
      // 
      // btnSalvarLetra
      // 
      this.btnSalvarLetra.AccessibleDescription = "salvar letra";
      this.btnSalvarLetra.AccessibleName = "salvar letra";
      this.btnSalvarLetra.ActiveControl = null;
      this.btnSalvarLetra.Location = new System.Drawing.Point(13, 3);
      this.btnSalvarLetra.Name = "btnSalvarLetra";
      this.btnSalvarLetra.Size = new System.Drawing.Size(89, 76);
      this.btnSalvarLetra.Style = MetroFramework.MetroColorStyle.Teal;
      this.btnSalvarLetra.TabIndex = 0;
      this.btnSalvarLetra.TileImage = global::Tiresias_V_alfa01.Properties.Resources.salvarPartitura;
      this.btnSalvarLetra.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.btnSalvarLetra.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
      this.btnSalvarLetra.UseSelectable = true;
      this.btnSalvarLetra.UseTileImage = true;
      this.btnSalvarLetra.Click += new System.EventHandler(this.btnSalvarLetra_Click);
      // 
      // btnEscutarPartitura
      // 
      this.btnEscutarPartitura.AccessibleDescription = "escutar partitura";
      this.btnEscutarPartitura.AccessibleName = "escutar partitura";
      this.btnEscutarPartitura.ActiveControl = null;
      this.btnEscutarPartitura.Location = new System.Drawing.Point(108, 3);
      this.btnEscutarPartitura.Name = "btnEscutarPartitura";
      this.btnEscutarPartitura.Size = new System.Drawing.Size(89, 76);
      this.btnEscutarPartitura.Style = MetroFramework.MetroColorStyle.Teal;
      this.btnEscutarPartitura.TabIndex = 1;
      this.btnEscutarPartitura.TileImage = global::Tiresias_V_alfa01.Properties.Resources.audio;
      this.btnEscutarPartitura.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.btnEscutarPartitura.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
      this.btnEscutarPartitura.UseSelectable = true;
      this.btnEscutarPartitura.UseTileImage = true;
      this.btnEscutarPartitura.Click += new System.EventHandler(this.btnEscutarPartitura_Click);
      // 
      // txtPartitura
      // 
      this.txtPartitura.AccessibleDescription = " ";
      this.txtPartitura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtPartitura.Enabled = false;
      this.txtPartitura.Font = new System.Drawing.Font("Lassus", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtPartitura.ForeColor = System.Drawing.Color.Black;
      this.txtPartitura.Location = new System.Drawing.Point(13, 193);
      this.txtPartitura.Multiline = true;
      this.txtPartitura.Name = "txtPartitura";
      this.txtPartitura.Size = new System.Drawing.Size(892, 207);
      this.txtPartitura.TabIndex = 2;
      // 
      // ucLetraPartitura
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.panelPartituras);
      this.Name = "ucLetraPartitura";
      this.Size = new System.Drawing.Size(952, 569);
      this.Load += new System.EventHandler(this.ucLetraPartitura_Load);
      this.panelPartituras.ResumeLayout(false);
      this.panelPartituras.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panelPartituras;
    private System.Windows.Forms.TextBox txtBraille;
    private System.Windows.Forms.TextBox txtLetra;
    private MetroFramework.Controls.MetroTile btnSalvarLetra;
    private MetroFramework.Controls.MetroTile btnEscutarPartitura;
    private System.Windows.Forms.TextBox txtPartitura;
  }
}
