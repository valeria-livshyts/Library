using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class BookCollection
    {
        private Book[] _books;

        public event EventHandler Changed;

        public BookCollection()
        {
            _books = new Book[0];
        }

        public void Add(Book book)
        {
            int newSize = _books.Length + 1;
            Book[] newArray = new Book[newSize];
            for (int i = 0; i < _books.Length && i < newSize; i++)
            {
                newArray[i] = _books[i];
            }

            newArray[newArray.Length - 1] = book;
            _books = newArray;

            book.Changed += Book_Changed;

            RaiseChangedEvent();
        }

        public int Count
        {
            get { return _books.Length; }
        }

        public void Delete(Book book)
        {
            int index = -1;
            for (int i = 0; i < _books.Length; i++)
            {
                Book currentBook = _books[i];

                if (currentBook == book)
                {
                    index = i;
                }
            }

            if (index == -1)
            {
                throw new ArgumentException("Неможливо видалити вказану книгу, оскільки її немає в колекції");
            }

            Delete(index);
        }


        public void Delete(int index)
        {
            if (index < 0 || index >= _books.Length)
            {
                throw new Exception("Книги під цим номером не існує.");
            }

            Book[] ArrayForDelete = new Book[_books.Length - 1];
            for (int i = 0; i < _books.Length; i++)
            {
                if (i < index)
                {
                    ArrayForDelete[i] = _books[i];
                }
                else if (i > index)
                {
                    ArrayForDelete[i - 1] = _books[i];
                }
                else
                {
                    ArrayForDelete[i - 1].Changed -= Book_Changed;
                }
            }

            _books = ArrayForDelete;

            RaiseChangedEvent();
        }


        public Book Get(int index)
        {
            if (index < 0 || index >= _books.Length)
            {
                throw new Exception("Книги під цим номером не існує.");
            }

            return _books[index];
        }

        //public void SaveToFile(string path, Book book)
        //{
        //    FileStream stream = File.Create(path);
        //    StreamWriter writer = new StreamWriter(stream);

        //    for (int i = 0; i < _books.Length; i++)
        //    {
        //        book = _books[i];
        //        writer.WriteLine(book.Title);
        //        writer.WriteLine(book.Authors);
        //        writer.WriteLine(book.PublishingHouse);
        //        writer.WriteLine(book.YearOfPublication);
        //        writer.WriteLine(book.Genre);
        //        writer.WriteLine(book.Description);
        //        writer.WriteLine(book.Picture);
        //        writer.WriteLine(book.Content);

        //    }
        //    writer.Close();
        //    writer.Dispose();

        //    stream.Close();
        //    stream.Dispose();
        //}

        public void SaveToFile(string path)
        {

            using (FileStream stream = File.Create(path))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    string json = JsonConvert.SerializeObject(_books, new JsonSerializerSettings
                    {
                        Formatting = Formatting.Indented,
                    });
                    writer.Write(json);
                    //for (int i = 0; i < _books.Length; i++)
                    //{
                    //    Book book = _books[i];
                    //    writer.WriteLine(book.Title);
                    //    writer.WriteLine(book.Authors);
                    //    writer.WriteLine(book.PublishingHouse);
                    //    writer.WriteLine(book.YearOfPublication);
                    //    writer.WriteLine(book.Genre);
                    //    writer.WriteLine(book.Description);
                    //    writer.WriteLine(book.Picture);
                    //    writer.WriteLine(book.Content);
                    //}
                }
            }
        }


        //public void ReadFromFile(string path)
        //{
        //    using (StreamReader reader = File.OpenText(path))
        //    {
        //        while (!reader.EndOfStream)
        //        {
        //            string title = reader.ReadLine();
        //            string authors = reader.ReadLine();
        //            string publishingHouse = reader.ReadLine();
        //            string yearOfPublication = reader.ReadLine();
        //            string description = reader.ReadLine();
        //            string genre = reader.ReadLine();
        //            string picture = reader.ReadLine();
        //            string content = reader.ReadLine();
        //            Book book = new Book(title, authors, publishingHouse, int.Parse(yearOfPublication), description, genre, picture, content);
        //            Add(book);
        //        }
        //    }
        //}


        public void ReadFromFile(string path) // Deserialize
        {

            using (StreamReader reader = File.OpenText(path))
            {
                string json = reader.ReadToEnd();
                _books = JsonConvert.DeserializeObject<Book[]>(json);

                for (int i = 0; i < _books.Length; i++)
                {
                    Book book = _books[i];
                    book.Changed += Book_Changed;
                }

                RaiseChangedEvent();
                //while (!reader.EndOfStream)
                //{
                //    string title = reader.ReadLine();
                //    string authors = reader.ReadLine();
                //    string publishingHouse = reader.ReadLine();
                //    string yearOfPublication = reader.ReadLine();
                //    string genre = reader.ReadLine();
                //    string description = reader.ReadLine();
                //    string picture = reader.ReadLine();
                //    string content = reader.ReadLine();
                //    Book book = new Book(title, authors, publishingHouse, int.Parse(yearOfPublication), description, genre, picture, content);
                //    Add(book);
                //}
            }
        }

        public Book[] Search(SearchParameters parameters)
        {
            int j = 0;
            Book[] result = new Book[_books.Length];

            for (int i = 0; i < _books.Length; i++)
            {
                Book book = _books[i];

                bool match = book.Title.Contains(parameters.Title, StringComparison.InvariantCultureIgnoreCase)
                    && book.Authors.Contains(parameters.Authors, StringComparison.InvariantCultureIgnoreCase)
                    && book.PublishingHouse.Contains(parameters.PublishingHouse, StringComparison.InvariantCultureIgnoreCase)
                    && book.Genre.Contains(parameters.Genre, StringComparison.InvariantCultureIgnoreCase)
                    && book.Description.Contains(parameters.Description, StringComparison.InvariantCultureIgnoreCase);

                if (match)
                {
                    if (parameters.YearOfPublication != null)
                    {
                        match = book.YearOfPublication == parameters.YearOfPublication;
                    }
                }

                if (match)
                {
                    result[j++] = book;
                }
            }

            Book[] finalResult = new Book[j];
            for (int i = 0; i < finalResult.Length; i++)
            {
                finalResult[i] = result[i];
            }

            return finalResult;
        }

        private void RaiseChangedEvent()
        {
            if (Changed != null)
            {
                Changed(this, EventArgs.Empty);
            }
        }

        private void Book_Changed(object? sender, EventArgs e)
        {
            RaiseChangedEvent();
        }
    }
}
