using System;

class Calculadora
{
    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.Clear(); // Limpia la pantalla en cada ciclo
            Console.WriteLine("Calculadora\n");
            Console.WriteLine("1- Suma");
            Console.WriteLine("2- Resta");
            Console.WriteLine("3- Multiplicación");
            Console.WriteLine("4- División");
            Console.WriteLine("5- Elevar un número a la potencia");
            Console.WriteLine("6- Salir");
            Console.Write("\nSeleccione una opción: ");

            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Sumar();
                    break;
                case 2:
                    Restar();
                    break;
                case 3:
                    Multiplicar();
                    break;
                case 4:
                    Dividir();
                    break;
                case 5:
                    Potencia();
                    break;
                case 6:
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida, intente de nuevo.");
                    break;
            }

            if (continuar)
            {
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }
    }

    static void Sumar()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double resultado = num1 + num2;
        Console.WriteLine($"El resultado de la suma es: {resultado}");
    }

    static void Restar()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double resultado = num1 - num2;
        Console.WriteLine($"El resultado de la resta es: {resultado}");
    }

    static void Multiplicar()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double resultado = num1 * num2;
        Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
    }

    static void Dividir()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        if (num2 != 0)
        {
            double resultado = num1 / num2;
            Console.WriteLine($"El resultado de la división es: {resultado}");
        }
        else
        {
            Console.WriteLine("Error: No se puede dividir entre cero.");
        }
    }

    static void Potencia()
    {
        Console.Write("Ingrese la base: ");
        double baseNum = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el exponente: ");
        double exponente = Convert.ToDouble(Console.ReadLine());

        double resultado = Math.Pow(baseNum, exponente);
        Console.WriteLine($"El resultado de elevar {baseNum} a la potencia {exponente} es: {resultado}");
    }
}
