namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Vamos checar se A + B < C");
                Console.WriteLine("------------------------------------------");
                bool sucess;
                decimal Avalue = 0;
                decimal Bvalue = 0;
                decimal Cvalue = 0;

                do
                {
                    Console.WriteLine("Insira o valor de A");
                    Console.WriteLine("------------------------------------------");
                    string entry = Console.ReadLine()!;
                    sucess = true;
                    sucess = decimal.TryParse(entry, out Avalue);

                    if (sucess == false)
                    {
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("Erro! digite apenas NÚMEROS");
                        Console.WriteLine("------------------------------------------");
                    }

                } while (!sucess);

                do
                {
                    Console.WriteLine("Insira o valor de B");
                    Console.WriteLine("------------------------------------------");
                    string entry = Console.ReadLine()!;
                    sucess = true;
                    sucess = decimal.TryParse(entry, out Bvalue);

                    if (sucess == false)
                    {
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("Erro! digite apenas NÚMEROS");
                        Console.WriteLine("------------------------------------------");
                    }

                } while (!sucess);

                do
                {
                    Console.WriteLine("Insira o valor de C");
                    Console.WriteLine("------------------------------------------");
                    string entry = Console.ReadLine()!;
                    sucess = true;
                    sucess = decimal.TryParse(entry, out Cvalue);

                    if (sucess == false)
                    {
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("Erro! digite apenas NÚMEROS");
                        Console.WriteLine("------------------------------------------");
                    }

                } while (!sucess);


                if (Avalue + Bvalue > Cvalue)
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("A SOMA DE ('A' + 'B') É -MAIOR- QUE 'C'");
                    Console.WriteLine("------------------------------------------");
                }

                else if (Avalue + Bvalue < Cvalue)
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("A SOMA DE ('A' + 'B') É -MENOR- QUE 'C'");
                    Console.WriteLine("------------------------------------------");
                }
                else if (Avalue + Bvalue == Cvalue)
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("A SOMA DE ('A' + 'B') TEM - O MESMO VALOR- QUE 'C'");
                    Console.WriteLine("------------------------------------------");
                }

                Console.WriteLine("Deseja reiniciar o progama? (S/N): ");
                Console.WriteLine("------------------------------------------");
                string toContinue = Console.ReadLine()!.ToUpper();
                if (toContinue != "S")
                    break;
            }
        }
    }
}
