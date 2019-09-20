using System;

namespace Campeonato_de_Natação
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Campeonato de Natação");

            Console.WriteLine("Digite sua idade e veja qual categoria se enquadra:");
            int idade = int.Parse(Console.ReadLine());

            if(idade <= 7){
                Console.WriteLine("Sua categoria é Infantil A");
            }else if(idade <= 10){
                Console.WriteLine("Sua categoria é Infantil B");
            }else if(idade <= 13){
                Console.WriteLine("Sua categoria é Juvenil A");
            }else if(idade <= 17){
                Console.WriteLine("Sua categoria é Juvenil B");
            }
        {
                Console.WriteLine("Sua categoria é Adulto");
            }
        }
    }
}
