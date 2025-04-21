namespace Ucu.Poo.GameOfLife;

public static class Logica
{
    public static Board Jugar(Board tableroBool)
    {
        Board gameBoard = tableroBool;
        int boardWidth = gameBoard.Height;
        int boardHeight = gameBoard.Width;

        Board cloneboard = new Board(boardWidth, boardHeight);
        for (int x = 0; x < boardWidth; x++)
        {
            for (int y = 0; y < boardHeight; y++)
            {
                int aliveNeighbors = 0;
                for (int i = x-1; i<=x+1;i++)
                {
                    for (int j = y-1;j<=y+1;j++)
                    {
                        if(i>=0 && i<boardWidth && j>=0 && j < boardHeight && gameBoard.IsCellAlive(i,j))
                        {
                            aliveNeighbors++;
                        }
                    }
                }
                if(gameBoard.IsCellAlive(x,y))
                {
                    aliveNeighbors--;
                }
                if (gameBoard.IsCellAlive(x,y) && aliveNeighbors < 2)
                {
                    //Celula muere por baja población
                    cloneboard.SetCells(x,y,false);
                }
                else if (gameBoard.IsCellAlive(x,y) && aliveNeighbors > 3)
                {
                    //Celula muere por sobrepoblación
                    cloneboard.SetCells(x, y, false);
                }
                else if (!gameBoard.IsCellAlive(x,y) && aliveNeighbors == 3)
                {
                    //Celula nace por reproducción
                    cloneboard.SetCells(x, y, true);
                }
                else
                {
                    //Celula mantiene el estado que tenía
                    cloneboard.SetCells(x,y,gameBoard.IsCellAlive(x,y));
                }
            }
        }
        gameBoard = cloneboard;
        return gameBoard;
    }
}