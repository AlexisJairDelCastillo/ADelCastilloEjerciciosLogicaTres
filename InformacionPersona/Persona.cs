using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformacionPersona
{
    public class Persona
    {
        public string Nombre;

        public int Edad;

        public string DNI;

        public char Sexo;

        public double Peso;

        public double Altura;

        public const char SEXODEFECTO = 'H';

        public Persona() {
            this.Nombre = "";
            this.Edad = 0;
            this.DNI = GenerarDNI();
            this.Sexo = SEXODEFECTO;
            this.Peso = 0.0;
            this.Altura = 0.0;
        }

        public Persona(string nombre, int edad, char sexo)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.DNI = GenerarDNI();
            this.Sexo = ComprobarSexo(sexo);
            this.Peso = 0.0;
            this.Altura = 0.0;
        }

        public Persona(string nombre, int edad, string dni, char sexo, double peso, double altura)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.DNI = GenerarDNI();
            this.Sexo = ComprobarSexo(sexo);
            this.Peso = peso;
            this.Altura = altura;
        }

        public int CalcularIMC()
        {
            double imc = Peso / Math.Pow(Altura, 2);

            if(imc < 20)
            {
                return -1;
            }
            else
            if (imc >= 20 && imc <= 25)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public bool EsMayorDeEdad()
        {
            if (Edad >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char ComprobarSexo(char sexo)
        {
            if (sexo == 'H' || sexo == 'M')
            {
                return sexo;
            }
            else
            {
                return SEXODEFECTO;
            }
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Edad: {Edad}, DNI: {DNI}, Sexo: {Sexo}, Peso: {Peso}, Altura: {Altura}";
        }

        public string GenerarDNI()
        {
            Random rand = new Random();
            int numeroDNI = rand.Next(10000000, 99999999);
            char letra = ObtenerLetraDNI(numeroDNI);

            return $"{numeroDNI} - {letra}";
        }

        public char ObtenerLetraDNI(int numeroDNI)
        {
            string letras = "TRWAGMYFPDXBNJZSQVHLCKE";
            int indiceLetra = numeroDNI % 23;

            return letras[indiceLetra];
        }

        public void SetNombre(string nombre)
        {
            this.Nombre = nombre;
        }

        public void SetEdad(int edad)
        {
            this.Edad = edad;
        }

        public void SetSexo(char sexo)
        {
            this.Sexo = ComprobarSexo(sexo);
        }

        public void SetPeso(double peso)
        {
            this.Peso = peso;
        }

        public void SetAltura(double altura)
        {
            this.Altura = altura;
        }
    }
}
