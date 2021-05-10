using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fila
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis
            Pessoa a = new Pessoa();
            int o = 1, E;
            //fim Variáveis
            do
            {
                Console.Clear();
                Console.WriteLine("Sistema de Filas © (Por: Bruno Costa & Pedro Novais 2ºDS (Tarde)) ETEC JK 2019");
                Console.WriteLine("-----------------------/");
                Console.WriteLine("|1| - Cadastrar");
                Console.WriteLine("|2| - Alterar Informaçoes");
                Console.WriteLine("|3| - Atendimento");
                Console.WriteLine("|4| - Fila");
                Console.WriteLine("|0| - Sair");
                Console.WriteLine("-----------------------/");
                E = int.Parse(Console.ReadLine());
                switch (E)
                {
                    case 1:
                        a.Registra();
                        break;
                    case 2:
                        a.Alterar();
                        break;
                    case 3:
                        a.Atender();
                        break;
                    case 4:
                        a.MostrarFila();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Comando não identificado");
                        Console.ReadKey();
                        break;
                }
            } while (o == 1);
        }
    }
}