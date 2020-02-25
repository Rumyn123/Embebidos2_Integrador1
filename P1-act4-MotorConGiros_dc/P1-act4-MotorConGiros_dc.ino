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
      mensaje("Apagando pin V=0");
      digitalWrite(pin, LOW);
      delay(90);
      mensaje("Prendiendo pin "+pin);
      digitalWrite(pin, HIGH);
    break;
    case 1:
      mensaje("Apagando pin  V=1");
      digitalWrite(pin, LOW);
      delay(80);
      mensaje("Prendiendo pin "+pin);
      digitalWrite(pin, HIGH);
    break;
    case 2:
      mensaje("Apagando pin  V=2");
      digitalWrite(pin, LOW);
      delay(70);
      mensaje("Prendiendo pin "+pin);
      digitalWrite(pin, HIGH);
    break;
    case 3:
      mensaje("Apagando pin  V=3");
      digitalWrite(pin, LOW);
      delay(60);
      mensaje("Prendiendo pin "+pin);
      digitalWrite(pin, HIGH);
    break;
    case 4:
      mensaje("Apagando pin V=4");
      digitalWrite(pin, LOW);
      delay(50);
      mensaje("Prendiendo pin "+pin);
      digitalWrite(pin, HIGH);
    break;
    case 5:
      mensaje("Apagando pin  V=5");
      digitalWrite(pin, LOW);
      delay(40);
      mensaje("Prendiendo pin "+pin);
      digitalWrite(pin, HIGH);
    break;
    case 6:
      mensaje("Apagando pin V=6");
      digitalWrite(pin, LOW);
      delay(30);
      mensaje("Prendiendo pin "+pin);
      digitalWrite(pin, HIGH);
    break;
    case 7:
      mensaje("Apagando pin  V=7");
      digitalWrite(pin, LOW);
      delay(20);
      mensaje("Prendiendo pin "+pin);
      digitalWrite(pin, HIGH);
    break;
    case 8:
      mensaje("Apagando pin  V=8");
      digitalWrite(pin, LOW);
      delay(10);
      mensaje("Prendiendo pin "+pin);
      digitalWrite(pin, HIGH);
    break;
    case 9:
      mensaje("Apagando pin  V=9");
      digitalWrite(pin, LOW);
      mensaje("Prendiendo pin "+pin);
      digitalWrite(pin, HIGH);
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
