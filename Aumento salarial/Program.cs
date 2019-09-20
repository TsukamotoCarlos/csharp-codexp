using System;

namespace Aumento_salarial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App cálculo de aumento salarial");

            Console.WriteLine("Digite seu salário:");
            float salario = float.Parse(Console.ReadLine());

            if(salario < 990){
                double reajuste = salario * 0.3;//Efetua o cálculo do reajuste
                double sreajustado = salario + reajuste; // soma o reajuste ao salário
                Console.WriteLine($"Seu salário reajustado fica em: {sreajustado}");
            }else{
                Console.WriteLine($"Você não tem direito ao aumento salárial");
            }

        }
    }
}
