using System.Globalization;

CultureInfo CI = CultureInfo.InvariantCulture;

string nome, nome2;
int idade, idade_2;

Console.WriteLine("Dados da primeira pessoa");
Console.Write("Nome: ");
nome = Console.ReadLine();
Console.Write("Idade: ");
idade = int.Parse(Console.ReadLine());
//SEGUNDA PESSOA
Console.WriteLine("Dados da segunda pessoa");
Console.Write("Nome: ");
nome2 = Console.ReadLine();
Console.Write("Idade: ");
idade_2 = int.Parse(Console.ReadLine());
//CALCULO
double media = (double)(idade + idade_2)/2;
//
Console.WriteLine("A idade média de "+ nome+ " e "+ nome2+" é igual a "+ media.ToString("F2", CI));


