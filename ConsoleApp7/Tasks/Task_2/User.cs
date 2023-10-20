using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningTool.Tasks.Task_2
{
    internal class User
    {
        string _name;
        string _email;
        string _book;
        string _author;

        static int userCount;

        public User(string name, string email, Book book, Author author) 
        {
            _name = name;
            _email = email;
            _book = book.GetTitle();
            _author = author.GetName();

            userCount++;
        }

        public static int GetUserCount() 
        {
            return userCount;
        }

        public override string ToString() 
        {
            return $"Пользователь {_name} взял книгу {_book} ({_author})."
                +"\nВсего пользователей взяло книг: " + userCount;
        }
    }
}
