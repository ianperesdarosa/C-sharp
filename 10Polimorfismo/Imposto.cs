using System;
class Imposto
{   

    public virtual void valeAlimentacao(int soldo)
    {
        Console.WriteLine($"Desconto padrão de {(soldo * 0.1)} do vale transporte!");
    }   

    public virtual void valeTransporte(int soldo) 
    {
        Console.WriteLine($"Desconto padrão de {(soldo * 0.1)} do vale alimentação!");
    }
}