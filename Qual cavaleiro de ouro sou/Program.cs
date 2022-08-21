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

                while(dia > 31)
                {
                    Console.WriteLine("Dia invalido. Digite o dia do seu aniversario");
                    int.TryParse(Console.ReadLine(), out int dia2);

                    dia = dia2;
                }

                Console.WriteLine("Agora o mes representado pelo seu numero");
                int.TryParse(Console.ReadLine(), out int mes);

                while (mes > 12)
                {
                    Console.WriteLine("Mes invalido. Digite o mes do seu aniversario");
                    int.TryParse(Console.ReadLine(), out int mes2);

                    mes = mes2;
                }

                Console.WriteLine(RetornaCavaleiro(dia, mes));

                Console.WriteLine("Digite 1 pra sair ou 2 para continuar");
                try
                {
                    terminarPrograma = int.Parse(Console.ReadLine()) == 1;

                }
                catch (Exception)
                {

                    
                }
                
            }
        }

        private static string RetornaCavaleiro(int dia, int mes)
        {
            string cavaleiro = "";

            if ((dia >= 21 && mes == 3) || (dia <= 20 && mes == 4))
            {
                cavaleiro = "Áries";
            }
            if ((dia >= 21 && mes == 4) || (dia <= 20 && mes == 5))
            {
                cavaleiro = "Touro";
            }
            if ((dia >= 21 && mes == 5) || (dia <= 20 && mes == 6))
            {
                cavaleiro = "Gêmeos";
            }
            if ((dia >= 21 && mes == 6) || (dia <= 22 && mes == 7))
            {
                cavaleiro = "Câncer";
            }
            if ((dia >= 23 && mes == 7) || (dia <= 22 && mes == 8))
            {
                cavaleiro = "Leão";
            }
            if ((dia >= 23 && mes == 8) || (dia <= 22 && mes == 9))
            {
                cavaleiro = "Virgem";
            }
            if ((dia >= 23 && mes == 9) || (dia <= 222 && mes == 10))
            {
                cavaleiro = "Libra";
            }
            if ((dia >= 23 && mes == 10) || (dia <= 21 && mes == 11))
            {
                cavaleiro = "Escorpião";
            }
            if ((dia >= 22 && mes == 11) || (dia <= 21 && mes == 12))
            {
                cavaleiro = "Sagitário";
            }
            if ((dia >= 22 && mes == 12) || (dia <= 20 && mes == 1))
            {
                cavaleiro = "Capricórnio";
            }
            if ((dia >= 21 && mes == 1) || (dia <= 18 && mes == 2))
            {
                cavaleiro = "Aquário";
            }
            if ((dia >= 19 && mes == 2) || (dia <= 20 && mes == 3))
            {
                cavaleiro = "Peixes";
            }

            return cavaleiro;
        }
    }
}
