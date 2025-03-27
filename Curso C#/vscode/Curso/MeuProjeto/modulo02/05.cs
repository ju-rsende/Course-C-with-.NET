using System;

class Program
{
    static void Main()
    {

        // Exercício 5
        // Cálculo da fórmula de Bhaskara
        double a = 1, b = 12, c = -13;
        double delta = Math.Pow(b, 2) - 4 * a * c;
        
        if (delta < 0)
        {
            Console.WriteLine("Não existem raízes reais.");
        }
        else
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            
            Console.WriteLine($"As raízes da equação são: x1 = {x1}, x2 = {x2}");
        }

    
    }
}