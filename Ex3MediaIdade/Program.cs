using System;

namespace Ex3MediaIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] idade = new int[2];
            int contador = 0;
            int maiorIdade = 0;
            int menorIdade = 0;
            while (contador < 2)
            {
                Console.WriteLine($"Digite a {contador+1}ª idade");
                idade[contador] = int.Parse(Console.ReadLine());
                if(idade[contador]>=18){
                    //Maior
                    maiorIdade++; 
                }else{
                    //menor
                    menorIdade++;
                }
                contador++;
            }//fim while
            Console.WriteLine($"Total de Maiores = {maiorIdade} e Menores = {menorIdade}");
        }
    }
}
