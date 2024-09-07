using DesafioPOO.Models;

Nokia meuNokia = new Nokia("123456789", "Nokia 3310", "IMEI123456789", 32);
meuNokia.Ligar();
meuNokia.InstalarAplicativo("Instagran");

Iphone meuIphone = new Iphone("987654321", "Iphone 12", "IMEI987654321", 128);
meuIphone.ReceberLigacao();
meuIphone.InstalarAplicativo("WhatsApp");

// TODO: Realizar os testes com as classes Nokia e Iphone