using DesafioPOO.Models;

Console.WriteLine("Especificações Nokia:");
Console.WriteLine("---------------------");
Nokia n1 = new Nokia(numero: "(71) 93456-9786", modelo: "S20", imei:"343423523", memoria: 256);
Console.WriteLine($"Número: {n1.Numero}");
Console.WriteLine($"Modelo: {n1.Modelo}");
Console.WriteLine($"IMEI do Smartphone: {n1.IMEI}");
Console.WriteLine($"Memória: {n1.Memoria}");
Console.WriteLine("----------------------");
Console.WriteLine("\n");

n1.Ligar();
n1.InstalarAplicativo(nomeApp: "Instagram");
n1.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("Especificações Iphone:");
Console.WriteLine("---------------------");
Iphone i1 = new Iphone(numero: "(71) 92368-1234", modelo: "15 plus", imei:"12343536", memoria: 128);
Console.WriteLine($"Número: {i1.Numero}");
Console.WriteLine($"Modelo: {i1.Modelo}");
Console.WriteLine($"IMEI do Smartphone: {i1.IMEI}");
Console.WriteLine($"Memória: {i1.Memoria}");
Console.WriteLine("---------------------");
Console.WriteLine("\n");

n1.Ligar();
i1.InstalarAplicativo(nomeApp: "Snapchat");
n1.ReceberLigacao();
