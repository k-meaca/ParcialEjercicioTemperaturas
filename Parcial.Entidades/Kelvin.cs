using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialEjercicioTemperaturas.Entidades
{
    public class Kelvin
    {
        public float Magnitud;

        public static float CeroAbsoluto;

        //CONSTRUCTORES

        static Kelvin()
        {
            CeroAbsoluto = 0;
        }

        public Kelvin(float magnitud)
        {
            if (!MagnitudValida(magnitud))
                throw new ArgumentException($"La temperatura es incorrecta debe ser mayor que {CeroAbsoluto} Kelvin.");
            Magnitud = magnitud;
        }

        //METODOS

        //PRIVADOS

        private bool MagnitudValida(float magnitud)
        {
            return magnitud >= CeroAbsoluto;
        }

        //PUBLICOS
        public static bool operator ==(Kelvin kelvin, Kelvin otroKelvin)
        {
            return kelvin.Magnitud == otroKelvin.Magnitud;
        }

        public static bool operator !=(Kelvin kelvin, Kelvin otroKelvin)
        {
            return !(kelvin == otroKelvin);
        }

        public static bool operator ==(Kelvin kelvin, Celsius celsius)
        {
            return kelvin.Magnitud == ((Kelvin)celsius).Magnitud;
        }

        public static bool operator !=(Kelvin kelvin, Celsius celsius)
        {
            return !(kelvin == celsius);
        }

        public static bool operator ==(Kelvin kelvin, Fahrenheit fahr)
        {
            return kelvin.Magnitud == ((Kelvin)fahr).Magnitud;
        }

        public static bool operator !=(Kelvin kelvin, Fahrenheit fahr)
        {
            return !(kelvin == fahr);
        }

        public static implicit operator Kelvin(float temperatura)
        {
            return new Kelvin(temperatura);
        }

        public static implicit operator float(Kelvin kelvin)
        {
            return kelvin.Magnitud;
        }

        public static explicit operator Kelvin(Celsius celsius)
        {
            return new Kelvin(celsius.Magnitud + (-1) * Celsius.CeroAbsoluto);
        }

        public static explicit operator Kelvin(Fahrenheit fahr)
        {
            float magnitud = (fahr.Magnitud + (-1) * Fahrenheit.CeroAbsoluto) * (5 / 9);
            return new Kelvin(magnitud);
        }

        public static Kelvin operator +(Kelvin kelvin, Kelvin otroKelvin)
        {
            return new Kelvin(kelvin.Magnitud + otroKelvin.Magnitud);
        }

        public static Kelvin operator -(Kelvin kelvin, Kelvin otroKelvin)
        {
            float magnitud;

            if (otroKelvin.Magnitud < 0)
            {
                magnitud = kelvin.Magnitud + otroKelvin.Magnitud;
            }
            else
            {
                magnitud = kelvin.Magnitud - otroKelvin.Magnitud;
            }
            return new Kelvin(magnitud);
        }

        public static bool operator >(Kelvin kelvin, Kelvin otroKelvin)
        {
            return kelvin.Magnitud > otroKelvin.Magnitud;
        }

        public static bool operator <(Kelvin kelvin, Kelvin otroKelvin)
        {
            return kelvin.Magnitud < otroKelvin.Magnitud;
        }

        public static bool operator >=(Kelvin kelvin, Kelvin otroKelvin)
        {
            return (kelvin == otroKelvin) || (kelvin > otroKelvin);
        }

        public static bool operator <=(Kelvin kelvin, Kelvin otroKelvin)
        {
            return (kelvin == otroKelvin) || (kelvin < otroKelvin);
        }
        public static Kelvin operator +(Kelvin kelvin, Celsius celsius)
        {
            return new Kelvin(kelvin.Magnitud + ((Kelvin)celsius).Magnitud);
        }

        public static Kelvin operator -(Kelvin kelvin, Celsius celsius)
        {
            float magnitud;

            if (celsius.Magnitud < 0)
            {
                magnitud = kelvin.Magnitud + ((Kelvin)celsius).Magnitud;
            }
            else
            {
                magnitud = kelvin.Magnitud - ((Kelvin)celsius).Magnitud;
            }
            return new Kelvin(magnitud);
        }

        public static bool operator >(Kelvin kelvin, Celsius celsius)
        {
            return kelvin.Magnitud > ((Kelvin)celsius).Magnitud;
        }

        public static bool operator <(Kelvin kelvin, Celsius celsius)
        {
            return kelvin.Magnitud < ((Kelvin)celsius).Magnitud;
        }

        public static bool operator >=(Kelvin kelvin, Celsius celsius)
        {
            return (kelvin == celsius) || (kelvin > celsius);
        }

        public static bool operator <=(Kelvin kelvin, Celsius celsius)
        {
            return (kelvin == celsius) || (kelvin < celsius);
        }
        public static Kelvin operator +(Kelvin kelvin, Fahrenheit fahr)
        {
            return new Kelvin(fahr.Magnitud + ((Kelvin)fahr).Magnitud);
        }

        public static Kelvin operator -(Kelvin kelvin, Fahrenheit fahr)
        {
            float magnitud;

            if (fahr.Magnitud < 0)
            {
                magnitud = kelvin.Magnitud + ((Kelvin)fahr).Magnitud;
            }
            else
            {
                magnitud = kelvin.Magnitud - ((Kelvin)fahr).Magnitud;
            }
            return new Kelvin(magnitud);
        }

        public static bool operator >(Kelvin kelvin, Fahrenheit fahr)
        {
            return kelvin.Magnitud > ((Kelvin)fahr).Magnitud;
        }

        public static bool operator <(Kelvin kelvin, Fahrenheit fahr)
        {
            return kelvin.Magnitud < ((Kelvin)fahr).Magnitud;
        }

        public static bool operator >=(Kelvin kelvin, Fahrenheit fahr)
        {
            return (kelvin == fahr) || (kelvin > fahr);
        }

        public static bool operator <=(Kelvin kelvin, Fahrenheit fahr)
        {
            return (kelvin == fahr) || (kelvin < fahr);
        }
    }
}
