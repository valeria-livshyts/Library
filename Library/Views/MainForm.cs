using Library.Models;
using Library.Views;
using System.Collections;

namespace Library
{
    public partial class MainForm : Form
    {
        private BookFormState _state = BookFormState.Add;
        private BookCollection _books = new BookCollection();
        private string destinationFileForCover;
        private string destinationFileForContent;
        private string BooksTxt = "Books.json";
        private SearchParameters savedSearch;

        private ListViewColumnSorter lvwColumnSorter;

        private bool _isReading;

        public MainForm()
        {
            InitializeComponent();

            lvwColumnSorter = new ListViewColumnSorter();
            this.BookListView.ListViewItemSorter = lvwColumnSorter;

            _books.Changed += Books_Changed;

            _isReading = true;
            _books.ReadFromFile(BooksTxt);
            _isReading = false;

            savedSearch = new SearchParameters();
        }

        private void Books_Changed(object? sender, EventArgs e)
        {
            InvalidateBookCollection(!_isReading);
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
        private void InvalidateBookCollection(bool fileSave)
        {
            if (fileSave)
            {
                _books.SaveToFile(BooksTxt);
            }

            BookListView.Items.Clear();

            for (int i = 0; i < _books.Count; i++)
            {
                Book book = _books.Get(i);

                //ColumnHeader columnheader;
                // ListViewItem booklistviewitem;

                BookListView.View = View.Details;

                ListViewItem item = new ListViewItem(book.Title);
                item.SubItems.Add(book.Authors);
                item.SubItems.Add(book.PublishingHouse);
                item.SubItems.Add(book.YearOfPublication.ToString());
                item.SubItems.Add(book.Genre);
                // item.SubItems.Add(book.Description);
                item.SubItems.Add(MarkInStars(book.Mark));

                BookListView.Items.Add(item);
                item.Tag = book;
            }

            BookListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.None);
        }

        private void InvalidateSearchButtonState()
        {
            SearchButton.Enabled = true
             && !string.IsNullOrWhiteSpace(SearchTextBox.Text);
        }


        private void RemoveBookButton_Click(object sender, EventArgs e)
        {

            if (BookListView.Items.Count > 0)
            {
                ListViewItem selectedItem = BookListView.SelectedItems[0];
                if (selectedItem.Tag is Book book)
                {

                    BookListView.Items.Remove(selectedItem);

                    _books.Delete(book);
                    RemoveBookButton.Enabled = false;
                    EditBookButton.Enabled = false;
                    Cover.Image = null;
                }
            }

        }

        private void EditBookButton_Click(object sender, EventArgs e)
        {
            if (BookListView.SelectedItems.Count > 0)
            {

                if (BookListView.SelectedItems[0].Tag is Book book)
                {
                    UpdateInfoAfterEdit(book);
                }
                _state = BookFormState.Edit;

            }

        }

        private void BookListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BookListView.SelectedItems.Count == 1)
            {
                RemoveBookButton.Enabled = true;
                EditBookButton.Enabled = true;
                object selectedItem = BookListView.SelectedItems[0].Text;


                if (BookListView.SelectedItems[0].Tag is Book book)
                {
                    if (book.Picture != "" && book.Picture != null)
                    {
                        Cover.Image = Image.FromFile(book.Picture);
                        TitleNameLabel.Text = $"{book.Title}\n";

                    }
                    else
                    {
                        Cover.Image = null;
                        TitleNameLabel.Text = $"{book.Title}\n";
                        Cover.Image?.Dispose();
                    }
                }
                else
                {
                    Cover.Image = null;
                    Cover.Image?.Dispose();
                }
            }
            else
            {
                Cover.Image = null;
                Cover.Image?.Dispose();
                TitleNameLabel.Text = string.Empty;
                EditBookButton.Enabled = false;
                RemoveBookButton.Enabled = false;
            }


        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            BookListView.Items.Clear();
            for (int i = 0; i < _books.Count; i++)
            {
                Book book = _books.Get(i);
                if (book.Title.ToLower().Contains(SearchTextBox.Text)
                    || book.Authors.ToLower().Contains(SearchTextBox.Text)
                    || book.PublishingHouse.ToLower().Contains(SearchTextBox.Text)
                    || book.Genre.ToLower().Contains(SearchTextBox.Text)
                    || book.Description.ToLower().Contains(SearchTextBox.Text)
                    )
                {
                    ListViewItem item = new ListViewItem(book.Title);
                    item.SubItems.Add(book.Authors);
                    item.SubItems.Add(book.PublishingHouse);
                    item.SubItems.Add(book.YearOfPublication.ToString());
                    item.SubItems.Add(book.Genre);
                    //  item.SubItems.Add(book.Description);
                    item.SubItems.Add(MarkInStars(book.Mark));

                    BookListView.Items.Add(item);
                    item.Tag = book;
                }
            }
            RefreshButton.Enabled = true;
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            InvalidateSearchButtonState();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            lvwColumnSorter.Order = SortOrder.None;
            InvalidateBookCollection(false);
            SearchTextBox.Clear();
            SearchButton.Enabled = false;
            // RefreshButton.Enabled = false;

            savedSearch = null;
            SearchForm searchform = new SearchForm(savedSearch);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Add_EditForm form = new Add_EditForm();
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                Book result = form.Result;
                _books.Add(result);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BookListView_Leave(object sender, EventArgs e)
        {
            if (Cover.Image != null)
            {
                Cover.Image.Dispose();
            }
            Cover.Image = null;
            TitleNameLabel.Text = string.Empty;
            //EditBookButton.Enabled = false;
            //RemoveBookButton.Enabled = false;
        }

        private void FullSearchButton_Click(object sender, EventArgs e)
        {
            SearchForm searchform = new SearchForm(savedSearch);

            DialogResult dialogResult = searchform.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                savedSearch = searchform.Result;
                BookListView.Items.Clear();

                Book[] searchResult = _books.Search(searchform.Result);
                for (int i = 0; i < searchResult.Length; i++)
                {
                    Book book = searchResult[i];

                    ListViewItem item = new ListViewItem(book.Title);
                    item.SubItems.Add(book.Authors);
                    item.SubItems.Add(book.PublishingHouse);
                    item.SubItems.Add(book.YearOfPublication.ToString());
                    item.SubItems.Add(book.Genre);
                    //   item.SubItems.Add(book.Description);
                    item.SubItems.Add(MarkInStars(book.Mark));

                    BookListView.Items.Add(item);
                    item.Tag = book;
                }

            }
            RefreshButton.Enabled = true;


        }

        private void UpdateInfoAfterEdit(Book book)
        {
            Add_EditForm form = new Add_EditForm(book);
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                Book result = form.Result;

                book.Title = result.Title;
                book.Authors = result.Authors;
                book.PublishingHouse = result.PublishingHouse;
                book.YearOfPublication = result.YearOfPublication;
                book.Genre = result.Genre;
                book.Description = result.Description;
                book.Picture = result.Picture;
                book.Content = result.Content;
            }
        }

        private void BookListView_DoubleClick(object sender, EventArgs e)
        {
            if (BookListView.SelectedItems.Count > 0)
            {
                if (BookListView.SelectedItems[0].Tag is Book book)
                {

                    ShowInfoBookForm showInfoBookForm = new ShowInfoBookForm(book);
                    DialogResult dialogResult = showInfoBookForm.ShowDialog();
                    if (dialogResult == DialogResult.Continue)
                    {
                        UpdateInfoAfterEdit(book);
                    }
                }

            }
        }


        public class ListViewColumnSorter : IComparer
        {
            private int ColumnToSort;
            private SortOrder OrderOfSort;
            private CaseInsensitiveComparer objectCompare;

            public ListViewColumnSorter()
            {
                ColumnToSort = 0;

                OrderOfSort = SortOrder.None;

                objectCompare = new CaseInsensitiveComparer();
            }

            public int Compare(object x, object y)
            {
                int CompareResult;
                ListViewItem listviewX, listviewY;

                listviewX = (ListViewItem)x;
                listviewY = (ListViewItem)y;

                CompareResult = objectCompare.Compare(listviewX.SubItems[ColumnToSort].Text, listviewY.SubItems[ColumnToSort].Text);

                if (OrderOfSort == SortOrder.Ascending)
                {
                    return CompareResult;
                }
                else if (OrderOfSort == SortOrder.Descending)
                {
                    return (-CompareResult);
                }
                else
                {
                    return 0;
                }
            }

            public int SortColumn
            {
                set
                {
                    ColumnToSort = value;
                }
                get
                {
                    return ColumnToSort;
                }

            }

            public SortOrder Order
            {
                set
                {
                    OrderOfSort = value;
                }
                get
                {
                    return OrderOfSort;
                }

            }

        }

        private void BookListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            //ColumnHeader column = BookListView.Columns[e.Column];
            //if (column.Tag is string property)
            //{

            //    BookListView.ListViewItemSorter = ..;
            //}



            if (e.Column == lvwColumnSorter.SortColumn)
            {
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {

                    lvwColumnSorter.Order = SortOrder.Descending;

                }

                else
                {

                    lvwColumnSorter.Order = SortOrder.Ascending;

                }
            }
            else
            {
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }
            this.BookListView.Sort();
        }

        private void AboutProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("©by Valeria, 2024");
        }

        private void FullSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchTextBox.Focus();
        }

        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FullSearchButton.Focus();
        }
    }
}