#include<Wire.h>
#include"DFRobot_SHTC3.h"

DFRobot_SHTC3 sensor;

String receiveVal;
uint32_t id = 0;
float temperature,  humidity;

void setup() {
   Serial.begin(9600);
   sensor.begin();
   sensor.wakeup();

     while((id = sensor.getDeviceID()) == 0){
    delay(10);
  }
}

void loop() {
  // put your main code here, to run repeatedly:
  if(Serial.available())
    {
      receiveVal = Serial.readString();
      if (receiveVal.startsWith("T"))
        {
            /**
             * 
             *    mode  Configure sensor working mode, vary among different sensors 
             *          SHTC3：
             *                  PRECISION_HIGH_CLKSTRETCH_ON                              Clock Stretching Enabled 
             *                  PRECISION_HIGH_CLKSTRETCH_OFF                             Clock Stretching Disabled 
             *                  PRECISION_LOW_CLKSTRETCH_ON                               Clock Stretching Enabled & Low Power
             *                  PRECISION_LOW_CLKSTRETCH_OFF                              Clock Stretching Disabled & Low Power
             */
           temperature = sensor.getTemperature(/*mode = */ PRECISION_HIGH_CLKSTRETCH_OFF);
           humidity = sensor.getHumidity(/*mode = */ PRECISION_HIGH_CLKSTRETCH_OFF); 
           if(temperature == MODE_ERR)
            {
              Serial.println("Incorrect mode configuration to get temperature");
            } 
           else if(humidity == MODE_ERR)
            {
              Serial.println("Incorrect mode configuration to get humidity");

            }
            else{
              Serial.println(temperature, 1);
              Serial.println(humidity, 1);            
              }
        }
    
           
    

    
    
    
    }
}
