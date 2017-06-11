﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class ComicBook
    {
        public int id { get; set; }
        public String SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public String DescriptionHtml { get; set; }
        public Artist[] Artists { get; set; }
        public bool Favorite { get; set; }
           
        public string DisplayText
        {
            get
            {
                return SeriesTitle + " #" + IssueNumber;
            }
        }

        public string CoverImageFileName
        {
            get
            {
                return SeriesTitle.Replace(" ", "-").ToLower()+
                    "-" + IssueNumber + ".jpg";
            }
        }
    }
}