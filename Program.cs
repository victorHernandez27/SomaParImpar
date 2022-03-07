using System;

namespace SomaParImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0, numeroPar = 0, numeroImpar = 0;

            do
            {
                Console.WriteLine("Digite um numero inteiro e positivo: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero < 0)
                {
                    Console.WriteLine("Não são permitidos números negativos");
                }
                else
                {
                    if (numero > 1000)
                    {
                        Console.WriteLine("Encerrando o programa");
                    }
                    else
                    {
                        if (numero % 2 == 0)
                        {
                            numeroPar = numeroPar + numero;
                        }
                        else
                        {
                            numeroImpar = numeroImpar + numero;
                        }
                    }
                }

            } while (numero <= 1000);

            Console.WriteLine("Soma dos numeros pares é {0} e a Soma dos numeros impares é {1}", numeroPar,numeroImpar);

            Console.ReadKey();

        }
    }
}
