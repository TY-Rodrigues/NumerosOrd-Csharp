using System;
using System.Collections.Generic;
using System.IO;

namespace OrdenacaoNumerosApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();

            Console.WriteLine("Digite 'sair' para finalizar \nDigite os números: ");

            while (true)
            {
                string entrada = Console.ReadLine();

                if (entrada.ToLower() == "sair")
                    break;

                if (int.TryParse(entrada, out int numero))
                {
                    numeros.Add(numero);
                }
                else
                {
                    Console.WriteLine("Entrada inválida. \nDigite um número válido ou 'sair' para finalizar.");
                }
            }

            numeros.Sort();

            Console.WriteLine("Números ordenados:");

            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }
            string caminhoArquivo = "numeros_ordenados.txt";

            using (StreamWriter writer = new StreamWriter(caminhoArquivo))
            {
                foreach (int num in numeros)
                {
                    writer.WriteLine(num);
                }
            }

            Console.WriteLine($"Números ordenados foram gravados no arquivo: {caminhoArquivo}");
        }
    }
}


