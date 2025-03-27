using System;

class Program
{
    static void Main()
    {

        // Exercício 4
        // Recebe dois valores do tipo double via teclado
        Console.Write("\nDigite o primeiro valor: ");
        double valor1 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Digite o segundo valor: ");
        double valor2 = Convert.ToDouble(Console.ReadLine());
        
        // Realiza as operações matemáticas
        double soma = valor1 + valor2;
        double subtracao = valor1 - valor2;
        double multiplicacao = valor1 * valor2;
        double divisao = valor2 != 0 ? valor1 / valor2 : double.NaN;
        double modulo = valor1 % valor2;
        double exponenciacao = Math.Pow(valor1, valor2);
        
        // Exibe os resultados
        Console.WriteLine($"Soma: {soma}");
        Console.WriteLine($"Subtração: {subtracao}");
        Console.WriteLine($"Multiplicação: {multiplicacao}");
        Console.WriteLine($"Divisão: {(valor2 != 0 ? divisao.ToString() : "Indefinido")}");
        Console.WriteLine($"Módulo: {modulo}");
        Console.WriteLine($"Exponenciação: {exponenciacao}");

    
    }
}