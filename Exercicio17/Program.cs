namespace Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------------------------------------------------------------");
                Console.WriteLine("VAMOS LÁ, O CONSOLE A SEGUIR TEM  O OBJETIVO DE: LER DOIS VALORES INTEIROS 'A' E 'B'.");
                Console.WriteLine("------------------------------------------------------------------------------------------------");
                Console.WriteLine("SE ESSES VALORES FOREM IGUAIS, ELES SERÃO SOMADOS, CASO CONTRÁRIO, SERÃO MULTIPLICADOS UM PELO OUTRO.");
                Console.WriteLine("------------------------------------------------------------------------------------------------");
                Console.WriteLine("INDEPENDENTE DO CÁLCULO, SERÁ GERADO UM VALOR 'C' COM O RESULTADO. VEJA A SEGUIR:");
                Console.WriteLine("------------------------------------------------------------------------------------------------");
                bool success;
                int A, B;
                do
                {
                    Console.WriteLine("Insira o primeiro número (A): ");
                    Console.WriteLine("------------------------------------------------------------------------------------------------");
                    success = int.TryParse(Console.ReadLine()!, out A);
                    if(!success)    
                    {
                        Console.WriteLine("Erro! Apenas números inteiros permitidos!");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        continue;
                    }
                } while (!success);

                do
                {
                    Console.WriteLine("Insira o segundo número (B): ");
                    Console.WriteLine("------------------------------------------------------------------------------------------------");
                    success = int.TryParse(Console.ReadLine()!, out B);
                    if (!success)
                    {
                        Console.WriteLine("Erro! Apenas números inteiros permitidos!");
                        Console.WriteLine("------------------------------------------------------------------------------------------------");
                        continue;
                    }
                } while (!success);

                int C;
                if (A == B)
                    C = A + B;
                else
                    C = A * B;

                Console.WriteLine("------------------------------------------------------------------------------------------------");
                Console.WriteLine($"Valor C = {C} ");

                Console.WriteLine("------------------------------------------------------------------------------------------------");
                Console.WriteLine("Deseja repetir o processo? (S/N): ");
                Console.WriteLine("------------------------------------------------------------------------------------------------");
                string toContinue = Console.ReadLine()!.ToUpper();
                if (toContinue != "S")
                    break;
            }
        }
    }
}
