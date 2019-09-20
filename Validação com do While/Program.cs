using System;

namespace Validação_com_do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validação com DO WHILE");
            string email;
            do{
                Console.WriteLine("Digite seu E-Mail");
                email = Console.ReadLine(); //Carlos@gmail.com

            }while(!email.Contains("@") || !email.Contains("."));//repete quando a condição é verdadeira

            string senha;
            do
            {
                Console.WriteLine("Digite a senha");
                senha = Console.ReadLine();//1234567
            } while (senha.Length <= 6);


         

        }
    }
}
