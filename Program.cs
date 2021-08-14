using System;
using System.Threading;

namespace Cronometro
{
            //****Cronometro regressivo****
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu ()
        {   
            Console.Clear();
            Console.WriteLine("S = Segundos => 10s  = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("R = Regressivo => 10s ou 1m");
            Console.WriteLine("0 = Sair =>");
            Console.WriteLine("Quanto tempo deseja contar? ");

            string data = Console.ReadLine().ToLower();
            //Com o código abaixo, verifico a quantidade de caracteres,
            //que o usuário inseriu e imputo o ultimo na tela.
            //exemplo: 10s ele irá se identificar pelo "s" de segundos.
            char type = char.Parse(data.Substring(data.Length -1,1));
            int time = int.Parse(data.Substring(0, data.Length -1));
            //multiplicador que inicia sempre com 1
            int multiplier = 1;

            //verificação se o usuário digitar "m" minutos, o contador
            //contará até 60 segundos
            if (type == 'm')
                multiplier--;

            if (type == 's')
                multiplier--;    

            //Se o usuário digitar 0 ele irá sair da aplicação
            if(time == 0)           
            {
                System.Environment.Exit(0);
            }

            //Realizará a contagem do contador sempre por 1 segundo.
            Start( time - multiplier);              

        }
        static void  Start (int time)
        {   
            //instanciando a contagem do 0 ao 10
        
            //Realizando a verificação da contagem do cronometro por
            //meio do While ele fará a contagem do 0 ao 10.
            //para isso inseri o simbolo de condição != 
            //ou seja enquanto currentime for diferente de Time
            //ele realizará a contagem.
            while (time > 0)
            {   
                Console.Clear();
                //Contador.
                time--;
                Console.WriteLine(time);
                //Comando responsável por fazer a verificação do while
                //a cada 1000 milesegundos.
                Thread.Sleep(1000);
            }        

            Console.Clear();
            Console.WriteLine("Cronometro Finalizado!");
            Thread.Sleep(2500);
            Menu();
        }       
    }
}
