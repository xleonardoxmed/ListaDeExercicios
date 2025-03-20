namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o comprimento da caixa: ");
            decimal length = Convert.ToDecimal(Console.ReadLine());
            
            Console.WriteLine("Digite a largura da caixa: ");
            decimal width = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a altura da caixa: ");
            decimal height = Convert.ToDecimal(Console.ReadLine());

            decimal result = length + width + height;
            Console.ReadLine();
        }
    }
}
