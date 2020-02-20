using System;

namespace FIrst_Project_C_
{
    class Program 
    {

        static void Main(string[] args) 
        {

// | ----------------------------- EXERCICIO1 ----------------------------- |            

            string captura1, captura2;
            double number1, number2, resultCalc = 0;

            Console.WriteLine("Digite o primeiro número");
            captura1 = Console.ReadLine();

            Console.WriteLine("Digite o segundo número");
            captura2 = Console.ReadLine();

            if (!double.TryParse(captura1, out number1) && !double.TryParse(captura2, out number2))  
            {
                Console.WriteLine("Valores Inválidos!");
                return;
            } else if (!double.TryParse(captura1, out number1)) 
            {   
                Console.WriteLine("O primeiro valor é inválido!");
                return;
            } else if (!double.TryParse(captura2, out number2))
            {
                Console.WriteLine("O segundo valor é inválido!");
                return;
            }

            Console.Clear();

            while (resultCalc != 5) 
            {
                Console.WriteLine("      *--- CALCULADORA ---*     ");
                Console.WriteLine("|------------------------------|");
                Console.WriteLine("| [1] - SOMAR                  |");
                Console.WriteLine("|------------------------------|");
                Console.WriteLine("| [2] - SUBTRAIR               |");
                Console.WriteLine("|------------------------------|");
                Console.WriteLine("| [3] - DIVIDIR                |");
                Console.WriteLine("|------------------------------|");
                Console.WriteLine("| [4] - MULTIPLICAR            |");
                Console.WriteLine("|------------------------------|");
                Console.WriteLine("| [5] - SAIR                   |");
                Console.WriteLine("|------------------------------|");

                resultCalc = int.Parse (Console.ReadLine ());

                switch (resultCalc)
                {
                    case 1:
                        Console.WriteLine("A Soma de " + number1 + "+" + number2 + " é {0}", number1 + number2);
                        break;
                    case 2:
                        Console.WriteLine("A Subtração de " + number1 + "-" + number2 + "é = {0}", number1 - number2);
                        break;
                    case 3:
                        Console.WriteLine("A Divisão de " + number1 + "/" + number2 + "é = {0}", number1 / number2);
                        break;
                    case 4:
                        Console.WriteLine("A Multiplicação " + number1 + "*" + number2 + "é = {0}", number1 * number2);
                        break;
                }

                Console.ReadLine();
                Console.Clear();
            }

// | ----------------------------- EXERCICIO1 ----------------------------- |

// | ----------------------------- EXERCICIO2 ----------------------------- |
            
                string scanner;

                Console.WriteLine("Escreva uma frase");
                scanner = Console.ReadLine();

                int position = 0;
                for (int i = 0; i < scanner.Length; i++)
                {
                    string palavra = scanner[i].ToString();

                    if (palavra.Contains("a")) 
                    {
                        position++;   
                    }

                    if (palavra.Contains("e")) 
                    {
                        position++;
                    } 

                    if (palavra.Contains("i")) 
                    {
                        position++;
                    } 

                    if (palavra.Contains("o")) 
                    {
                        position++;
                    } 

                    if (palavra.Contains("u")) 
                    {
                        position++;
                    } 
                }

                Console.WriteLine("A quantidade de Vogais é " + pos);

// | ----------------------------- EXERCICIO2 ----------------------------- |

        }
    }
}