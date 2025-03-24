namespace Exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Enumerable.Range(1, 500).ToArray(); // intervalo
            int[] oddNumbers = numbers.Where(n => n % 2 != 0).ToArray(); // ímpares
            int[] multiplesOf3 = oddNumbers.Where(n => n % 3 == 0).ToArray(); // Múltiplos de três
            int sum = multiplesOf3.Sum(); // Soma dos elementos
            Console.WriteLine("------");
            Console.WriteLine(sum); // impressão
            Console.WriteLine("------");
            Console.ReadLine();
        }
    }
}
