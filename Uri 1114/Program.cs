// string senha;
// Console.WriteLine("Digite sua senha");
// senha = Console.ReadLine();
// while (senha != "2002")
// {
//     Console.WriteLine("Senha Invalida");
//     Console.WriteLine("Digite sua senha");
//     senha = Console.ReadLine();


// }
// Console.WriteLine("Acesso Permitido");string senha;
Console.WriteLine("Digite sua senha");
int senha = int.Parse(Console.ReadLine());
while (senha != 2002)
{
    Console.WriteLine("Senha Invalida");
    Console.WriteLine("Digite sua senha");
    senha = int.Parse(Console.ReadLine());


}
Console.WriteLine("Acesso Permitido");

