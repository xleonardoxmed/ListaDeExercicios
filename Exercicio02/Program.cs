namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double radius = 3.1;
            double height = 10;
            double volume = Math.PI * Math.Pow(radius, 2) * height;

            Console.WriteLine($"O volume do cilindro é: {volume} cm³");
            Console.ReadLine();
        }
    }
}