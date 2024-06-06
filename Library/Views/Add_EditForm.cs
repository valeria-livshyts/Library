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

namespace Library
{

    public partial class Add_EditForm : Form
    {

        private BookFormState _state = BookFormState.Add;
        private MainForm _form1;

        // private BookCollection _books = new BookCollection();

        
        private string openFileCover;
        private string openFileContent;

       

        private string destinationFileForCover;
        private string destinationFileForContent;

        private string temporaryFileForCover;
        private string temporaryFileForContent;
        public Book Result { get; private set; }

        public Add_EditForm()
        {
            InitializeComponent();

            this.Text = "Додавання книги";
            GenreComboBox.SelectedIndexChanged += GenreComboBox_SelectedIndexChanged_1;

            Add_EditButton.Text = "Додати";

            tableLayoutPanel4.BorderStyle = BorderStyle.FixedSingle;
        }

        public Add_EditForm(Book book)
        {
            InitializeComponent();

            
            this.Text = "Редагування книги";
            TitleTextBox.Text = book.Title;
            AuthorTextBox.Text = book.Authors;
            PublishingHouseTextBox.Text = book.PublishingHouse;
            YearOfPublicationTextBox.Text = book.YearOfPublication.ToString();
            GenreComboBox.SelectedItem = book.Genre;
            DescriptionTextBox.Text = book.Description;

            if (book.Picture != "" && book.Picture != null)
            {
                selectedCoverToAdd.Image = Image.FromFile(book.Picture);

                destinationFileForCover = book.Picture;
                destinationFileForContent = book.Content;
            }


            Add_EditButton.Enabled = false;
            _state = BookFormState.Edit;

            InvalidateConfirmButtonState();

            Add_EditButton.Text = "Редагувати";

        }


        //private void AddBookButton_Click(object sender, EventArgs e)
        //{
        //    int convertYearOfPublication = int.Parse(YearOfPublicationTextBox.Text);


        //    Book book = new Book(TitleTextBox.Text, AuthorTextBox.Text, PublishingHouseTextBox.Text, convertYearOfPublication, DescriptionTextBox.Text, GenreComboBox.SelectedItem.ToString(), destinationFileForCover, destinationFileForContent);


        //    Result = book;
        //    CleanTextBox();

        //    selectedCoverToAdd.Image = null;

        //    DialogResult = DialogResult.OK;
        //}

        private void InvalidateConfirmButtonState()
        {
            Add_EditButton.Enabled = !string.IsNullOrWhiteSpace(TitleTextBox.Text)
                 && !string.IsNullOrWhiteSpace(AuthorTextBox.Text)
                 && !string.IsNullOrWhiteSpace(PublishingHouseTextBox.Text)
                 && TryCheckInt(YearOfPublicationTextBox.Text, out int yearOfPublication)
                 && yearOfPublication >= 0
                 && yearOfPublication <= 2024
                 && CheckGenre()
                && !string.IsNullOrWhiteSpace(DescriptionTextBox.Text);
        }

        //private void InvalidateAddBookButtonState()
        //{
        //    AddBookButton.Enabled = _state == BookFormState.Add
        //         && !string.IsNullOrWhiteSpace(TitleTextBox.Text)
        //         && !string.IsNullOrWhiteSpace(AuthorTextBox.Text)
        //         && !string.IsNullOrWhiteSpace(PublishingHouseTextBox.Text)
        //         && TryCheckInt(YearOfPublicationTextBox.Text, out int yearOfPublication)
        //         && yearOfPublication >= 0
        //         && yearOfPublication <= 2024
        //         && CheckGenre()
        //        && !string.IsNullOrWhiteSpace(DescriptionTextBox.Text);
        //}

        private void CleanTextBox()
        {
            TitleTextBox.Clear();
            AuthorTextBox.Clear();
            PublishingHouseTextBox.Clear();
            YearOfPublicationTextBox.Clear();
            DescriptionTextBox.Clear();
            GenreComboBox.SelectedItem = null;
        }

        private bool TryCheckInt(string input, out int result)
        {
            result = 0;

            try
            {
                result = int.Parse(input);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private bool CheckGenre()
        {
            if (GenreComboBox.SelectedItem != null)
            {
                string selectedGenre = GenreComboBox.SelectedItem.ToString();
                return true;
            }
            else
                return false;

        }


        private void TitleTextBox_TextChanged_1(object sender, EventArgs e)
        {
            Debug.WriteLine($"Введено назву: {TitleTextBox.Text}");

            //InvalidateAddBookButtonState();
            InvalidateConfirmButtonState();
        }

        private void AuthorTextBox_TextChanged_1(object sender, EventArgs e)
        {

            Debug.WriteLine($"Введено автора: {AuthorTextBox.Text}");

            // InvalidateAddBookButtonState();
            InvalidateConfirmButtonState();
        }

        private void PublishingHouseTextBox_TextChanged_1(object sender, EventArgs e)
        {
            // InvalidateAddBookButtonState();
            InvalidateConfirmButtonState();
        }

        private void YearOfPublicationTextBox_TextChanged_1(object sender, EventArgs e)
        {

            //  InvalidateAddBookButtonState();
            InvalidateConfirmButtonState();
        }

        private void DescriptionTextBox_TextChanged_1(object sender, EventArgs e)
        {

            // InvalidateAddBookButtonState();
            InvalidateConfirmButtonState();
        }

        private void GenreComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // InvalidateAddBookButtonState();
            InvalidateConfirmButtonState();
        }


        private void DownloadCoverButton_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Зображення (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
            openFileDialog.Title = "Який файл треба скопіювати";


            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                openFileCover = openFileDialog.FileName;

                selectedCoverToAdd.Image = Image.FromFile(openFileCover);

                if (selectedCoverToAdd.Image != null)
                {
                    label1.Text = "Обрана обкладинка";
                    label3.Text = "✅";
                }

                //using (FileStream stream1 = File.OpenRead(openFile))
                //{
                //    string destinationFolder = "imagesForCover";

                //    if (!Directory.Exists(destinationFolder))
                //    {
                //        Directory.CreateDirectory(destinationFolder);
                //    }

                //    selectedCoverToAdd.Image = Image.FromFile(openFile);


                //    if (selectedCoverToAdd.Image != null)
                //    {
                //        label1.Text = "Обрана обкладинка";
                //        label3.Text = "✅";
                //    }

                //    destinationFileForCover = Path.Combine(destinationFolder, Path.GetFileName(openFile));

                //    using (FileStream stream2 = File.Create(destinationFileForCover))
                //    {
                //        byte[] buffer1 = new byte[32];
                //        while (true)
                //        {
                //            int bytesRead = stream1.Read(buffer1, 0, buffer1.Length);

                //            stream2.Write(buffer1, 0, bytesRead);

                //            if (bytesRead < buffer1.Length)
                //            {
                //                break;
                //            }
                //        }
                //    }

                //}

                //MessageBox.Show($"You select {openFile} this file");
            }
        }


        //private void DownloadCoverButton_Click_1(object sender, EventArgs e)
        //{
        //    OpenFileDialog openFileDialog = new OpenFileDialog();
        //    openFileDialog.Filter = "Зображення (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
        //    openFileDialog.Title = "Який файл треба скопіювати";


        //    DialogResult result = openFileDialog.ShowDialog();
        //    if (result == DialogResult.OK)
        //    {
        //        openFile = openFileDialog.FileName;

        //        FileStream stream1 = File.OpenRead(openFile);
        //        string destinationFolder = "imagesForCover";

        //        if (!Directory.Exists(destinationFolder))
        //        {
        //            Directory.CreateDirectory(destinationFolder);
        //        }

        //        selectedCoverToAdd.Image = Image.FromFile(openFile);

        //        if (selectedCoverToAdd.Image != null)
        //        {
        //            label1.Text = "Обрана обкладинка";
        //        }

        //        destinationFileForCover = Path.Combine(destinationFolder, Path.GetFileName(openFile));


        //        FileStream stream2 = File.Create(destinationFileForCover);
        //        byte[] buffer1 = new byte[32];
        //        while (true)
        //        {
        //            int bytesRead = stream1.Read(buffer1, 0, buffer1.Length);

        //            stream2.Write(buffer1, 0, bytesRead);

        //            if (bytesRead < buffer1.Length)
        //            {
        //                break;
        //            }
        //        }
        //        stream2.Close();
        //        stream2.Dispose();

        //        stream1.Close();
        //        stream1.Dispose();

        //        //MessageBox.Show($"You select {openFile} this file");
        //    }
        //}

        private void ContentDownloadButton_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстові файли(*.doc, *.pdf, *.txt, *.epub)|*.doc;*.pdf;*.txt;*.epub";
            openFileDialog.Title = "Згрузити вміст книги";


            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                openFileContent = openFileDialog.FileName;

                if (openFileContent != null)
                {
                    label2.Text = $"✅ Назва файлу:  {Path.GetFileName(openFileContent)}";
                }

                //MessageBox.Show($"You select {openFile} this file");
            }
        }

       
        private void CopyCover()
        {
            using (FileStream stream1 = File.OpenRead(openFileCover))
            {
                string destinationFolder = "imagesForCover";

                if (!Directory.Exists(destinationFolder))
                {
                    Directory.CreateDirectory(destinationFolder);
                }

                destinationFileForCover = Path.Combine(destinationFolder, Path.GetFileName(openFileCover));

                using (FileStream stream2 = File.Create(destinationFileForCover))
                {
                    byte[] buffer1 = new byte[32];
                    while (true)
                    {
                        int bytesRead = stream1.Read(buffer1, 0, buffer1.Length);

                        stream2.Write(buffer1, 0, bytesRead);

                        if (bytesRead < buffer1.Length)
                        {
                            break;
                        }
                    }
                }

            }

        }

        private void CopyContent()
        {
            FileStream stream1 = File.OpenRead(openFileContent);
            string destinationFolder = "booksContent";

            if (!Directory.Exists(destinationFolder))
            {
                Directory.CreateDirectory(destinationFolder);
            }

            destinationFileForContent = Path.Combine(destinationFolder, Path.GetFileName(openFileContent));


            FileStream stream2 = File.Create(destinationFileForContent);
            byte[] buffer1 = new byte[32];
            while (true)
            {
                int bytesRead = stream1.Read(buffer1, 0, buffer1.Length);

                stream2.Write(buffer1, 0, bytesRead);

                if (bytesRead < buffer1.Length)
                {
                    break;
                }
            }
            stream2.Close();
            stream2.Dispose();

            stream1.Close();
            stream1.Dispose();
        }

        private void Add_EditButton_Click(object sender, EventArgs e)
        {
            if (_state == BookFormState.Add)
            {
                //AddBook();

                int convertYearOfPublication = int.Parse(YearOfPublicationTextBox.Text);
                if(openFileCover != null)
                {
                    CopyCover();
                }
                if(openFileContent != null)
                {
                    CopyContent();
                }


                Book book = new Book(TitleTextBox.Text, AuthorTextBox.Text, PublishingHouseTextBox.Text, convertYearOfPublication, DescriptionTextBox.Text, GenreComboBox.SelectedItem.ToString(), destinationFileForCover, destinationFileForContent);


                Result = book;
                CleanTextBox();

                selectedCoverToAdd.Image = null;

                DialogResult = DialogResult.OK;
            }
            else if (_state == BookFormState.Edit)
            {
               // EditBook();

                int convertYearOfPublication = int.Parse(YearOfPublicationTextBox.Text);

                if (openFileCover != null)
                {
                    CopyCover();
                }
                if (openFileContent != null)
                {
                    CopyContent();
                }

                Book book = new Book(TitleTextBox.Text, AuthorTextBox.Text, PublishingHouseTextBox.Text, convertYearOfPublication, DescriptionTextBox.Text, GenreComboBox.SelectedItem.ToString(), destinationFileForCover, destinationFileForContent);


                Result = book;
                CleanTextBox();

                selectedCoverToAdd.Image = null;
                DialogResult = DialogResult.OK;

              //  MessageBox.Show("Успішно");
            }
        }

        
    }
}
