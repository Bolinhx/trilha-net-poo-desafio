using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia("123456789", "Nokia 3310", "123456789", "16GB");
Smartphone iphone = new Iphone("987654321", "Iphone 12", "987654321", "128GB");


nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

iphone.Ligar();
iphone.InstalarAplicativo("Instagram");

