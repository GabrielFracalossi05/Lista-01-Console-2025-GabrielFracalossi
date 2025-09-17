// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Escreva um numemero maior que 0");
int num = int.Parse(Console.ReadLine());
for (int contador = 1; contador < num; contador++)
{
    Console.WriteLine($"{contador}");
}