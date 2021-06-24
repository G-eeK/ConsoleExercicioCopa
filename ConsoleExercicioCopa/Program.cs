using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExercicioCopa
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe o numero de casos");
            int casos = Convert.ToInt32(Console.ReadLine());



            for (int i = 0; i < casos; i++)
            {

                Console.WriteLine("Informe as selecoes");
                string selecoes = Console.ReadLine();

                //string selecoes = "Brasil Chile Colombia Uruguai Franca Nigeria Alemanha Argelia Holanda Mexico CostaRica Grecia Argentina Suica Belgica EUA";

                var arraySelecoes = selecoes.Split(' ').ToList();

                string[] arrayResultados = { };
                string resultados = "";

                int time1 = 0;
                int time2 = 1;
                int count = 0;


                while (arraySelecoes.Count() > 1)
                {

                    if (count == 8 || count == 12 || count == 14)
                    {
                        time1 = 0;
                        time2 = 1;
                    }

                        Console.WriteLine("");
                        resultados = Console.ReadLine();
                        arrayResultados = resultados.Split(' ');

                        if(arrayResultados[0] == arrayResultados[1])
                        {
                            Console.WriteLine("");
                            resultados = Console.ReadLine();
                            arrayResultados = resultados.Split(' ');
                        }

                    
                            if (Convert.ToInt32(arrayResultados[0]) > Convert.ToInt32(arrayResultados[1]))
                            {
                                arraySelecoes.RemoveAt(time2);
                            }
                            else
                            {
                                arraySelecoes.RemoveAt(time1);
                            }

                            time1 = time1 + 1;
                            time2 = time2 + 1;
                            count = count + 1;

                }

                Console.WriteLine(arraySelecoes[0].ToString());

            }


            Console.ReadKey();

        }
    }
}
