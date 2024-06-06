namespace Library
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            Title = new Label();
            Author = new Label();
            PublishingHouse = new Label();
            YearOfPublication = new Label();
            Genre = new Label();
            Description = new Label();
            TitleTextBox = new TextBox();
            AuthorTextBox = new TextBox();
            PublishingHouseTextBox = new TextBox();
            GenreComboBox = new ComboBox();
            DescriptionTextBox = new TextBox();
            YearOfPublicationTextBox = new TextBox();
            SearchButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(Title, 0, 0);
            tableLayoutPanel1.Controls.Add(Author, 0, 1);
            tableLayoutPanel1.Controls.Add(PublishingHouse, 0, 2);
            tableLayoutPanel1.Controls.Add(YearOfPublication, 0, 3);
            tableLayoutPanel1.Controls.Add(Genre, 0, 4);
            tableLayoutPanel1.Controls.Add(Description, 0, 5);
            tableLayoutPanel1.Controls.Add(TitleTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(AuthorTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(PublishingHouseTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(GenreComboBox, 1, 4);
            tableLayoutPanel1.Controls.Add(DescriptionTextBox, 1, 5);
            tableLayoutPanel1.Controls.Add(YearOfPublicationTextBox, 1, 3);
            tableLayoutPanel1.Controls.Add(SearchButton, 1, 6);
            tableLayoutPanel1.Location = new Point(0, -1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6658077F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6658077F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6658077F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6658077F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6658077F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 140F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6709557F));
            tableLayoutPanel1.Size = new Size(458, 454);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Title.AutoSize = true;
            Title.Location = new Point(13, 24);
            Title.Name = "Title";
            Title.Size = new Size(134, 20);
            Title.TabIndex = 11;
            Title.Text = "Назва";
            // 
            // Author
            // 
            Author.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Author.AutoSize = true;
            Author.Location = new Point(10, 72);
            Author.Margin = new Padding(0);
            Author.Name = "Author";
            Author.Size = new Size(140, 20);
            Author.TabIndex = 13;
            Author.Text = "Автор";
            // 
            // PublishingHouse
            // 
            PublishingHouse.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PublishingHouse.AutoSize = true;
            PublishingHouse.Location = new Point(10, 120);
            PublishingHouse.Margin = new Padding(0, 0, 3, 0);
            PublishingHouse.Name = "PublishingHouse";
            PublishingHouse.Size = new Size(137, 20);
            PublishingHouse.TabIndex = 15;
            PublishingHouse.Text = "Видавницвто";
            // 
            // YearOfPublication
            // 
            YearOfPublication.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            YearOfPublication.AutoSize = true;
            YearOfPublication.Location = new Point(13, 168);
            YearOfPublication.Name = "YearOfPublication";
            YearOfPublication.Size = new Size(134, 20);
            YearOfPublication.TabIndex = 16;
            YearOfPublication.Text = "Рік видання";
            // 
            // Genre
            // 
            Genre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Genre.AutoSize = true;
            Genre.Location = new Point(13, 216);
            Genre.Name = "Genre";
            Genre.Size = new Size(134, 20);
            Genre.TabIndex = 17;
            Genre.Text = "Жанр";
            // 
            // Description
            // 
            Description.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Description.AutoSize = true;
            Description.Location = new Point(13, 310);
            Description.Name = "Description";
            Description.Size = new Size(134, 20);
            Description.TabIndex = 18;
            Description.Text = "Опис";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TitleTextBox.Location = new Point(153, 20);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.PlaceholderText = "Назва";
            TitleTextBox.Size = new Size(292, 27);
            TitleTextBox.TabIndex = 19;
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AuthorTextBox.Location = new Point(150, 68);
            AuthorTextBox.Margin = new Padding(0);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.PlaceholderText = "Автор";
            AuthorTextBox.Size = new Size(298, 27);
            AuthorTextBox.TabIndex = 20;
            // 
            // PublishingHouseTextBox
            // 
            PublishingHouseTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PublishingHouseTextBox.Location = new Point(153, 116);
            PublishingHouseTextBox.Name = "PublishingHouseTextBox";
            PublishingHouseTextBox.PlaceholderText = "Видавництво";
            PublishingHouseTextBox.Size = new Size(292, 27);
            PublishingHouseTextBox.TabIndex = 21;
            // 
            // GenreComboBox
            // 
            GenreComboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            GenreComboBox.FormattingEnabled = true;
            GenreComboBox.Items.AddRange(new object[] { "Класична література", "Драматургія", "Казки", "Детективи", "Романи", "Фантастика", "Гумор", "Наука", "Кулінарія" });
            GenreComboBox.Location = new Point(153, 212);
            GenreComboBox.Name = "GenreComboBox";
            GenreComboBox.Size = new Size(292, 28);
            GenreComboBox.TabIndex = 27;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionTextBox.Location = new Point(153, 253);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.PlaceholderText = "Опис";
            DescriptionTextBox.ScrollBars = ScrollBars.Vertical;
            DescriptionTextBox.Size = new Size(292, 134);
            DescriptionTextBox.TabIndex = 28;
            // 
            // YearOfPublicationTextBox
            // 
            YearOfPublicationTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            YearOfPublicationTextBox.Location = new Point(153, 164);
            YearOfPublicationTextBox.Name = "YearOfPublicationTextBox";
            YearOfPublicationTextBox.PlaceholderText = "Рік видання";
            YearOfPublicationTextBox.Size = new Size(292, 27);
            YearOfPublicationTextBox.TabIndex = 22;
            // 
            // SearchButton
            // 
            SearchButton.Anchor = AnchorStyles.Left;
            SearchButton.Location = new Point(153, 402);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(292, 29);
            SearchButton.TabIndex = 29;
            SearchButton.Text = "Пошук";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 450);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SearchForm";
            Text = "Розширений пошук";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label Title;
        private Label Author;
        private Label PublishingHouse;
        private Label YearOfPublication;
        private Label Genre;
        private Label Description;
        private TextBox TitleTextBox;
        private TextBox AuthorTextBox;
        private TextBox PublishingHouseTextBox;
        private TextBox YearOfPublicationTextBox;
        private ComboBox GenreComboBox;
        private TextBox DescriptionTextBox;
        private Button SearchButton;
    }
}