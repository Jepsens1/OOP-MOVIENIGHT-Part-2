using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_MOVIENIGHT2
{
    class Movie
    {
        #region Properties


        //POPO Properties
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        private string genre;

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        #endregion

        #region
        public Movie()
        {

        }
        public Movie(string _title, int _year, string _genre, string _desc)
        {
            this.Title = _title;
            this.Year = _year;
            this.Description = _desc;
            this.Genre = _genre;
        }
        public Movie(int _id, string _title, int _year, string _desc, string _genre) : this(_title, _year, _desc, _genre)
        {
            this.id = _id;
        }
        public Movie(int _id)
        {
            this.Id = _id;
        }
        #endregion
    }
}
