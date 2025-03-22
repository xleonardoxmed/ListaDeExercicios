namespace Exercicio10
{
    internal class Program
    { 
        //A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia.
        //Cada pãozinho custa R$ 0,12 e a broa custa R$ 1,50.
        //Ao final do dia, o dono quer saber quanto arrecadou com a venda dos pães e broas (juntos),
        //e quanto deve guardar numa conta de poupança (10% do total arrecadado).

        static void Main(string[] args)
        {
            while (true)
            {
                decimal CornBreads = 1.50m;
                decimal Breads = 0.12m;
                Console.Clear();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("SUPREMACIA HOTPÃO");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Quantos pãezinhos foram vendidos no último mês?: ");
                Console.WriteLine("--------------------------------------------------");
                int BreadsSold = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Quantas broas foram vendidas no último mês?: ");
                Console.WriteLine("--------------------------------------------------");
                int CornBreadsSold = Convert.ToInt32(Console.ReadLine());
                decimal Apply = ((BreadsSold * Breads) + (CornBreadsSold * CornBreads)) * 0.10m;
                
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"Se pretende aplicar 10% do arrecadado em uma poupança, {Apply:F2} R$ devem ser aplicados. ");
                Console.WriteLine("--------------------------------------------------");

                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Deseja fazer um novo cálculo? (S/N)");
                Console.WriteLine("--------------------------------------------------");
                string toContinue = Console.ReadLine()!.ToUpper();
                if (toContinue != "S")
                    break;


            }
        }
    }
}
