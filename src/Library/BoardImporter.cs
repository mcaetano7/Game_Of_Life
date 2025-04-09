using System.IO;

class BoardImporter
{
    public bool[,] Board { get; private set; }

    public BoardImporter()
    {
        {
            string url = "C:\\Users\\Estudiante UCU\\Repositorios\\Game_Of_Life\\src\\array.txt";
            string content = File.ReadAllText(url);
            string[] contentLines = content.Split('\n');


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


