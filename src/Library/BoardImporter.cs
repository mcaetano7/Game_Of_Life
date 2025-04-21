using System.IO;
/// <summary>
/// imprime un tablero desde un txt. el tablero esta formado por
/// una matriz de booleanos
/// </summary>
public class BoardImporter
{
    public bool[,] Board { get; private set; }
    // guarda el tablero como una matriz 2d de booleanos
    // get allows to read desde fuera de la case
    // set restringe la modificacion a los metodos de la clase

    public BoardImporter()
    {
        {
            // metodo para obtener el valor de una celula que devuelva true or false
            // metodo para setear el valor: coordenadas, true
            string url = "array.txt";
            string content = File.ReadAllText(url);
            string[] contentLines = content.Split('\n');
            //


            Board = new bool[contentLines.Length, contentLines[0].Length];

            for (int y = 0; y < contentLines.Length; y++)
            {
                for (int x = 0; x < contentLines[y].Length; x++)
                {
                    if (contentLines[y][x] == '1')
                    {
                        Board[y, x] = true;
                    }
                }
            }
        }
    }


}


