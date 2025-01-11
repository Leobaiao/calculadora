using System;

namespace Calculadora
{
        class programa
        {
             static void Main (string[] strings)
             {
            Console.WriteLine("Digite o primeiro numero: ");
              int num1 = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Digite a operação: ");
                string operacao = Console.ReadLine();

            Console.WriteLine("Digite o segundo numero: ");
              int num2 = int.Parse(Console.ReadLine());
                
                switch (operacao)
                {
                    case "+":
                        Console.WriteLine("Resultado: " + (num1 + num2));
                        break;
                    case "-":
                        Console.WriteLine("Resultado: " + (num1 - num2));
                        break;
                    case "*":
                        Console.WriteLine("Resultado: " + (num1 * num2));
                        break;
                    case "/":
                    if (num1 == 0 || num2 == 0){
                        Console.WriteLine("Não é possível dividir por zero");
                    }else{
                        double num01 = Convert.ToDouble(num1);
                        Console.WriteLine("Resultado: " + (num01 / num2));
                    }
                        break;
                    default:
                        Console.WriteLine("Operação inválida");
                        break;
                }  
             }
        }
}