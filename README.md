# OlympiaGame

### Đây là project môn học .Net


#### Để chạy được project này cần một Broker MQTT trung gian giữa Client và Server
- Mosquitto là tốt nhất http://mosquitto.org/download/

- Có thể tham khảo cách cài tại đây https://sivatechworld.wordpress.com/2015/06/11/step-by-step-installing-and-configuring-mosquitto-with-windows-7/
> Sau khi cài đặt xong cần phải chỉnh lại địa chỉ server trong code
  - File ServerForm.cs `String MQTT_BROKER_ADDRESS = "your mqtt broker address";`
  - File ClientThiSinhForm `String MQTT_BROKER_ADDRESS = "your mqtt broker address";`
  
  Ví dụ: địa chỉ mqtt borker của mình là 192.168.1.6
  
  ==>> `String MQTT_BROKER_ADDRESS = "192.168.1.6";`
  
