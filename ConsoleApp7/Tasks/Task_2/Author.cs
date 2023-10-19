using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using static System.Reflection.Metadata.BlobBuilder;

namespace LearningTool.Tasks.Task_2
{
    internal class Author
    {
        //public Author() { }
        public Author(string name, string surname, string dateBirth)
        {
            _name = name;
            _surname = surname;
            _dateBirth = dateBirth;
        }
        public Author(string name, string surname, string dateBirth, string dateDeath) 
        {
            _name = name;
            _surname = surname;
            _dateBirth = dateBirth;
            _dateDeath = dateDeath;
        }

        private string _name;
        private string _surname;
        private string _dateBirth;
        private string _dateDeath = "Н/Д";
        
        List<Book> _books = new List<Book>();

        public void AddBook(Book newBook) 
        {
            _books.Add(newBook);
        }

        public void AddBook(List<Book> listBooks)
        {
            _books.AddRange(listBooks);
        }
        public void AddBook(Book[] Books)
        {
            List<Book> listBooks = Books.ToList();
            _books.AddRange(listBooks);
        }

        public override string ToString()
        {
            string listBooks = "";// string.Empty;
            bool isEmptyBooks = _books.Count == 0;

            string message =
                $"Автор: {_name} {_surname}"
                + $"\nДата рождения: {_dateBirth}"
                ;

            if (!isEmptyBooks)
            {
                foreach (Book book in _books)
                {
                    listBooks += book != _books.Last() ? book.GetTitle() : book.GetTitle() + ", ";

                }
                message += $"Книги: " + listBooks;
            }
            
            return message;
        }

        public string GetName() { return _name + " " + _surname; }

        public bool IsItDateInFormat(string dateString) 
        {

            //string dateString = "02/10/2023 14:30:00"; // Пример строки даты
            string pattern = @"^\d{2}\.\d{2}\.\d{4}$";
            bool result = Regex.IsMatch(dateString, pattern);
            // 
            //string format = "dd.MM.yyyy"; // Формат даты соответствующий строке
            //bool result = DateTime.TryParse(dateString,out DateTime date);
            
            
            return result; 
        }
    }
}
