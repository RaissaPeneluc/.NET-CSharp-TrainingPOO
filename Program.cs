using DesafioPOO.Models;

Console.WriteLine("Digite o número do celular Nokia:");
string numeroNokia = Console.ReadLine();

Console.WriteLine("Digite o modelo do celular Nokia:");
string modeloNokia = Console.ReadLine();

Console.WriteLine("Digite o IMEI do celular Nokia:");
string imeiNokia = Console.ReadLine();

Console.WriteLine("Digite a memória do celular Nokia:");
int memoriaNokia = int.Parse(Console.ReadLine());

Nokia n1 = new Nokia(numero: numeroNokia, modelo: modeloNokia, imei: imeiNokia, memoria: memoriaNokia);


Console.WriteLine("\n\nEspecificações Nokia:");
Console.WriteLine("---------------------");
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

Console.WriteLine("Digite o número do celular Iphone:");
string numeroIphone = Console.ReadLine();

Console.WriteLine("Digite o modelo do celular Iphone:");
string modeloIphone = Console.ReadLine();

Console.WriteLine("Digite o IMEI do celular Iphone:");
string imeiIphone = Console.ReadLine();

Console.WriteLine("Digite a memória do celular Iphone:");
int memoriaIphone = int.Parse(Console.ReadLine());

Iphone i1 = new Iphone(numero: numeroIphone, modelo: modeloIphone, imei: imeiIphone, memoria: memoriaIphone);


Console.WriteLine("\n\nEspecificações Iphone:");
Console.WriteLine("---------------------");
Console.WriteLine($"Número: {i1.Numero}");
Console.WriteLine($"Modelo: {i1.Modelo}");
Console.WriteLine($"IMEI do Smartphone: {i1.IMEI}");
Console.WriteLine($"Memória: {i1.Memoria}");
Console.WriteLine("---------------------");
Console.WriteLine("\n");

n1.Ligar();
i1.InstalarAplicativo(nomeApp: "Snapchat");
n1.ReceberLigacao();
