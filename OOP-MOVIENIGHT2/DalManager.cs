using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace OOP_MOVIENIGHT2
{
    class DalManager
    {
        #region INSERTDATA
        //Creates connection string
        private static string connstring = @"Server=DESKTOP-L52FU9Q\MSSQLSERV2;Initial Catalog=MCU; Integrated Security=SSPI";

        public static Actor InsertActor(Actor actor)
        {
            string InsertActor = "INSERT INTO Actor(FirstName, LastName) VALUES (@fname, @lname)";
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(InsertActor, connection);
                //Inserting data to table
                cmd.Parameters.Add(new SqlParameter("@fname", actor.FirstName));
                cmd.Parameters.Add(new SqlParameter("@lname", actor.LastName));

                cmd.ExecuteNonQuery();
            }
            return actor;
        }

        public static Movie InsertMovie(Movie movie)
        {
            string Insertmovie = "INSERT INTO Movie(Title, Year, Genre, Description) VALUES (@Title, @Year, @Genre, @Description)";
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Insertmovie, connection);
                //Adding data to movie table
                cmd.Parameters.Add(new SqlParameter("@Title", movie.Title));
                cmd.Parameters.Add(new SqlParameter("@Year", movie.Year));
                cmd.Parameters.Add(new SqlParameter("@Genre", movie.Genre));
                cmd.Parameters.Add(new SqlParameter("@Description", movie.Description));
                cmd.ExecuteNonQuery();
            }
            return movie;
        }
        public static Movie InsertGenre(Movie movie)
        {
            string Insertgenre = "INSERT INTO Movie(Genre) VALUES (@Genre)";
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Insertgenre, connection);
                //Adding genre to movie table
                cmd.Parameters.Add(new SqlParameter("@Genre", movie.Genre));
                cmd.ExecuteNonQuery();
            }
            return movie;
        }
        public static Contributing InsertContributing(Contributing contributing)
        {
            string insertData = "INSERT INTO Contributing(FID,SID) VALUES(@FID, @SID)";
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(insertData, connection);
                //Adds data
                cmd.Parameters.Add(new SqlParameter("@FID", contributing.Fid));
                cmd.Parameters.Add(new SqlParameter("@SID", contributing.Sid));
                cmd.ExecuteNonQuery();

            }
            return contributing;
        }
        #endregion

        #region UpdateMethods
        public static Actor UpdateActor(Actor actor)
        {
            string updateActor = "UPDATE Actor SET FirstName = @FirstName, LastName = @LastName WHERE SID = @SID";

            using (SqlConnection connection = new SqlConnection(connstring))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(updateActor, connection);
                //Update data in table with parameters
                cmd.Parameters.AddWithValue("@SID", actor.Sid);
                cmd.Parameters.AddWithValue("@FirstName", actor.FirstName);
                cmd.Parameters.AddWithValue("@LastName", actor.LastName);
                cmd.ExecuteNonQuery();
            }
            return actor;
        }
        public static Movie UpdateMovie(Movie movie)
        {
            string updateMovie = "UPDATE Movie SET Title = @Title, Year = @Year, Genre = @Genre, Description = @Description WHERE FID = @FID";
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(updateMovie, connection);
                //Update data in table with parameters
                cmd.Parameters.AddWithValue("@FID", movie.Id);
                cmd.Parameters.AddWithValue("@Title", movie.Title);
                cmd.Parameters.AddWithValue("@Year", movie.Year);
                cmd.Parameters.AddWithValue("@Genre", movie.Genre);
                cmd.Parameters.AddWithValue("@Description", movie.Description);
                cmd.ExecuteNonQuery();
            }
            return movie;
        }
        public static Contributing UpdateContributing(Contributing contributing)
        {
            string updateContributing = "UPDATE Contributing SET FID = @FID WHERE SID = @SID";
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(updateContributing, connection);
                cmd.Parameters.AddWithValue("@FID", contributing.Fid);
                cmd.Parameters.AddWithValue("@SID", contributing.Sid);
                cmd.ExecuteNonQuery();
            }
            return contributing;

        }

        #endregion

        #region GetMethods
        public static List<Movie> GetMovies()
        {
            List<Movie> moviesList = new List<Movie>();
            //Select data from the database
            string DataFromMovies = "SELECT * FROM Movie";
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                //Opens the connection to database
                connection.Open();

                //Request and gets data from database
                SqlCommand cmd = new SqlCommand(DataFromMovies, connection);

                SqlDataReader rdr = cmd.ExecuteReader();
                //Loop through all data
                while (rdr.Read())
                {
                    int id = (int)rdr["FID"];
                    string title = (string)rdr["Title"];
                    string genre = (string)rdr["Genre"];
                    int year = (int)rdr["Year"];
                    string description = (string)rdr["Description"];
                    //Creates movie object, and adds to list
                    Movie m = new Movie(id, title, year, genre, description);
                    moviesList.Add(m);
                }

            }
            return moviesList;
        }
        public static List<Actor> GetActors()
        {
            List<Actor> actorList = new List<Actor>();
            //Select statement
            string getActor = "Select * FROM actor";
            //Connects to database
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                //Open the connection
                connection.Open();
                //Request and gets data from database
                SqlCommand cmd = new SqlCommand(getActor, connection);
                SqlDataReader rdr = cmd.ExecuteReader();
                //Loop through data
                while (rdr.Read())
                {
                    int id = (int)rdr["SID"];
                    string firstName = (string)rdr["FirstName"];
                    string lastName = (string)rdr["LastName"];
                    int year = (int)rdr["Year"];
                    string desc = (string)rdr["Description"];

                    Actor actor = new Actor(id, firstName, lastName);
                    actorList.Add(actor);
                }
            }
            return actorList;
        }
        public static List<Movie> GetMovieTitle(string search)
        {

            List<Movie> movieTitleList = new List<Movie>();
            //Select data from the database
            string DataFromMovies = "SELECT * FROM Movie WHERE Title LIKE @search";
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                //Opens the connection to database
                connection.Open();

                //Request and gets data from database
                SqlCommand cmd = new SqlCommand(DataFromMovies, connection);
                SqlParameter sp = new SqlParameter();
                cmd.Parameters.AddWithValue("@search", search);
                SqlDataReader rdr = cmd.ExecuteReader();
                //Loop through all data
                while (rdr.Read())
                {
                    int id = (int)rdr["FID"];
                    string title = (string)rdr["Title"];
                    string genre = (string)rdr["Genre"];
                    int year = (int)rdr["Year"];
                    string description = (string)rdr["Description"];
                    //Creates movie object, and adds to list
                    Movie movietitle = new Movie(id, title, year, genre, description);
                    movieTitleList.Add(movietitle);
                }

            }
            return movieTitleList;
        }
        public static List<Actor> GetActorSearch(string search)
        {
            List<Actor> actorList = new List<Actor>();
            //Select statement
            string getActor = "Select * FROM actor WHERE LastName LIKE @search";
            //Connects to database
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                //Open the connection
                connection.Open();
                //Request and gets data from database
                SqlCommand cmd = new SqlCommand(getActor, connection);
                SqlParameter sp = new SqlParameter();
                cmd.Parameters.AddWithValue("@search", search);
                SqlDataReader rdr = cmd.ExecuteReader();
                //Loop through data
                while (rdr.Read())
                {
                    int id = (int)rdr["SID"];
                    string firstName = (string)rdr["FirstName"];
                    string lastName = (string)rdr["LastName"];
                    int year = (int)rdr["Year"];
                    string desc = (string)rdr["Description"];

                    Actor actor = new Actor(id, firstName, lastName);
                    actorList.Add(actor);
                }
            }
            return actorList;
        }
        public static List<Movie> GetMovieGenreSearch(string search)
        {
            List<Movie> movieGenreList = new List<Movie>();
            //Select data from the database
            string DataFromMovies = "SELECT * FROM Movie WHERE Genre Like @search";
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                //Opens the connection to database
                connection.Open();

                //Request and gets data from database
                SqlCommand cmd = new SqlCommand(DataFromMovies, connection);
                SqlParameter sp = new SqlParameter();
                cmd.Parameters.AddWithValue("@search", search);
                SqlDataReader rdr = cmd.ExecuteReader();
                //Loop through all data
                while (rdr.Read())
                {
                    int id = (int)rdr["FID"];
                    string title = (string)rdr["Title"];
                    string genre = (string)rdr["Genre"];
                    int year = (int)rdr["Year"];
                    string description = (string)rdr["Description"];
                    //Creates movie object, and adds to list
                    Movie moviegenre = new Movie(id, title, year, genre, description);
                    movieGenreList.Add(moviegenre);
                }

            }
            return movieGenreList;
        }
        #endregion

        #region DeleteMethods
        public static Movie DeleteMovie(Movie Movie)
        {
            //Deleting contributing first because movie table have relation with contributing
            string DeleteContributing = "DELETE FROM Contributing WHERE FID = @FID";

            string DeleteMovie = "DELETE FROM Movie WHERE FID = @FID";
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(DeleteContributing, connection);
                SqlCommand cmdMovie = new SqlCommand(DeleteMovie, connection);

                //First deleting contributing so i can delete movie
                cmd.Parameters.Add(new SqlParameter("@FID", Movie.Id));
                cmd.ExecuteNonQuery();
                //Now deleting movie
                cmdMovie.Parameters.Add(new SqlParameter("@FID", Movie.Id));
                cmdMovie.ExecuteNonQuery();
            }
            return Movie;
        }
        public static Actor DeleteActor(Actor actor)
        {
            //Deleting contributing first because actor table have relation with contributing
            string DeleteContributing = "DELETE FROM Contributing WHERE SID = @SID";

            string DeleteActor = "DELETE FROM Actor WHERE SID = @SID";
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(DeleteContributing, connection);
                SqlCommand cmdActor = new SqlCommand(DeleteActor, connection);

                //First deleting contributing so i can delete movie
                cmd.Parameters.Add(new SqlParameter("@SID", actor.Sid));
                cmd.ExecuteNonQuery();
                //Now deleting Actor
                cmdActor.Parameters.Add(new SqlParameter("@SID", actor.Sid));
                cmdActor.ExecuteNonQuery();
            }
            return actor;
            #endregion
        }
    }
}
