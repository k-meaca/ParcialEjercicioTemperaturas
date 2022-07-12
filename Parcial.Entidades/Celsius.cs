using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialEjercicioTemperaturas.Entidades
{
    public class Celsius
    {
        public float Magnitud;

        public static float CeroAbsoluto;

        //CONSTRUCTOREs

        static Celsius()
        {
            CeroAbsoluto = -273.15f;
        }

        public Celsius(float magnitud)
        {
            if (!MagnitudValida(magnitud))
                throw new ArgumentException($"La temperatura es incorrecta debe ser mayor que {CeroAbsoluto} Celsius."); 
            Magnitud = magnitud;
        }

        //METODOS

        //PRIVADOS
        private bool MagnitudValida(float magnitud)
        {
            return magnitud >= CeroAbsoluto;
        }

        //PUBLICOS
        public static bool operator ==(Celsius celsius, Celsius otroCelsius)
        {
            return celsius.Magnitud == otroCelsius.Magnitud;
        }

        public static bool operator !=(Celsius celsius, Celsius otroCelsius)
        {
            return !(celsius == otroCelsius);
        }

        public static bool operator ==(Celsius celsius, Kelvin kelvin)
        {
            return celsius.Magnitud == ((Celsius)kelvin).Magnitud;
        }

        public static bool operator !=(Celsius celsius, Kelvin kelvin)
        {
            return !(celsius == kelvin);
        }

        public static bool operator ==(Celsius celsius, Fahrenheit fahr)
        {
            return celsius.Magnitud == ((Celsius)fahr).Magnitud;
        }

        public static bool operator !=(Celsius celsius, Fahrenheit fahr)
        {
            return !(celsius == fahr);
        }


        public static implicit operator Celsius(float temperatura)
        {
            return new Celsius(temperatura);
        }

        public static implicit operator float(Celsius celsius)
        {
            return celsius.Magnitud;
        }

        public static explicit operator Celsius(Fahrenheit fahr)
        {
            return new Celsius((fahr.Magnitud - 32) * (5 / 9));
        }

        public static explicit operator Celsius(Kelvin kelvin)
        {
            return new Celsius(kelvin.Magnitud + CeroAbsoluto);
        }

        public static Celsius operator +(Celsius celsius, Celsius otroCelsius)
        {
            return new Celsius(celsius.Magnitud + otroCelsius.Magnitud);
        }

        public static Celsius operator -(Celsius celsius, Celsius otroCelsius)
        {
            float magnitud;

            if(otroCelsius.Magnitud < 0)
            {
                magnitud = celsius.Magnitud + otroCelsius.Magnitud;
            }
            else 
            {
                magnitud = celsius.Magnitud - otroCelsius.Magnitud;
            }
            return new Celsius(magnitud);
        }

        public static bool operator >(Celsius celsius, Celsius otroCelsius)
        {
            return celsius.Magnitud > otroCelsius.Magnitud;
        }

        public static bool operator <(Celsius celsius, Celsius otroCelsius)
        {
            return celsius.Magnitud < otroCelsius.Magnitud;
        }

        public static bool operator >=(Celsius celsius, Celsius otroCelsius)
        {
            return (celsius == otroCelsius) || (celsius > otroCelsius);
        }

        public static bool operator <=(Celsius celsius, Celsius otroCelsius)
        {
            return (celsius == otroCelsius) || (celsius < otroCelsius);
        }

        public static Celsius operator +(Celsius celsius, Kelvin kelvin )
        {
            return new Celsius(celsius.Magnitud + ((Celsius)kelvin).Magnitud);
        }

        public static Celsius operator -(Celsius celsius, Kelvin kelvin)
        {
            float magnitud;

            if (kelvin.Magnitud < 0)
            {
                magnitud = celsius.Magnitud + ((Celsius)kelvin).Magnitud;
            }
            else
            {
                magnitud = celsius.Magnitud - ((Celsius)kelvin).Magnitud;
            }
            return new Celsius(magnitud);
        }

        public static bool operator >(Celsius celsius, Kelvin kelvin)
        {
            return celsius.Magnitud > ((Celsius)kelvin).Magnitud;
        }

        public static bool operator <(Celsius celsius, Kelvin kelvin)
        {
            return celsius.Magnitud < ((Celsius)kelvin).Magnitud;
        }

        public static bool operator >=(Celsius celsius, Kelvin kelvin)
        {
            return (celsius == kelvin) || (celsius > kelvin);
        }

        public static bool operator <=(Celsius celsius, Kelvin kelvin)
        {
            return (celsius == kelvin) || (celsius < kelvin);
        }
        public static Celsius operator +(Celsius celsius, Fahrenheit fahr)
        {
            return new Celsius(celsius.Magnitud + ((Celsius)fahr).Magnitud);
        }

        public static Celsius operator -(Celsius celsius, Fahrenheit fahr)
        {
            float magnitud;

            if (fahr.Magnitud < 0)
            {
                magnitud = celsius.Magnitud + ((Fahrenheit)fahr).Magnitud;
            }
            else
            {
                magnitud = celsius.Magnitud - ((Fahrenheit)fahr).Magnitud;
            }
            return new Celsius(magnitud);
        }

        public static bool operator >(Celsius celsius, Fahrenheit fahr)
        {
            return celsius.Magnitud > ((Celsius)fahr).Magnitud;
        }

        public static bool operator <(Celsius celsius, Fahrenheit fahr)
        {
            return celsius.Magnitud < ((Celsius)fahr).Magnitud;
        }

        public static bool operator >=(Celsius celsius, Fahrenheit fahr)
        {
            return (celsius == fahr) || (celsius > fahr);
        }

        public static bool operator <=(Celsius celsius, Fahrenheit fahr)
        {
            return (celsius == fahr) || (celsius < fahr);
        }

    }
}
