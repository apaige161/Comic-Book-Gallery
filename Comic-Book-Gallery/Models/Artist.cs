using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Comic_Book_Gallery.Models
{
    public class Artist
    {
        //since the artist object contains a key value pair we set up artists in its own class
        public string Name { get; set; }
        public string Role { get; set; }

    }
}