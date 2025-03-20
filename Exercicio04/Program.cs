using System.Globalization;

namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Conversor de temperatura C -> F");
                Console.WriteLine("-----------------------------------------");
                Console.Write("Digite a temperatura na escala Celsius: ");
                Console.WriteLine("\n-----------------------------------------");
                decimal Ctemperature = Convert.ToDecimal(Console.ReadLine());
                decimal Ftemperature = (Ctemperature * 1.8m) + 32;
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"A temperatura na escala Fahrenheit fica: {Ftemperature} ");
  
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Gostaria de fazer uma nova conversão? (S/N)");
                Console.WriteLine("-----------------------------------------");
                string toContinue = Console.ReadLine()!.ToUpper();
                if (toContinue != "S")
                    break;
            }
           
            

        }
    }
}
