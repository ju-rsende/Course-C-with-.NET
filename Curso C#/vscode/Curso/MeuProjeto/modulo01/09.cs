using System;

class Program
{
    static void Main()
    {

        // 9- O que é Pascal Case? Exemplo de aplicação
        MinhaClasse exemplo = new MinhaClasse();
        exemplo.MeuMetodo();
    }
}

class MinhaClasse
{
    public int MinhaPropriedade { get; set; }
    public void MeuMetodo()
    {
        Console.WriteLine("Exemplo de Pascal Case");
    }
}