namespace MenorMayor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[5];

            Console.WriteLine("Introduce 5 numeros.");

            for(int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine("Introduce un numero: ");
                arreglo[i] = int.Parse(Console.ReadLine());
            }

            int menor = arreglo[0];
            int mayor = arreglo[0];

            for (int i = 1; i < arreglo.Length; i++)
            {
                if (arreglo[i] < menor )
                {
                    menor = arreglo[i];
                }

                if (arreglo[i] > mayor)
                {
                    mayor = arreglo[i];
                }
            }

            Console.WriteLine($"El numero menor del arreglo es: {menor}");
            Console.WriteLine($"El numero mayor del arreglo es: {mayor}");
            Console.ReadKey();
        }
    }
}