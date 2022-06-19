Console.WriteLine("Distancia percorrida (em km): ");
double distancia = double.Parse(Console.ReadLine());
Console.WriteLine("Combustivel gasto: ");
double combustivel = double.Parse(Console.ReadLine());
double media = distancia/combustivel;

Console.WriteLine("Consumo médio: "+ media.ToString("F3"));
