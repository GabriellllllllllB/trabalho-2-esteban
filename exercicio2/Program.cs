string[] n = new string[10];
double[] p = new double[10];
int i;

for (i = 0; i < 10; i++)
{
    Console.WriteLine($"escreva o nome do {i + 1}º produto:");
    n[i] = Console.ReadLine();

    Console.WriteLine($"escreva o preço do produto {n[i]}:");
    p[i] = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine("escreva um valor para pesquisar os produtos:");
double valorp = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"produto com preço até R${valorp:F2}:");
bool e = false;

for (i = 0; i < 10; i++)
{
    if (p[i] <= valorp)
    {
        Console.WriteLine($"- {n[i]}: R${p[i]:F2}");
        e = true;
    }
}

if (!e)
{
    Console.WriteLine("nenhum produto encontrado");
}