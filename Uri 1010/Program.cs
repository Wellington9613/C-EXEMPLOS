using System.Globalization;
double valor, codigo, quantidade;

string[] vect = Console.ReadLine().Split(' ');
codigo = double.Parse(vect[0], CultureInfo.InvariantCulture);
quantidade = double.Parse(vect[1], CultureInfo.InvariantCulture);
valor = double.Parse(vect[2], CultureInfo.InvariantCulture);
string[] vect1 = Console.ReadLine().Split(' ');
double codigo1 = double.Parse(vect1[0], CultureInfo.InvariantCulture);
double quantidade1 = double.Parse(vect1[1], CultureInfo.InvariantCulture);
double valor1 = double.Parse(vect1[2], CultureInfo.InvariantCulture);
double valortotal = valor * quantidade;
double valortotal1 = valor1 * quantidade1;
double total = valortotal + valortotal1;
System.Console.WriteLine($"VALOR A PAGAR: R${total.ToString("F2", CultureInfo.InvariantCulture)} ");


