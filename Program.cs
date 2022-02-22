using System;

namespace Calculadora.BaltaCurso
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("-------------------");
            Console.WriteLine("Selecione uma opção: ");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break; // sai da aplicação
                default: Menu(); break;
            }





        }

        static void Soma()
        {

            Console.Clear(); // limpa campo
            Console.WriteLine("Primeiro valor: "); // valor informado
            float v1 = float.Parse(Console.ReadLine()); // rececbe o valor informado

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine(""); // quebra uma linha

            float resultado = v1 + v2; // soma do v1 e v2

            Console.WriteLine("O valor da soma é " + resultado);
            Console.ReadKey(); // não sai da aplicação
            Menu(); // volta para o menu
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da Subtração é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão é {resultado}");

            Console.ReadKey();
            Menu();



        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Vaor ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Vaor ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;

            Console.WriteLine($"O valor da Multiplicação é {resultado}");

            Console.ReadKey();
            Menu();


        }

    }

}
