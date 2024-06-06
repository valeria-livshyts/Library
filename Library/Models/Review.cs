using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Review
    {
        private string _author;

        private double _mark;

        private string _text;

        public string Author
        {
            get
            {
                return _author;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }

                _author = value;
            }
        }

        public double Mark
        {
            get
            {
                return _mark;
            }

            set
            {
                if (value < 1 || value > 5)
                {
                    throw new ArgumentException();
                }

                _mark = value;
            }
        }

        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }

                _text = value;
            }
        }

        public Models.Book Book
        {
            get => default;
            set
            {
            }
        }

        public Review(string author, double mark, string text)
        {
            Author = author;
            Mark = mark;
            Text = text;
        }
    }

}
