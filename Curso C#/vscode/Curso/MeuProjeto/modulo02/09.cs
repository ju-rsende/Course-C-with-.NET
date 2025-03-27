using System;

class Program
{
    static void Main()
    {

        // Exercício 9
        // Teste de incremento pós e pré-fixado
        int yTeste = 5;
        yTeste = yTeste++ + yTeste + ++yTeste;
        Console.WriteLine($"Resultado de y: {yTeste}");

    
    }
}