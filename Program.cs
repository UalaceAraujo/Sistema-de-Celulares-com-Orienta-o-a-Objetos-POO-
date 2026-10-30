using System.Text;
using DesafioPOO.Models;

Console.OutputEncoding = Encoding.UTF8;

Smartphone nokia = new Nokia("11987654321", "Nokia 3310", "111111111", 64);
Smartphone iphone = new Iphone("11912345678", "iPhone 14", "222222222", 128);

Console.WriteLine("=== TESTANDO NOKIA ===");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n=== TESTANDO IPHONE ===");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");