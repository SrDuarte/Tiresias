namespace Tiresias_V_alfa01
{
  partial class frmMain
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
      this.mPanel = new MetroFramework.Controls.MetroPanel();
      this.voltar = new MetroFramework.Controls.MetroTile();
      this.SuspendLayout();
      // 
      // mPanel
      // 
      this.mPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.mPanel.BackColor = System.Drawing.Color.Transparent;
      this.mPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.mPanel.HorizontalScrollbarBarColor = true;
      this.mPanel.HorizontalScrollbarHighlightOnWheel = false;
      this.mPanel.HorizontalScrollbarSize = 10;
      this.mPanel.Location = new System.Drawing.Point(54, 88);
      this.mPanel.Name = "mPanel";
      this.mPanel.Size = new System.Drawing.Size(751, 406);
      this.mPanel.TabIndex = 3;
      this.mPanel.VerticalScrollbarBarColor = true;
      this.mPanel.VerticalScrollbarHighlightOnWheel = false;
      this.mPanel.VerticalScrollbarSize = 10;
      // 
      // voltar
      // 
      this.voltar.AccessibleDescription = "voltar ao painel principal";
      this.voltar.AccessibleName = "voltar ao painel principal";
      this.voltar.ActiveControl = null;
      this.voltar.BackColor = System.Drawing.Color.Transparent;
      this.voltar.Location = new System.Drawing.Point(9, 7);
      this.voltar.Name = "voltar";
      this.voltar.Size = new System.Drawing.Size(84, 79);
      this.voltar.TabIndex = 2;
      this.voltar.Text = "VOLTAR";
      this.voltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.voltar.TileImage = global::Tiresias_V_alfa01.Properties.Resources.voltar;
      this.voltar.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
      this.voltar.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
      this.voltar.UseCustomBackColor = true;
      this.voltar.UseCustomForeColor = true;
      this.voltar.UseSelectable = true;
      this.voltar.UseTileImage = true;
      this.voltar.Click += new System.EventHandler(this.voltar_Click);
      // 
      // frmMain
      // 
      this.AccessibleDescription = "painel principal, tirésias";
      this.AccessibleName = "painel principal, tirésias";
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoScroll = true;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(873, 551);
      this.Controls.Add(this.mPanel);
      this.Controls.Add(this.voltar);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.Name = "frmMain";
      this.Resizable = false;
      this.Text = "                                         Tirésias";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmMain_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
      this.ResumeLayout(false);

    }

    #endregion

    private MetroFramework.Controls.MetroTile voltar;
    private MetroFramework.Controls.MetroPanel mPanel;
  }
}