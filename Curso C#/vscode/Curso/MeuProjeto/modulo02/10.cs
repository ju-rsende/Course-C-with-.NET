using System;

class Program
{
    static void Main()
    {

        // Exercício 10
        // Conversão de temperatura
        Console.Write("\nDigite a temperatura em graus Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        
        double kelvin = celsius + 273;
        double fahrenheit = (celsius * 9) / 5 + 32;
        
        Console.WriteLine($"Temperatura em Kelvin: {kelvin}");
        Console.WriteLine($"Temperatura em Fahrenheit: {fahrenheit}");
    
    }
}