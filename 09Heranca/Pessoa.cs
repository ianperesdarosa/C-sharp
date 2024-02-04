class Pessoa
{
    protected string? nome;

    protected int idade;

    protected void msgPessoa()
    {
        Console.WriteLine($"Nome: {nome}, Idade: {idade}");
    }
}