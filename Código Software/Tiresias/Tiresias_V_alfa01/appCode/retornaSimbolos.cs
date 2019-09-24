namespace Tiresias_V_alfa01.appCode
{
  class retornaSimbolos
  {

    public string getNota(string nota)
    {
      string retorno = "";

      switch (nota)
      {
        case "DÓ#VAZIO#SEMIBREVE":
          retorno = "4#r#y";
          break;
        case "DÓ#VAZIO#MINIMA":
          retorno = "2#l#n";
          break;
        case "DÓ#VAZIO#SEMIMINIMA":
          retorno = "1#%#ô";
          break;
        case "DÓ#VAZIO#COLCHEIA":
          retorno = "0,5#{#d";
          break;
        case "DÓ#VAZIO#PAUSA DE SEMIBREVE":
          retorno = "4#0#m";
          break;
        case "DÓ#VAZIO#PAUSA DE MINIMA":
          retorno = "2#9#u";
          break;
        case "DÓ#VAZIO#PAUSA DE SEMIMININA":
          retorno = "1#8#v";
          break;
        case "DÓ#VAZIO#PAUSA DE COLCHEIA":
          retorno = "0,5#7#x";
          break;


        case "DÓ#BEMOL#SEMIBREVE":
          retorno = "4#r>#yê";
          break;
        case "DÓ#BEMOL#MINIMA":
          retorno = "2#l>#nê";
          break;
        case "DÓ#BEMOL#SEMIMINIMA":
          retorno = "1#%>#ôê";
          break;
        case "DÓ#BEMOL#COLCHEIA":
          retorno = "0,5#{>#dê";
          break;


        case "RÉ#VAZIO#SEMIBREVE":
          retorno = "4#t#z";
          break;
        case "RÉ#VAZIO#MINIMA":
          retorno = "2#;#o";
          break;
        case "RÉ#VAZIO#SEMIMINIMA":
          retorno = "1#^#û";
          break;
        case "RÉ#VAZIO#COLCHEIA":
          retorno = "0,5#}#e";
          break;
        case "RÉ#VAZIO#PAUSA DE SEMIBREVE":
          retorno = "4#0#m";
          break;
        case "RÉ#VAZIO#PAUSA DE MINIMA":
          retorno = "2#9#u";
          break;
        case "RÉ#VAZIO#PAUSA DE SEMIMININA":
          retorno = "1#8#v";
          break;
        case "RÉ#VAZIO#PAUSA DE COLCHEIA":
          retorno = "0,5#7#x";
          break;


        case "RÉ#BEMOL#SEMIBREVE":
          retorno = "4#t>#zê";
          break;
        case "RÉ#BEMOL#MINIMA":
          retorno = "2#;>#oê";
          break;
        case "RÉ#BEMOL#SEMIMINIMA":
          retorno = "1#^>#ûê";
          break;
        case "RÉ#BEMOL#COLCHEIA":
          retorno = "0,5#}>#eê";
          break;


        case "MI#VAZIO#SEMIBREVE":
          retorno = "4#y#ç";
          break;
        case "MI#VAZIO#MINIMA":
          retorno = "2#\'#p";
          break;
        case "MI#VAZIO#SEMIMINIMA":
          retorno = "1#&#ë";
          break;
        case "MI#VAZIO#COLCHEIA":
          retorno = "0,5#|#f";
          break;
        case "MI#VAZIO#PAUSA DE SEMIBREVE":
          retorno = "4#0#m";
          break;
        case "MI#VAZIO#PAUSA DE MINIMA":
          retorno = "2#9#u";
          break;
        case "MI#VAZIO#PAUSA DE SEMIMININA":
          retorno = "1#8#v";
          break;
        case "MI#VAZIO#PAUSA DE COLCHEIA":
          retorno = "0,5#7#x";
          break;


        case "MI#BEMOL#SEMIBREVE":
          retorno = "4#y>#çê";
          break;
        case "MI#BEMOL#MINIMA":
          retorno = "2#\'>#pê";
          break;
        case "MI#BEMOL#SEMIMINIMA":
          retorno = "1#&>#ëê";
          break;
        case "MI#BEMOL#COLCHEIA":
          retorno = "0,5#|>#fê";
          break;


        case "FÁ#VAZIO#SEMIBREVE":
          retorno = "4#u#é";
          break;
        case "FÁ#VAZIO#MINIMA":
          retorno = "2#z#q";
          break;
        case "FÁ#VAZIO#SEMIMINIMA":
          retorno = "1#*#ñ";
          break;
        case "FÁ#VAZIO#COLCHEIA":
          retorno = "0,5#A#g";
          break;
        case "FÁ#VAZIO#PAUSA DE SEMIBREVE":
          retorno = "4#0#m";
          break;
        case "FÁ#VAZIO#PAUSA DE MINIMA":
          retorno = "2#9#u";
          break;
        case "FÁ#VAZIO#PAUSA DE SEMIMININA":
          retorno = "1#8#v";
          break;
        case "FÁ#VAZIO#PAUSA DE COLCHEIA":
          retorno = "0,5#7#x";
          break;


        case "FÁ#BEMOL#SEMIBREVE":
          retorno = "4#u>#éê";
          break;
        case "FÁ#BEMOL#MINIMA":
          retorno = "2#z>#qê";
          break;
        case "FÁ#BEMOL#SEMIMINIMA":
          retorno = "1#*>#ñê";
          break;
        case "FÁ#BEMOL#COLCHEIA":
          retorno = "0,5#A>#gê";
          break;


        case "SOL#VAZIO#SEMIBREVE":
          retorno = "4#i#á";
          break;
        case "SOL#VAZIO#MINIMA":
          retorno = "2#x#r";
          break;
        case "SOL#VAZIO#SEMIMINIMA":
          retorno = "1#(#Ü";
          break;
        case "SOL#VAZIO#COLCHEIA":
          retorno = "0,5#S#h";
          break;
        case "SOL#VAZIO#PAUSA DE SEMIBREVE":
          retorno = "4#0#m";
          break;
        case "SOL#VAZIO#PAUSA DE MINIMA":
          retorno = "2#9#u";
          break;
        case "SOL#VAZIO#PAUSA DE SEMIMININA":
          retorno = "1#8#v";
          break;
        case "SOL#VAZIO#PAUSA DE COLCHEIA":
          retorno = "0,5#7#x";
          break;


        case "SOL#BEMOL#SEMIBREVE":
          retorno = "4#i>#áê";
          break;
        case "SOL#BEMOL#MINIMA":
          retorno = "2#x>#rê";
          break;
        case "SOL#BEMOL#SEMIMINIMA":
          retorno = "1#(>#Üê";
          break;
        case "SOL#BEMOL#COLCHEIA":
          retorno = "0,5#S>#hê";
          break;


        case "LA#VAZIO#SEMIBREVE":
          retorno = "4#o#è";
          break;
        case "LA#VAZIO#MINIMA":
          retorno = "2#c#s";
          break;
        case "LA#VAZIO#SEMIMINIMA":
          retorno = "1#)#ó";
          break;
        case "LA#VAZIO#COLCHEIA":
          retorno = "0,5#D#i";
          break;
        case "LA#VAZIO#PAUSA DE SEMIBREVE":
          retorno = "4#0#m";
          break;
        case "LA#VAZIO#PAUSA DE MINIMA":
          retorno = "2#9#u";
          break;
        case "LA#VAZIO#PAUSA DE SEMIMININA":
          retorno = "1#8#v";
          break;
        case "LA#VAZIO#PAUSA DE COLCHEIA":
          retorno = "0,5#7#x";
          break;


        case "LA#BEMOL#SEMIBREVE":
          retorno = "4#o>#èê";
          break;
        case "LA#BEMOL#MINIMA":
          retorno = "2#c>#sê";
          break;
        case "LA#BEMOL#SEMIMINIMA":
          retorno = "1#)>#óê";
          break;
        case "LA#BEMOL#COLCHEIA":
          retorno = "0,5#D>#iê";
          break;


        case "SI#VAZIO#SEMIBREVE":
          retorno = "4#p#ú";
          break;
        case "SI#VAZIO#MINIMA":
          retorno = "2#v#t";
          break;
        case "SI#VAZIO#SEMIMINIMA":
          retorno = "1#_#w";
          break;
        case "SI#VAZIO#COLCHEIA":
          retorno = "0,5#F#j";
          break;
        case "SI#VAZIO#PAUSA DE SEMIBREVE":
          retorno = "4#0#m";
          break;
        case "SI#VAZIO#PAUSA DE MINIMA":
          retorno = "2#9#u";
          break;
        case "SI#VAZIO#PAUSA DE SEMIMININA":
          retorno = "1#8#v";
          break;
        case "SI#VAZIO#PAUSA DE COLCHEIA":
          retorno = "0,5#7#x";
          break;



        case "SI#BEMOL#SEMIBREVE":
          retorno = "4#p>#úê";
          break;
        case "SI#BEMOL#MINIMA":
          retorno = "2#v>#tê";
          break;
        case "SI#BEMOL#SEMIMINIMA":
          retorno = "1#_>#wê";
          break;
        case "SI#BEMOL#COLCHEIA":
          retorno = "0,5#F>#jê";
          break;


        case "DÓ/OITAVA#VAZIO#SEMIBREVE":
          retorno = "4#[#y";
          break;
        case "DÓ/OITAVA#VAZIO#MINIMA":
          retorno = "2#b#n";
          break;
        case "DÓ/OITAVA#VAZIO#SEMIMINIMA":
          retorno = "1#+#ô";
          break;
        case "DÓ/OITAVA#VAZIO#COLCHEIA":
          retorno = "0,5#G#d";
          break;
        case "DÓ/OITAVA#VAZIO#PAUSA DE SEMIBREVE":
          retorno = "4#[#m";
          break;
        case "DÓ/OITAVA#VAZIO#PAUSA DE MINIMA":
          retorno = "2#b#u";
          break;
        case "DÓ/OITAVA#VAZIO#PAUSA DE SEMIMININA":
          retorno = "1#+#v";
          break;
        case "DÓ/OITAVA#VAZIO#PAUSA DE COLCHEIA":
          retorno = "0,5#G#x";
          break;


        case "DÓ/OITAVA#BEMOL#SEMIBREVE":
          retorno = "4#[>#yê";
          break;
        case "DÓ/OITAVA#BEMOL#MINIMA":
          retorno = "2#b>#nê";
          break;
        case "DÓ/OITAVA#BEMOL#SEMIMINIMA":
          retorno = "1#+>#ôê";
          break;
        case "DÓ/OITAVA#BEMOL#COLCHEIA":
          retorno = "0,5#G>#dê";

          break;


        case "RÉ/OITAVA#VAZIO#SEMIBREVE":
          retorno = "4#]#z";
          break;
        case "RÉ/OITAVA#VAZIO#MINIMA":
          retorno = "2#n#o";
          break;
        case "RÉ/OITAVA#VAZIO#SEMIMINIMA":
          retorno = "1#Q#û";
          break;
        case "RÉ/OITAVA#VAZIO#COLCHEIA":
          retorno = "0,5#R#e";
          break;
        case "RÉ/OITAVA#VAZIO#PAUSA DE SEMIBREVE":
          retorno = "4#0#m";
          break;
        case "RÉ/OITAVA#VAZIO#PAUSA DE MINIMA":
          retorno = "2#9#u";
          break;
        case "RÉ/OITAVA#VAZIO#PAUSA DE SEMIMININA":
          retorno = "1#8#v";
          break;
        case "RÉ/OITAVA#VAZIO#PAUSA DE COLCHEIA":
          retorno = "0,5#7#x";
          break;



        case "RÉ/OITAVA#BEMOL#SEMIBREVE":
          retorno = "4#]>#zê";
          break;
        case "RÉ/OITAVA#BEMOL#MINIMA":
          retorno = "2#n>#oê";
          break;
        case "RÉ/OITAVA#BEMOL#SEMIMINIMA":
          retorno = "1#Q>#ûê";
          break;
        case "RÉ/OITAVA#BEMOL#COLCHEIA":
          retorno = "0,5#R>#eê";
          break;


        case "MI/OITAVA#VAZIO#SEMIBREVE":
          retorno = "4#\\#ç";
          break;
        case "MI/OITAVA#VAZIO#MINIMA":
          retorno = "2#m#p";
          break;
        case "MI/OITAVA#VAZIO#SEMIMINIMA":
          retorno = "1#W#ë";
          break;
        case "MI/OITAVA#VAZIO#COLCHEIA":
          retorno = "0,5#J#f";
          break;
        case "MI/OITAVA#VAZIO#PAUSA DE SEMIBREVE":
          retorno = "4#0#m";
          break;
        case "MI/OITAVA#VAZIO#PAUSA DE MINIMA":
          retorno = "2#9#u";
          break;
        case "MI/OITAVA#VAZIO#PAUSA DE SEMIMININA":
          retorno = "1#8#v";
          break;
        case "MI/OITAVA#VAZIO#PAUSA DE COLCHEIA":
          retorno = "0,5#7#x";
          break;


        case "MI/OITAVA#BEMOL#SEMIBREVE":
          retorno = "4#\\>#çê";
          break;
        case "MI/OITAVA#BEMOL#MINIMA":
          retorno = "2#m>#pê";
          break;
        case "MI/OITAVA#BEMOL#SEMIMINIMA":
          retorno = "1#W>#ëê";
          break;
        case "MI/OITAVA#BEMOL#COLCHEIA":
          retorno = "0,5#J>#fê";
          break;


        case "FÁ/OITAVA#VAZIO#SEMIBREVE":
          retorno = "4#a#é";
          break;
        case "FÁ/OITAVA#VAZIO#MINIMA":
          retorno = "2#,#q";
          break;
        case "FÁ/OITAVA#VAZIO#SEMIMINIMA":
          retorno = "1#E#ñ";
          break;
        case "FÁ/OITAVA#VAZIO#COLCHEIA":
          retorno = "0,5#K#g";
          break;
        case "FÁ/OITAVA#VAZIO#PAUSA DE SEMIBREVE":
          retorno = "4#0#m";
          break;
        case "FÁ/OITAVA#VAZIO#PAUSA DE MINIMA":
          retorno = "2#9#u";
          break;
        case "FÁ/OITAVA#VAZIO#PAUSA DE SEMIMININA":
          retorno = "1#8#v";
          break;
        case "FÁ/OITAVA#VAZIO#PAUSA DE COLCHEIA":
          retorno = "0,5#7#x";
          break;


        case "FÁ/OITAVA#BEMOL#SEMIBREVE":
          retorno = "4#a>#éê";
          break;
        case "FÁ/OITAVA#BEMOL#MINIMA":
          retorno = "2#,>#qê";
          break;
        case "FÁ/OITAVA#BEMOL#SEMIMINIMA":
          retorno = "1#E>#ñê";
          break;
        case "FÁ/OITAVA#BEMOL#COLCHEIA":
          retorno = "0,5#K>#gê";
          break;


        case "SOL/OITAVA#VAZIO#SEMIBREVE":
          retorno = "4#s#á";
          break;
        case "SOL/OITAVA#VAZIO#MINIMA":
          retorno = "2#.#r";
          break;
        case "SOL/OITAVA#VAZIO#SEMIMINIMA":
          retorno = "1#R#Ü";
          break;
        case "SOL/OITAVA#VAZIO#COLCHEIA":
          retorno = "0,5#L#h";
          break;
        case "SOL/OITAVA#VAZIO#PAUSA DE SEMIBREVE":
          retorno = "4#0#m";
          break;
        case "SOL/OITAVA#VAZIO#PAUSA DE MINIMA":
          retorno = "2#9#u";
          break;
        case "SOL/OITAVA#VAZIO#PAUSA DE SEMIMININA":
          retorno = "1#8#v";
          break;
        case "SOL/OITAVA#VAZIO#PAUSA DE COLCHEIA":
          retorno = "0,5#7#x";
          break;



        case "SOL/OITAVA#BEMOL#SEMIBREVE":
          retorno = "4#s>#áê";
          break;
        case "SOL/OITAVA#BEMOL#MINIMA":
          retorno = "2#.>#rê";
          break;
        case "SOL/OITAVA#BEMOL#SEMIMINIMA":
          retorno = "1#R>#Üê";
          break;
        case "SOL/OITAVA#BEMOL#COLCHEIA":
          retorno = "0,5#L>#hê";
          break;


        case "LA/OITAVA#VAZIO#SEMIBREVE":
          retorno = "4#d#è";
          break;
        case "LA/OITAVA#VAZIO#MINIMA":
          retorno = "2#/#s";
          break;
        case "LA/OITAVA#VAZIO#SEMIMINIMA":
          retorno = "1#T#ó";
          break;
        case "LA/OITAVA#VAZIO#COLCHEIA":
          retorno = "0,5#:#i";
          break;
        case "LA/OITAVA#VAZIO#PAUSA DE SEMIBREVE":
          retorno = "4#0#m";
          break;
        case "LA/OITAVA#VAZIO#PAUSA DE MINIMA":
          retorno = "2#9#u";
          break;
        case "LA/OITAVA#VAZIO#PAUSA DE SEMIMININA":
          retorno = "1#8#v";
          break;
        case "LA/OITAVA#VAZIO#PAUSA DE COLCHEIA":
          retorno = "0,5#7#x";
          break;


        case "LA/OITAVA#BEMOL#SEMIBREVE":
          retorno = "4#d>#èê";
          break;
        case "LA/OITAVA#BEMOL#MINIMA":
          retorno = "2#/>#sê";
          break;
        case "LA/OITAVA#BEMOL#SEMIMINIMA":
          retorno = "1#T>#óê";
          break;
        case "LA/OITAVA#BEMOL#COLCHEIA":
          retorno = "0,5#:>#iê";
          break;


        case "SI/OITAVA#VAZIO#SEMIBREVE":
          retorno = "4#f#ú";
          break;
        case "SI/OITAVA#VAZIO#MINIMA":
          retorno = "2#~#t";
          break;
        case "SI/OITAVA#VAZIO#SEMIMINIMA":
          retorno = "1#Y#w";
          break;
        case "SI/OITAVA#VAZIO#COLCHEIA":
          retorno = "0,5#\"#j";
          break;
        case "SI/OITAVA#VAZIO#PAUSA DE SEMIBREVE":
          retorno = "4#0#m";
          break;
        case "SI/OITAVA#VAZIO#PAUSA DE MINIMA":
          retorno = "2#9#u";
          break;
        case "SI/OITAVA#VAZIO#PAUSA DE SEMIMININA":
          retorno = "1#8#v";
          break;
        case "SI/OITAVA#VAZIO#PAUSA DE COLCHEIA":
          retorno = "0,5#7#x";
          break;



        case "SI/OITAVA#BEMOL#SEMIBREVE":
          retorno = "4#f>#úê";
          break;
        case "SI/OITAVA#BEMOL#MINIMA":
          retorno = "2#~>#tê";
          break;
        case "SI/OITAVA#BEMOL#SEMIMINIMA":
          retorno = "1#Y>#wê";
          break;
        case "SI/OITAVA#BEMOL#COLCHEIA":
          retorno = "0,5#\">#jê";
          break;


      }


      return retorno;
    }

    public string getClave(string clave)
    {
      string retorno = "";
      switch (clave)
      {

        case "SOL#QUATERNÁRIO 4/4":
          retorno = "`4#ãíl";
          break;

      }

      return retorno;
    }

    public string traduzBraille(string braille)
    {
      string retorno = "";
      foreach (char item in braille)
      {
        retorno += switchBraille(item); 
      }
      return retorno;
    }

    private string switchBraille(char nota)
    {
      string retorno = "";
      switch (nota)
      {
        case 'y':
          retorno = "A";
          break;

        case 'z':
          retorno = "B";
          break;

        case 'ç':
          retorno = "C";
          break;

        case 'é':
          retorno = "D";
          break;

        case 'a':
          retorno = "E";
          break;

        case 'è':
          retorno = "F";
          break;

        case 'ú':
          retorno = "G";
          break;

        case 'n':
          retorno = "H";
          break;

        case 'o':
          retorno = "I";
          break;

        case 'p':
          retorno = "J";
          break;

        case 'q':
          retorno = "K";
          break;

        case 'r':
          retorno = "L";
          break;

        case 's':
          retorno = "M";
          break;

        case 't':
          retorno = "N";
          break;

        case 'ô':
          retorno = "O";
          break;

        case 'û':
          retorno = "P";
          break;

        case 'Ü':
          retorno = "S";
          break;

        case 'ó':
          retorno = "T";
          break;

        case 'w':
          retorno = "U";
          break;

        case 'd':
          retorno = "V";
          break;

        case 'e':
          retorno = "W";
          break;

        case 'f':
          retorno = "X";
          break;

        case 'g':
          retorno = "Z";
          break;

        case 'h':
          retorno = "Y";
          break;

        case 'i':
          retorno = "a";
          break;

        case 'j':
          retorno = "b";
          break;

        case 'm':
          retorno = "1";
          break;

        case 'u':
          retorno = "2";
          break;

        case 'v':
          retorno = "3";
          break;

        case 'x':
          retorno = "4";
          break;

        case 'ê':
          retorno = "c";
          break;

        case 'ã':
          retorno = "5";
          break;

        case 'í':
          retorno = "6";
          break;

        case 'l':
          retorno = "7";
          break;

      }

      return retorno;
    }
  }
}
