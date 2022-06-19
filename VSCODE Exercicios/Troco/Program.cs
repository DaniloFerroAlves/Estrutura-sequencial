using System.Globalization;

CultureInfo CI = CultureInfo.InvariantCulture;

double preco, dinheiro;
int qntd;

Console.WriteLine("Preço unitário do produto: ");
preco = double.Parse(Console.ReadLine(), CI);
Console.WriteLine("Quantidade disponível: ");
qntd = int.Parse(Console.ReadLine(), CI);
Console.WriteLine("Dinheiro recebido: ");
dinheiro = double.Parse(Console.ReadLine(), CI);

double precototal = preco * qntd;
double troco = dinheiro - precototal;

if(dinheiro < precototal)
{
    Console.WriteLine("Você não tem dinheiro suficiente");
}
else if(dinheiro > precototal)
{
    Console.WriteLine("Troco:"+ troco.ToString("F2", CI));
}
else
{
    Console.WriteLine("Não tem troco");
}


