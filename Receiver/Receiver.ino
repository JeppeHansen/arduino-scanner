#define ledRed 10
#define ledGreen 11

void setup() {


  Serial.begin(9600);

  pinMode(ledRed, OUTPUT);
  pinMode(ledGreen, OUTPUT);

   // Startup sequence
  // -------------------------------
  for (int i = 0; i < 2; i++)
  {
    digitalWrite(ledRed, HIGH);
    delay(100);
    digitalWrite(ledRed, LOW);
    delay(100);

    digitalWrite(ledGreen, HIGH);
    delay(100);
    digitalWrite(ledGreen, LOW);
    delay(100);   
  }
}



void loop() {
  // put your main code here, to run repeatedly:

    digitalWrite(ledRed, HIGH);
    delay(2000);
    digitalWrite(ledRed, LOW);
    delay(100);

   while(Serial.available())
    {




    char ch = Serial.read();

    if (ch != 0){

      digitalWrite(ledGreen, HIGH);
      delay(2000);
      digitalWrite(ledGreen, LOW);
      delay(100);  
    }
  

  }
}


void SerialEvent(){

  while(Serial.available())
  {


    char ch = Serial.read();

    if (ch != 0){

      digitalWrite(ledGreen, HIGH);
      delay(2000);
      digitalWrite(ledGreen, LOW);
      delay(100);  
    }
  

  }

}














