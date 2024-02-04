using System;
class Gerente : Imposto
{
    public override void valeAlimentacao(int soldo)
    {
        Console.WriteLine($"Desconto do cargo Gerente {(soldo * 0.15)} do vale alimentação!");
    }

    public override void valeTransporte(int soldo)
    {
        Console.WriteLine($"Desconto do cargo Gerente {(soldo * 0.15)} do vale transporte!");
    }
}