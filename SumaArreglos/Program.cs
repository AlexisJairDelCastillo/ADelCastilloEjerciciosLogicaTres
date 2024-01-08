namespace SumaArreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[10];
            int suma = 0;

            Console.WriteLine("Introduce 10 numeros del 1 al 50.");

            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine("Introduce un numero: ");
                arreglo[i] = int.Parse(Console.ReadLine());

                suma += arreglo[i];
            }

            Console.WriteLine($"La suma de todos los numeros es: {suma}");
            Console.ReadKey();
        }
    }
}