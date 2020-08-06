using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Comic_Book_Gallery.Models
{
    public class ComicBook
    {
        //set property values
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; }

        //set as an array of artist pbject that has it own attributes
        public Artist[] Artists { get; set; }
        public bool Favorite { get; set; }

        public string DisplayText
        {
            //readonly
            get
            {
                return SeriesTitle + "#" + IssueNumber;
            }
        }

        //attach a comic cover with comic book
        public string CoverImageFileNme
        {
            get 
            {
                //replace any spaces with -
                return SeriesTitle.Replace(" ", "-").ToLower() + "-" + IssueNumber
                    + ".jpg";
            }
        }

    }
}