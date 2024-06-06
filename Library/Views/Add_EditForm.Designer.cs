namespace Library
{
    partial class Add_EditForm
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
            Add_EditButton = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            label1 = new Label();
            selectedCoverToAdd = new PictureBox();
            Title = new Label();
            Author = new Label();
            PublishingHouse = new Label();
            YearOfPublication = new Label();
            Genre = new Label();
            TitleTextBox = new TextBox();
            AuthorTextBox = new TextBox();
            PublishingHouseTextBox = new TextBox();
            YearOfPublicationTextBox = new TextBox();
            GenreComboBox = new ComboBox();
            DescriptionTextBox = new TextBox();
            DownloadCoverButton = new Button();
            ContentDownloadButton = new Button();
            Description = new Label();
            label2 = new Label();
            label3 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)selectedCoverToAdd).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.4114723F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.58853F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 228F));
            tableLayoutPanel1.Controls.Add(Add_EditButton, 1, 8);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 2, 0);
            tableLayoutPanel1.Controls.Add(Title, 0, 0);
            tableLayoutPanel1.Controls.Add(Author, 0, 1);
            tableLayoutPanel1.Controls.Add(PublishingHouse, 0, 2);
            tableLayoutPanel1.Controls.Add(YearOfPublication, 0, 3);
            tableLayoutPanel1.Controls.Add(Genre, 0, 4);
            tableLayoutPanel1.Controls.Add(TitleTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(AuthorTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(PublishingHouseTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(YearOfPublicationTextBox, 1, 3);
            tableLayoutPanel1.Controls.Add(GenreComboBox, 1, 4);
            tableLayoutPanel1.Controls.Add(DescriptionTextBox, 1, 5);
            tableLayoutPanel1.Controls.Add(DownloadCoverButton, 1, 6);
            tableLayoutPanel1.Controls.Add(ContentDownloadButton, 1, 7);
            tableLayoutPanel1.Controls.Add(Description, 0, 5);
            tableLayoutPanel1.Controls.Add(label2, 2, 7);
            tableLayoutPanel1.Controls.Add(label3, 2, 6);
            tableLayoutPanel1.Location = new Point(5, 1);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.3481665F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.3481665F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.3481665F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.3481665F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.3481665F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.4609833F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.138689F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.2518063F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.4076929F));
            tableLayoutPanel1.Size = new Size(630, 494);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // Add_EditButton
            // 
            Add_EditButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Add_EditButton.Enabled = false;
            Add_EditButton.Location = new Point(148, 439);
            Add_EditButton.Name = "Add_EditButton";
            Add_EditButton.Size = new Size(240, 39);
            Add_EditButton.TabIndex = 40;
            Add_EditButton.Text = "Додавання_редагування";
            Add_EditButton.UseVisualStyleBackColor = true;
            Add_EditButton.Click += Add_EditButton_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label1, 0, 1);
            tableLayoutPanel4.Controls.Add(selectedCoverToAdd, 0, 0);
            tableLayoutPanel4.Location = new Point(394, 13);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel1.SetRowSpan(tableLayoutPanel4, 6);
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 91.42857F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 8.571428F));
            tableLayoutPanel4.Size = new Size(223, 321);
            tableLayoutPanel4.TabIndex = 39;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 297);
            label1.Name = "label1";
            label1.Size = new Size(217, 20);
            label1.TabIndex = 33;
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // selectedCoverToAdd
            // 
            selectedCoverToAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            selectedCoverToAdd.Location = new Point(3, 3);
            selectedCoverToAdd.Name = "selectedCoverToAdd";
            selectedCoverToAdd.Size = new Size(217, 287);
            selectedCoverToAdd.SizeMode = PictureBoxSizeMode.Zoom;
            selectedCoverToAdd.TabIndex = 32;
            selectedCoverToAdd.TabStop = false;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Title.AutoSize = true;
            Title.Location = new Point(13, 24);
            Title.Name = "Title";
            Title.Size = new Size(129, 20);
            Title.TabIndex = 10;
            Title.Text = "Назва";
            // 
            // Author
            // 
            Author.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Author.AutoSize = true;
            Author.Location = new Point(10, 73);
            Author.Margin = new Padding(0);
            Author.Name = "Author";
            Author.Size = new Size(135, 20);
            Author.TabIndex = 12;
            Author.Text = "Автор";
            // 
            // PublishingHouse
            // 
            PublishingHouse.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PublishingHouse.AutoSize = true;
            PublishingHouse.Location = new Point(10, 122);
            PublishingHouse.Margin = new Padding(0, 0, 3, 0);
            PublishingHouse.Name = "PublishingHouse";
            PublishingHouse.Size = new Size(132, 20);
            PublishingHouse.TabIndex = 14;
            PublishingHouse.Text = "Видавницвто";
            // 
            // YearOfPublication
            // 
            YearOfPublication.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            YearOfPublication.AutoSize = true;
            YearOfPublication.Location = new Point(13, 171);
            YearOfPublication.Name = "YearOfPublication";
            YearOfPublication.Size = new Size(129, 20);
            YearOfPublication.TabIndex = 15;
            YearOfPublication.Text = "Рік видання";
            // 
            // Genre
            // 
            Genre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Genre.AutoSize = true;
            Genre.Location = new Point(13, 220);
            Genre.Name = "Genre";
            Genre.Size = new Size(129, 20);
            Genre.TabIndex = 16;
            Genre.Text = "Жанр";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TitleTextBox.Location = new Point(148, 21);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(240, 27);
            TitleTextBox.TabIndex = 18;
            TitleTextBox.TextChanged += TitleTextBox_TextChanged_1;
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AuthorTextBox.Location = new Point(148, 70);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.Size = new Size(240, 27);
            AuthorTextBox.TabIndex = 19;
            AuthorTextBox.TextChanged += AuthorTextBox_TextChanged_1;
            // 
            // PublishingHouseTextBox
            // 
            PublishingHouseTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PublishingHouseTextBox.Location = new Point(148, 119);
            PublishingHouseTextBox.Name = "PublishingHouseTextBox";
            PublishingHouseTextBox.Size = new Size(240, 27);
            PublishingHouseTextBox.TabIndex = 20;
            PublishingHouseTextBox.TextChanged += PublishingHouseTextBox_TextChanged_1;
            // 
            // YearOfPublicationTextBox
            // 
            YearOfPublicationTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            YearOfPublicationTextBox.Location = new Point(148, 168);
            YearOfPublicationTextBox.Name = "YearOfPublicationTextBox";
            YearOfPublicationTextBox.Size = new Size(240, 27);
            YearOfPublicationTextBox.TabIndex = 21;
            YearOfPublicationTextBox.TextChanged += YearOfPublicationTextBox_TextChanged_1;
            // 
            // GenreComboBox
            // 
            GenreComboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            GenreComboBox.FormattingEnabled = true;
            GenreComboBox.Items.AddRange(new object[] { "Класична література", "Драматургія", "Казки", "Детективи", "Романи", "Фантастика", "Гумор", "Наука", "Кулінарія" });
            GenreComboBox.Location = new Point(148, 216);
            GenreComboBox.Name = "GenreComboBox";
            GenreComboBox.Size = new Size(240, 28);
            GenreComboBox.TabIndex = 26;
            GenreComboBox.SelectedIndexChanged += GenreComboBox_SelectedIndexChanged_1;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionTextBox.Location = new Point(148, 258);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.ScrollBars = ScrollBars.Vertical;
            DescriptionTextBox.Size = new Size(240, 76);
            DescriptionTextBox.TabIndex = 27;
            DescriptionTextBox.TextChanged += DescriptionTextBox_TextChanged_1;
            // 
            // DownloadCoverButton
            // 
            DownloadCoverButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DownloadCoverButton.Location = new Point(148, 347);
            DownloadCoverButton.Name = "DownloadCoverButton";
            DownloadCoverButton.Size = new Size(240, 27);
            DownloadCoverButton.TabIndex = 30;
            DownloadCoverButton.Text = "Загрузити обкладинку";
            DownloadCoverButton.UseVisualStyleBackColor = true;
            DownloadCoverButton.Click += DownloadCoverButton_Click_1;
            // 
            // ContentDownloadButton
            // 
            ContentDownloadButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ContentDownloadButton.Location = new Point(148, 395);
            ContentDownloadButton.Name = "ContentDownloadButton";
            ContentDownloadButton.Size = new Size(240, 27);
            ContentDownloadButton.TabIndex = 33;
            ContentDownloadButton.Text = "Загрузити вміст книги";
            ContentDownloadButton.UseVisualStyleBackColor = true;
            ContentDownloadButton.Click += ContentDownloadButton_Click_1;
            // 
            // Description
            // 
            Description.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Description.AutoSize = true;
            Description.Location = new Point(13, 286);
            Description.Name = "Description";
            Description.Size = new Size(129, 20);
            Description.TabIndex = 17;
            Description.Text = "Опис";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(394, 399);
            label2.Name = "label2";
            label2.Size = new Size(223, 20);
            label2.TabIndex = 41;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(394, 351);
            label3.Name = "label3";
            label3.Size = new Size(223, 20);
            label3.TabIndex = 42;
            // 
            // Add_EditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 498);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Add_EditForm";
            Text = "Додавання_Редагування";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)selectedCoverToAdd).EndInit();
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
        private Button DownloadCoverButton;
        private Button ContentDownloadButton;
        private PictureBox selectedCoverToAdd;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label1;
        private Button Add_EditButton;
        private Label label2;
        private Label label3;
    }
}