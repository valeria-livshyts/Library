using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Book
    {
        private string _title;
        private string _authors;
        private string _publishingHouse;
        private int _yearOfPublication;
        private string _description;
        private string _genre;
        private string _picture;
        private string _content;
        private ReviewCollection _reviews = new ReviewCollection();

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }

                _title = value;

                RaiseChangedEvent();
            }
        }

        public string Authors
        {
            get
            {
                return _authors;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }

                _authors = value;

                RaiseChangedEvent();
            }
        }
        public string PublishingHouse
        {
            get
            {
                return _publishingHouse;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }

                _publishingHouse = value;

                RaiseChangedEvent();
            }
        }
        public int YearOfPublication
        {
            get
            {
                return _yearOfPublication;
            }

            set
            {
                if (value < 0 || value > 2024)
                {
                    throw new ArgumentException();
                }

                _yearOfPublication = value;

                RaiseChangedEvent();
            }
        }
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }

                _description = value;

                RaiseChangedEvent();
            }
        }
        public string Genre
        {
            get
            {
                return _genre;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }

                _genre = value;

                RaiseChangedEvent();
            }
        }

        public string Picture
        {
            get
            {
                return _picture;
            }
            set
            {
                _picture = value;

                RaiseChangedEvent();
            }

        }
        public string Content
        {
            get
            {
                return _content;
            }
            set
            {
                _content = value;

                RaiseChangedEvent();
            }

        }

        public ReviewCollection Reviews
        {
            get
            {
                return _reviews;
            }
            set
            {
                _reviews = value;

               // RaiseChangedEvent();
            }
        }

        public event EventHandler Changed;

        public Book(string title, string authors, string publishingHouse, int yearOfPublication, string description, string genre, string picture, string content)
        {

            Title = title;
            Authors = authors;
            PublishingHouse = publishingHouse;
            YearOfPublication = yearOfPublication;
            Description = description;
            Genre = genre;
            Picture = picture;
            Content = content;
        }

        public void AddReview(Review review)
        {
            _reviews.AddReview(review);
            RaiseChangedEvent();
        }


        public void RemoveReview(Review review)
        {
            _reviews.RemoveReview(review);
            RaiseChangedEvent();
        }


        public void EditReview(int index, Review newreview)
        {
            _reviews.EditReview(index,newreview);
            RaiseChangedEvent();
        }



        [JsonIgnore]
        public double Mark
        {
            get
            {
                double totalMark = 0;
                if(_reviews.Count == 0 )
                {
                    return 0;
                }
                for (int i = 0; i < _reviews.Count; i++)
                {
                    totalMark += _reviews.Get(i).Mark;
                }

                return Math.Round(totalMark / _reviews.Count, 1);
            }
        }


        public override string ToString()
        {
            return $"{Title} ({Authors}) + {PublishingHouse} + {YearOfPublication}  + {Genre}+ {Description}";
        }

        private void RaiseChangedEvent()
        {
            if (Changed != null)
            {
                Changed(this, EventArgs.Empty);
            }
        }
    }
}
