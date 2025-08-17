using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        Nokia nokia = new Nokia("123456789", "Nokia X20", "IMEI123456789", 128);
        Iphone iphone = new Iphone("987654321", "iPhone 14", "IMEI987654321", 256);

        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");

        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}