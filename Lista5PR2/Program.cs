using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista5PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pro1;

            Console.WriteLine("Digite o exercicio desejado?");
            pro1 = int.Parse(Console.ReadLine());

            switch (pro1)
            {
                case 1:
                    int num;
                    Console.WriteLine("Digite o número desejado? ");
                    num = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= num; i++)
                    {


                        Console.WriteLine(i);


                    }
                    break;
                case 2:
                    int nume;
                    Console.WriteLine("Digite o número desejado?");
                    nume = int.Parse(Console.ReadLine());

                    for (int i = 0; i <= nume; i++)
                    {

                        if (i % 2 == 0)
                            Console.WriteLine(i);


                    }
                    break;

                case 3:
                    int numer;
                    Console.WriteLine("Digite o número desejado?");
                    numer = int.Parse(Console.ReadLine());

                    for (int i = 1000; i >= numer; i--)
                    {

                        if (i % 2 == 0)
                            Console.WriteLine(i);


                    }
                    break;

                case 4:
                    int numero1, numero2, som = 0;
                    Console.WriteLine("Digite o primeiro número desejado?");
                    numero1 = int.Parse(Console.ReadLine());


                    for (; numero1 <= 200;)
                    {
                        Console.WriteLine("Digite o segundo numero:");
                        numero2 = int.Parse(Console.ReadLine());
                        if (numero2 > 0)
                            numero1 = numero1 + numero2;
                        Console.WriteLine(numero1);


                    }

                    break;

                case 5:

                    int numero;
                    Console.WriteLine("Digite o número desejado?");
                    numero = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= numero; i++)
                    {

                        if (numero % i == 0)
                            Console.WriteLine(i);


                    }

                    break;

                case 6:

                    int num1, num2, num3, num4, num5, num6, num7, num8, num9, num10;

                    Console.WriteLine("Qual o num1");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Qual o num2");
                    num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Qual o num3");
                    num3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Qual o num4");
                    num4 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Qual o num5");
                    num5 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Qual o num6");
                    num6 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Qual o num7");
                    num7 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Qual o num8");
                    num8 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Qual o num9");
                    num9 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Qual o num10");
                    num10 = int.Parse(Console.ReadLine());
                    for (int i = 1; ; i++)
                    {

                        if (num1 == i || num2 == i || num3 == i || num4 == i || num5 == i || num6 == i || num7 == i || num8 == i || num9 == i || num10 == i)
                        {
                            Console.WriteLine(i);
                        }


                    }
                    break;

                case 7:

                    int numer1, numer2, numeros = 0;
                    Console.WriteLine("Digite o primeiro numero desejado?");
                    numer1 = int.Parse(Console.ReadLine());




                    for (int i = 1; numer1 > 0; i++)
                    {

                        Console.WriteLine("digite o segundo numero:");
                        numer2 = int.Parse(Console.ReadLine());
                        if (numer2 == 0)
                            break;
                        if (numer2 % 2 == 0)
                        {
                            numer1 = numer1 + numer2;
                            Console.WriteLine(numer1);
                        }
                        else
                        {

                            numeros = numeros + numer2;
                            Console.WriteLine(numeros);
                        }



                    }

                    break;

            }
        }
    }
}
