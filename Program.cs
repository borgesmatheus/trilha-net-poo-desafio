using DesafioPOO.Models;

Console.WriteLine("Chamada do Nokia:");
Smartphone nokia = new Nokia(numero: "3411111111", modelo: "Modelo Lumia", imei: "1965497896512", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Chamada do IPhone:");
Smartphone iphone = new Iphone(numero: "342222222", modelo: "XR", imei: "58262591651", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Tinder");