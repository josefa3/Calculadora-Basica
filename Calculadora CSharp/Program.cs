// See https://aka.ms/new-console-template for more information

float Valor1 = 0;
float Valor2 = 0;
float resultado = 0;
string signo = "";

Console.WriteLine("Bienvenido a la calculadora\n" + "Por favor elija cualquiera de los 4 tipos de operación\n");
Console.WriteLine("+ para sumar\n - para restar\n * para multiplicar\n / para dividir\n 4 para salir\n");

signo = Console.ReadLine();

do
{
    try
    {
        switch (signo)
        {
            case "+":
                Console.WriteLine("Introduzca el valor 1");
                Valor1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Introduzca el valor 2");
                Valor2 = float.Parse(Console.ReadLine());
                resultado = Valor1 + Valor2;
                Console.WriteLine("{0} + {1} = {2}\n", Valor1, Valor2, resultado);
                break;
            case "-":
                Console.WriteLine("Introduzca el valor 1");
                Valor1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Introduzca el valor 2");
                Valor2 = float.Parse(Console.ReadLine());
                resultado = Valor1 - Valor2;
                Console.WriteLine("{0} - {1} = {2}\n", Valor1, Valor2, resultado);
                break;
            case "*":
                Console.WriteLine("Introduzca el valor 1");
                Valor1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Introduzca el valor 2");
                Valor2 = float.Parse(Console.ReadLine());
                resultado = Valor1 * Valor2;
                Console.WriteLine("{0} * {1} = {2}\n", Valor1, Valor2, resultado);
                break;
            case "/":
                Console.WriteLine("Introduzca el valor 1");
                Valor1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Introduzca el valor 2");
                Valor2 = float.Parse(Console.ReadLine());
                resultado = Valor1 / Valor2;
                Console.WriteLine("{0} / {1} = {2}\n", Valor1, Valor2, resultado);
                break;
            case "4":
                Console.WriteLine("Adios!!!\n");
                break;
            default:
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Ha introducido un formato incorrecto, por favor, solo utilice numeros\n");
    }


    Console.WriteLine("Eliga una opcion del menu anterior\n");
    signo = Console.ReadLine();

} while (signo != "4");

