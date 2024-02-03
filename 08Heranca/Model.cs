class Model 
{
    protected string nome;
    protected int idade;
    protected int id;

    protected void msgModel()
    {
        Console.WriteLine($"Id: {id}, Nome: {nome}, Idade: {idade}");
    }
}