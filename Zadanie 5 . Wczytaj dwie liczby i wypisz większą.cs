// See https://aka.ms/new-console-template for more information
float a=float.Parse(Console.ReadLine());
float b = float.Parse(Console.ReadLine());

if(a==b)
{
    Console.WriteLine("Liczby jednakowe i wynoszą" +a);
}
if(a>b)
{
    Console.WriteLine("Większa liczba to: " + a);
}
if(b>a)
{
    Console.WriteLine("Większa liczba to: "+b);
}