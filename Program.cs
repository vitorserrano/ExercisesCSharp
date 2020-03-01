using System;

namespace ExercisesCSharp
{
  class Program
  {

    static void Main(string[] args)
    {

      // | ----------------------------- EXERCICIO 01 ----------------------------- |            

      string firstInput, secondInput;
      double firstNumber, secondNumber, resultCalculation = 0;

      Console.WriteLine("|---------------------- Exercicio 01 ----------------------|");

      Console.WriteLine("Digite o primeiro número");
      firstInput = Console.ReadLine();

      Console.WriteLine("Digite o segundo número");
      secondInput = Console.ReadLine();

      if (!double.TryParse(firstInput, out firstNumber) && !double.TryParse(secondInput, out secondNumber))
      {
        Console.WriteLine("Valores Inválidos!");
        return;
      }
      else if (!double.TryParse(firstInput, out firstNumber))
      {
        Console.WriteLine("O primeiro valor é inválido!");
        return;
      }
      else if (!double.TryParse(secondInput, out secondNumber))
      {
        Console.WriteLine("O segundo valor é inválido!");
        return;
      }

      Console.Clear();

      while (resultCalculation != 5)
      {
        Console.WriteLine("      * --- CALCULADORA --- *     ");
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

        resultCalculation = int.Parse(Console.ReadLine());

        switch (resultCalculation)
        {
          case 1:
            Console.WriteLine("A Soma de " + firstNumber + "+" + secondNumber + " é {0}", firstNumber + secondNumber);
            break;
          case 2:
            Console.WriteLine("A Subtração de " + firstNumber + "-" + secondNumber + "é = {0}", firstNumber - secondNumber);
            break;
          case 3:
            Console.WriteLine("A Divisão de " + firstNumber + "/" + secondNumber + "é = {0}", firstNumber / secondNumber);
            break;
          case 4:
            Console.WriteLine("A Multiplicação " + firstNumber + "*" + secondNumber + "é = {0}", firstNumber * secondNumber);
            break;
        }

        Console.ReadLine();
      }

      Console.WriteLine("|---------------------- Exercicio 01 ----------------------|");

      // | ----------------------------- EXERCICIO 01 ----------------------------- |

      // | ----------------------------- EXERCICIO 02 ----------------------------- |

      string firstScanner;

      Console.WriteLine("|---------------------- Exercicio 02 ----------------------|");
      Console.WriteLine("Escreva uma frase: ");
      firstScanner = Console.ReadLine();

      int position = 0;
      for (int i = 0; i < firstScanner.Length; i++)
      {
        string word = firstScanner[i].ToString();

        if (word.Contains("a"))
        {
          position++;
        }

        if (word.Contains("e"))
        {
          position++;
        }

        if (word.Contains("i"))
        {
          position++;
        }

        if (word.Contains("o"))
        {
          position++;
        }

        if (word.Contains("u"))
        {
          position++;
        }
      }

      Console.WriteLine("A quantidade de Vogais é " + position);
      Console.WriteLine("|---------------------- Exercicio 02 ----------------------|");

      // | ----------------------------- EXERCICIO 02 ----------------------------- |

      // | ----------------------------- EXERCICIO 03 ----------------------------- |

      string secondScanner;

      Console.WriteLine("|---------------------- Exercicio 03 ----------------------|");
      Console.WriteLine("Escreva uma frase: ");
      secondScanner = Console.ReadLine();

      for (int i = 0; i < secondScanner.Length; i++)
      {
        if (secondScanner[i] == 'a' ||
            secondScanner[i] == 'e' ||
            secondScanner[i] == 'i' ||
            secondScanner[i] == 'o' ||
            secondScanner[i] == 'u')
        {

          Console.WriteLine("Posição: " + "[" + i + "]" + " - " + "Vogal: " + secondScanner[i]);
        }
      }

      Console.WriteLine("|---------------------- Exercicio 03 ----------------------|");
      // | ----------------------------- EXERCICIO 03 ----------------------------- |

      // | ----------------------------- EXERCICIO 04 ----------------------------- |

      string thirdScanner;

      Console.WriteLine("|---------------------- Exercicio 04 ----------------------|");
      Console.WriteLine("Escreva uma frase: ");
      thirdScanner = Console.ReadLine();

      for (int i = 0; i < thirdScanner.Length; i++)
      {
        if (thirdScanner[i] != 'a' &&
            thirdScanner[i] != 'e' &&
            thirdScanner[i] != 'i' &&
            thirdScanner[i] != 'o' &&
            thirdScanner[i] != 'u')
        {
          Console.WriteLine("Posição: " + "[" + i + "]" + " - " + "Consoante: " + thirdScanner[i]);
        }
      }

      Console.WriteLine("|---------------------- Exercicio 04 ----------------------|");
      // | ----------------------------- EXERCICIO 04 ----------------------------- |

      // | ----------------------------- EXERCICIO 05 ----------------------------- |

      double age;

      Console.WriteLine("|---------------------- Exercicio 05 ----------------------|");
      Console.WriteLine("Informe a sua idade: ");
      age = Double.Parse(Console.ReadLine());

      if (age == 0 || age <= 19)
      {
        Console.WriteLine("Com " + age + " anos " + "você ainda é Jovem!");
      }
      else if (age == 20 || age <= 59)
      {
        Console.WriteLine("Com " + age + " anos " + "você já é Adulto!");
      }
      else if (age >= 60)
      {
        Console.WriteLine("Com " + age + " anos " + "você está Idoso!");
      }

      Console.WriteLine("|---------------------- Exercicio 05 ----------------------|");
      // | ----------------------------- EXERCICIO 05 ----------------------------- |

      // | ----------------------------- EXERCICIO 06 ----------------------------- |

      Livro livro;

      Console.WriteLine("|---------------------- Exercicio 06 ----------------------|");
      Console.WriteLine("Informe o Título: ");
      livro.Titulo = Console.ReadLine();

      Console.WriteLine("Informe o Autor: ");
      livro.Autor = Console.ReadLine();

      Console.WriteLine("Informe o Valor: ");
      livro.Valor = double.Parse(Console.ReadLine());

      Console.WriteLine("Sucesso! O Livro foi cadastrado.");
      Console.WriteLine("Título: " + livro.Titulo);
      Console.WriteLine("Autor: " + livro.Autor);
      Console.WriteLine("Valor: " + livro.Valor);
      Console.ReadKey();

      Console.WriteLine("|---------------------- Exercicio 06 ----------------------|");

      // | ----------------------------- EXERCICIO 06 ----------------------------- |

      // | ----------------------------- EXERCICIO 07 ----------------------------- |

      Aluno aluno;

      Console.WriteLine("|---------------------- Exercicio 07 ----------------------|");
      Console.WriteLine("Nome do Aluno: ");
      aluno.Nome = Console.ReadLine();

      Console.WriteLine("R.A. do Aluno: ");
      aluno.RA = int.Parse(Console.ReadLine());

      Console.WriteLine("Nota do Aluno: ");
      aluno.Nota = double.Parse(Console.ReadLine());

      Console.WriteLine("Frequência do aluno");
      aluno.Frequencia = double.Parse(Console.ReadLine());

      Console.WriteLine("Sucesso! o Aluno foi cadastrado.");
      Console.WriteLine("Nome: " + aluno.Nome);
      Console.WriteLine("R.A.: " + aluno.RA);
      Console.WriteLine("Nota: " + aluno.Nota + "O aluno está " + Media(aluno.Nota));
      Console.WriteLine("Frequência: " + Frequencia(aluno.Frequencia));
      Console.ReadKey();
      // Menu();

      string Media(double nota) => nota < 7 ? "Reprovado" : "Aprovado";
      string Frequencia(double frequencia)
      {
        double resultado = ((frequencia / 25) * 100);
        return resultado < 40 ? resultado + "% Reprovado por falta" : resultado + "% Aprovado";
      }

      Console.WriteLine("|---------------------- Exercicio 07 ----------------------|");
      // | ----------------------------- EXERCICIO 07 ----------------------------- |

    }
  }

  // | ----------------------------- STRUCT EXERCICIO 06 ----------------------------- |

  struct Livro
  {
    public string Titulo;
    public string Autor;
    public double Valor;
  }

  // | ----------------------------- STRUCT EXERCICIO 06 ----------------------------- |

  // | ----------------------------- STRUCT EXERCICIO 06 ----------------------------- |

  struct Aluno
  {
    public string Nome;
    public int RA;
    public double Nota;
    public double Frequencia;
  }

  // | ----------------------------- STRUCT EXERCICIO 06 ----------------------------- |

}
