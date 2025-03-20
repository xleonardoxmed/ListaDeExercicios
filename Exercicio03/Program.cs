namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------");
            Console.Write("Digite a quilometragem inicial: ");
            double kmBefore = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("-----------------------------------------");
            Console.Write("Digite a quilometragem final: ");
            double kmAfter = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("-----------------------------------------");
            Console.Write("Digite o gasto de combustível: ");
            double fuelSpend = Convert.ToDouble(Console.ReadLine());

            double route = kmAfter - kmBefore;
            double fuelPerKmSpend = route / fuelSpend;

            Console.WriteLine($"O consumo de combustível durante o percurso foi de ~ {fuelPerKmSpend} Km/L");
            Console.ReadLine();
        }
    }
}
