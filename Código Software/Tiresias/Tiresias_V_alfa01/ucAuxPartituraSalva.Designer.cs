namespace Tiresias_V_alfa01
{
  partial class ucAuxPartituraSalva
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
      this.btnExecutarDispositivoBraille = new MetroFramework.Controls.MetroTile();
      this.btnExecutarDispositivoAudio = new MetroFramework.Controls.MetroTile();
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
      this.panelPartituras.Controls.Add(this.btnExecutarDispositivoBraille);
      this.panelPartituras.Controls.Add(this.btnExecutarDispositivoAudio);
      this.panelPartituras.Controls.Add(this.txtPartitura);
      this.panelPartituras.Location = new System.Drawing.Point(27, 23);
      this.panelPartituras.Name = "panelPartituras";
      this.panelPartituras.Size = new System.Drawing.Size(899, 528);
      this.panelPartituras.TabIndex = 1;
      // 
      // txtBraille
      // 
      this.txtBraille.AccessibleDescription = " ";
      this.txtBraille.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtBraille.Enabled = false;
      this.txtBraille.Font = new System.Drawing.Font("Night Braille", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.txtBraille.ForeColor = System.Drawing.Color.Black;
      this.txtBraille.Location = new System.Drawing.Point(13, 395);
      this.txtBraille.Multiline = true;
      this.txtBraille.Name = "txtBraille";
      this.txtBraille.Size = new System.Drawing.Size(871, 108);
      this.txtBraille.TabIndex = 8;
      // 
      // txtLetra
      // 
      this.txtLetra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtLetra.Enabled = false;
      this.txtLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtLetra.Location = new System.Drawing.Point(13, 85);
      this.txtLetra.Multiline = true;
      this.txtLetra.Name = "txtLetra";
      this.txtLetra.Size = new System.Drawing.Size(871, 91);
      this.txtLetra.TabIndex = 7;
      // 
      // btnExecutarDispositivoBraille
      // 
      this.btnExecutarDispositivoBraille.AccessibleDescription = "Executar no Dispositivo de Braile";
      this.btnExecutarDispositivoBraille.AccessibleName = "Executar no Dispositivo de Braile";
      this.btnExecutarDispositivoBraille.ActiveControl = null;
      this.btnExecutarDispositivoBraille.Location = new System.Drawing.Point(108, 3);
      this.btnExecutarDispositivoBraille.Name = "btnExecutarDispositivoBraille";
      this.btnExecutarDispositivoBraille.Size = new System.Drawing.Size(89, 76);
      this.btnExecutarDispositivoBraille.Style = MetroFramework.MetroColorStyle.Teal;
      this.btnExecutarDispositivoBraille.TabIndex = 1;
      this.btnExecutarDispositivoBraille.TileImage = global::Tiresias_V_alfa01.Properties.Resources.braille;
      this.btnExecutarDispositivoBraille.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.btnExecutarDispositivoBraille.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
      this.btnExecutarDispositivoBraille.UseSelectable = true;
      this.btnExecutarDispositivoBraille.UseTileImage = true;
      this.btnExecutarDispositivoBraille.Click += new System.EventHandler(this.btnExecutarDispositivoBraille_Click);
      // 
      // btnExecutarDispositivoAudio
      // 
      this.btnExecutarDispositivoAudio.AccessibleDescription = "Executar no Dispositivo de Áudio";
      this.btnExecutarDispositivoAudio.AccessibleName = "Executar no Dispositivo de Áudio";
      this.btnExecutarDispositivoAudio.ActiveControl = null;
      this.btnExecutarDispositivoAudio.Location = new System.Drawing.Point(13, 3);
      this.btnExecutarDispositivoAudio.Name = "btnExecutarDispositivoAudio";
      this.btnExecutarDispositivoAudio.Size = new System.Drawing.Size(89, 76);
      this.btnExecutarDispositivoAudio.Style = MetroFramework.MetroColorStyle.Teal;
      this.btnExecutarDispositivoAudio.TabIndex = 0;
      this.btnExecutarDispositivoAudio.TileImage = global::Tiresias_V_alfa01.Properties.Resources.audio;
      this.btnExecutarDispositivoAudio.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.btnExecutarDispositivoAudio.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
      this.btnExecutarDispositivoAudio.UseSelectable = true;
      this.btnExecutarDispositivoAudio.UseTileImage = true;
      this.btnExecutarDispositivoAudio.Click += new System.EventHandler(this.btnExecutarDispositivoAudio_Click);
      // 
      // txtPartitura
      // 
      this.txtPartitura.AccessibleDescription = " ";
      this.txtPartitura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtPartitura.Enabled = false;
      this.txtPartitura.Font = new System.Drawing.Font("Lassus", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtPartitura.ForeColor = System.Drawing.Color.Black;
      this.txtPartitura.Location = new System.Drawing.Point(13, 181);
      this.txtPartitura.Multiline = true;
      this.txtPartitura.Name = "txtPartitura";
      this.txtPartitura.Size = new System.Drawing.Size(871, 207);
      this.txtPartitura.TabIndex = 2;
      // 
      // ucAuxPartituraSalva
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.panelPartituras);
      this.Name = "ucAuxPartituraSalva";
      this.Size = new System.Drawing.Size(952, 569);
      this.Load += new System.EventHandler(this.ucAuxPartituraSalva_Load);
      this.panelPartituras.ResumeLayout(false);
      this.panelPartituras.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panelPartituras;
    private System.Windows.Forms.TextBox txtPartitura;
    private MetroFramework.Controls.MetroTile btnExecutarDispositivoBraille;
    private MetroFramework.Controls.MetroTile btnExecutarDispositivoAudio;
    private System.Windows.Forms.TextBox txtLetra;
    private System.Windows.Forms.TextBox txtBraille;
  }
}
