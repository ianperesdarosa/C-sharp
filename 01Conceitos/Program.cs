using System;

namespace appConceitos
{
    class App 
    {
        public static void Main(string[] args) 
        {
            // Instancia uma instancia 
            Person obj = new Person();
            obj.nome = "Ian";
            obj.idade = 19;
            obj.msg();
        }
    }
}