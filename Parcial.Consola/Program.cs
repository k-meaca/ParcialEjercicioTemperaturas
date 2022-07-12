using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParcialEjercicioTemperaturas.Entidades;

namespace ParcialEjercicioTemperaturas.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Celsius celsius = new Celsius(24);
                Celsius otroCelsius = new Celsius(-5);
                
                if(celsius > otroCelsius)
                {
                    Console.WriteLine($"{celsius.Magnitud} °C es mayor que {otroCelsius.Magnitud} °C.");
                }
                else
                {
                    Console.WriteLine($"{celsius.Magnitud} °C es menor que {otroCelsius.Magnitud} °C.");
                }

                Fahrenheit fahr = 70f;
                Fahrenheit otroFahr = (Fahrenheit)celsius;

                if(fahr == otroFahr)
                {
                    Console.WriteLine($"Los fharenheit son iguales. {fahr.Magnitud} == {otroFahr.Magnitud}");
                }
                else
                {
                    Console.WriteLine($"Los fahrenheit son distintos. {fahr.Magnitud} != {otroFahr.Magnitud}");
                }

                Kelvin kelvin = new Kelvin(100);
                Kelvin otroKelvin = (Kelvin)(Fahrenheit)otroCelsius;

                if (otroKelvin <= kelvin)
                {
                    Console.WriteLine($"La suma de {celsius.Magnitud}°C + {otroKelvin.Magnitud}K en Celsius es {(celsius + otroKelvin).Magnitud}°C");
                }
                else
                {
                    Console.WriteLine($"La suma de {fahr.Magnitud}F + {kelvin.Magnitud}K en Kelvin es {(kelvin + fahr).Magnitud}");
                }

                Celsius clsius = celsius.Magnitud - otroCelsius.Magnitud;
                Console.WriteLine($"La resta de {celsius.Magnitud} y {otroCelsius.Magnitud} es {(celsius - otroCelsius).Magnitud}°C");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.ReadLine();
        }
    }
}
