#define Pin1  2
#define Pin2  3
#define Pin3  4
#define Pin4  5
#define Pin5  6
#define Pin6  7
#define Pin7  8
#define Buzina  10

String inputString = "";
boolean stringComplete = false;
String commandString = "";
String aux="";

boolean isConnected = false;

void setup() {
  Serial.begin(9600);

  pinMode(Pin1, OUTPUT);
  pinMode(Pin2, OUTPUT);
  pinMode(Pin3, OUTPUT);
  pinMode(Pin4, OUTPUT);
  pinMode(Pin5, OUTPUT);
  pinMode(Pin6, OUTPUT);
  pinMode(Pin7, OUTPUT);
  pinMode(Buzina, OUTPUT);
  
}

void loop() {
        
    if(stringComplete)
    {
      stringComplete = false;
      getCommand();
      solenoideOFF();
      for(int i = 0; i < commandString.length() - 1; i++) {
        aux = commandString.substring(i, i + 1);
        executaNota();
      }
      
      inputString = "";
      solenoideOFF();
    }
}

void executaNota(){
  if(aux.equals("5")){

    digitalWrite(Pin1, LOW);
    digitalWrite(Pin2, LOW);
    digitalWrite(Pin6, LOW);
    
    delay(2000);
    solenoideOFF();
    delay(500);
  }else if(aux.equals("6")){

  digitalWrite(Pin1, LOW);
  digitalWrite(Pin2, LOW);
  
  digitalWrite(Pin5, LOW);
  digitalWrite(Pin6, LOW);
    
    
    delay(2000);
    solenoideOFF();
    delay(500);
    
  }else if(aux.equals("7")){
    
    digitalWrite(Pin4, LOW);
    digitalWrite(Pin5, LOW);
    digitalWrite(Pin6, LOW);
    digitalWrite(Buzina, HIGH);
    delay(100);
    digitalWrite(Buzina, LOW);
    delay(100);
    digitalWrite(Buzina, HIGH);
    delay(100);
    digitalWrite(Buzina, LOW);
    solenoideOFF();
    delay(2000);
    
  }else if(aux.equals("A")){

   
  digitalWrite(Pin2, LOW);
  
    delay(2000);
    solenoideOFF();
    delay(500);
    
  }else if(aux.equals("B")){

    
  digitalWrite(Pin5, LOW);
  
    delay(2000);
    solenoideOFF();
    delay(500);
    
  }else if(aux.equals("C")){

    digitalWrite(Pin5, LOW);
    
    delay(2000);
    solenoideOFF();
    delay(500);
    
  }else if(aux.equals("D")){

   digitalWrite(Pin1, LOW);
  digitalWrite(Pin2, LOW);
  digitalWrite(Pin3, LOW);
  digitalWrite(Pin4, LOW);
  digitalWrite(Pin5, LOW);
  digitalWrite(Pin6, LOW);
   
    delay(2000);
    solenoideOFF();
    delay(500);
    
  }else if(aux.equals("E")){

    digitalWrite(Pin4, LOW);
    
    delay(2000);
    solenoideOFF();
    delay(500);
    
  }else if(aux.equals("F")){

    digitalWrite(Pin1, LOW);
  
  digitalWrite(Pin5, LOW);
  
    delay(2000);
    solenoideOFF();
    delay(500);
    
  }else if(aux.equals("G")){

   digitalWrite(Pin1, LOW);
  
    delay(2000);
    solenoideOFF();
    delay(500);
    
  }else if(aux.equals("H")){
  
  
  digitalWrite(Pin2, LOW);
  
  digitalWrite(Pin6, LOW);
    
    delay(2000);
    solenoideOFF();
    delay(500);
    
  }else if(aux.equals("I")){

   
  digitalWrite(Pin2, LOW);
  
  digitalWrite(Pin4, LOW);
  
  digitalWrite(Pin6, LOW);
  
    delay(2000);
    solenoideOFF();
    delay(500);
    
  }else if(aux.equals("J")){

   
  digitalWrite(Pin5, LOW);
  digitalWrite(Pin6, LOW);
    
    delay(2000);
    solenoideOFF();
    delay(500);
    
  }else if(aux.equals("K")){

    
  digitalWrite(Pin6, LOW);
    
    delay(2000);
    solenoideOFF();
    delay(500);
    
  }else if(aux.equals("L")){

    
  digitalWrite(Pin4, LOW);
  
  digitalWrite(Pin6, LOW);
    
    delay(2000);
    solenoideOFF();
    delay(500);
    
  }else if(aux.equals("M")){

    digitalWrite(Pin1, LOW);
  
  
  digitalWrite(Pin5, LOW);
  digitalWrite(Pin6, LOW);
    
    delay(2000);
    solenoideOFF();
    delay(500);
    
  }else if(aux.equals("N")){

    digitalWrite(Pin1, LOW);
  
  digitalWrite(Pin6, LOW);
    
    delay(2000);
    solenoideOFF();
    delay(500);
    
  }else if(aux.equals("O")){

    
  digitalWrite(Pin2, LOW);
  digitalWrite(Pin3, LOW);
  
    delay(2000);
    solenoideOFF();
    delay(500);
    
  }else if(aux.equals("P")){

    
  digitalWrite(Pin2, LOW);
  digitalWrite(Pin3, LOW);
  digitalWrite(Pin4, LOW);
  
    delay(2000);
    solenoideOFF();
    delay(500);
    
  }else if(aux.equals("Q")){

    
  digitalWrite(Pin3, LOW);
  
  digitalWrite(Pin5, LOW);
  
    delay(2000);
    solenoideOFF();
    delay(500);
    
  }else if(aux.equals("R")){

   
  digitalWrite(Pin3, LOW);
  
    delay(2000);
    solenoideOFF();
    delay(500);
    
  }else if(aux.equals("S")){

   
  digitalWrite(Pin3, LOW);
  digitalWrite(Pin4, LOW);
  
    delay(2000);
    solenoideOFF();
    delay(500);
    
  }else if(aux.equals("T")){

   digitalWrite(Pin1, LOW);
  
  digitalWrite(Pin3, LOW);
  
  digitalWrite(Pin5, LOW);
  
    delay(2000);
    solenoideOFF();
    delay(500);
    
  }else if(aux.equals("U")){

    digitalWrite(Pin1, LOW);
  
  digitalWrite(Pin3, LOW);
  
    delay(2000);
    solenoideOFF();
    delay(500);
    
  }else if(aux.equals("V")){

    
  digitalWrite(Pin2, LOW);
  digitalWrite(Pin3, LOW);
  
  digitalWrite(Pin6, LOW);
    
    delay(2000);
    solenoideOFF();
    delay(500);
    
  }else if(aux.equals("W")){

    
  digitalWrite(Pin2, LOW);
  digitalWrite(Pin3, LOW);
  digitalWrite(Pin4, LOW);
  
  digitalWrite(Pin6, LOW);
    
    delay(2000);
    solenoideOFF();
    delay(500);
    
  }else if(aux.equals("X")){

    
  digitalWrite(Pin3, LOW);
  
  digitalWrite(Pin5, LOW);
  digitalWrite(Pin6, LOW);
    
    delay(2000);
    solenoideOFF();
    delay(500);
    
  }else if(aux.equals("Z")){

    
  digitalWrite(Pin3, LOW);
  
  
  digitalWrite(Pin6, LOW);
    
    delay(2000);
    solenoideOFF();
    delay(500);
    
  }else if(aux.equals("Y")){

   
  digitalWrite(Pin3, LOW);
  digitalWrite(Pin4, LOW);
  
  digitalWrite(Pin6, LOW);
    
    delay(2000);
    solenoideOFF();
    delay(500);
    
  }else if(aux.equals("a")){

    
    digitalWrite(Pin1, LOW);
  
  digitalWrite(Pin3, LOW);
  
  digitalWrite(Pin5, LOW);
  digitalWrite(Pin6, LOW);
    
    delay(2000);
    solenoideOFF();
    delay(500);
    
  }else if(aux.equals("b")){

   digitalWrite(Pin1, LOW);
  
  digitalWrite(Pin3, LOW);
  
  digitalWrite(Pin6, LOW);
    
    delay(2000);
    solenoideOFF();
    delay(500);
    
  }else if(aux.equals("c")){

    
  
  digitalWrite(Pin3, LOW);
  digitalWrite(Pin4, LOW);
  digitalWrite(Pin5, LOW);
  
  
    delay(2000);
    solenoideOFF();
    delay(500);
    
  }else if(aux.equals("1")){

    
  digitalWrite(Pin2, LOW);
  
  digitalWrite(Pin5, LOW);
  digitalWrite(Pin6, LOW);
    
    delay(2000);
    solenoideOFF();
    delay(500);
    
  }else if(aux.equals("2")){

    
  digitalWrite(Pin2, LOW);
  
  digitalWrite(Pin4, LOW);
  digitalWrite(Pin5, LOW);
  
  
    delay(2000);
    solenoideOFF();
    delay(500);
    
  }else if(aux.equals("3")){

   
  digitalWrite(Pin4, LOW);
  digitalWrite(Pin5, LOW);
  
  
    delay(2000);
    solenoideOFF();
    delay(500);
    
  }else if(aux.equals("4")){

   
  digitalWrite(Pin2, LOW);
  
  
  digitalWrite(Pin5, LOW);
 
  
    delay(2000);
    solenoideOFF();
    delay(500);
    
  }
  
}


void solenoideOFF()
{
  digitalWrite(Pin1, HIGH);
  digitalWrite(Pin2, HIGH);
  digitalWrite(Pin3, HIGH);
  digitalWrite(Pin4, HIGH);
  digitalWrite(Pin5, HIGH);
  digitalWrite(Pin6, HIGH);
}
void getCommand()
{
  if(inputString.length()>0)
  {
     commandString = inputString.substring(0,inputString.length()-1);
  }
}
  
void serialEvent() {
  while (Serial.available()) {
    char inChar = (char)Serial.read();
    inputString += inChar;

    if (inChar == '\n') {
      stringComplete = true;
    }
  }
}
