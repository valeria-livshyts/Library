using Library.Models;
using Library.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Library
{
    public partial class ShowInfoBookForm : Form
    {
        private string _content;

        private Book _book;

        private ReviewCollection _reviews = new ReviewCollection();
        public Book Result { get; private set; }
        public ShowInfoBookForm(Book book)
        {
            InitializeComponent();

            _book = book;

            MarkLabel.Text = $"Рейтинг книги: {MarkInStars(_book.Mark)}";

            UpdateInfo();
            UpdateReviewList();
        }

        private void UpdateInfo()
        {
            TitleLabel.Text = _book.Title;
            AuthorLabel.Text = _book.Authors;
            PublishingHouseLabel.Text = _book.PublishingHouse;
            YearOfPublicationLabel.Text = _book.YearOfPublication.ToString();
            GenreLabel.Text = _book.Genre;
            DescriptionTextBox.Text = _book.Description;
            if (_book.Picture != null)
            {
                CoverImageBox.Image = Image.FromFile(_book.Picture);
            }

            _content = _book.Content;

        }

        private string MarkInStars(double mark)
        {
            int allStars = 5;
            int filledStars = (int)Math.Ceiling(mark);
            string stars = "";
            for (int i = 0; i < filledStars; i++)
            {
                stars += "★";
            }
            for (int i = filledStars; i < allStars; i++)
            {
                stars += "☆";
            }
            return stars;
        }

        private void UpdateReviewList()
        {
            ReviewListView.Items.Clear();
            for (int i = 0; i < _book.Reviews.Count; i++)
            {
                Review review = _book.Reviews.Get(i);
                //ReviewsListBox.Items.Add($"{review.Author}: {review.Mark}; {review.Text}");

                ListViewItem item = new ListViewItem(review.Author);
                item.SubItems.Add(MarkInStars(review.Mark));
                item.SubItems.Add(review.Text);


                ReviewListView.Items.Add(item);
                item.Tag = review;
            }
            ReviewListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void OpenContentButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo(_content)
            {
                UseShellExecute = true,
            };
            Process.Start(processStartInfo);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Continue;
        }

        private void AddReviewButton_Click(object sender, EventArgs e)
        {
            AddReviewForm form = new AddReviewForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _book.AddReview(form.Review);
                UpdateReviewList();
            }
            MarkLabel.Text = $"Рейтинг книги: {MarkInStars(_book.Mark)}";
        }

        private void RemoveReviewButton_Click(object sender, EventArgs e)
        {
            //_book.RemoveReview(ReviewsListBox.SelectedIndex);
            //UpdateReviewList();
            //RemoveReviewButton.Enabled = false;
            //MarkLabel.Text = _book.Mark.ToString();


            if (ReviewListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = ReviewListView.SelectedItems[0];
                if (selectedItem.Tag is Review review)
                {
                    ReviewListView.Items.Remove(selectedItem);
                    _book.RemoveReview(review);

                    RemoveReviewButton.Enabled = false;
                    EditReviewButton.Enabled = false;

                }
                MarkLabel.Text = $"Рейтинг книги: {MarkInStars(_book.Mark)}";
            }
        }

        private void EditReviewButton_Click(object sender, EventArgs e)
        {

            if (ReviewListView.SelectedItems.Count > 0)
            {

                if (ReviewListView.SelectedItems[0].Tag is Review review)
                {
                    AddReviewForm reviewForm = new AddReviewForm(review);
                    if (reviewForm.ShowDialog() == DialogResult.OK)
                    {
                        int selectedIndex = ReviewListView.SelectedItems[0].Index;
                        _book.EditReview(selectedIndex, reviewForm.Review);
                        UpdateReviewList();
                    }
                    MarkLabel.Text = $"Рейтинг книги: {MarkInStars(_book.Mark)}";
                }

            }
        }

        private void ReviewListView_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ReviewListView.SelectedItems.Count == 1)
            {
                RemoveReviewButton.Enabled = true;
                EditReviewButton.Enabled = true;

            }
            else
            {
                EditReviewButton.Enabled = false;
                RemoveReviewButton.Enabled = false;
            }
        }

        private void ReviewListView_Leave(object sender, EventArgs e)
        {
            //EditReviewButton.Enabled = false;
            //RemoveReviewButton.Enabled = false;
        }
    }
}
