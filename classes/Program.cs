using System;

namespace classes
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa nome1, idade1, nome2, idade2;

            nome1 = new Pessoa();
            idade1 = new Pessoa();
            nome2 = new Pessoa();
            idade2 = new Pessoa();

            
            Console.WriteLine("insira seu nome:");
            nome1.nome = Console.ReadLine();
            Console.WriteLine("sua idade:");
            idade1.idade = int.Parse(Console.ReadLine());

            
            Console.WriteLine("insira seu nome:");
            nome2.nome = Console.ReadLine();
            Console.WriteLine("sua idade:");
            idade2.idade = int.Parse(Console.ReadLine());

            
            if (idade1.idade > idade2.idade)
            {
                Console.WriteLine("Mais velho(a): " + nome1.nome);
            }
            else if(idade1.idade < idade2.idade)
            {
                Console.WriteLine("mais velho(a): " + nome2.nome);
            }
            else
            {
                Console.WriteLine("mesma idade:" + idade1.idade);
            }
                  



        }
    }
}
