using System;

namespace OOP_MOVIENIGHT2
{
    class Program
    {
        static void Main(string[] args)
        {
            Contributing contributing = new Contributing(5, 5);

            Contributing updateContributing = new Contributing(19, 6);
            Actor actor = new Actor("Phillip", "Jepsen");

            Actor updateActor = new Actor(2, "Kim", "Larsen");

            Actor deleteActor = new Actor(13);

            Movie movie = new Movie("The Internship", 2013, "Comedy", "Sjov film");
            Movie UpdateMovie = new Movie(1, "Iron man", 2002, "SciFi", "Avengers");

            Movie deleteMovie = new Movie(10);



            //Console.WriteLine("Insert new actor to database");
            //MovieManager.InsertActor(actor);
            //Console.WriteLine($"{actor.FirstName} {actor.LastName}");

            //Console.WriteLine("\nInsert new movie to database");
            //MovieManager.InsertMovie(movie);
            //Console.WriteLine($"{movie.Title} {movie.Year} {movie.Showtime} {movie.Genre}");

            //Console.WriteLine("Insert IDs to contributing table");
            //MovieManager.InsertContributing(contributing);
            //Console.WriteLine($"FID: {contributing.FID}\nSID: {contributing.SID}");

            //Console.WriteLine("\nDelete Actor in database");
            //MovieManager.DeleteActor(deleteActor);
            //Console.WriteLine($"SID: {deleteActor.Id}");


            //Console.WriteLine("\nDelete movie in database");
            //MovieManager.DeleteMovie(deleteMovie);
            //Console.WriteLine($"FID: {deleteMovie.Id}");



            //Console.WriteLine("\nUpdate Actor in database");
            //MovieManager.UpdateActor(updateActor);
            //Console.WriteLine($"{updateActor.FirstName} {updateActor.LastName}");

            //Console.WriteLine("\nUpdate movie in database");
            //MovieManager.UpdateMovie(UpdateMovie);
            //Console.WriteLine($"{UpdateMovie.Title} {UpdateMovie.Year} {UpdateMovie.Showtime} {UpdateMovie.Genre}");

            //Console.WriteLine("\nUpdate contributing in table");
            //MovieManager.UpdateContributing(updateContributing);
            //Console.WriteLine($"Updates FID: {updateContributing.FID}\nWHERE SID: {updateContributing.SID}");
        }
    }
}
