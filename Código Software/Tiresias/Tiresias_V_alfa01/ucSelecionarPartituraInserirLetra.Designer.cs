namespace Tiresias_V_alfa01
{
  partial class ucSelecionarPartituraInserirLetra
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
      this.SuspendLayout();
      // 
      // panelPartituras
      // 
      this.panelPartituras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panelPartituras.Location = new System.Drawing.Point(19, 16);
      this.panelPartituras.Name = "panelPartituras";
      this.panelPartituras.Size = new System.Drawing.Size(913, 527);
      this.panelPartituras.TabIndex = 1;
      // 
      // ucSelecionarPartituraInserirLetra
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.panelPartituras);
      this.Name = "ucSelecionarPartituraInserirLetra";
      this.Size = new System.Drawing.Size(952, 569);
      this.Load += new System.EventHandler(this.ucSelecionarPartituraInserirLetra_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panelPartituras;
  }
}
