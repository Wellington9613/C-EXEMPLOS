using System.Globalization;
double raio, pi = 3.14159, area;

System.Console.WriteLine("Digite o Raio");
raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
area = pi * Math.Pow(raio, 2);
System.Console.WriteLine($"A={area.ToString("F4", CultureInfo.InvariantCulture)}");

