using System.Threading.Tasks.Dataflow;

namespace Exercicio23
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            for (int count = 1; count <= 100; count++)
            {
                if (count % 3 == 0 && count % 5 == 0) 
                    Console.Write("FizzBuzz ");
                else if (count % 3 == 0 && count % 5 != 0) 
                    Console.Write("Fizz ");
                else if (count % 5 == 0 && count % 3 != 0) 
                    Console.Write("Buzz ");
                else
                    Console.Write(count + " ");
            }

            Console.ReadLine();
        }
    }
}
