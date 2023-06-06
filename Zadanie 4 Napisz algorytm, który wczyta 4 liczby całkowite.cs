// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
int a = int.Parse(Console.ReadLine());
int b= int.Parse(Console.ReadLine());
int c= int.Parse(Console.ReadLine());
int d= int.Parse(Console.ReadLine());
if(b==0 || d==0)
{
    Console.WriteLine("Brak rozwiązań");
    
}
else
{
    int x = (a * d) + (b * c);
    int y = (b * d);
    Console.WriteLine(x);
    Console.WriteLine("--");
    Console.WriteLine(y);

}


