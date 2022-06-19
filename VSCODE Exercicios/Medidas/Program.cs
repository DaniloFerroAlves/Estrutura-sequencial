Console.WriteLine("Digite o valor de A: ");
double A = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de B: ");
double B = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de C: ");
double C = double.Parse(Console.ReadLine());
double quadrado = A * A;
double triangulo_ret = (A * B) / 2;
double trapezio = (A + B)* C / 2;

Console.WriteLine("Área do quadrado = "+ quadrado.ToString("F4"));
Console.WriteLine("Área do triangulo retangulo = "+ triangulo_ret.ToString("F4"));
Console.WriteLine("Área do quadrado = "+ trapezio.ToString("F4"));
