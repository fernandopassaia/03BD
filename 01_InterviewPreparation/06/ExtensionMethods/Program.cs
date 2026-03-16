using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        var pessoa = new Pessoa
        {
            Id = Guid.NewGuid(),
            Nome = "Fernando Passaia",
            CPF = "123.456.789-10",
            Endereco = "Rua Exemplo, 123",
            Telefone = "(11)99999-9999",
            Email = "fernando@email.com"
        };

        Console.WriteLine($"Nome: {pessoa.Nome}");
        Console.WriteLine($"CPF: {pessoa.CPF}");
        Console.WriteLine($"Email: {pessoa.Email}");

        Console.WriteLine();

        Console.WriteLine($"CPF válido? {pessoa.ValidaCpf()}");
        Console.WriteLine($"Email válido? {pessoa.Email.IsEmail()}");
    }
}

public class Pessoa
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string CPF { get; set; }
    public string Endereco { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
}

public static class Extensions
{
    // Nota - "this" diz ao compilador que quero estender a classe pessoa
    public static bool ValidaCpf(this Pessoa pessoa)
    {
        if (string.IsNullOrWhiteSpace(pessoa.CPF))
            return false;

        var regex = new Regex(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$");

        return regex.IsMatch(pessoa.CPF);
    }

    public static bool IsEmail(this string email)
    {
        // Nota - "this" diz ao compilador que quero estender a classe string
        if (string.IsNullOrWhiteSpace(email))
            return false;

        return email.Contains("@") && email.Contains(".");
    }
}