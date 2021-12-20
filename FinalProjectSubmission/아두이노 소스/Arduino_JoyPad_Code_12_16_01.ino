#include <Keyboard.h>

#define btnStatCk_(x) (digitalRead(d_btn##x) != (st_btn##x))
#define btnPress_(x) ((st_btn##x) == LOW)
#define btnStatSw_(x) ((st_btn##x) = !(st_btn##x))

#define KEY_LU 'f'
#define KEY_RU 'j'
#define KEY_C ' '
#define KEY_LD 'v'
#define KEY_RD 'n'
#define KEY_Coin 'c'

const int d_btnLU =3;
const int d_btnRU =4;
const int d_btnC =5;
const int d_btnLD =6;
const int d_btnRD =7;
const int d_btnCoin =8;

void setup() {
  pinMode(d_btnLU, INPUT);
  digitalWrite(d_btnLU, HIGH);

  pinMode(d_btnRU, INPUT);
  digitalWrite(d_btnRU, HIGH);

  pinMode(d_btnC, INPUT);
  digitalWrite(d_btnC, HIGH);

  pinMode(d_btnLD, INPUT);
  digitalWrite(d_btnLD, HIGH);

  pinMode(d_btnRD, INPUT);
  digitalWrite(d_btnRD, HIGH);

  pinMode(d_btnCoin, INPUT);
  digitalWrite(d_btnCoin, HIGH);


  Keyboard.begin();
  Keyboard.releaseAll();
}

void loop() {

  static boolean st_btnLU = HIGH;
  static boolean st_btnRU = HIGH;
  static boolean st_btnC = HIGH;
  static boolean st_btnLD = HIGH;
  static boolean st_btnRD = HIGH;
  static boolean st_btnCoin = HIGH;

  if(btnStatCk_(LU)) {
    btnStatSw_(LU);
    if (btnPress_(LU))  Keyboard.press(KEY_LU);
    else        Keyboard.release(KEY_LU);
  }

  if(btnStatCk_(RU)) {
    btnStatSw_(RU);
    if (btnPress_(RU))  Keyboard.press(KEY_RU);
    else        Keyboard.release(KEY_RU);
  }

  if(btnStatCk_(C)) {
    btnStatSw_(C);
    if (btnPress_(C))  Keyboard.press(KEY_C);
    else        Keyboard.release(KEY_C);
  }

  if(btnStatCk_(LD)) {
    btnStatSw_(LD);
    if (btnPress_(LD))  Keyboard.press(KEY_LD);
    else        Keyboard.release(KEY_LD);
  }

  if(btnStatCk_(RD)) {
    btnStatSw_(RD);
    if (btnPress_(RD))  Keyboard.press(KEY_RD);
    else        Keyboard.release(KEY_RD);
  }

  if(btnStatCk_(Coin)) {
    btnStatSw_(Coin);
    if (btnPress_(Coin))  Keyboard.press(KEY_Coin);
  }

  delay(20);
}
