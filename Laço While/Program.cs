using System;

namespace Laço_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laço de Repetição While");
            
            Console.WriteLine("Digite o Número Inicial");        
            int contador = int.Parse(Console.ReadLine()) ;

            Console.WriteLine("Digite o valor limite");
            int limite = int.Parse(Console.ReadLine());

            Console.WriteLine("---------------------");

            
           while(contador <= limite)
           {
            Console.WriteLine(contador);
        
            contador = contador + 1;

           }//fim do While



        }
    }
}
