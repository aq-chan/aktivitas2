﻿using System;
using System.Collections.Generic;
using System.Text;

namespace aktivitas2
//aktivitas2 - namespace di modul : Pustakamedia
{
    class Book
    {
        private string title;
        private string author;

        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        public string getTitle()
        {
            return this.title;
        }

        public string getAuthor()
        {
            return this.author;
        }
    }
}
