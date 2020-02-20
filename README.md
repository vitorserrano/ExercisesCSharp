## Utilizar C# no Visual Studio Code

1 - Baixar Extensão C# da Microsoft

2 - Abrir a pasta do projeto

3 - No Terminal: 
        - dotnet new console (Criar primeiro projeto - "Hello World")
        - dotnet run (Rodar o projeto) 

-------------------------------------------------------------------------------

using System;

namespace FIrst_Project_C_
{
    class Program 
    {
        static void Main(string[] args) 
        {
            // Adição e Divisão
            int valor1 = 3;
            int valor2 = 5;
            double valor3 = 1.2;
            
            var resultado = (valor1 + valor2) / valor3;
            Console.WriteLine(resultado);

//----------------------------------------------------------------//
            
            // Verificar se o diar de hoje é Par
            bool isDiaPar = true;
            int dia = DateTime.Now.Day;

            isDiaPar = (dia % 2) == 0;
            Console.WriteLine(isDiaPar);

//----------------------------------------------------------------//

            // GPS (Latitude, Longitude)
            var gps = new GPS(-23.6563393, -52.6066043);
            var gps2 = gps;
            gps.latitude = -8.90988;

            var gpsClass1 = new GPS2(1.01, -2.02);
            var gpsClass2 = gpsClass1;
            gpsClass1.longitude = -3.01;

            Console.WriteLine($"Latitude: {gps.latitude} / Longitude: {gps.longitude}");
            Console.WriteLine($"Latitude: {gps2.latitude} / Longitude: {gps2.longitude}");

            Console.WriteLine($"Latitude: {gpsClass1.latitude} / Longitude: {gpsClass1.longitude}");
            Console.WriteLine($"Latitude: {gpsClass2.latitude} / Longitude: {gpsClass2.longitude}");

//----------------------------------------------------------------//
            
            // Transacao 
            var transacao = new Transacao(TipoVenda.NFC);
            Console.WriteLine(transacao.ToString());

//----------------------------------------------------------------//
            // Input
            // var teste = Console.ReadLine();
            var teste = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Nome Digitado: {teste}");
        }

        public class GPS
        {
            public double latitude {get; set;}                
            public double longitude {get; set;}                

            // Construtor
            public GPS(double latitude, double longitude)
            {
                latitude = latitude;
                longitude = longitude;
            }
        }

        public class GPS2 
        {
            public double latitude {get; set;}                
            public double longitude {get; set;} 

            // Construtor
            public GPS2(double latitude, double longitude) 
            {
                latitude = latitude;
                longitude = longitude;
            }
        }

        public class Transacao
        {
            public int NumeroTransacao { get; set; }
            public DateTime DataTransacao { get; set; }    
            public TipoVenda Tipo { get; private set; }

            public Transacao(TipoVenda tipo)
            {
                NumeroTransacao = 1;
                DataTransacao = DateTime.Now;
                Tipo = tipo;
            } 

            public override string ToString() 
            {
                return $"Número : {NumeroTransacao}\n" +
                       $"Data: {DataTransacao.ToString()}\n" +
                       $"Tipo: {Tipo.ToString()}";
            }
        }

        public enum TipoVenda 
        {
            ECF,
            NFC,
            NFE,
            SAT
        }   
    }
}
