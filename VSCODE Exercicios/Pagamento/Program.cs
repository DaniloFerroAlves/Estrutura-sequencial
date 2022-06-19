//EXIBIR NOME, HORAS TRABALHADAS E GANHO POR HORA// FINAL EXIBIR SALÁRIO
Console.WriteLine("Nome: ");
string nome = Console.ReadLine();
Console.WriteLine("Ganho por hora: ");
double ganhohr = int.Parse(Console.ReadLine());
Console.WriteLine("Horas trabalhadas: ");
double horas = double.Parse(Console.ReadLine());
double salário = ganhohr * horas;

Console.WriteLine("O Salário de "+nome+ " é R$ "+salário.ToString("F2"));
