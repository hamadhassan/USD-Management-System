using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityStudentDiaryManagementSystem.BL;
using System.IO;

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
        public static void clearList()
        {
            bookList.Clear();
        }
        public static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        public static bool loadRecordFromFile(string path)
        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string typeBook=parseData(record,1);
                    string title= parseData(record, 2);
                    string authorName = parseData(record, 3);
                    string bookFrom = parseData(record, 4);
                    string remarks = parseData(record, 5);
                    Book book=new Book(typeBook,title,authorName,bookFrom,remarks);
                    bookList.Add(book);
                }
                fileVariable.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void storeRecordIntoFile(Book record, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(record.TypeBook + "," + record.Title + "," + record.AuthorName + "," + record.BookFrom + "," + record.Remarks);
            file.Flush();
            file.Close();

        }
        public static void storeAllRecordIntoFile(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (Book record in bookList)
            {
                file.WriteLine(record.TypeBook + "," + record.Title + "," + record.AuthorName + "," + record.BookFrom + "," + record.Remarks);
            }
            file.Flush();
            file.Close();
        }
    }
}
