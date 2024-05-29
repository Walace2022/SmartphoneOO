//Testando a herança e o polimorfismo das classes Nokia e Iphone

using SmartphoneOO.Modelos;

Nokia nokia = new Nokia(numero: "11999999999", modelo: "Modelo 1", imei: "123456789", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Iphone iphone = new Iphone(numero: "11899999999", modelo: "Modelo 2", imei: "1234543239", memoria: 256);
iphone.ReceberLigação();
iphone.InstalarAplicativo("Telegram");