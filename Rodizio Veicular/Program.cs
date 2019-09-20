using System;

namespace Rodizio_Veicular
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rodizio Veícular");

            Console.WriteLine("Insira a sua placa");
            // int placa = int.Parse(Console.ReadLine());
            string placa = Console.ReadLine();

            int caracteres = placa.Length;
            //abc1234
            int final = int.Parse(placa.Substring(caracteres - 1));

            Console.WriteLine($"O útimo número é: {final}");
            Console.WriteLine("Seu Rodizio é de:");
            if(final == 0 || final == 1){
                Console.WriteLine("Segunda-Feira");
            }else if(final == 2 || final == 3){
                Console.WriteLine("Terça-Feira");
            }else if(final == 4 || final == 5){
                Console.WriteLine("Quarta-Feira");
            }else if(final == 6 ||  final == 7){
                Console.WriteLine("Quinta-Feira");
            }else if(final == 8 || final == 9){
                Console.WriteLine("Sexta-Feira");
            }else{
                Console.WriteLine("Insira apenas o último dígito");
            }
        }
    }
}
