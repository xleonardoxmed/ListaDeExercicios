namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Cheque sua situação salarial");
                Console.WriteLine("------------------------------------------");
                  
                bool sucess;
                decimal salary = 0;
                do
                {
                    Console.Write("Qual é o seu salário? :");
                    string entry = Console.ReadLine()!;
                    sucess = true;
                    sucess = decimal.TryParse(entry, out salary);
                    if(sucess == false)
                    {
                        Console.WriteLine("--------------------------------------------------");
                        Console.WriteLine(" Erro! Insira apenas NÚMEROS");
                        Console.WriteLine("--------------------------------------------------");
                    }
                    
                } while (!sucess);

                decimal salaryRaise = (salary * 0.15m) + salary;
                decimal salaryDecrease = salaryRaise - (salaryRaise * 0.08m);

                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Sua situação: ");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine($"Seu salário base: {salary:F2}R$");
                Console.WriteLine($"Seu salário com aumento de 15%: {salaryRaise:F2}R$");
                Console.WriteLine($"Seu salário final (Com 8% de impostos): {salaryDecrease:F2}R$");
                Console.WriteLine("------------------------------------------");

                Console.WriteLine("Deseja reiniciar o progama? (S/N): ");
                Console.WriteLine("------------------------------------------");
                string toContinue = Console.ReadLine()!.ToUpper();
                if (toContinue != "S")
                    break;
            }
        }
    }
}
