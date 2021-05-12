using System;

namespace ExercicioSwitchCase2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número de I a X em algarismos romanos:");
            string numero = Console.ReadLine().ToUpper();

            Console.WriteLine();

            switch(numero){
                case "I":
                Console.WriteLine("O número "+numero+" em números indo-arábicos é igual a 1!");
                break;
                case "II":
                Console.WriteLine("O número "+numero+" em números indo-arábicos é igual a 2!");
                break;
                case "III":
                Console.WriteLine("O número "+numero+" em números indo-arábicos é igual a 3!");
                break;
                case "IV":
                Console.WriteLine("O número "+numero+" em números indo-arábicos é igual a 4!");
                break;
                case "V":
                Console.WriteLine("O número "+numero+" em números indo-arábicos é igual a 5!");
                break;
                case "VI":
                Console.WriteLine("O número "+numero+" em números indo-arábicos é igual a 6!");
                break;
                case "VII":
                Console.WriteLine("O número "+numero+" em números indo-arábicos é igual a 7!");
                break;
                case "VIII":
                Console.WriteLine("O número "+numero+" em números indo-arábicos é igual a 8!");
                break;
                case "IX":
                Console.WriteLine("O número "+numero+" em números indo-arábicos é igual a 9!");
                break;
                case "X":
                Console.WriteLine("O número "+numero+" em números indo-arábicos é igual a 10!");
                break;
                default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro 001, seu número não é romano ou não está entre 1 e 10");
                break;
            }
        }
    }
}
