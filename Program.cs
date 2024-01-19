
class Program
{
    //1.Calcular máxim
    static int Maxim(int num1, int num2)
    {
        if (num1 > num2)
        {
            return num1;
        }
        else
        {
            return num2;
        }
    }



    // 2.Métode per calcular el MCD
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

    // 3.Métode per calcular el MCM
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

    //Main
    static void Main()
    {
        //Variables
        int opcio;
        int num1 = 0;
        int num2 = 0;
        double num = 0;

        //Interfaz
        do
        {
            //Colors
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
            int centerY = (Console.WindowHeight - MenuInterfaz.Length) / 2;

            // Bucle per posar cada linea del menu centrada
            foreach (string linea in MenuInterfaz)
            {
                // Calcular la posició
                int centerX = (Console.WindowWidth - linea.Length) / 2;

                Console.SetCursorPosition(centerX, centerY);
                Console.WriteLine(linea);

                // Increment pe rla sseuent linea
                centerY++;
            }

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

            // Switch per calcular la opció
            switch (opcio)
            {
                case 1:
                    int maxim = Maxim(num1, num2);
                    Console.WriteLine($"El Máxim de {num1} i {num2} es: {maxim}");
                    break;

                case 2:
                    int mcd = CalcularMCD(num1, num2);
                    Console.WriteLine($"El MCD de {num1} i {num2} es: {mcd}");
                    break;

                case 3:
                    int mcm = CalcularMCM(num1, num2);
                    Console.WriteLine($"El MCM de {num1} i {num2} es: {mcm}");
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