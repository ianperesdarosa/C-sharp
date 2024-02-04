using System;

class Program
{
    static void Main(string[] args)
    {
        Gerente obj1 = new Gerente();
        obj1.valeAlimentacao(7500);
        obj1.valeTransporte(7500);
        Console.WriteLine("------------");
        Atendente obj2 = new Atendente();
        obj2.valeAlimentacao(3200);
        obj2.valeTransporte(3200);
        Console.WriteLine("------------");
        Estagiario obj3 = new Estagiario();
        obj3.valeTransporte(600);
        obj3.valeAlimentacao(600);
    }
}