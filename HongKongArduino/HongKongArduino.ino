const int DATA0 = 2;
const int DATA1 = 3;
const int DATA2 = 4;
const int DATA3 = 5;
const int DATA4 = 6;
const int DATA5 = 7;
const int DATA6 = 8;
const int DATA7 = 9;

const int GD = 10;
const int G0 = 11;
const int G1 = 12;
const int G2 = 13;

const int DIR = 14;
const int CK = 15;
const int OE = 16;
const int CS = 17;
const int WE = 18;
const int RST = 19;

void setDataDir(int DATADIR)
{
  if (DATADIR == INPUT) {
    DDRD &= 0b00000011;
    DDRB &= 0b11111100;
  } else {
    DDRD |= 0b11111100;
    DDRB |= 0b00000011;
  }
}

void setData(byte b)
{
  PORTD &= 0b00000011;
  PORTB &= 0b11111100;
  PORTD |= b << 2;
  PORTB |= b >> 6;
}

void outCh(int ch, byte b)
{
  PORTB &= ~0b00001000 << ch; //0b11110111
  setData(b);
  PORTC |= 0b00000010;
  PORTC &= 0b11111101;
  PORTB |= 0b00001000 << ch; // Ch Disable
}

void setAddress(unsigned long address, int isLoROM)
{
  if (isLoROM) {
    unsigned long upper = address / 0x8000;
    unsigned long lower = address % 0x8000;
    address = upper * 2 * 0x8000 + lower + 0x8000;
  }

  byte a[3];

  a[0] = (byte)(address >> (8*0));
  a[1] = (byte)(address >> (8*1));
  a[2] = (byte)(address >> (8*2));
  
  outCh(0, a[0]);
  outCh(1, a[1]);
  outCh(2, a[2]);
}

void readData()
{
  setDataDir(INPUT);
  digitalWrite(GD, LOW); // Ch Enable

  byte b = 0;
  for (int i = 0; i < 8; i++) {
    if (digitalRead(DATA0 + i) == HIGH) {
      b |= (1 << i);
    }
  }

  digitalWrite(GD, HIGH); // Ch Disable
  setDataDir(OUTPUT);
  
  Serial.write(b);
}

void setup()
{
  setDataDir(OUTPUT);

  for (int i = GD; i <= RST; i++) {
    pinMode(i, OUTPUT);
  }

  digitalWrite(GD, HIGH); // Disable
  digitalWrite(G0, HIGH); // Disable
  digitalWrite(G1, HIGH); // Disable
  digitalWrite(G2, HIGH); // Disable

  digitalWrite(CK, LOW);

  digitalWrite(DIR, LOW); // 入力
  
  digitalWrite(OE, LOW);  // RD
  digitalWrite(CS, LOW);
  digitalWrite(WE, HIGH); // WR
  digitalWrite(RST, LOW);

  Serial.begin(500000);
}

void loop()
{
  if (Serial.available() >= 2) {
    byte cmd = Serial.read();
    
    if (cmd == 'R' || cmd == 'r') {
      while (Serial.available() < 6) {
        delay(1);
      }

      int isLoROM = false;
      if (cmd == 'r') {
        isLoROM = true;
      }
      unsigned long a = Serial.read();
      unsigned long address = a;
      a = Serial.read();
      address += (a << 8);
      a = Serial.read();
      address += (a << 8*2);
      
      a = Serial.read();
      unsigned long datasize = a;
      a = Serial.read();
      datasize += (a << 8);
      a = Serial.read();
      datasize += (a << 8*2);
      
      for (unsigned long i = 0; i < datasize; i++, address++) {
        setAddress(address, isLoROM);
        readData();
      }

    } else if (cmd == 'c') {
      // control
      byte b = Serial.read();
      
      digitalWrite(OE, (b & B0001) ? HIGH : LOW);   // RD
      digitalWrite(CS, (b & B0010) ? HIGH : LOW);
      digitalWrite(WE, (b & B0100) ? HIGH : LOW);   // WR
      digitalWrite(RST, (b & B1000) ? HIGH : LOW);

    } else if (cmd == 'S' || cmd == 's') {
      // control
      byte b = Serial.read();
      
      digitalWrite(OE,  LOW);   // RD
      digitalWrite(CS, (cmd == 'S') ? HIGH : LOW);
      digitalWrite(WE,  HIGH);   // WR
      digitalWrite(RST, HIGH);

	  // LoROM : A15, BA4(A20), BA5(A21) - high
	  // HiROM : A13, A14, BA5(A20)      - high
    }
  }
}

