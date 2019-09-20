using System;

namespace Arrays_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objetivo Efetuar o cadastro de usuário com os seguintes
            //dados Nome, Telefone e Email de 5 usuários;
            Console.WriteLine("Exercício de Arrays 2");

            string[] nomes = new string[3];
            string[] telefones = new string[3];
            string[] emails = new string[3];
            
            int contador = 0;
            while(contador <= 2){
                Console.WriteLine("Digite o seu nome");
                nomes[contador] = Console.ReadLine();

                Console.WriteLine("Digite o seu telefone");
                telefones[contador] = Console.ReadLine();

                Console.WriteLine("Digite seu E-Mail");
                emails[contador] = Console.ReadLine();
                contador++;
            }//fim do while

            int contadorB = 0;
            while(contadorB <= 2){
                Console.WriteLine($"O cliente número {contadorB+1} - Nome: {nomes[contadorB]}, Tel: {telefones[contadorB]}, E-Mail: {emails[contadorB]}");
                contadorB++;
            }//fim While

        }
    }
}
