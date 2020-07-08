using System;

namespace Aula09Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora:");
            Console.WriteLine("==================================");

            Media calc = new Media();
            
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Qual operação você deseja fazer?\n 1- Somar\n 2- Subtrair\n 3- Multiplicar\n 4- Dividir \n 5- Media de 2 valores");
            Console.ResetColor();
            string escolha = Console.ReadLine();
            switch(escolha){
                case "1": 
                        Console.WriteLine("Digite o primeiro número da operação: "); 
                        calc.num1 = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o segundo número da operação: "); 
                        calc.num2 = Int32.Parse( Console.ReadLine() );  

                        System.Console.WriteLine(calc.Somar());
                break;

                case "2":
                        Console.WriteLine("Digite o primeiro número da operação: "); 
                        calc.num1 = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o segundo número da operação: "); 
                        calc.num2 = Int32.Parse( Console.ReadLine() );  

                        System.Console.WriteLine(calc.Subtrair());
                break;

                case "3":
                        Console.WriteLine("Digite o primeiro número da operação: "); 
                        calc.num1 = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o segundo número da operação: "); 
                        calc.num2 = Int32.Parse( Console.ReadLine() );  

                        System.Console.WriteLine(calc.Multiplicar());
                break;


                case "4":
                        Console.WriteLine("Digite o primeiro número da operação: "); 
                        calc.num1 = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o segundo número da operação: "); 
                        calc.num2 = Int32.Parse( Console.ReadLine() );  

                        System.Console.WriteLine(calc.Dividir());
                break;

                case "5":
                        Console.WriteLine("Digite o primeiro número da operação: "); 
                        calc.num1 = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o segundo número da operação: "); 
                        calc.num2 = Int32.Parse( Console.ReadLine() );  

                        System.Console.WriteLine(calc.DefinirMedia());
                break;

                default:
                        System.Console.WriteLine("Você não escolheu uma opção válida");
                break;

            }
                
            
        }
    }
}
