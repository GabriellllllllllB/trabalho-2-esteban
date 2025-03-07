int linhas;
int opcao;
int col;
int i;
int j;
int s = 0;

Console.WriteLine("tamanho da matriz:");
Console.WriteLine("1 - matriz 3x5");
Console.WriteLine("2 - matriz 5x3");
Console.Write("opcao: ");

opcao = int.Parse(Console.ReadLine());

if (opcao == 1)
{
    linhas = 3;
    col = 5;
}
else
{
    linhas = 5;
    col = 3;
}

int[,] matriz = new int[linhas, col];

Console.WriteLine($"escreva os {linhas * col} numeros da matriz {linhas}x{col}:");
for (i = 0; i < linhas; i++)
{
    for (j = 0; j < col; j++)
    {
        Console.Write($"matriz[{i},{j}]: ");
        matriz[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("soma da linha:");
for (i = 0; i < linhas; i++)
{
    for (j = 0; j < col; j++)
    {
        s += matriz[i, j];
    }
    Console.WriteLine($"linha {i}: {s}");
}