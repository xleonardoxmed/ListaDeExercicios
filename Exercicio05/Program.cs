namespace Exercicio05
{
    internal class Program
    {//Crie um programa para calcular o salário total de um vendedor.
     //Deverá ser informado o salário base e o total de  vendas.
     //A comissão é calculada com um percentual(informado pelo usuário) sobre o total de vendas.

        static void Main(string[] args)
        {
            while (true)
            {              
                Console.Clear();
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Calcule seu salário do mês!");
                Console.WriteLine("-----------------------------------------");
                Console.Write("Qual o seu salário? (base): ");
                decimal salary = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("-----------------------------------------");
                Console.Write("Quantas vendas você fez esse mês?: ");
                decimal sells = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("-----------------------------------------");
                Console.Write("Qual o valor dos produtos que você vende?: ");
                decimal value = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("-----------------------------------------");
                Console.Write("Qual o percentual de suas comissões?: ");
                decimal comissionPercentage = Convert.ToDecimal(Console.ReadLine());

                if (salary < 0 || sells < 0 || value < 0 || comissionPercentage < 0)
                {
                    Console.WriteLine("Erro! Os valores informados são inválidos.");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("-----------------------------------------");
                decimal fullSalary = salary + ((sells * value)*comissionPercentage/100);
                Console.WriteLine($"\nSeu salário total é de: {fullSalary}");

                Console.WriteLine("\n-----------------------------------------");
                Console.WriteLine("Gostaria de fazer uma nova conversão? (S/N)");
                Console.WriteLine("-----------------------------------------");
                string toContinue = Console.ReadLine()!.ToUpper();
                if (toContinue != "S")
                    break;
            }
            

        }
    }
}
