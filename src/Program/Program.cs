/*Clases y responsabilidades:
Distribuimos las responsabilidades en 4 boardImporter, Board, Lógica e boardPrinter.

La clase boardImporter tiene la responsabilidad de leer el archivo que contiene los valores iniciales de las células.
Esta clase cumple con el principio SRP al tener una sola razón de cambio. Si tuviera distintos tipos de archivos
para leer podríamos editar esa clase y no afectaría a las demás (o crear nuevas). También cumple con Expert porque conoce
el url del archivo a leer por lo que es la clase óptima para cumplir esta responsabilidad. No colabora con ninguna clase.

La clase board tiene la responsabilidad de crear el tablero a partir del archivo que retornó la clase boardImporter, por lo que
colabora con ella. Tiene una sola razón de cambio por lo que cumple con SRP. También con Expert porque tiene la información
necesaria que le permite cumplir con su responsabilidad (conocer el archivo que debe transformar).

La clase Lógica se encarga únicamente de calcular las nuevas generaciones (una única responsabilidad y razón de cambio).
Colabora con la clase Matriz y tiene la información necesaria para cumplir su responsabilidad (conoce el tablero que
se creó en la clase Matriz).

Por último, la clase boardPrinter se encarga de mostrar el tablero en consola. Hacer esta clase nos permite que si
tuviéramos que implementar nuevas formas de impresión podemos cambiar la clase con nuevos métodos o
inventar nuevas clases (si es necesario por SRP) sin afectar el resto del funcionamiento de las clases restantes.
Cumple con Expert porque es la clase ideal para realizar esta responsabilidad, ya que conoce cada tablero de cada
generación que va calculando la clase Lógica (colabora con ella).
 */

using System;

namespace Ucu.Poo.GameOfLife
{
  class Program 
   /*La clase Program ejecuta todas las responsabilidades de las clases en una sola.
    Primero lee el archivo (en clase boardImporter), luego crea el tablero (en clase board), ejecuta el juego (en clase lógica)
    y finalmente imprime el tablero para que se pueda visualizar (en clase Imprimir). Estas últimas dos responsabilidades
    en un bucle while para que se puedan ir calculando las nuevas generaciones y mostrarlas en consola.*/
  
  {
   static void Main(string[] args)
   {
    Console.WriteLine("Game of Life");
    
    BoardImporter importer = new BoardImporter();
    bool[,] tableroTrueFalse = importer.Board;
    
    while (true)
    {
     tableroTrueFalse = Logica.Jugar(tableroTrueFalse); //Calcula la nueva generación 
     BoardPrinter.ImprimirBoard(tableroTrueFalse); //Imprime el tablero para que se puedan visualizar los ciclos de vida
    }


   }
  }
 }
