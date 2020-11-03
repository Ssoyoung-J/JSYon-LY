void setup() {
  // 시리얼 통신 전송속도 설정
  Serial.begin(9600);
 for(int i=0;i<=255;i++){
   Serial.print (i,DEC);
   Serial.print ("\t");
   Serial.print (i,BIN);
   Serial.print ("\t");
   Serial.print (i,OCT);
   Serial.print ("\t");
   Serial.println (i,HEX);
 }

}

void loop() {
  // put your main code here, to run repeatedly:
 
}
