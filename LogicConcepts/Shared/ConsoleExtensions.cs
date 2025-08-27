namespace Shared
{
    public class ConsoleExtensions
    {

        public static int GetInt(string message)
        {

            Console.Write(message);
            var imput = Console.ReadLine();
            if (int.TryParse(imput, out int result))
            {
                return result;
            }

            throw new Exception("El valor ingresado no es un numero entero valido");


        }

    }
    

 }

