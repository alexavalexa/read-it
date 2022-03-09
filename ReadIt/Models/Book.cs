using System;

namespace ReadIt.Models
{
    public class Book
    {
        private static int id = 0;
        private string title;
        private string author;

        public Book(string title, string author)
        {
            id++;
            Id = id;
            Title = title;
            Author = author;
        }

        public int Id { get; }

        public string Title
        {
            get { return title; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty!");
                }
                title = value;
            }
        }
        public string Author
        {
            get { return author; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Author cannot be null or empty!");
                }
                author = value;
            }
        }

    }
}
