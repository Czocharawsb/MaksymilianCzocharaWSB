// See https://aka.ms/new-console-template for more information
Console.WriteLine("Podaj współrzędne punktu P:");
Console.Write("x: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("y: ");
double y = Convert.ToDouble(Console.ReadLine());

Console.Write("Podaj promień koła r: ");
double r = Convert.ToDouble(Console.ReadLine());

double distanceSquared = x * x + y * y;
double radiusSquared = r * r;

if (distanceSquared <= radiusSquared)
{
    Console.WriteLine("Punkt P({0}, {1}) leży w obrębie koła o środku O(0, 0) i promieniu {2}.", x, y, r);
}
else
{
    Console.WriteLine("Punkt P({0}, {1}) nie leży w obrębie koła o środku O(0, 0) i promieniu {2}.", x, y, r);
}


