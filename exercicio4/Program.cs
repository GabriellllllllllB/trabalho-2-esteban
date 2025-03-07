int[,] m = new int[5, 5];
int i;
int j;

Console.WriteLine("escreva os 25 numeros para fazer a matriz 5x5:");
for (i = 0; i < 5; i++)
{
    for (j = 0; j < 5; j++)
    {
        Console.Write($"matriz[{i},{j}]: ");
        m[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("valor da soma da diagonal");

for (i = 0; i < 5; i++)
{
    for (j = 0; j < 5; j++)
    {
        if (i == j || i + j == 4)
            Console.Write($"{m[i, j],3} ");
        else
            Console.Write(" ");
    }
    Console.WriteLine();
}