using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia("98765-4321", "Nokia N1", "76325659876", 32);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Iphone iphone = new Iphone("96832-9945", "Iphone 12", "94820486299", 64);
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");