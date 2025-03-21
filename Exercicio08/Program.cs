namespace Exercicio08
{
    internal class Program  
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("-----------------------------");
                Console.WriteLine("Consultor de Números Primos");
                Console.WriteLine("-----------------------------");
                Console.Write("Insira o número que deseja verificar: ");
                int number = Convert.ToInt32(Console.ReadLine());

                bool check = primeCheck(number);

                if (check)
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Esse número é primo!");
                    Console.WriteLine("-----------------------------");
                }
                else
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Esse número NÃO é primo!");
                    Console.WriteLine("-----------------------------");
                }
                Console.WriteLine("Deseja fazer uma nova verficação? (S/N)");
                Console.WriteLine("-----------------------------");
                string toContinue = Console.ReadLine()!.ToUpper();
                if (toContinue != "S")
                    break;


            }
        }
        static bool primeCheck(int number)
        {
            if (number <= 1)
            {
               return false;
            }

            for (int numberTwo = 2; numberTwo <= number / 2; numberTwo++)
            {
                if (number % numberTwo == 0)
                {
                    return false;
                }
            }
            return true;
        }
            

    }
}
