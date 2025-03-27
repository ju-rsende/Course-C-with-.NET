using System;

class Program
{
    static void Main()
    {

        // Exercício 8
        // Recebe um número inteiro via teclado
        Console.Write("\nDigite um número inteiro (x): ");
        int num = Convert.ToInt32(Console.ReadLine());
        double pi = 3.1415;
        
        // Cálculo das operações
        Console.WriteLine($"-6 + x * 5 = {-6 + num * 5}");
        Console.WriteLine($"(13 - 2) * x = {(13 - 2) * num}");
        Console.WriteLine($"(x + -2) * (20 / x) = {(num + -2) * (20.0 / num)}");
        Console.WriteLine($"(12 + x) / (x - 4) = {(12.0 + num) / (num - 4)}");
        Console.WriteLine($"3 * x^2 + x + 10 = {3 * Math.Pow(num, 2) + num + 10}");
        Console.WriteLine($"pi * x^2 = {pi * Math.Pow(num, 2)}");


    
    }
}