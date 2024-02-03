using System;

class Pessoa 
{   
    //Construtor
    public Pessoa() 
    {
        Console.WriteLine("Contruido!");
    }

    public Pessoa(string nome)
    {
        Console.WriteLine($"Olá, {nome}");
    }
}