using System;
using System.Reflection.Metadata.Ecma335;
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

    // Métode per calcular el Factorial
    static int Factorial(int num)
    {
        int result = 1;
        for (int i = 1; i <= num; i++)
        {
            result *= i;
        }
        return result;
    }

    // Métode per calcular Combinatori
    static int Combinatori(int num1, int num2)
    {
        return Factorial(num1) / (Factorial(num2) * Factorial(num1 - num2));
    }

    // Métode per calcular el Divisor Major
    static int DivisorMajor(int num)
    {
        int major = -1;
        for (int i = 2; i <= / 2;  i++)
        {
            if (num % i == 0)
            {
                major = i;
            }
        }
    }
    return major;

    // Métode per calcular el numero primer
    static bool Primer(int num)
    {
        bool primer = false;
        int cont = 1, resultat = 0;
        while (cont <= num)
        {
            if (numero % cont == 0)
            {
                resultat++;
            }
            cont++;
        }

        if (resultat <= 2)
        {
            primer = true;
        }
        return primer;
    }
    // Métode per calcular els 5 Primers
    static string NPrimers(int primers)
    {
        int num = 1, a, b, i = 1;
        string primersp = "";
        while (n < primers)
        {
            a = 0;
            for (b = 1; b <= i; b++)
            {
                if (i % b == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                n++;
                primersp += i + " ";
            }
            i++;
        }
        return primersp;
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
                    double factorial = Factorial(num);
                    Console.WriteLine($"El resultat Factorial de {num} es: {factorial}");
                    break;
                case 5:
                    int convinatori = Combinatori(int num1, int num2);
                    Console.WriteLine($"El resultat Combinatori de {num1} i {num2} es: {convinatori}");
                    break;
                case 6:
                    int major = DivisorMajor(int num);
                    Console.WriteLine($"El resultat de Divisor Major de {num} es: {major}");
                    break;
                case 7:
                    bool primer = Primer(int num);
                    Console.WriteLine($"El resultat de Numero Primer de {num} es: {primer}");
                    break;
                case 8:
                    string primersprimer = NPrimers(int num);
                    Console.WriteLine($"El resultat de PrimersPrimer de {num} es:  )
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