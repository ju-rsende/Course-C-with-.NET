using System;

class Program
{
    static void Main()
    {
        // 1 - Criando a variável idade e exibindo seu valor
        int idade = 35;
        Console.WriteLine("Idade: " + idade);

        // 2 - Criando a variável nome e exibindo seu valor
        string nome = "Maria";
        Console.WriteLine("Nome: " + nome);

        // 3 - Criando a variável altura
        double altura = 3.45;
        Console.WriteLine("Altura: " + altura);

        // 4 - Criando a variável data e exibindo seu valor
        DateTime data = new DateTime(1999, 9, 4);
        Console.WriteLine("Data: " + data.ToString("dd/MM/yyyy"));

        // 5- Criar uma constante chamada ano e atribuir o valor 2025
        const int ano = 2025;
        Console.WriteLine("Ano: " + ano);

        // 6- Criar uma variável chamada nota e atribuir o valor 9.5
        float nota = 9.5f;
        Console.WriteLine("Nota: " + nota);

        // 7- Criar duas variáveis x e y do tipo int e calcular a soma
        int x = 77;
        int y = 66;
        int soma = x + y;
        Console.WriteLine("Soma de x e y: " + soma);

        // 11- O que é Camel Case? Exemplo de aplicação
        string minhaVariavel = "Exemplo de Camel Case";
        int totalDeItens = 10;
        Console.WriteLine("Camel Case: " + minhaVariavel + ", Total de Itens: " + totalDeItens);

        // 12- O que é Pascal Case? Exemplo de aplicação
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