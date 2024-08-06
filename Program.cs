namespace arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];

            Console.WriteLine("Por favor, ingresa 10 números desordenados:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Número " + (i + 1) + ": ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numeros);

            Console.WriteLine("\nNúmeros ordenados:");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
           