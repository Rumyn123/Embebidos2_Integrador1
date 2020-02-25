int pinA = 8;
int pinB = 9;
int vel = 0;
void setup() {
  // put your setup code here, to run once:
  pinMode(pinA, OUTPUT);
  pinMode(pinB, OUTPUT);
  Serial.begin(9600);
}

void mensaje (char m[]){
  Serial.println(m);
}

void velocidad (int v, int pin){
  switch(v){
    case 0:
      digitalWrite(pin, LOW);
      delay(1000);
      digitalWrite(pin, HIGH);
    break;
    case 1:
      digitalWrite(pin, LOW);
      delay(900);
      digitalWrite(pin, HIGH);
    break;
    case 2:
      digitalWrite(pin, LOW);
      delay(800);
      digitalWrite(pin, HIGH);
    break;
    case 3:
      digitalWrite(pin, LOW);
      delay(700);
      digitalWrite(pin, HIGH);
    break;
    case 4:
      digitalWrite(pin, LOW);
      delay(600);
      digitalWrite(pin, HIGH);
    break;
    case 5:
      digitalWrite(pin, LOW);
      delay(500);
      digitalWrite(pin, HIGH);
    break;
    case 6:
      digitalWrite(pin, LOW);
      delay(400);
      digitalWrite(pin, HIGH);
    break;
    case 7:
      digitalWrite(pin, LOW);
      delay(300);
      digitalWrite(pin, HIGH);
    break;
    case 8:
      digitalWrite(pin, LOW);
      delay(200);
      digitalWrite(pin, HIGH);
    break;
    case 9:
      digitalWrite(pin, LOW);
      delay(100);
      digitalWrite(pin, HIGH);
    break;
  }
}


void loop() {
  // put your main code here, to run repeatedly:
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
    
  }

  /*if(digitalRead(pinA) == HIGH){
    velocidad(vel, pinA);
  }else if(digitalRead(pinB) == HIGH){
    velocidad(vel, pinB);
  }

  switch(Serial.read()){
    case 97:
    vel = 0;
    break;
    case 98:
    vel = 1;
    break;
    case 99:
    vel = 2;
    break;
    case 100:
    vel = 3;
    break;
    case 101:
    vel = 4;
    break;
    case 102:
    vel = 5;
    break;
    case 103:
    vel = 6;
    break;
    case 104:
    vel = 7;
    break;
    case 105:
    vel = 8;
    break;
    case 106:
    vel = 9;
    break;
  }*/
  
}
