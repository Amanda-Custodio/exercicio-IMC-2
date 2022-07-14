using System;

namespace Exercicio_IMC_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao sistema. Qual é o seu nome?");
            string name = Console.ReadLine();

            Console.WriteLine("Qual sua idade?");
            string idade = Console.ReadLine();

            Console.WriteLine("Escreva seu peso com vírgula");
            float peso = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escreva sua altura com vírgula");
            float altura = (float)Convert.ToDouble(Console.ReadLine());

            float resultado = peso / (altura * altura);

            Console.WriteLine("Seu IMC é " + resultado);

            if (resultado < 18.5)
            {
                Console.WriteLine("Abaixo do Peso");
            }
            else if (resultado > 18 && resultado < 25)
            {
                Console.WriteLine("Dentro do Peso");
            }
            else if (resultado >= 25 && resultado < 30)
                Console.WriteLine("Sobrepeso");
            
            else { 
                Console.WriteLine("Obesidade");
            }
        }
    }
}
