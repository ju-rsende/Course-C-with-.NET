using System;

class Program
{
    static void Main()
    {

        // Exercício 7
        // Recebe dois números inteiros via teclado
        Console.Write("\nDigite o primeiro número inteiro (x): ");
        int x = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Digite o segundo número inteiro (y): ");
        int y = Convert.ToInt32(Console.ReadLine());
        
        // Verifica se são pares ou não usando operador ternário
        string resultadoX = (x % 2 == 0) ? "par" : "ímpar";
        string resultadoY = (y % 2 == 0) ? "par" : "ímpar";
        
        Console.WriteLine($"O número {x} é {resultadoX}.");
        Console.WriteLine($"O número {y} é {resultadoY}.");


    
    }
}