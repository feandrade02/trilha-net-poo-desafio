using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:\n");
Nokia nokia = new Nokia("123456789", "Nokia 3310", "IMEI123456789", 16);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");
nokia.Numero = "987654321";
Console.WriteLine($"Novo número do Nokia: {nokia.Numero}\n");

Console.WriteLine("Smartphone iPhone:\n");
Iphone iphone = new Iphone("987654321", "iPhone 12", "IMEI987654321", 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");
