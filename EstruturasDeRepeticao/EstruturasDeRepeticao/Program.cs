using System;

namespace EstruturasDeRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Favor informar palavras no argumento");
                return;
            }
            //for
            for (var indice = 0; indice < args.Length; indice++)
            {
                Console.WriteLine($"Estrutura for, indice e valor: {indice}, {args[indice]}");
            }

            //while
            var argsLidos = 0;
            while (argsLidos < args.Length)
            {
                Console.WriteLine($"Estrutura while, argsLidos e valor lido: {argsLidos}, {args[argsLidos]}");
                argsLidos++;
            }

            //$ para poder colocar variável dentro da string
            //do while
            var loopsEfetuados = 0;
            do
            {
                Console.WriteLine($"Estrutura do while, loops efetuados: {loopsEfetuados}, valor lido: {args[loopsEfetuados]}");
                loopsEfetuados++;
            } while (loopsEfetuados < args.Length);

            //foreach
            foreach (var argumento in args)
            {
                Console.WriteLine($"Estrutura foreach, valor lido: {argumento}");
            }

        }
    }
}



