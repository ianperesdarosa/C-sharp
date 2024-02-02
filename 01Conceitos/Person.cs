using System;

class Person
{
    //Atributos
    public string? nome;
    public int idade;


    //Métodos

    public void msg() 
    {
        Console.WriteLine("Holla, " + nome + " você tem " + idade + " anos!");
    }

}