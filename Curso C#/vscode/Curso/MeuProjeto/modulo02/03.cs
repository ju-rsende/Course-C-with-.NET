using System;

class Program
{
    static void Main()
    {

        // Exercício 3
        // Recebe três letras via teclado
        Console.Write("Digite a primeira letra: ");
        char letra1 = Console.ReadKey().KeyChar;
        Console.Write("\nDigite a segunda letra: ");
        char letra2 = Console.ReadKey().KeyChar;
        Console.Write("\nDigite a terceira letra: ");
        char letra3 = Console.ReadKey().KeyChar;
        
        // Exibe na ordem reversa usando concatenação
        Console.WriteLine("\nOrdem reversa (concatenação): " + letra3 + letra2 + letra1);
        
        // Exibe na ordem reversa usando interpolação
        Console.WriteLine($"Ordem reversa (interpolação): {letra3}{letra2}{letra1}");


    }
}