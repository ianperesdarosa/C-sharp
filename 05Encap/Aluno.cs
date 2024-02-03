class Aluno
{
    private int n1, n2, n3;

    private int media()
    {   
        return n1 + n2 + n3;
    }

    public void situacao()
    {

        Console.Write("Digite sua nota: ");
        n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite sua nota: ");
        n2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite sua nota: ");
        n3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Nota do Aluno(a): {media()}");


        int res = media();

        if (res  >= 18)
        {
            Console.WriteLine("Aprovado!!!");
        }
        else 
        {
             Console.WriteLine("Reprovado!!!");
        }

    }
}