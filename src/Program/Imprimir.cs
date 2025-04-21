using System;
using System.Text;
using System.Threading;
namespace Ucu.Poo.GameOfLife;

public class Imprimir
{
    public static void imprimirTablero(bool[,] board)
    {
        int width = board.GetLength(0);
        int height = board.GetLength(1);
        Console.Clear();
        StringBuilder s = new StringBuilder();
        for (int y = 0; y<height;y++)
        {
            for (int x = 0; x<width; x++)
            {
                if(board[x,y])
                {
                    s.Append("|X|");
                }
                else
                {
                    s.Append("___");
                }
            }
            s.Append("\n");
        }

        Console.WriteLine(s.ToString());
        Thread.Sleep(300);
      
    }
}
