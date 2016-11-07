using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_GenresLab_10
{
    public class Movie
    {
        private string FilmTitle;
        private string FilmCategory;

        #region Get/Set
        public string FilmTitle1
        {
            get
            {
                return FilmTitle;
            }

            set
            {
                FilmTitle = value;
            }
        }

        public string FilmCategory1
        {
            get
            {
                return FilmCategory;
            }

            set
            {
                FilmCategory = value;
            }
        }
        #endregion

        public Movie(string title, string category)
        {
            FilmTitle1 = title;
            FilmCategory1 = category;
        }

        public string MatchCategory(string sategory)
        {
            return FilmTitle1;
        }

        public string getTitle ()
        {

            return FilmTitle;
        }









    }
}
