using System;

namespace Lab3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter number of movies: ");
            int count = int.Parse(Console.ReadLine()!);

            Movie[] movies = new Movie[count];

            Console.WriteLine("Genres: 1-Action, 2-Comedy, 3-Drama, 4-Horror, 5-SciFi");
            Console.WriteLine("Format: Id, Name, Year, Genre(1-5), Views, Likes");

            for (int i = 0; i < count; i++)
            {
                Console.Write($"Movie {i + 1}: ");
                movies[i] = new Movie();
                movies[i].Parse(Console.ReadLine()!);
            }

            Console.WriteLine();
            Console.WriteLine($"{"Id",4} {"Name",-15} {"Year",-8} {"Genre",-12} {"Rating",8}");
            Console.WriteLine(new string('-', 51));
            for (int i = 0; i < count; i++)
                Console.WriteLine(movies[i]); // կանչվում է override արված ToString()-ը
        }
    }
}
