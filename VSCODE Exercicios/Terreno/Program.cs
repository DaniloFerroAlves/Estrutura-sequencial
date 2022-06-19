using System.Globalization;

CultureInfo CI = CultureInfo.InvariantCulture;


Console.WriteLine("Digite a largura do terreno: ");
double largura = double.Parse(Console.ReadLine(), CI);
Console.WriteLine("Digite o comprimento do terreno: ");
double comprimento = double.Parse(Console.ReadLine(), CI);
Console.WriteLine("Digite o valor por metro quadrado: ");
double valorm = double.Parse(Console.ReadLine(), CI);
//CALCULO
double area = comprimento * largura;
double preço = valorm * comprimento * largura;
//
Console.WriteLine("Área do terreno: "+ area.ToString("F2", CI));
Console.Write("Preço do terreno: "+ preço.ToString("F2", CI));