int[] vetor = new int[15];
int i;

Console.WriteLine("escreva 15 numeros inteiros:");
for (i = 0; i < 15; i++)
{
    Console.Write($"posição {i}: ");
    vetor[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("numeros armazenados em posiçoes pares:");
for (i = 0; i < 15; i += 2)
{
    Console.WriteLine($"Posição {i}: {vetor[i]}");
}
