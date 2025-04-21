//clase board 
//- conocer el tamaño del tablero 
//- conocer donde estan las celulas
//- conocer el estado de una celula (viva o muerta)
//- crear el array de booleanos (encapsular el array)

public class Board
{
    private bool[,] cells; //matriz de booleanos (cada posición representa una célula)

    // constructor (recibe la matriz de celdas ya armada)
    public Board(bool[,] initialCells) 
    {
        cells = initialCells; //guardamos la matriz dentro de la variable para poder usarla
    }

    // devuelve el ancho del tablero (cantidad de filas)
    public int Height => cells.GetLength(0);

    // devuelve el alto del tablero (cantidad de columnas)
    public int Width => cells.GetLength(1);

    // informa si una celda está viva en la posición (x, y)
    public bool IsCellAlive(int x, int y)
    {
        return cells[x, y];  // devuelve lo que haya en la posición, si es true está viva, si es false está muerta
    }
    
    public bool[,] GetCells() //Esta función devuelve toda la matriz completa (cells)
    {
        return cells;
    }
}
 
 