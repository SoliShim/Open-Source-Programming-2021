#define btnStatCk_(x)(digitalRead(d_btn##x)!=(st_btn##x)
#define btnPress_(x)((st_btn##x)==LOW)
#define btnStatSw_(x)((st_btn##x)=!(st_btn##x))

const int d_btnLU=3;

void setup() {
  pinMode(LED_BUILTIN, OUTPUT);
  pinMode(d_btnLU, INPUT);
  digitalWrite(d_btnLU, HIGH);
}

void loop() {
  // put your main code here, to run repeatedly:

}
