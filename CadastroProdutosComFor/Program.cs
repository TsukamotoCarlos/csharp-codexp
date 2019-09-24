using System;

namespace CadastroProdutosComFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cadastro de Produtos com For");

            string[] produtoNome = new string[3];//CamelCase
            double[] produtoPreco = new double[3];
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Digite o nome do {i+1}º produto");
                produtoNome[i] = Console.ReadLine();
                Console.WriteLine("Digite o Preço:");
                produtoPreco[i] = double.Parse(Console.ReadLine()); 
            
            }//fim for
            //Para  cada produto em produtoNome{coca, fata, pepsi}
            foreach (var produto in produtoNome)
            {
                Console.WriteLine($"Produto: {produto}");
         
            }//fim foreach
            for(int i = 0; i <3 ; i++){
                //no for consigo acessar quantos arrays forem necessários
                 Console.WriteLine($"Produto: {produtoNome[i]} preço: {produtoPreco[i]}");
            }//fim for

        }
    }
}


