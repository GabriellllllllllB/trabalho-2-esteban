char[,] tabuleiro = new char[3, 3];
for (int i = 0; i < 3; i++)
    for (int j = 0; j < 3; j++)
        tabuleiro[i, j] = ' ';

int contador = 0;
bool fimJogo = false;

while (!fimJogo && contador < 9)
{
    Console.Clear();
    Console.WriteLine("Jogo da Velha");
    ExibirTabuleiro(tabuleiro);

    char jogador = contador % 2 == 0 ? 'X' : 'O';
    Console.WriteLine($"\nVez do jogador {(jogador == 'X' ? "1" : "2")} ({jogador}).");

    int linha, coluna;
    bool jogadaValida = false;

    do
    {
        Console.Write("Digite a linha (0, 1 ou 2): ");
        linha = int.Parse(Console.ReadLine());
        Console.Write("Digite a coluna (0, 1 ou 2): ");
        coluna = int.Parse(Console.ReadLine());

        if (linha >= 0 && linha < 3 && coluna >= 0 && coluna < 3)
        {
            if (tabuleiro[linha, coluna] == ' ')
            {
                tabuleiro[linha, coluna] = jogador;
                jogadaValida = true;
            }
            else
            {
                Console.WriteLine("Posição já ocupada! Tente novamente.");
            }
        }
        else
        {
            Console.WriteLine("Posição inválida! Tente novamente.");
        }
    } while (!jogadaValida);

    if (VerificarVencedor(tabuleiro, jogador))
    {
        Console.Clear();
        ExibirTabuleiro(tabuleiro);
        Console.WriteLine($"\nParabéns! Jogador {(jogador == 'X' ? "1" : "2")} ({jogador}) venceu!");
        fimJogo = true;
    }
    else
    {
        contador++;
    }
}

if (!fimJogo)
{
    Console.Clear();
    ExibirTabuleiro(tabuleiro);
    Console.WriteLine("\nO jogo empatou!");
}

Console.WriteLine("Pressione qualquer tecla para sair.");
Console.ReadKey();
}

static void ExibirTabuleiro(char[,] tabuleiro)
{
    Console.WriteLine(" 0 1 2");
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine(" -------------");
        Console.Write($"{i} |");
        for (int j = 0; j < 3; j++)
        {
            Console.Write($" {tabuleiro[i, j]} |");
        }
        Console.WriteLine();
    }
    Console.WriteLine(" -------------");
}

static bool VerificarVencedor(char[,] tabuleiro, char jogador)
{
    for (int i = 0; i < 3; i++)
    {
        if ((tabuleiro[i, 0] == jogador && tabuleiro[i, 1] == jogador && tabuleiro[i, 2] == jogador) ||
        (tabuleiro[0, i] == jogador && tabuleiro[1, i] == jogador && tabuleiro[2, i] == jogador))
        {
            return true;
        }
    }

    if ((tabuleiro[0, 0] == jogador && tabuleiro[1, 1] == jogador && tabuleiro[2, 2] == jogador) ||
    (tabuleiro[0, 2] == jogador && tabuleiro[1, 1] == jogador && tabuleiro[2, 0] == jogador))
    {
        return true;
    }

    return false;
}