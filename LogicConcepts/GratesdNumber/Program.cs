using Shared;

var response = string.Empty;
do
{
    try
    {
        var number1 = ConsoleExtensions.GetInt("Ingrese primer numero: ");
        var number2 = ConsoleExtensions.GetInt("Ingrese segundo numero: ");
        var number3 = ConsoleExtensions.GetInt("Ingrese tercer numero: ");

        if (number1 > number2 && number1 > number3)
        {
            Console.WriteLine($"El numero mayor es: {number1}");
        }
        else if (number2 > number1 && number2 > number3)
        {
            Console.WriteLine($"El numero mayor es: {number2}");
        }
        else if ( number3 > number1 && number3 > number2)
        {
            Console.WriteLine($"El numero mayor es: {number3}");
        }
        else
        {
            Console.WriteLine("Los numeros son iguales o no se pudo determinar un unico mayot");
        }

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    Console.Write("Desea continuar[S/N]? ");
    response = Console.ReadLine()!.ToUpper();
} while (response == "S");
