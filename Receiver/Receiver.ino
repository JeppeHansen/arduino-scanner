#include "Sonar.h"


#define ledRed 10
#define ledGreen 11

#define echoPin 12 
#define trigPin 13

void setup() {


  Serial.begin(9600);

  pinMode(ledRed, OUTPUT);
  pinMode(ledGreen, OUTPUT);

  pinMode(trigPin, OUTPUT);
  pinMode(echoPin, INPUT);

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

  double duration, distance;



   while(Serial.available())
    {
      // ensure no transmits
      digitalWrite(trigPin, LOW);
      delayMicroseconds(2);


      char cmd = Serial.read();

      //Serial.println(cmd);

      switch(cmd) {
        case '1':
          digitalWrite(ledRed, HIGH);
          delay(2000);
          digitalWrite(ledRed, LOW);
          delay(100);
          break;
        case '2':

          // transmit
          digitalWrite(trigPin, HIGH);
          delayMicroseconds(10);
          digitalWrite(trigPin, LOW);

          duration = pulseIn(echoPin, HIGH);
          distance = ((duration * 340) / 10000) / 2;

          Serial.println(distance);
          digitalWrite(ledGreen, HIGH);
          delay(2000);
          digitalWrite(ledGreen, LOW);
          delay(100);
          break;
      }
    }
}
















