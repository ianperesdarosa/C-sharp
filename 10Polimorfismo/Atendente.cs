using System;
class Atendente : Imposto
{   
    public override void valeAlimentacao(int soldo)
    {   
        double calc = soldo * 0.9;
        string resSoldo = calc.ToString("F2");
        Console.WriteLine($"Desconto do cargo Atendente {(resSoldo)} do vale alimentação!");
    }

    public override void valeTransporte(int soldo)
    {      
        double calc = soldo * 0.9;
        string resSoldo = calc.ToString("F2");
        Console.WriteLine($"Desconto do cargo Atendente {(resSoldo)} do vale transporte!");
    }
}