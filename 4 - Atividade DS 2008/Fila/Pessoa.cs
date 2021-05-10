using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fila
{
    public class Pessoa
    {

        public string Nome;
        public bool Pref;
        public string[] auxNome = new string[15];
        public bool[] auxPref = new bool[15];

        //----------------------------------------------------------
        public void Registra()
        {
            //Variáveis
            Pessoa a = new Pessoa();
            int Escolha, r, y = 0, j, m, n;
            //fim Variáveis
            Console.Clear();
            Console.WriteLine("+|Cadastramento de Pessoas|+");
            Console.WriteLine("");
            Console.Write("Digite quantas pessoas vão ser adicionadas a fila: ");
            Escolha = int.Parse(Console.ReadLine());
            if (auxNome[14] != null)
            {
                Console.Clear();
                Console.WriteLine("Erro: Fila Cheia, use o comando 'Atender' para liberar espaço na fila.");
                Console.ReadKey();
            }
            else
            {
                for (r = 0; r < Escolha;)
                {
                    if (auxNome[r] != null)
                    {
                        r++;
                        Escolha++;
                    }
                    else
                    {
                        Nome = a.RegistraNome();
                        Console.Clear();
                        Pref = a.RegistraPreferencia(Nome);
                        if (Pref)
                        {
                            while (auxPref[y] == true)
                            {
                                y++;
                            }
                            j = y;
                            for (m = 13; m >= y; m--)
                            {
                                n = m + 1;
                                auxNome[n] = auxNome[m];
                                auxPref[n] = auxPref[m];
                            }
                            auxNome[j] = Nome;
                            auxPref[j] = Pref;
                            y = 0;
                        }
                        else
                        {
                            auxNome[r] = Nome;
                            auxPref[r] = Pref;
                        }
                        r++;
                    }
                }
            }
        }
        //----------------------------------------------------------
        public string RegistraNome()
        {
            //Variáveis
            string m;
            //fim Variáveis
            Console.Clear();
            Console.WriteLine("+|Registro|+");
            Console.WriteLine("");
            Console.Write("Digite o nome da pessoa: ");
            m = Console.ReadLine();
            return m;
        }
        //----------------------------------------------------------
        public bool RegistraPreferencia(string a)
        {
            //Variáveis
            bool y;
            int i;
            //fim Variáveis
            Console.WriteLine("O(a) {0} tem preferência?", a);
            Console.WriteLine("");
            Console.WriteLine("|1| Sim");
            Console.WriteLine("|0| Não");
            Console.Write(" ");
            i = int.Parse(Console.ReadLine());
            if (i == 1)
            {
                y = true;
            }
            else
            {
                y = false;
            }
            return y;
        }
        //----------------------------------------------------------
        public void Alterar()
        {
            //Variáveis
            Pessoa a = new Pessoa();
            int v, y = 0, j, m, n, o, k;
            //fim Variáveis
            Console.Clear();
            Console.WriteLine("+|Alterar Informações|+");
            Console.WriteLine("");
            Console.Write("Digite a posição da pessoa para alterar a informação: ");
            v = int.Parse(Console.ReadLine());
            Console.Clear();
            v = v - 1;
            if (auxNome[v] != null)
            {
                Console.WriteLine("Pessoa selecionada: {0}", auxNome[v]);
                if (auxPref[v])
                {
                    Console.WriteLine("Preferência: Sim");
                }
                else
                {
                    Console.WriteLine("Preferência: Não");
                }
                Console.WriteLine("");
                Console.WriteLine("Deseja alterar ou cancelar?");
                Console.WriteLine("");
                Console.WriteLine("|1| Alterar");
                Console.WriteLine("|0| Cancelar");
                Console.Write(" ");
                n = int.Parse(Console.ReadLine());
                Console.Clear();
                if (n == 1)
                {
                    Nome = a.RegistraNome();
                    Console.Clear();
                    Pref = a.RegistraPreferencia(Nome);
                    if (Pref)
                    {
                        auxNome[v] = null;
                        auxPref[v] = false;
                        for (m = v; m <= 13; m++)
                        {
                            auxNome[m] = auxNome[m + 1];
                            auxPref[m] = auxPref[m + 1];
                            auxNome[m+1] = null;
                            auxPref[m+1] = false;
                        }
                        while (auxPref[y] == true)
                        {
                            y++;
                        }
                        j = y;
                        for (m = 13; m >= y; m--)
                        {
                            k = m + 1;
                            auxNome[k] = auxNome[m];
                            auxPref[k] = auxPref[m];
                        }
                        auxNome[j] = Nome;
                        auxPref[j] = Pref;
                        y = 0;
                    }
                    else
                    {
                        auxNome[v] = Nome;
                        auxPref[v] = Pref;
                    }
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Erro: Não existe nenhuma pessoa na posição selecionada");
                Console.ReadKey();
            }
        }
        //----------------------------------------------------------
        public void MostrarFila()
        {
            //Variáveis
            int h, i;
            //fim Variáveis
            Console.Clear();
            Console.WriteLine("+|Fila|+");
            Console.WriteLine("");
            for (i = 0; i < 15; i++)
            {
                h = i + 1;
                if (auxNome[i] != null)
                {
                    if (auxPref[i])
                    {
                        Console.WriteLine("{0}º : {1} | Prefência = Sim", h, auxNome[i]);
                    }
                    else
                    {
                        Console.WriteLine("{0}º : {1} | Prefência = Não", h, auxNome[i]);
                    }
                }
                else
                {
                    Console.WriteLine("{0}º :", h);
                }
            }
            Console.ReadKey();
        }
        //----------------------------------------------------------
        public void Atender()
        {
            //Variáveis
            int y = 0, m;
            //fim Variáveis
            Console.Clear();
            Console.WriteLine("+|Atendimento|+");
            Console.WriteLine("");
            if (auxNome[y] != null)
            {
                Console.WriteLine("Atender: {0}", auxNome[y]);
                if (auxPref[y])
                {
                    Console.WriteLine("Preferência: Sim");
                }
                else
                {
                    Console.WriteLine("Preferência: Não");
                }
                auxNome[0] = null;
                auxPref[0] = false;
                for (m = 0; m <= 13; m++)
                {
                    auxNome[m] = auxNome[m + 1];
                    auxPref[m] = auxPref[m + 1];
                    auxNome[m + 1] = null;
                    auxPref[m + 1] = false;
                }
                auxNome[14] = null;
                auxPref[14] = false;
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Erro: Ninguém na fila");
                Console.ReadKey();
            }
        }
        //----------------------------------------------------------
    }
}