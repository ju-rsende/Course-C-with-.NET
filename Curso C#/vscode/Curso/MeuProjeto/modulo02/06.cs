using System;

class Program
{
    static void Main()
    {

        // Exercício 6
        // Recebe nome e senha via teclado
        Console.Write("\nDigite o nome de usuário: ");
        string usuario = Console.ReadLine();
        
        Console.Write("Digite a senha: ");
        int senha = Convert.ToInt32(Console.ReadLine());
        
        // Validação com operador condicional ternário
        string mensagem = (usuario == "admin" || usuario == "maria") && senha == 123 
            ? "Login feito com sucesso" 
            : "Login inválido";
        
        Console.WriteLine(mensagem);

    }
}