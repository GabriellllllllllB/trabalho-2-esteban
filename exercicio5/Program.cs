const int nalunos = 10;
const int nnotas = 3;
int i;
int j;

string[] nomes = new string[nalunos];
double[,] notas = new double[nalunos, nnotas];
double[] medias = new double[nalunos];

for (i = 0; i < nalunos; i++)
{
    Console.Write($"escreva o nome dos alunos {i + 1}: ");
    nomes[i] = Console.ReadLine();

    double somanotas = 0;
    for (j = 0; j < nnotas; j++)
    {
        Console.Write($"escreva a nota {j + 1} do aluno {nomes[i]}: ");
        notas[i, j] = double.Parse(Console.ReadLine());
        somanotas += notas[i, j];
    }
    medias[i] = somanotas / nnotas;
}

Console.WriteLine("relatorio dos alunos:");
for (i = 0; i < nalunos; i++)
{
    if (medias[i] >= 7.0)
        Console.ForegroundColor = ConsoleColor.Blue;
    else
        Console.ForegroundColor = ConsoleColor.Red;

    Console.WriteLine("------------------------------------");
    Console.WriteLine($"aluno: {nomes[i]}");
    Console.Write("notas: ");
    for (j = 0; j < nnotas; j++)
    {
        Console.Write(notas[i, j].ToString("F2") + " ");
    }
    Console.WriteLine($"\média: {medias[i]:F2}");
    Console.WriteLine(medias[i] >= 7.0 ? "situação: aprovado" : "situação: reprovado");
    Console.WriteLine("------------------------------------");

    Console.ResetColor();
}