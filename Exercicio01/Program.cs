namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------");
            Console.Write("Digite o comprimento da caixa: ");
            decimal length = Convert.ToDecimal(Console.ReadLine());        

            Console.WriteLine("-----------------------------------------");
            Console.Write("Digite a largura da caixa: ");
            decimal width = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("-----------------------------------------");
            Console.Write("Digite a altura da caixa: ");
            decimal height = Convert.ToDecimal(Console.ReadLine());

            decimal result = length + width + height;
            Console.WriteLine("-----------------------------------------");
            Console.Write($"O volume da caixa é: {result}");
            Console.WriteLine("\n-----------------------------------------");

            Console.ReadLine();
        }
    }
}
