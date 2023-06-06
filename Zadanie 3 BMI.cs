// See https://aka.ms/new-console-template for more information
Console.WriteLine("Podaj wage i wzrost");
float waga=float.Parse(Console.ReadLine());
float wzrost=float.Parse(Console.ReadLine());
float BMI = waga/(wzrost * wzrost);
Console.WriteLine("Wynik to: "+BMI);