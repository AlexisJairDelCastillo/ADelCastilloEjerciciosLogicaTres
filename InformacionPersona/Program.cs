namespace InformacionPersona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre1, nombre2;
            int edad1, edad2;
            char sexo1, sexo2;
            double peso1;
            double altura1;
            string dni = "";

            Console.WriteLine("Introduce tu nombre: ");
            nombre1 = Console.ReadLine();
            Console.WriteLine("Introduce tu edad: ");
            edad1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce tu genero: H o M");
            sexo1 = char.Parse(Console.ReadLine());
            Console.WriteLine("Introduce tu peso en kg: ");
            peso1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduce tu altura en cm: ");
            altura1 = double.Parse(Console.ReadLine());

            Persona persona1 = new Persona(nombre1, edad1, dni, sexo1, peso1, altura1);

            Console.WriteLine("Introduce tu nombre: ");
            nombre2 = Console.ReadLine();
            Console.WriteLine("Introduce tu edad: ");
            edad2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce tu genero: H o M");
            sexo2 = char.Parse(Console.ReadLine());

            Persona persona2 = new Persona(nombre2, edad2, sexo2);

            Persona persona3 = new Persona();

            Console.WriteLine("Persona 1");
            double imc1 = persona1.CalcularIMC();
            Console.WriteLine($"IMC: {imc1}");
            Console.WriteLine($"¿Es mayor de edad?: {persona1.EsMayorDeEdad()}");
            Console.WriteLine(persona1.ToString());

            Console.WriteLine("Persona 2");
            double imc2 = persona2.CalcularIMC();
            Console.WriteLine($"IMC: {imc2}");
            Console.WriteLine($"¿Es mayor de edad?: {persona2.EsMayorDeEdad()}");
            Console.WriteLine(persona2.ToString());

            Console.WriteLine("Persona 3");
            double imc3 = persona3.CalcularIMC();
            Console.WriteLine($"IMC: {imc3}");
            Console.WriteLine($"¿Es mayor de edad?: {persona3.EsMayorDeEdad()}");
            Console.WriteLine(persona3.ToString());
        }
    }
}