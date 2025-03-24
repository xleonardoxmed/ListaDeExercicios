namespace Exercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("-------------FATORIAL----------------");
                Console.WriteLine("--------------------------------------------");
                int number;
                string elements;                            
                bool success;
                do
                {
                    Console.WriteLine("Deseja checar o fatorial de qual número?");
                    Console.WriteLine("--------------------------------------------");
                    string entry = Console.ReadLine()!;
                    success = int.TryParse(entry, out number);
                    if(!success || number <= 0)
                    {
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("Erro! Digite um número inteiro maior que zero.");
                        Console.WriteLine("--------------------------------------------");
                        continue;
                    }
                } while (!success || number <= 0);
             
                int[] array = Enumerable.Range(1, number).ToArray();
                Array.Sort(array);
                Array.Reverse(array);
                elements = String.Join(" x ", array);

                Console.WriteLine("--------------------------------------------");
                int agg = array.Aggregate(1, (acc, val) => acc * val);
                Console.WriteLine($"{number}!: {elements} : {agg} ");

                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Deseja conferir o fatorial de outro número? (S/N): ");
                Console.WriteLine("--------------------------------------------");
                string toContinue = Console.ReadLine()!.ToUpper();
                if (toContinue != "S")
                    break;
            }
        }
    }
}
