using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");

Smartphone nokia = new Nokia("83999418109", "Nokia", "123456", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smatphone Iphone");
Smartphone iphone = new Iphone("83999835748", "Iphone", "654321", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");

