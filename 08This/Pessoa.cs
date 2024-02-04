using System;

class Pessoa 
{
    private string nome = "Erica";

    public Pessoa(string nome)
    {
        Console.WriteLine(nome);
        Console.WriteLine(this.nome);
    }
}