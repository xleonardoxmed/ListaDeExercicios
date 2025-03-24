using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercicio18
{
    internal class Program
    {//Escrever um algoritmo que gera e escreve os números ímpares entre 100 e 200.
        static void Main(string[] args)
        {
                Console.Clear();
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Esses são os números ímpares entre 100 e 200.");
                Console.WriteLine("----------------------------------------");
              
                int[] numbers = Enumerable.Range(100, 101).ToArray();// determina o intervalo desejado (início/quantidade)
                int[] oddNumbers = numbers.Where(n => n % 2 != 0).ToArray();// separa somente os números que respeitam a condição: Terem resto na divisão por 2 (ímpares)

                Console.WriteLine(string.Join("|", oddNumbers));

                Console.WriteLine("------------------------------------------");
                Console.Write("Pressione qualquer tecla para sair.");              
                Console.ReadKey();
                Console.WriteLine("----------------------------------------");
        }
    }
}

