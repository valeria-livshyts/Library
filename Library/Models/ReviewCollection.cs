using Library.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ReviewCollection
    {
        [JsonProperty("Items")]
        private Review[] _reviews;

        [JsonIgnore]
        public int Count
        {
            get { return _reviews.Length; }
        }

        public ReviewCollection()
        {
            _reviews = new Review[0];
        }

        public Review Get(int index)
        {
            return _reviews[index];
        }

        public void AddReview(Review review)
        {
            int newSize = _reviews.Length + 1;
            Review[] newArray = new Review[newSize];
            for (int i = 0; i < _reviews.Length && i < newSize; i++)
            {
                newArray[i] = _reviews[i];
            }

            newArray[newArray.Length - 1] = review;
            _reviews = newArray;
        }

        public void RemoveReview(Review review)
        {
            int index = -1;
            for (int i = 0; i < _reviews.Length; i++)
            {
                Review currentReview = _reviews[i];
                if (currentReview == review)
                {
                    index = i;
                }
            }

            if (index == -1)
            {
                throw new ArgumentException("Неможливо видалити вказаний відгук");
            }

            RemoveReview(index);
        }


        public void RemoveReview(int index)
        {
            if (index < 0 || index >= _reviews.Length)
            {
                throw new Exception("Відгуку під цим номером не існує.");
            }

            Review[] ArrayForDelete = new Review[_reviews.Length - 1];
            for (int i = 0; i < _reviews.Length; i++)
            {
                if (i < index)
                {
                    ArrayForDelete[i] = _reviews[i];
                }
                else if (i > index)
                {
                    ArrayForDelete[i - 1] = _reviews[i];
                }
            }

            _reviews = ArrayForDelete;
        }

        public void EditReview(int index, Review newReview)
        {
            if (index < 0 || index >= _reviews.Length)
            {
                throw new Exception("Відгуку під цим номером не існує.");
            }
            _reviews[index] = newReview;
        }
    }
}
