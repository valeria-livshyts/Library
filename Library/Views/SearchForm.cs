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
    public partial class SearchForm : Form
    {
        public SearchParameters Result { get; private set; }

        
        public SearchForm(SearchParameters lastSearch)
        {
            InitializeComponent();

            if(lastSearch != null)
            {
                TitleTextBox.Text = lastSearch.Title;
                AuthorTextBox.Text = lastSearch.Authors;
                PublishingHouseTextBox.Text = lastSearch.PublishingHouse;
                YearOfPublicationTextBox.Text = lastSearch.YearOfPublication.ToString();
                GenreComboBox.Text = lastSearch.Genre;
                DescriptionTextBox.Text = lastSearch.Description;

            }

        }



        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchParameters convertYearOfPublication = new SearchParameters();
            if (int.TryParse(YearOfPublicationTextBox.Text, out int year))
            {
                convertYearOfPublication.YearOfPublication = year;
            }
            else
            {
                convertYearOfPublication.YearOfPublication = null;
            }

            Result = new SearchParameters
            {
                Title = TitleTextBox.Text,
                Authors = AuthorTextBox.Text,
                PublishingHouse = PublishingHouseTextBox.Text,
                YearOfPublication = convertYearOfPublication.YearOfPublication,
                Genre = GenreComboBox.Text,
                Description = DescriptionTextBox.Text,
            };

            DialogResult = DialogResult.OK;
        }
     
    }
}
