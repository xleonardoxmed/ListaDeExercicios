using System.Reflection.Metadata;

namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine(" Venha checar  quantos dias viveu!");
                Console.WriteLine("--------------------------------------------------");
                Console.Write(" Olá! Como se chama?: ");                
                string name = Convert.ToString(Console.ReadLine()!);
                Console.WriteLine("--------------------------------------------------");

                int age = 0;
                bool sucess;
                do
                {                   
                    Console.Write($" Seja bem vindo {name}! Quantos anos você tem? :");
                    string entry = Console.ReadLine()!;
                    sucess = true;
                    sucess = int.TryParse(entry, out age);
                    Console.WriteLine("\n--------------------------------------------------");

                    if (sucess == false)
                    {
                        Console.WriteLine(" Erro! Insira a idade em NÚMEROS");
                        Console.WriteLine("--------------------------------------------------");                                                           
                    }

                } while (!sucess);

                int days = age * 365;

                Console.Write($" Olha, {name}, você já viveu {days} DIAS!  E espero que viva muito mais! ");

                Console.WriteLine("\n--------------------------------------------------");
                Console.WriteLine(" Deseja reiniciar o progama? (S/N)");
                Console.WriteLine("--------------------------------------------------");
                string toContinue = Console.ReadLine()!.ToUpper();
                if (toContinue != "S")
                    break;
            }
        }
    }
}
