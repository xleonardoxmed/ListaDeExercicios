namespace Exercicio09
{
    internal class Program
    { //7. A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um algoritmo para ler as dimensões de um
        //terreno e depois exibir a área do terreno.

        // base * height
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();

                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("Imobiliária Imóbilis: Calcule a área do terreno desejado");
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine(" ----------------------");
                Console.WriteLine(" |                    |");
                Console.WriteLine(" |                    | Comprimento");
                Console.WriteLine(" |                    |");
                Console.WriteLine(" -----largura----------");
                Console.WriteLine("----------------------------------------------------------------");

                Console.Write("Informe a LARGURA do terreno retangular: ");
                decimal Length = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("----------------------------------------------------------------");
                Console.Write("Informe agora o COMPRIMENTO do terreno retangular: ");
                decimal Height = Convert.ToDecimal(Console.ReadLine());

                decimal Area = Length * Height;
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine($"A área do terreno retangular é de {Area}");
                Console.WriteLine("----------------------------------------------------------------");

                Console.WriteLine("Deseja fazer uma nova verficação? (S/N)");
                Console.WriteLine("----------------------------------------------------------------");
                string toContinue = Console.ReadLine()!.ToUpper();
                if (toContinue != "S")
                    break;
            }
        }
    }
}
