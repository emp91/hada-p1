using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    class Program
    {

        /// <summary>
        /// Modificamos el main para tener la opcion de las horas
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string respuesta = "";
            do
            {
                Console.WriteLine("¿De que unidad quiere partir?(minutos/segundos/horas)");
                string unidad = Console.ReadLine();
                Console.WriteLine("Cantidad:");
                string cantidad = Console.ReadLine();
                if (unidad == "minutos")
                {
                    double cantidad1 = double.Parse(cantidad);
                    double total1 = HadaP1.Minutes2Seconds(cantidad1);
                    Console.WriteLine("Cantidad de segundos:");
                    Console.WriteLine(total1);
                }
                else
                {
                    if (unidad == "segundos")
                    {
                        double cantidad1 = double.Parse(cantidad);
                        double total = HadaP1.Seconds2Minutes(cantidad1);
                        Console.WriteLine("Cantidad de minutos:");
                        Console.WriteLine(total);
                    }
                    else
                    {
                        if (unidad == "horas")
                        {
                            double cantidad1 = double.Parse(cantidad);
                            double total = HadaP1.Hours2Minutes(cantidad1);
                            Console.WriteLine("Cantidad de minutos:");
                            Console.WriteLine(total);
                        }
                        else {
                            Console.WriteLine("Error, no está esa opcion");
                        }
                    }

                }
                Console.WriteLine("¿Tiene otra consulta?(s/n)");
                respuesta = Console.ReadLine();

            } while (respuesta != "n");
        }

    }
}
