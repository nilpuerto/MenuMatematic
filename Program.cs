class Program
{
    // 1.Calcular màxim
    static int Maxim(int a, int b)
    {
        return (a > b) ? a : b;
    }

    // 2.Mètode per calcular el MCD
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

    // 3.Mètode per calcular el MCM
    static int CalcularMCM(int a, int b)
    {
        int mcd = CalcularMCD(a, b);
        int mcm = (a * b) / ((mcd == 0) ? 1 : mcd);
        return mcm;
    }

    // 4.Calcular Factorial
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

    // 5. Calcular Combinatori
    static double CalcularCombinatori(double n, int k)
    {
        double combinatori = CalcularFactorial(n) / (CalcularFactorial(k) * CalcularFactorial(n - k));
        return combinatori;
    }

    // 6. Calcular Divisor Major
    static int CalcularDivisorMajor(int a, int b)
    {
        int divisorMajor = 1;

        for (int i = 1; i <= a && i <= b; i++)
        {
            if (a % i == 0 && b % i == 0)
            {
                divisorMajor = i;
            }
        }

        return divisorMajor;
    }

    // 7. Calcular Numero Primer
    static bool EsNumeroPrimer(int num)
    {
        if (num < 2)
        {
            return false;
        }

        //MATH SQRT per calcualr arrel quadrada
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }
    // Main
    static void Main()
    {
        // Variables
        int opcio;
        int num1 = 0;
        int num2 = 0;
        double num = 0;

        // Interfaz
        do
        {
            // Colors
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Quadre
            string[] MenuInterfaz = {
                    " ╔═════════════════════════════════════════════════════════╗ ",
                    " ║                    MENU MATEMATIC                       ║ ",
                    " ║=========================================================║ ",
                    " ║                    1) Maxim                             ║ ",
                    " ║                    2) MCD                               ║ ",
                    " ║                    3) MCM                               ║ ",
                    " ║                    4) Factorial                         ║ ",
                    " ║                    5) Combinatori                       ║ ",
                    " ║                    6) Divisor Major                     ║ ",
                    " ║                    7) Numero Primer                     ║ ",
                    " ║                    8) NPrimers                          ║ ",
                    " ║                    9) Sortir                            ║ ",
                    " ║=========================================================║ ",
                    " ║   - Escull una opcio -                                  ║ ",
                    " ║=========================================================║ ",
                    " ║                                             Nil i Alex  ║ ",
                    " ║_________________________________________________________║ "
            };

            // POSICIO EN VERTICAL
            int centreY = (Console.WindowHeight - MenuInterfaz.Length) / 2;

            // Bucle per posar cada línia del menú centrada
            foreach (string linea in MenuInterfaz)
            {
                // Calcular la posició
                int centreX = (Console.WindowWidth - linea.Length) / 2;

                Console.SetCursorPosition(centreX, centreY);
                Console.WriteLine(linea);

                // Increment per la següent línia
                centreY++;
            }

            opcio = Convert.ToInt32(Console.ReadLine());

            // Seleccionar opció y preguntar números
            if (opcio > 0 && opcio < 9)
            {
                // Preguntar per un sol número si tria el 4 o el 5
                if (opcio != 4 && opcio != 5)
                {
                    Console.Write("Escriu un número: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Escriu un altre número: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.Write("Escriu un número: ");
                    num = Convert.ToDouble(Console.ReadLine());
                }
            }

            // Switch per calcular la opció
            switch (opcio)
            {
                case 1:
                    int maxim = Maxim(num1, num2);
                    Console.WriteLine($"El Màxim de {num1} i {num2} és: {maxim}");
                    break;

                case 2:
                    int mcd = CalcularMCD(num1, num2);
                    Console.WriteLine($"El MCD de {num1} i {num2} és: {mcd}");
                    break;

                case 3:
                    int mcm = CalcularMCM(num1, num2);
                    Console.WriteLine($"El MCM de {num1} i {num2} és: {mcm}");
                    break;

                case 4:
                    double factorial = CalcularFactorial(num);
                    Console.WriteLine($"El resultat Factorial de {num} és: {factorial}");
                    break;

                case 5:
                    Console.Write("Escriu un altre valor: ");
                    int valorP = Convert.ToInt32(Console.ReadLine());
                    double combinatoriResultat = CalcularCombinatori(num, valorP);
                    Console.WriteLine($"El Combinatori de C({num1}, {valorP}) és: {combinatoriResultat}");
                    break;

                case 6:
                    int divisorMajor = CalcularDivisorMajor(num1, num2);
                    Console.WriteLine($"El Divisor Major de {num1} i {num2} és: {divisorMajor}");
                    break;

                case 7:
                    bool esPrimer1 = EsNumeroPrimer(num1);
                    bool esPrimer2 = EsNumeroPrimer(num2);

                    Console.WriteLine($"El número {num1} {(esPrimer1 ? "es" : "no es")} primer.");
                    Console.WriteLine($"El número {num2} {(esPrimer2 ? "es" : "no es")} primer.");
                    break;

                // Opció de sortida
                case 9:
                    Console.WriteLine("Sortint del programa.");
                    break;
            }

            // Aquí fem que esperi 5 segons
            if (opcio != 9)
            {
                for (int i = 5; i > 0; i--)
                {
                    Console.WriteLine($"Esperant {i} segons...");
                    Thread.Sleep(1000); // 1000 milisegons = 1 segon
                }

                Console.WriteLine("Esperant 0 segons...");
            }
        } while (opcio != 9);
    }
}
