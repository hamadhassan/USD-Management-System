﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityStudentDiaryManagementSystem.BL
{
    public class Book
    {
        private string typeBook;
        private string title;
        private string authorName;
        private string bookFrom;
        private string remarks;

        public Book (string typeBook,string title,string authorName,string bookFrom,string remarks)
        {
            this.typeBook = typeBook;
            this.title = title;
            this.authorName = authorName;
            this.bookFrom = bookFrom;
            this.remarks = remarks;
        }
        public string TypeBook { get => typeBook; set => typeBook = value; }
        public string Title { get => title; set => title = value; }
        public string AuthorName { get => authorName; set => authorName = value; }
        public string BookFrom { get => bookFrom; set => bookFrom = value; }
        public string Remarks { get => remarks; set => remarks = value; }
    }
}
