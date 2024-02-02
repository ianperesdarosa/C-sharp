using System;

class Aluno 
{
    public string? nome;
    public int id;
    public int nota1;
    public int nota2;
    public int nota3;


    public double media()
    {
        return (nota1 + nota2 + nota3);
    }

    public string situação(double media)
    {
        return media >= 18 ? "Aprovado!" : "Reprovado";
    }

    public void informations()
    {   
        double mediaNota = media();
        string res = situação(mediaNota);
        Console.WriteLine($"Id: {id}, Nome: {nome}, Situação: {res}, Nota: {mediaNota}");
    }

}