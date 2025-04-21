using System.IO;
namespace Ucu.Poo.GameOfLife;

public class Leer
{
    public static string LeerTablero(string url)
    {
        string content = File.ReadAllText(url);
        return content;
    }

}
