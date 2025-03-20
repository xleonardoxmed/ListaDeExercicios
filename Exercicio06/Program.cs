namespace Exercicio06
{
    internal class Program
    {//Crie um programa para calcular a média harmônica das notas de um Aluno
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Quantas provas você fez?: ");
                Console.WriteLine("-----------------------------");
                int grades = int.Parse(Console.ReadLine()!);
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Insira-as");
                Console.WriteLine("-----------------------------");

                decimal[] tests = new decimal[grades];

                for (int gradesKnown = 0; gradesKnown < grades; gradesKnown++)
                {
                    Console.Write($"Nota {gradesKnown + 1}: ");
                    decimal insert = Convert.ToDecimal(Console.ReadLine());
                    tests[gradesKnown] = insert;
                }
                decimal sum = tests.Sum(n => 1m/ n);

                decimal harmonic = grades / sum;
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"A sua média harmônica é de: {harmonic:F2}");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Gostaria de fazer uma nova conversão? (S/N)");
                Console.WriteLine("-----------------------------");
                string toContinue = Console.ReadLine()!.ToUpper();
                if (toContinue != "S")
                    break;
            }
        }     
    }
}
