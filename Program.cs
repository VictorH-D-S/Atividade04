using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade04_Condicoes_Parte2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mes;
            int dia;
            string periodo;


            Console.WriteLine("Bem Vindo ao sistema de compras de passagens!");
            Console.WriteLine("Por favor, escolha o mês para a compra da passagem.");
            Console.WriteLine("08 - Agosto\n09 - Setembro\n10 - Outrubro");
            mes = int.Parse(Console.ReadLine());

            // Operador || ---> o mesmo que OU
            if (mes > 10 || mes < 8)
            {
                Console.WriteLine("Mês invalido. Tente novamente.");
                Console.ReadLine();
                Console.Clear();
                Main(null);
                return;

            }

            Console.WriteLine("Confirmado! Agora é só escolher um dos dias disponíveis!");
            Console.WriteLine("O dias disponíveis são entre os dias 6 e 21.");
            dia = int.Parse(Console.ReadLine());

            if (dia > 21 || dia < 6)
            {

                Console.WriteLine("Dia inválido. Tente novamente.");
                Console.ReadLine();
                Console.Clear();
                Main(null);
                return;

            }

            Console.WriteLine("Confirmado! Agora só precisa digitar o período de sua viagem!");
            Console.WriteLine("- Manhã\n- Tarde \n- Noite");
            periodo = Console.ReadLine();

            if (periodo == "Manhã" || periodo == "Tarde" || periodo == "Noite")
            {

                Console.WriteLine($"Tudo certo! Sua viagem está marcada para o dia {dia}/{mes} para o período da {periodo}!");
                Console.WriteLine("Obrigado e volte sempre!");
                Console.ReadKey();
                return;
            }

            else
            {
                Console.WriteLine("Período inválido. Tente novamente.");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }
        }
    }
}
