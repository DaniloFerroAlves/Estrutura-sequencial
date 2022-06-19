using System.Globalization;

CultureInfo CI = CultureInfo.InvariantCulture;


Console.WriteLine("Informe a base do retangulo: ");
double base_ = double.Parse(Console.ReadLine(), CI);
Console.WriteLine("Informe a altura: ");
double alt = double.Parse(Console.ReadLine(), CI);
//CALCULOS
double diag = Math.Sqrt(base_ * base_ + alt * alt); 
double per = (base_ + alt) * 2;
double area = base_ * alt;

Console.WriteLine("Area do retangulo: "+ area.ToString("F4", CI));
Console.WriteLine("Perimetro: "+ per.ToString("F4", CI));
Console.WriteLine("Diagonal: "+ diag.ToString("F4", CI));