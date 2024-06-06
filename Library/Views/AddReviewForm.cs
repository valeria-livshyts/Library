using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class AddReviewForm : Form
    {
        public Review Review { get; private set; }
        public AddReviewForm()
        {

            InitializeComponent();
            this.Text = "Додати відгук";
            Add_EditReviewButton.Text = "Додати відгук";
        }

        public AddReviewForm(Review review)
        {
            InitializeComponent();
            this.Text = "Редагувати відгук";
            Add_EditReviewButton.Text = "Редагувати відгук";
            AuthorTextBox.Text = review.Author;
            MarkTextBox.Text = review.Mark.ToString();
            ReviewTextBox.Text = review.Text;
        }


        private void InvalidateConfirmButtonState()
        {
            Add_EditReviewButton.Enabled = !string.IsNullOrWhiteSpace(AuthorTextBox.Text)
                 && TryCheckDouble(MarkTextBox.Text, out double Mark)
                 && Mark >= 1
                 && Mark <= 5
                && !string.IsNullOrWhiteSpace(ReviewTextBox.Text);
        }


        private bool TryCheckDouble(string input, out double result)
        {
            result = 0;

            try
            {
                result = double.Parse(input);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        private void Add_EditReviewButton_Click(object sender, EventArgs e)
        {
            int convertMark = int.Parse(MarkTextBox.Text);
        
            Review review = new Review(AuthorTextBox.Text, convertMark, ReviewTextBox.Text);
            Review = review;
            DialogResult = DialogResult.OK;
        }

        private void AuthorTextBox_TextChanged(object sender, EventArgs e)
        {
            InvalidateConfirmButtonState();
        }

        private void MarkTextBox_TextChanged(object sender, EventArgs e)
        {
            InvalidateConfirmButtonState();
        }

        private void ReviewTextBox_TextChanged(object sender, EventArgs e)
        {
            InvalidateConfirmButtonState();
        }
    }
}
