#ifndef SONAR_H
#define SONAR_H


#define ledRed 10
#define ledGreen 11

#define echoPin 12
#define echoPin 13


class Sonar
{
public:

	void led_startup(int times);
	float calc_distance_cm(double duration);
};


void Sonar::led_startup(int times) {

	for (int i = 0; i < times; i++) {

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

float Sonar::calc_distance_cm(double duration) {
	return ((duration * 340) / 10000) / 2;
}

#endif

