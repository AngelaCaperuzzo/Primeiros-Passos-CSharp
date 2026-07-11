using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Aula1
    {
        static void Main(string[] args)
        {

            int idade = 29;
            double saldo = 2.000;
            char genero = 'F';
            string nome = "Angela";

            //Placeholder
            Console.WriteLine(" Sr.a {0} do gênero {1}, com a seguinte idade {2}, possui em seu saldo o valor de {3:F3} yenes", nome, genero, idade, saldo); //saldo.ToString("F3")

            //Interpolação
            Console.WriteLine($"{nome} tem {idade} anos, é do gênero {genero} e possui {saldo:F3} yenes.");

            //Concatenação
            Console.WriteLine(nome + " de " + idade + " anos, é do gênero " + genero + ", e ela possui o salde de " + saldo.ToString("F3", CultureInfo.InvariantCulture) + " yenes.");

        }
    }
}