// See https://aka.ms/new-console-template for more information
var PI = 3.14;

var Pole= double.Parse(Console.ReadLine());

var r = double.Sqrt(Pole);
var OBW = 2 * r;
Console.WriteLine("Obwód to "+OBW+"*PI ");
Console.WriteLine("wynik bez symbolu pi"+(OBW*PI));

