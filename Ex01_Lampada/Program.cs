using System;

namespace Ex01_Lampada
{
    class Program
    {
        static void Main(string[] args)
        {
            var lampada = new Lampada("Philips", "LED");

            lampada.alternar();
            lampada.ajustarBrilho(55);

            Console.WriteLine($"A lâmpada {lampada.marca} tecnologia {lampada.tecnologia} está ligada? {lampada.estado} e no volume {lampada.brilho}");


        }
    }
}