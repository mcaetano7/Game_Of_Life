using System;

//Clase para imprimir tablero
public class BoardPrinter
{
    //Método que recibe al tablero y lo imprime
    public void ImprimirBoard(Board board)
    {
        string resultado = "";

        //Recorro cada fila del tablero
        for (int y = 0; y < board.Height; y++)
        {
            //Recorro cada columna de la fila
            for (int x = 0; x < board.Width; x++)
            {
                if (board.IsCellAlive(x, y))
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