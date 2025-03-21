namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                int grades = 2;
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Calculadora de Média Ponderada");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Qual o peso da suas provas?: ");
                Console.WriteLine("-----------------------------");

                decimal[] allWeights = new decimal[grades];

                for (int weightsKnown = 0; weightsKnown < grades; weightsKnown++)
                {
                    
                    Console.Write($"Peso da Prova {weightsKnown + 1}: ");
                    decimal insert = Convert.ToDecimal(Console.ReadLine());
                    allWeights[weightsKnown] = insert;
                }

                Console.WriteLine("-----------------------------");
                Console.WriteLine("Insira as suas notas: ");
                Console.WriteLine("-----------------------------");

               
                decimal[] tests = new decimal[grades];

                for (int gradesKnown = 0; gradesKnown < grades; gradesKnown++)
                {
                    Console.Write($"Nota {gradesKnown + 1}: ");
                    decimal insert = Convert.ToDecimal(Console.ReadLine());
                    tests[gradesKnown] = insert;
                }

                decimal weightsXgrades = (tests[0] * allWeights[0]) + (tests[1] * allWeights[1]);           
                decimal weightsSum = allWeights.Sum();

                decimal Pondered = weightsXgrades / weightsSum;
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"A sua média ponderada é de: {Pondered:F2}");
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
