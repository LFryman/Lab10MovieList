using System;
using System.Collections.Generic;
using System.Text;

namespace MovieList10
{
    class Movie
    {
        #region fields
        private string _title;
        private string _catagory;

        #endregion

        #region properties

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string Catagory
        {
            get { return _catagory; }
            set { _catagory = value; }
        }

        public Movie()
        {

        }

        #endregion

        #region Constructor 
        public Movie(string title, string category)
        {
            _title = title;
            _catagory = category;
        }
        #endregion 

        public void Print()
        {
            Console.WriteLine(_title);
        }
    }
}
