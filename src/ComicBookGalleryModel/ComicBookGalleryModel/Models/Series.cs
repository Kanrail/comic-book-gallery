﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicBookGalleryModel.Models;

namespace ComicBookGalleryModel.Models
{
    public class Series
    {
        public Series()
        {
            ComicBooks = new List<ComicBook>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public ICollection<ComicBook> ComicBooks { get; set; }
    }
}
