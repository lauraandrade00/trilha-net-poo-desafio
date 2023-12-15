using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "56754", modelo: "Nova Iorque", imei: "38378435", memoria: 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Cacululadora Inteligente");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "74635", modelo: "Dakota", imei: "74823903", memoria: 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Duolingo");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Xiaomi:");
Smartphone xiaomi = new Xiaomi(numero: "93647", modelo: "Atlanta", imei: "84392716", memoria: 128);
xiaomi.Ligar();
xiaomi.ReceberLigacao();
xiaomi.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Motorola:");
Smartphone motorola = new Motorola(numero: "65934", modelo: "Iowa", imei: "76644323", memoria: 128);
motorola.Ligar();
motorola.ReceberLigacao();
motorola.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Samsung:");
Smartphone samsung = new Samsung(numero: "12865", modelo: "Texas", imei: "78659454", memoria: 64);
samsung.Ligar();
samsung.ReceberLigacao();
samsung.InstalarAplicativo("Dio");



