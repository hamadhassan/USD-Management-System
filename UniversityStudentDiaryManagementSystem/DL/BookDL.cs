using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityStudentDiaryManagementSystem.BL;

namespace UniversityStudentDiaryManagementSystem.DL
{
    internal class BookDL
    {
        private static List<Book> bookList = new List<Book>();
        public static bool setIntoBookList(Book book)
        {
            bookList.Add(book);
            return true;
        }
        public static List<Book> getBooklist()
        {
            return bookList;
        }
    }
}
