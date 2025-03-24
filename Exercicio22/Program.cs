namespace Exercicio22
{
    internal class Program
    {//Escreva um programa que leia um número e
     //imprima a sequência de Fibonacci até esse número.  ///erroooo
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("----------------------------FIBONACCI--------------------------------");
                Console.WriteLine("---------------------------------------------------------------------");
                int number;
                bool success;
                do
                {
                    Console.WriteLine("Deseja checar a sequência de fibonnaci em cima de qual número?");
                    Console.WriteLine("---------------------------------------------------------------------");
                    string entry = Console.ReadLine()!;
                    success = int.TryParse(entry, out number);
                    if (!success || number <= 0)
                    {
                        Console.WriteLine("---------------------------------------------------------------------");
                        Console.WriteLine("Erro! Digite um número inteiro maior que zero.");
                        Console.WriteLine("---------------------------------------------------------------------");
                        continue;
                    }
                } while (!success || number <= 0);

                int[] fibonacci = new int[number];  
                if (number > 0) fibonacci[0] = 0;  // A primeira posição é 0
                if (number > 1) fibonacci[1] = 1;  // A segunda posição é 1


                for (int count = 2; count < number; count++)
                {
                  fibonacci[count] = fibonacci[count - 1] + fibonacci[count - 2];
                }
                Console.WriteLine("---------------------------------------------------------------------");

                if (fibonacci[number - 1] < number)
                {
                    int nextNumber = fibonacci[number - 1] + fibonacci[number - 2];
                    Console.WriteLine("Sequência de Fibonacci até o número inserido:");
                    Console.WriteLine(string.Join(" ", fibonacci) + " " + nextNumber);
                }
                else
                {
                    Console.WriteLine(string.Join(" ", fibonacci));
                }
                Console.WriteLine("---------------------------------------------------------------------");
                Console.Write("Deseja checar a sequência de Fibonacchi em cima de outro número? (S/N): ");
                Console.WriteLine("\n---------------------------------------------------------------------");
                string toContinue = Console.ReadLine()!.ToUpper();
                if (toContinue != "S")
                    break;
            }
        }
    }
}
