namespace Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("TESTE DE IMC");
                Console.WriteLine("------------------------------------------");
                
                bool sucess;
                decimal weight = 0;
                decimal height = 0;

                do
                {
                    Console.Write("Informe seu PESO(kg): ");
                    string entryW = Console.ReadLine()!;
                    sucess = decimal.TryParse(entryW, out weight);
                    if(sucess == false || weight <= 0)
                    {
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("Erro! Apenas números maiores que zero permitidos!");
                        Console.WriteLine("------------------------------------------");
                        continue;
                    }

                } while (!sucess);

                do
                {
                    Console.Write("Informe sua ALTURA(m): ");
                    string entryH = Console.ReadLine()!;
                    sucess = decimal.TryParse(entryH, out height);
                    if (sucess == false || height <= 0)
                    {
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("Erro! Apenas números maiores que zero permitidos!");
                        Console.WriteLine("------------------------------------------");
                        continue;
                    }

                } while (!sucess);

                decimal IMC = weight / (height * height);
                string condition = "";

                if (IMC < 18.5M)
                    condition = "ABAIXO DO PESO";
                else if (IMC >= 18.5M && IMC < 25)
                    condition = "COM PESO NORMAL";
                else if (IMC >= 25M && IMC < 30M)
                    condition = "ACIMA DO PESO";
                else 
                    condition = "OBESO";

                decimal minimunWeight = 18.5M * (height * height);
                decimal maximumWeight = 24.9M * (height * height);

                Console.WriteLine("------------------------------------------");
                Console.WriteLine($"Seu IMC é {IMC:F2}. Classificação: {condition}");
                if(condition != "COM PESO NORMAL")
                Console.WriteLine($"\nPeso ideal para sua altura({height:F2}) é entre: {minimunWeight:F2}kg e {maximumWeight:F2}kg.");

                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Deseja reiniciar o programa? (S/N): ");
                Console.WriteLine("------------------------------------------");
                string toContinue = Console.ReadLine()!.ToUpper();
                if (toContinue != "S")
                    break;
            }

        }
    }
}
