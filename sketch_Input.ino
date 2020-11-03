void setup() {
  // 시리얼 통신 전송속도 설정
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
 int len;
 char input;
 len = Serial.available();
 input = Serial.println(len);
 Serial.read(); // 버퍼 내 문자열 글자씩 출력
 delay(1000);
}
