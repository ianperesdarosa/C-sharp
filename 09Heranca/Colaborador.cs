class Colaborador : Pessoa
{
    private int soldo;
    private string? cargo;

    public Colaborador(string nome, int idade, int soldo, string cargo)
    {
        this.nome = nome;
        this.idade = idade;
        this.soldo = soldo;
        this.cargo = cargo;

        msgPessoa();
        msgColaborador();
    }
    
    private void msgColaborador()
    {
        Console.WriteLine($"Soldo: {soldo}, Cargo: {cargo}");
    }
}