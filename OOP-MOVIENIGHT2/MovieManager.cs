using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_MOVIENIGHT2
{
    class MovieManager
    {

        #region Insert data
        public static Actor InsertActor(Actor actor)
        {
            return DalManager.InsertActor(actor);
        }
        public static Movie InsertMovie(Movie movie)
        {
            return DalManager.InsertMovie(movie);
        }
        public static Movie InsertGenre(Movie movie)
        {
            return DalManager.InsertGenre(movie);
        }
        public static Contributing InsertData(Contributing contributing)
        {
            return DalManager.InsertContributing(contributing);
        }
        #endregion

        #region GetMethod
        public static List<Movie> GetMovies()
        {
            return DalManager.GetMovies();
        }
        public static List<Actor> GetActors()
        {
            return DalManager.GetActors();
        }
        public static List<Movie> GetMovieTitle(string search)
        {
            return DalManager.GetMovieTitle(search);
        }
        public static List<Actor> GetActorSearch(string search)
        {
            return DalManager.GetActorSearch(search);
        }
        public static List<Movie> GetMoviesGenre(string search)
        {
            return DalManager.GetMovieGenreSearch(search);
        }
        #endregion

        #region UpdateMethod
        public static Actor UpdateActor(Actor actor)
        {
            return DalManager.UpdateActor(actor);
        }
        public static Movie UpdateMovie(Movie movie)
        {
            return DalManager.UpdateMovie(movie);
        }
        public static Contributing UpdataContributing(Contributing contributing)
        {
            return DalManager.UpdateContributing(contributing);
        }

        #endregion
        #region DeleteMethod
        public static Movie DeleteMovie(Movie movie)
        {
            return DalManager.DeleteMovie(movie);
        }
        public static Actor DeleteActor(Actor actor)
        {
            return DalManager.DeleteActor(actor);
        }
        #endregion
    }
}
