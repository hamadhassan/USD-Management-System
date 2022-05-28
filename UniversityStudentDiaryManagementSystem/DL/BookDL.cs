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
        public static void deleteFromBookList(Book book)
        {
            for (int index = 0; index < bookList.Count; index++)
            {
                if (bookList[index].TypeBook == book.TypeBook && bookList[index].Title == book.Title && bookList[index].AuthorName == book.AuthorName && bookList[index].BookFrom == book.BookFrom && bookList[index].Remarks == book.Remarks)
                {
                    bookList.RemoveAt(index);

                }
            }
        }
        public static bool EditFromBookList(Book previous, Book updated)
        {
            foreach (Book a in bookList)
            {
                if (a.TypeBook == previous.TypeBook && a.Title == previous.Title && a.AuthorName == previous.AuthorName && a.BookFrom == previous.BookFrom && a.Remarks == previous.Remarks)
                {
                    a.TypeBook = updated.TypeBook;
                    a.Title = updated.Title;
                    a.AuthorName = updated.AuthorName;
                    a.BookFrom = updated.BookFrom;
                    a.Remarks = updated.Remarks;
                    return true;
                }
            }
            return false;
        }
    }
}
