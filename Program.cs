using DesafioPOO.Models;
Console.WriteLine("Smartphone Nokia!");

Smartphone nokia = new Nokia(numero: "123456789",modelo: "Nokia", imei: "123456789", memoria:32);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");


Console.WriteLine("/n");

Console.WriteLine("Smartphone Iphone!");

Smartphone iphone = new Iphone(numero: "123456789",modelo: "Iphone", imei: "123456789", memoria:32);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");


// TODO: Realizar os testes com as classes Nokia e Iphone