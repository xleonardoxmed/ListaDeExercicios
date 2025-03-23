namespace Exercicio16
{
    internal class Program
    {

        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("TESTE DE PARIDADE");
                Console.WriteLine("------------------------------------------");
                int number = 0;
                bool success;
                do
                {
                    Console.Write("Insira o número que deseja checar: ");
                    string entry = Console.ReadLine()!;
                    success = int.TryParse(entry, out number);
                    Console.WriteLine("------------------------------------------");

                    if (success == false)
                    {                       
                        Console.WriteLine("ERRO! Somente números válidos permitidos");
                        Console.WriteLine("------------------------------------------");
                        continue;                       
                    }


                } while(!success);

                if (number % 2 == 0)
                    Console.WriteLine("Esse número é PAR");
                else
                    Console.WriteLine("Esse número é ÍMPAR");

                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Deseja fazer uma noca checagem? (S/N): ");
                Console.WriteLine("------------------------------------------");
                string toContinue = Console.ReadLine()!.ToUpper();
                if (toContinue != "S")
                    break;
            }
        }
    }
}
