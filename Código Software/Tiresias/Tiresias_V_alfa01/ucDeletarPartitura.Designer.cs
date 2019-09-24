namespace Tiresias_V_alfa01
{
  partial class ucDeletarPartitura
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.panelPartituras = new System.Windows.Forms.Panel();
      this.SuspendLayout();
      // 
      // panelPartituras
      // 
      this.panelPartituras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panelPartituras.Location = new System.Drawing.Point(17, 17);
      this.panelPartituras.Name = "panelPartituras";
      this.panelPartituras.Size = new System.Drawing.Size(918, 645);
      this.panelPartituras.TabIndex = 2;
      // 
      // ucDeletarPartitura
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.panelPartituras);
      this.Name = "ucDeletarPartitura";
      this.Size = new System.Drawing.Size(952, 684);
      this.Load += new System.EventHandler(this.ucDeletarPartitura_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panelPartituras;
  }
}
