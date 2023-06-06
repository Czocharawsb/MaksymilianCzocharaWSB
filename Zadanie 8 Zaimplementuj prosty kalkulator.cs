// See https://aka.ms/new-console-template for more information
Console.WriteLine("Podaj pierwszą liczbę:");
double number1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Podaj drugą liczbę:");
double number2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Podaj numer działania (dodawanie - 1, odejmowanie - 2, mnożenie - 3, dzielenie - 4):");
int operation = Convert.ToInt32(Console.ReadLine());

double result = 0;

switch (operation)
{
    case 1:
        result = number1 + number2;
        break;
    case 2:
        result = number1 - number2;
        break;
    case 3:
        result = number1 * number2;
        break;
    case 4:
        if (number2 != 0)
        {
            result = number1 / number2;
        }
        else
        {
            Console.WriteLine("Nie można dzielić przez zero!");
            
            return;
        }
        break;
    default:
        Console.WriteLine("Nieprawidłowy numer działania.");
        return;
}

Console.WriteLine("Wynik: " + result);
