using System;
using System.Collections.Generic;

namespace Romanos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número romano:");
            var numeroRomano = Console.ReadLine().ToUpper();

            var dicionario = new Dictionary<char, int>()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };
               
            var numeroInt = 0;

            try
            {
                for (var i = 0; i < numeroRomano.Length; i++)
                {
                    if (i < (numeroRomano.Length - 1) && dicionario[numeroRomano[i + 1]] > dicionario[numeroRomano[i]])
                    {
                        var numeroComposto = dicionario[numeroRomano[i + 1]] - dicionario[numeroRomano[i]];
                        numeroInt += numeroComposto;
                        i++;
                    }
                    else
                    {
                        numeroInt += dicionario[numeroRomano[i]];
                    }
                }

                Console.WriteLine(numeroInt);
            }
            catch(KeyNotFoundException)
            {
                Console.WriteLine("Número inválido! Tente novamente!");
            }
        }
    }
}
