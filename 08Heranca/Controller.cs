class Controller : Model 
{
    private string cargo;
    private double salario;

    public void db(int id, string nome, int idade, string cargo, double salario)
    {
        this.id = id;
        this.nome = nome;
        this.idade = idade;
        this.cargo = cargo;
        this.salario = salario;

        Console.WriteLine(msgModel());
        Console.WriteLine($"Cargo: {cargo}, Sálario: {salario}");
    }


}