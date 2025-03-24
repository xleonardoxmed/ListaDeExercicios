using System;

namespace Exercicio20
{
   
    internal class Program
    { 
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("Tabuada");
                Console.WriteLine("--------------------------------------------------------------");
                string[] x = new string[10];

                int number = 0;
                bool success;
                do
                {
                    Console.Write("Deseja ver a tabuada de qual número?: ");
                    string entry = Console.ReadLine()!;
                    success = int.TryParse(entry, out number);
                    if (!success || number <= 0)
                    {
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine("Erro! Somente números inteiros maiores que zero permitidos!");
                        Console.WriteLine("--------------------------------------------------------------");
                        continue;
                    }

                } while (!success || number <= 0);

                for (int count = 1; count <= x.Length; count++)
                {
                    int result = number * count;

                    x[count - 1] = $"{number} x {count} = {result}";
                }
                Console.WriteLine("--------------------------------------------------------------");
                for (int count = 0; count < x.Length; count++)
                    Console.WriteLine(x[count]);

                Console.WriteLine("--------------------------------------------------------------");
                Console.Write("Deseja conferir a tabuada de outro número? (S/N): ");
                string toContinue = Console.ReadLine()!.ToUpper();
                if (toContinue != "S")
                    break;
            }
        }
    }
}
