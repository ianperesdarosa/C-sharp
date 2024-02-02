using System;

namespace appConceitos
{
    class Program
    {
        public static void Main(string[] args) 
        {
            // Instanciando um objeto
            Person obj = new Person();
            obj.nome = "Ian";
            obj.idade = 19;
            obj.msg();
        }
    }
}