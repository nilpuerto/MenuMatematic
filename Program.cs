using System;
using System.Threading;

class Program
{
    // Métode per calcular el MCD
    static int CalcularMCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Métode per calcular el MCM
    static int CalcularMCM(int a, int b)
    {
        int mcd = CalcularMCD(a, b);
        int mcm = (a * b) / ((mcd == 0) ? 1 : mcd);

        return mcm;
    }

    static double CalcularFactorial(double n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        else
        {
            return n * CalcularFactorial(n - 1);
        }
    }

    static void Main()
    {
        int opcio;
        int num1 = 0;
        int num2 = 0;
        double num = 0;

        do
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Titul
            Console.WriteLine(" ╔═════════════════════════════════════════════════════════╗ ");
            Console.WriteLine(" ║                    MENU MATEMATIC                       ║ ");
            Console.WriteLine(" ║=========================================================║ ");
            Console.WriteLine(" ║                    1) Maxim                             ║ ");
            Console.WriteLine(" ║                    2) MCD                               ║ ");
            Console.WriteLine(" ║                    3) MCM                               ║ ");
            Console.WriteLine(" ║                    4) Factorial                         ║ ");
            Console.WriteLine(" ║                    5) Combinatori                       ║ ");
            Console.WriteLine(" ║                    6) Divisor Major                     ║ ");
            Console.WriteLine(" ║                    7) Numero Primer                     ║ ");
            Console.WriteLine(" ║                    8) NPrimers                          ║ ");
            Console.WriteLine(" ║                    9) Sortir                            ║ ");
            Console.WriteLine(" ║=========================================================║ ");
            Console.WriteLine(" ║   - Escull una opcio -                                  ║ ");
            Console.WriteLine(" ║=========================================================║ ");
            Console.WriteLine(" ║                                             Nil i Alex  ║ ");
            Console.WriteLine(" ║_________________________________________________________║ ");

            opcio = Convert.ToInt32(Console.ReadLine());

            // Seleccionar opció y preguntar números
            if (opcio > 0 && opcio < 9)
            {
                // Preguntar per un sol número si tria el 3
                if (opcio != 4)
                {
                    Console.Write("Escriu un numero: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Escriu un altre numero: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.Write("Escriu un numero: ");
                    num = Convert.ToDouble(Console.ReadLine());
                }
            }

            // Switch per calcular la opción
            switch (opcio)
            {
                case 2:
                    int mcd = CalcularMCD(num1, num2);
                    Console.WriteLine($"El MCD de {num1} y {num2} es: {mcd}");
                    break;

                case 3:
                    int mcm = CalcularMCM(num1, num2);
                    Console.WriteLine($"El MCM de {num1} y {num2} es: {mcm}");
                    break;

                case 4:
                    double factorial = CalcularFactorial(num);
                    Console.WriteLine($"El resultat Factorial de {num} es: {factorial}");
                    break;

                // Opció de sortida
                case 9:
                    Console.WriteLine("Sortint del programa.");
                    break;
            }

            // Aqui fem que em d'esperar 5 segons
            if (opcio != 9)
            {
                Console.WriteLine("Esperant 5 segons...");
                Thread.Sleep(5000); // 5000 milisegons = 5 segons

            }

        } while (opcio != 9);

    }
}