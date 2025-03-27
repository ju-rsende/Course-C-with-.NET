using System;

class Program
{
    static void Main()
    {
        // Exercício 1
        // Declaração das variáveis
        string nome = "Paulo";
        int idade = 17;
        double nota = 7.5;

        // Exibição usando concatenação
        Console.WriteLine("Aluno " + nome + " tem " + idade + " anos e nota " + nota);
        
        // Exibição usando interpolação de strings
        Console.WriteLine($"Aluno {nome} tem {idade} anos e nota {nota}");
        
    
    }
}