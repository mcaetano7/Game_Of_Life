using System;

//Clase para imprimir tablero
public static class BoardPrinter
{
    //Método que recibe al tablero y lo imprime
    public static void ImprimirBoard(bool[,] board)
    {
        string resultado = "";

        int width = board.GetLength(0);
        int height = board.GetLength(1);

        //Recorro cada fila del tablero
        for (int y = 0; y < height; y++)
        {
            //Recorro cada columna de la fila
            for (int x = 0; x < width; x++)
            {
                if (board[x, y])
                {
                    //Si está viva
                    resultado += "|X|";
                }
                else
                {
                    //Si está muerta
                    resultado += "___";
                }
            }

            //Cuando termino la fila paso a la siguiente con un enter
            resultado += "\n";
        }

        //Imprime todoo junto
        Console.WriteLine(resultado);
    }
}