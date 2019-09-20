﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ComicBookGalleryModel.Models;

namespace ComicBookGalleryModel
{
    internal class DatabaseInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            var series1 = new Series()
            {
                Title = "The Amazing Spiderman"
            };
            var series2 = new Series()
            {
                Title = "The Invincible Ironman"
            };

            var artist1 = new Artist()
            {
                Name = "Stan Lee"
            };
            var artist2 = new Artist()
            {
                Name = "Steve Ditko"
            };
            var artist3 = new Artist()
            {
                Name = "Jack Kirby"
            };

            var role1 = new Role()
            {
                Name = "Script"
            };
            var role2 = new Role()
            {
                Name = "Pencils"
            };

            var comicBook1 = new ComicBook()
            {
                Series = series1,
                IssueNumber = 1,
                PublishedOn = DateTime.Today
            };
            comicBook1.AddArtist(artist1, role1);
            comicBook1.AddArtist(artist2, role2);

            var comicBook2 = new ComicBook()
            {
                Series = series1,
                IssueNumber = 2,
                PublishedOn = DateTime.Today
            };
            comicBook2.AddArtist(artist1, role1);
            comicBook2.AddArtist(artist2, role2);

            var comicBook3 = new ComicBook()
            {
                Series = series2,
                IssueNumber = 1,
                PublishedOn = DateTime.Today
            };
            comicBook3.AddArtist(artist1, role1);
            comicBook3.AddArtist(artist3, role2);

            context.ComicBooks.Add(comicBook1);
            context.ComicBooks.Add(comicBook2);
            context.ComicBooks.Add(comicBook3);
            context.SaveChanges();
        }
    }
}
