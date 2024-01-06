using DesafioPOO.Models;

Console.WriteLine($"Smartphone Nokia Modelo:");
Nokia aparalhoNokia = new Nokia(numero: "99888", imei: "11111111", memoria: 128, modeloNokia : "Modelo 3110", modelo: "3110");

aparalhoNokia.Ligar();
aparalhoNokia.ReceberLigacao();
aparalhoNokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine($"Smartphone Iphone Modelo:");
Iphone aparalhoIphone = new Iphone(numero: "555999", imei: "222222", memoria: 256, modeloIphone : "Modelo 8-Plus", modelo: "8-Plus");

aparalhoIphone.Ligar();
aparalhoIphone.ReceberLigacao();
aparalhoIphone.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

// FEITO!!!