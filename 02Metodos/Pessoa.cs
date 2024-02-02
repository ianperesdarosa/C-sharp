using System;

class Pessoa 
{
        //Método 01
        public void apresentar()
        {
            Console.WriteLine("Ola!");
        }
        //Método 02
        public void apresentar(string nome)
        {
            Console.WriteLine("Olá, " + nome);
        }
        //Método 03
        public void apresentar(string fName, string lName)
        {
            Console.WriteLine("Informações: " + fName + " " + lName);
        }
}