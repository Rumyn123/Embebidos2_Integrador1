int pinA = 8;
int pinB = 9;
int vel;

void setup() {
  // put your setup code here, to run once:
  pinMode(pinA, OUTPUT);
  pinMode(pinB, OUTPUT);
  Serial.begin(9600);
  vel = 0;
}

void mensaje (char m[]){
  Serial.println(m);
}

void velocidad (int v, int pin){
  switch(v){
    case 0:
      mensaje("Activando pwm en 10%");
      analogWrite(pin, 25);
    break;
    case 1:
      mensaje("Activando pwm en 20%");
      analogWrite(pin, 50);
    break;
    case 2:
      mensaje("Activando pwm en 30%");
      analogWrite(pin, 75);
    break;
    case 3:
      mensaje("Activando pwm en 40%");
      analogWrite(pin, 100);
    break;
    case 4:
      mensaje("Activando pwm en 50%");
      analogWrite(pin, 125);
    break;
    case 5:
      mensaje("Activando pwm en 60%");
      analogWrite(pin, 150);
    break;
    case 6:
      mensaje("Activando pwm en 70%");
      analogWrite(pin, 175);
    break;
    case 7:
      mensaje("Activando pwm en 80%");
      analogWrite(pin, 200);
    break;
    case 8:
      mensaje("Activando pwm en 90%");
      analogWrite(pin, 225);
    break;
    case 9:
      mensaje("Activando pwm en 100%");
      analogWrite(pin, 255);
    break;
  }
}


void loop() {
  // put your main code here, to run repeatedly:
  delay(300);
  switch(Serial.read()){
    case 48:
    digitalWrite(pinA, LOW);
    digitalWrite(pinB, LOW);
    mensaje("Motor apagado");
    break;
    case 49:
    digitalWrite(pinA, HIGH);
    digitalWrite(pinB, LOW);
    mensaje("Girando a la izquierda");
    break;
    case 50:
    digitalWrite(pinA, LOW);
    digitalWrite(pinB, HIGH);
    mensaje("Girando a la derecha");
    break;


    case 97:
    mensaje("Velocidad es igual a 0"); 
    vel = 0;
    break;
    case 98:
    mensaje("Velocidad es igual a 1");
    vel = 1;
    break;
    case 99:
    mensaje("Velocidad es igual a 2");
    vel = 2;
    break;
    case 100:
    mensaje("Velocidad es igual a 3");
    vel = 3;
    break;
    case 101:
    mensaje("Velocidad es igual a 4");
    vel = 4;
    break;
    case 102:
    mensaje("Velocidad es igual a 5");
    vel = 5;
    break;
    case 103:
    mensaje("Velocidad es igual a 6");
    vel = 6;
    break;
    case 104:
    mensaje("Velocidad es igual a 7");
    vel = 7;
    break;
    case 105:
    mensaje("Velocidad es igual a 8");
    vel = 8;
    break;
    case 106:
    mensaje("Velocidad es igual a 9");
    vel = 9;
    break;
  }

  
  if(digitalRead(pinA) == HIGH){
    mensaje("Mandando velocidad en el pinA");
    velocidad(vel, pinA);
  }else if(digitalRead(pinB) == HIGH){
    mensaje("Mandando velocidad  en el pinB");
    velocidad(vel, pinB);
  }
  
}
