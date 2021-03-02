using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_MOVIENIGHT2
{
    class Actor
    {
        #region Properties
        private int sid;

        public int Sid
        {
            get { return sid; }
            set { sid = value; }
        }
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        #endregion

        #region Constructor
        public Actor()
        {

        }
        public Actor(string _firstname, string _lastname)
        {
            this.FirstName = _firstname;
            this.LastName = _lastname;

        }
        public Actor(int _id, string _firstname, string _lastname) : this(_firstname, _lastname)
        {
            this.Sid = _id;
        }
        public Actor(int _id)
        {
            this.Sid = _id;
        }
        #endregion
    }
}
