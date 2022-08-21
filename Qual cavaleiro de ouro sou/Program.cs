using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Qual_cavaleiro_de_ouro_sou
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool terminarPrograma = false;
            

            while (!terminarPrograma)
            {
                Console.WriteLine("Digite seu nome");

                string nome = Console.ReadLine();

                Console.WriteLine("Digite o dia do seu aniversario");
                int.TryParse(Console.ReadLine(), out int dia);

                Console.WriteLine("Agora o mes representado pelo seu numero");
                int.TryParse(Console.ReadLine(), out int mes);




                if ((dia >= 21 && mes == 3) || (dia <= 20 && mes == 4))
                {
                    Console.WriteLine("Áries");
                }
                if ((dia >= 21 && mes == 4) || (dia <= 20 && mes == 5))
                {
                    Console.WriteLine("Touro");
                }
                if ((dia >= 21 && mes == 5) || (dia <= 20 && mes == 6))
                {
                    Console.WriteLine("Gêmeos");
                }
                if ((dia >= 21 && mes == 6) || (dia <= 22 && mes == 7))
                {
                    Console.WriteLine("Câncer");
                }
                if ((dia >= 23 && mes == 7) || (dia <= 22 && mes == 8))
                {
                    Console.WriteLine("Leão");
                }
                if ((dia >= 23 && mes == 8) || (dia <= 22 && mes == 9))
                {
                    Console.WriteLine("Virgem");
                }
                if ((dia >= 23 && mes == 9) || (dia <= 222 && mes == 10))
                {
                    Console.WriteLine("Libra");
                }
                if ((dia >= 23 && mes == 10) || (dia <= 21 && mes == 11))
                {
                    Console.WriteLine("Escorpião");
                }
                if ((dia >= 22 && mes == 11) || (dia <= 21 && mes == 12))
                {
                    Console.WriteLine("Sagitário");
                }
                if ((dia >= 22 && mes == 12) || (dia <= 20 && mes == 1))
                {
                    Console.WriteLine("Capricórnio");
                }
                if ((dia >= 21 && mes == 1) || (dia <= 18 && mes == 2))
                {
                    Console.WriteLine("Aquário");
                }
                if ((dia >= 19 && mes == 2) || (dia <= 20 && mes == 3))
                {
                    Console.WriteLine("Peixes");
                }

                Console.WriteLine("Digite 1 pra sair ou 2 para continuar");
                terminarPrograma = int.Parse(Console.ReadLine()) == 1;
                

            }
            
            
                         

        }
    }
}
