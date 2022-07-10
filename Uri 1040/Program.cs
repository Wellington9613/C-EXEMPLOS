using System.Globalization;
double media, n1, n2, n3, n4;

Console.WriteLine("Digite as 4 Notas: ");
string[] vet = Console.ReadLine().Split(' ');
n1 = double.Parse(vet[0], CultureInfo.InvariantCulture) * 2;
n2 = double.Parse(vet[1], CultureInfo.InvariantCulture) * 3;
n3 = double.Parse(vet[2], CultureInfo.InvariantCulture) * 4;
n4 = double.Parse(vet[3], CultureInfo.InvariantCulture) * 1;
media = (n1 + n2 + n3 + n4) / 10;
Console.WriteLine($"Media: {media.ToString("F1", CultureInfo.InvariantCulture)}");
if (media >= 7.0)
{
    Console.WriteLine("Aluno aprovado.");
}
else if (media >= 5.0 && media <= 6.9)
{
    Console.WriteLine("Aluno em exame.");
    double exame;
    Console.WriteLine("Digite a nota do exame: ");
    exame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    double media_exame = (media + exame) / 2;
    System.Console.WriteLine("Nota do exame: " + exame);
    if (media_exame >= 5)
        Console.WriteLine("Aluno aprovado.");

    else
    {
        Console.WriteLine("Aluno reprovado.");

    }
    Console.WriteLine($"Media final: {media_exame.ToString("F1", CultureInfo.InvariantCulture)}");


}
else
{
    Console.WriteLine("Aluno reprovado");
}



