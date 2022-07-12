using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialEjercicioTemperaturas.Entidades
{
    public class Fahrenheit
    {
        public float Magnitud;

        public static float CeroAbsoluto;

        //CONSTRUCTORES

        static Fahrenheit()
        {
            CeroAbsoluto = -459.67f;
        }

        public Fahrenheit(float magnitud)
        {
            if (!MagnitudValida(magnitud))
                throw new ArgumentException($"La temperatura es incorrecta debe ser mayor que {CeroAbsoluto} Fahrenheit.");
            Magnitud = magnitud;
        }

        //METODOS

        //PRIVADOS

        private bool MagnitudValida(float magnitud)
        {
            return magnitud >= CeroAbsoluto;
        }


        //PUBLICOS
        public static bool operator ==(Fahrenheit fahr, Fahrenheit otroFarh)
        {
            return fahr.Magnitud == otroFarh.Magnitud;
        }

        public static bool operator !=(Fahrenheit fahr, Fahrenheit otroFarh)
        {
            return !(fahr == otroFarh);
        }

        public static bool operator ==(Fahrenheit fahr, Celsius celsius)
        {
            return fahr.Magnitud == ((Fahrenheit)celsius).Magnitud;
        }

        public static bool operator !=(Fahrenheit fahr, Celsius celsius)
        {
            return !(fahr == celsius);
        }

        public static bool operator ==(Fahrenheit fahr, Kelvin kelvin)
        {
            return fahr.Magnitud == ((Fahrenheit)kelvin).Magnitud;
        }

        public static bool operator !=(Fahrenheit fahr, Kelvin kelvin)
        {
            return !(fahr == kelvin);
        }

        public static implicit operator Fahrenheit(float temperatura)
        {
            return new Fahrenheit(temperatura);
        }

        public static implicit operator float(Fahrenheit fahr)
        {
            return fahr.Magnitud;
        }

        public static explicit operator Fahrenheit(Celsius celsius)
        {
            return new Fahrenheit((celsius.Magnitud * (9 / 5)) + 32);
        }

        public static explicit operator Fahrenheit(Kelvin kelvin)
        {
            return new Fahrenheit((kelvin.Magnitud * (9 / 5)) + CeroAbsoluto);
        }

        public static Fahrenheit operator +(Fahrenheit fahr, Fahrenheit otroFahr)
        {
            return new Fahrenheit(fahr.Magnitud + otroFahr.Magnitud);
        }

        public static Fahrenheit operator -(Fahrenheit fahr, Fahrenheit otroFahr)
        {
            float magnitud;

            if (otroFahr.Magnitud < 0)
            {
                magnitud = fahr.Magnitud + otroFahr.Magnitud;
            }
            else
            {
                magnitud = fahr.Magnitud - otroFahr.Magnitud;
            }
            return new Fahrenheit(magnitud);
        }

        public static bool operator >(Fahrenheit fahr, Fahrenheit otroFahr)
        {
            return fahr.Magnitud > otroFahr.Magnitud;
        }

        public static bool operator <(Fahrenheit fahr, Fahrenheit otroFahr)
        {
            return fahr.Magnitud < otroFahr.Magnitud;
        }
        public static bool operator >=(Fahrenheit fahr, Fahrenheit otroFahr)
        {
            return (fahr == otroFahr) || (fahr > otroFahr);
        }

        public static bool operator <=(Fahrenheit fahr, Fahrenheit otroFahr)
        {
            return (fahr == otroFahr) || (fahr < otroFahr);
        }

        public static Fahrenheit operator +(Fahrenheit fahr, Celsius celsius)
        {
            return new Fahrenheit(fahr.Magnitud + ((Fahrenheit)celsius).Magnitud);
        }

        public static Fahrenheit operator -(Fahrenheit fahr, Celsius celsius)
        {
            float magnitud;

            if (celsius.Magnitud < 0)
            {
                magnitud = fahr.Magnitud + ((Fahrenheit)celsius).Magnitud;
            }
            else
            {
                magnitud = fahr.Magnitud - ((Fahrenheit)celsius).Magnitud;
            }
            return new Fahrenheit(magnitud);
        }

        public static bool operator >(Fahrenheit fahr, Celsius celsius)
        {
            return fahr.Magnitud > ((Fahrenheit)celsius).Magnitud;
        }

        public static bool operator <(Fahrenheit fahr, Celsius celsius)
        {
            return fahr.Magnitud < ((Fahrenheit)celsius).Magnitud;
        }

        public static bool operator >=(Fahrenheit fahr, Celsius celsius)
        {
            return (fahr == celsius) || (fahr > celsius);
        }

        public static bool operator <=(Fahrenheit fahr, Celsius celsius)
        {
            return (fahr == celsius) || (fahr < celsius);
        }
        public static Fahrenheit operator +(Fahrenheit fahr, Kelvin kelvin)
        {
            return new Fahrenheit(fahr.Magnitud + ((Fahrenheit)kelvin).Magnitud);
        }

        public static Fahrenheit operator -(Fahrenheit fahr, Kelvin kelvin)
        {
            float magnitud;

            if (kelvin.Magnitud < 0)
            {
                magnitud = fahr.Magnitud + ((Fahrenheit)kelvin).Magnitud;
            }
            else
            {
                magnitud = fahr.Magnitud - ((Fahrenheit)kelvin).Magnitud;
            }
            return new Fahrenheit(magnitud);
        }

        public static bool operator >(Fahrenheit fahr, Kelvin kelvin)
        {
            return fahr.Magnitud > ((Fahrenheit)kelvin).Magnitud;
        }

        public static bool operator <(Fahrenheit fahr, Kelvin kelvin)
        {
            return fahr.Magnitud < ((Fahrenheit)kelvin).Magnitud;
        }

        public static bool operator >=(Fahrenheit fahr, Kelvin kelvin)
        {
            return (fahr == kelvin) || (fahr > kelvin);
        }

        public static bool operator <=(Fahrenheit fahr, Kelvin kelvin)
        {
            return (fahr == kelvin) || (fahr < kelvin);
        }
    }
}
