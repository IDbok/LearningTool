using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningTool.Tasks.Task_2
{
    internal class Book
    {
        public Book() { }
        public Book(string title, string author, int releaseYear)
        {
            _title = title;
            _author = author;
            _releaseYear = releaseYear;

        }
        public Book(string title, string author, int releaseYear, string description, int pageAmount)
        {
            //_id = Guid.NewGuid();
            _title = title;
            _author = author;
            _releaseYear = releaseYear;
            _description = description;
            _pageAmount = pageAmount;
            //_formats;
        }

        public Book(string title, Author author, int releaseYear, string description, int pageAmount)
        {
            //_id = Guid.NewGuid();
            _title = title;
            _author = author.GetName(); // Можно ли так делать??
            _releaseYear = releaseYear;
            _description = description;
            _pageAmount = pageAmount;
            //_formats;
        }

        private Guid _id = Guid.NewGuid();
        private string _title;
        public string _author;
        private int _releaseYear;
        private string? _description;
        private int _pageAmount;

        private List<int> _rates = new List<int>();
        //private string[] _formats;

        private void AddBookAuthor() { }
        public string GetTitle() 
        {
            return _title;
        }

        public void RateBook(int rate) 
        {
            _rates.Add(rate);

        }

        public override string ToString() // вместо toString() тк он похож на метод ToString класс oblect 
                                   // + начинается с маленькой буквы
        {
            //var pageAm = _pageAmount == 0 ? "нет данных": _pageAmount; 
            int value = _rates.Count;
            double score = Math.Round((double)_rates.Sum() / value, 1);

            
            string message = 
                $"Книга с идетификатором: {_id}\n"+
                $"Название книги:{_title}"+
                $"\nАвтор: {_author}"+
                $"\nДата издания: {_releaseYear}"+
                $"\nКоличество страниц: {(_pageAmount == 0 ? "#Н/Д": _pageAmount)}"+
                $"\nОписание: {(_description == null ? "#Н/Д" : _description)}"+
                $"\nСредняя оценка: {(value == 0 ? "Нет ни одной оценки" : score)}";

            return message;
        }

    }
}
