namespace Exercicio22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("----------------------------FIBONACCI--------------------------------");
                Console.WriteLine("---------------------------------------------------------------------");
                int number;
                bool success;
                do
                {
                    Console.WriteLine("Deseja checar a sequência de Fibonacci até qual número?");
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

                List<int> fibonacci = new List<int>();

                int a = 0, b = 1;
                fibonacci.Add(a);

                while (b <= number)
                {
                    fibonacci.Add(b);
                    int temp = a + b;
                    a = b;
                    b = temp;
                }
              
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("Sequência de Fibonacci até o número inserido:");
                Console.WriteLine(string.Join(" ", fibonacci));
                Console.WriteLine("---------------------------------------------------------------------");

                Console.Write("Deseja checar a sequência de Fibonacci em cima de outro número? (S/N): ");
                Console.WriteLine("\n---------------------------------------------------------------------");
                string toContinue = Console.ReadLine()!.ToUpper();
                if (toContinue != "S")
                    break;
            }
        }
    }
}
