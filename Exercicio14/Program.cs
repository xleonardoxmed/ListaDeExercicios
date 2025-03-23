namespace Exercicio14
{
    internal class Program
    {//Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("EM FILA DESCRESCENTE");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("INSIRA 3 VALORES INTEIROS E DISTINTOS");
                Console.WriteLine("------------------------------------------");
                bool success;
                int one;
                int two;
                int three;

                do
                {
                    Console.Write("Valor 1: ");
                    string entry = Console.ReadLine()!;                  
                    success = int.TryParse(entry, out one);
                    if(success == false)
                    {
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("ERRO! APENAS NÚMEROS INTEIROS TOLERADOS");
                        Console.WriteLine("------------------------------------------");
                    }

                } while (!success);

                do
                {
                    Console.Write("Valor 2: ");
                    string entry2 = Console.ReadLine()!;
                    success = int.TryParse(entry2, out two);
                    if (success == false)
                    {
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("ERRO! APENAS NÚMEROS INTEIROS TOLERADOS");
                        Console.WriteLine("------------------------------------------");
                    }
                } while (!success);

                do
                {
                    Console.Write("Valor 3: ");
                    string entry3 = Console.ReadLine()!;                   
                    success = int.TryParse(entry3, out three);
                    if (success == false)
                    {
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("ERRO! APENAS NÚMEROS INTEIROS TOLERADOS");
                        Console.WriteLine("------------------------------------------");
                    }
                } while (!success);

                if (one == two || one == three || two == three)
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("ERRO! OS 3 NÚMEROS PRECISAM SER DIFERENTES");
                    Console.WriteLine("PRESSIONE 'ENTER' PARA TENTAR NOVAMENTE...");
                    Console.WriteLine("------------------------------------------");
                    Console.ReadLine();
                    continue;
                }

                int[] numbers = { one, two, three };
                Array.Sort(numbers); //exibe os elementos em ordem crescente
                Array.Reverse(numbers); // inverte a ordem

                Console.WriteLine("ORDEM DESCRESCENTE:");
                Console.WriteLine($"{numbers[0]} - {numbers[1]} - {numbers[2]}");

                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Deseja reiniciar o progama? (S/N): ");
                Console.WriteLine("------------------------------------------");
                string toContinue = Console.ReadLine()!.ToUpper();
                if (toContinue != "S")
                    break;
            }
        }
    }
}
