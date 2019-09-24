using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Tiresias_V_alfa01.appCode
{
  class GerarPDF
  {
    public void getPdfPartitura(Partitura partitura)
    {
      if (!FontFactory.IsRegistered("Night-Braille"))
      {
        FontFactory.RegisterFamily("Night-Braille", "Night-Braille", @"C:\Windows\Fonts");
        FontFactory.RegisterDirectories();
      }
      Font fontBraille = FontFactory.GetFont("Night-Braille", 30, 0);
      if (!FontFactory.IsRegistered("LASSUS"))
      {
        FontFactory.RegisterFamily("LASSUS", "ttfNormal", @"C:\Windows\Fonts");
        FontFactory.RegisterDirectories();
      }
      Font fontPartitura = FontFactory.GetFont("LASSUS", 60, 0);
      Font fontArial = FontFactory.GetFont("Arial", 15, 1);
      Font fontArial2 = FontFactory.GetFont("Arial", 15, 0);


      Document doc = new Document(iTextSharp.text.PageSize.A4, 20,20,20,20);

      string exeFile = (new System.Uri(Assembly.GetEntryAssembly().CodeBase)).AbsolutePath;
      string exeDir = Path.GetDirectoryName(exeFile);
      string fullPath = Path.Combine(exeDir, "..\\..\\pdf\\file.pdf");

      FileStream arquivo = new FileStream(fullPath, FileMode.Create);
      PdfWriter writer = PdfWriter.GetInstance(doc,arquivo);

      doc.Open();
      doc.AddAuthor("Cleiton de Sousa, Raphael Duarte, Douglas Rodrigues, e DEUS, só ele sabe como isso funciona");
      doc.AddCreator("Partitura Braille");
      doc.AddKeywords("PDF partitura Braille");
      doc.AddTitle(partitura.Titulo);


      Paragraph para = new Paragraph(new Phrase("Partitura: " + partitura.Titulo, fontArial));
      doc.Add(para);
      para = new Paragraph(new Phrase(partitura.TextoPartitura + "=", fontPartitura));
      doc.Add(para);
      para = new Paragraph(new Phrase(" ", fontArial));
      doc.Add(para);
      para = new Paragraph(new Phrase(" ", fontArial));
      doc.Add(para);
      para = new Paragraph(new Phrase(" ", fontArial));
      doc.Add(para);

      para = new Paragraph(new Phrase("Partitura: " + partitura.Titulo, fontBraille));
      doc.Add(para);
      para = new Paragraph(new Phrase(partitura.BraillePartitura, fontBraille));
      doc.Add(para);

      doc.NewPage();
      para = new Paragraph(new Phrase("Letra da Partitura: " + partitura.Titulo, fontArial));
      doc.Add(para);
      para = new Paragraph(new Phrase(" ", fontArial));
      doc.Add(para);
      para = new Paragraph(new Phrase(partitura.LetraPartitura, fontArial2));
      doc.Add(para);
      para = new Paragraph(new Phrase(" ", fontArial));
      doc.Add(para);
      para = new Paragraph(new Phrase(" ", fontArial));
      doc.Add(para);
      para = new Paragraph(new Phrase(" ", fontArial));
      doc.Add(para);
      para = new Paragraph(new Phrase(" ", fontArial));
      doc.Add(para);
      para = new Paragraph(new Phrase("Letra da Partitura em Braille: " + partitura.Titulo, fontBraille));
      doc.Add(para);
      para = new Paragraph(new Phrase(partitura.LetraPartitura, fontBraille));
      doc.Add(para);


      doc.Close();
      arquivo.Close();
      System.Diagnostics.Process.Start(fullPath);
    }

    
  }
}
