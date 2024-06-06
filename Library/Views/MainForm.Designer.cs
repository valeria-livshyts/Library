namespace Library
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            BookListView = new ListView();
            TitleHeader = new ColumnHeader();
            AuthorHeader = new ColumnHeader();
            PublishingHouseHeader = new ColumnHeader();
            YearOfPublicationHeader = new ColumnHeader();
            GenreHeader = new ColumnHeader();
            MarkHeader = new ColumnHeader();
            tableLayoutPanel3 = new TableLayoutPanel();
            SearchTextBox = new TextBox();
            SearchButton = new Button();
            RefreshButton = new Button();
            FullSearchButton = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            Cover = new PictureBox();
            TitleNameLabel = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            RemoveBookButton = new Button();
            EditBookButton = new Button();
            AddButton = new Button();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            ToolsToolStripMenuItem = new ToolStripMenuItem();
            FullSearchToolStripMenuItem = new ToolStripMenuItem();
            SearchToolStripMenuItem = new ToolStripMenuItem();
            ReferenceToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            AboutProjectToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Cover).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.1958771F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.80412F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel1.Controls.Add(TitleNameLabel, 0, 7);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 8);
            tableLayoutPanel1.ForeColor = SystemColors.ControlText;
            tableLayoutPanel1.Location = new Point(0, 31);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.93774F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.562704F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.183628F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.472666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.472666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.183628F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.917284F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.0571976F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.212487F));
            tableLayoutPanel1.Size = new Size(1045, 468);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(BookListView, 0, 0);
            tableLayoutPanel2.Location = new Point(250, 53);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel1.SetRowSpan(tableLayoutPanel2, 7);
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(782, 361);
            tableLayoutPanel2.TabIndex = 37;
            // 
            // BookListView
            // 
            BookListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BookListView.Columns.AddRange(new ColumnHeader[] { TitleHeader, AuthorHeader, PublishingHouseHeader, YearOfPublicationHeader, GenreHeader, MarkHeader });
            BookListView.FullRowSelect = true;
            BookListView.Location = new Point(3, 3);
            BookListView.Name = "BookListView";
            BookListView.Size = new Size(776, 355);
            BookListView.Sorting = SortOrder.Ascending;
            BookListView.TabIndex = 0;
            BookListView.UseCompatibleStateImageBehavior = false;
            BookListView.View = View.Details;
            BookListView.ColumnClick += BookListView_ColumnClick;
            BookListView.SelectedIndexChanged += BookListView_SelectedIndexChanged;
            BookListView.DoubleClick += BookListView_DoubleClick;
            BookListView.Leave += BookListView_Leave;
            // 
            // TitleHeader
            // 
            TitleHeader.Tag = "Title";
            TitleHeader.Text = "Назва";
            TitleHeader.Width = 140;
            // 
            // AuthorHeader
            // 
            AuthorHeader.Text = "Автор";
            AuthorHeader.Width = 117;
            // 
            // PublishingHouseHeader
            // 
            PublishingHouseHeader.Text = "Видавництво";
            PublishingHouseHeader.Width = 130;
            // 
            // YearOfPublicationHeader
            // 
            YearOfPublicationHeader.Text = "Рік видання";
            YearOfPublicationHeader.Width = 120;
            // 
            // GenreHeader
            // 
            GenreHeader.Text = "Жанр";
            GenreHeader.Width = 120;
            // 
            // MarkHeader
            // 
            MarkHeader.Text = "Рейтинг";
            MarkHeader.Width = 120;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.36842F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.6315784F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 118F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tableLayoutPanel3.Controls.Add(SearchTextBox, 0, 0);
            tableLayoutPanel3.Controls.Add(SearchButton, 1, 0);
            tableLayoutPanel3.Controls.Add(RefreshButton, 2, 0);
            tableLayoutPanel3.Controls.Add(FullSearchButton, 3, 0);
            tableLayoutPanel3.Location = new Point(250, 13);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(782, 34);
            tableLayoutPanel3.TabIndex = 28;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SearchTextBox.Location = new Point(3, 3);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.PlaceholderText = "Пошук";
            SearchTextBox.Size = new Size(373, 27);
            SearchTextBox.TabIndex = 0;
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // SearchButton
            // 
            SearchButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SearchButton.Enabled = false;
            SearchButton.Location = new Point(382, 3);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(118, 28);
            SearchButton.TabIndex = 1;
            SearchButton.Text = "Знайти";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // RefreshButton
            // 
            RefreshButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RefreshButton.Location = new Point(506, 3);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(112, 28);
            RefreshButton.TabIndex = 2;
            RefreshButton.Text = "Повернути";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // FullSearchButton
            // 
            FullSearchButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FullSearchButton.Location = new Point(624, 3);
            FullSearchButton.Name = "FullSearchButton";
            FullSearchButton.Size = new Size(155, 28);
            FullSearchButton.TabIndex = 3;
            FullSearchButton.Text = "Розширений пошук";
            FullSearchButton.UseVisualStyleBackColor = true;
            FullSearchButton.Click += FullSearchButton_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(Cover, 0, 0);
            tableLayoutPanel5.Location = new Point(25, 53);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel1.SetRowSpan(tableLayoutPanel5, 6);
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(206, 285);
            tableLayoutPanel5.TabIndex = 38;
            // 
            // Cover
            // 
            Cover.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Cover.Location = new Point(3, 3);
            Cover.Name = "Cover";
            Cover.Size = new Size(200, 279);
            Cover.SizeMode = PictureBoxSizeMode.Zoom;
            Cover.TabIndex = 30;
            Cover.TabStop = false;
            // 
            // TitleNameLabel
            // 
            TitleNameLabel.Anchor = AnchorStyles.Top;
            TitleNameLabel.AutoSize = true;
            TitleNameLabel.Location = new Point(128, 341);
            TitleNameLabel.Name = "TitleNameLabel";
            TitleNameLabel.Size = new Size(0, 20);
            TitleNameLabel.TabIndex = 39;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Controls.Add(RemoveBookButton, 2, 0);
            tableLayoutPanel4.Controls.Add(EditBookButton, 1, 0);
            tableLayoutPanel4.Controls.Add(AddButton, 0, 0);
            tableLayoutPanel4.Location = new Point(250, 420);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(782, 35);
            tableLayoutPanel4.TabIndex = 24;
            // 
            // RemoveBookButton
            // 
            RemoveBookButton.Anchor = AnchorStyles.Top;
            RemoveBookButton.Enabled = false;
            RemoveBookButton.Location = new Point(580, 3);
            RemoveBookButton.Name = "RemoveBookButton";
            RemoveBookButton.Size = new Size(142, 29);
            RemoveBookButton.TabIndex = 9;
            RemoveBookButton.Text = "Видалити";
            RemoveBookButton.UseVisualStyleBackColor = true;
            RemoveBookButton.Click += RemoveBookButton_Click;
            // 
            // EditBookButton
            // 
            EditBookButton.Anchor = AnchorStyles.Top;
            EditBookButton.Enabled = false;
            EditBookButton.Location = new Point(319, 3);
            EditBookButton.Name = "EditBookButton";
            EditBookButton.Size = new Size(142, 29);
            EditBookButton.TabIndex = 26;
            EditBookButton.Text = "Редагувати книгу";
            EditBookButton.UseVisualStyleBackColor = true;
            EditBookButton.Click += EditBookButton_Click;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Top;
            AddButton.Location = new Point(59, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(142, 29);
            AddButton.TabIndex = 36;
            AddButton.Text = "Додати книгу";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, ToolsToolStripMenuItem, ReferenceToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1045, 28);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ExitToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "&Файл";
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            ExitToolStripMenuItem.Size = new Size(182, 26);
            ExitToolStripMenuItem.Text = "Вихід";
            ExitToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // ToolsToolStripMenuItem
            // 
            ToolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { FullSearchToolStripMenuItem, SearchToolStripMenuItem });
            ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
            ToolsToolStripMenuItem.Size = new Size(69, 24);
            ToolsToolStripMenuItem.Text = "&Пошук";
            // 
            // FullSearchToolStripMenuItem
            // 
            FullSearchToolStripMenuItem.Name = "FullSearchToolStripMenuItem";
            FullSearchToolStripMenuItem.Size = new Size(229, 26);
            FullSearchToolStripMenuItem.Text = "&Загальний пошук";
            FullSearchToolStripMenuItem.Click += FullSearchToolStripMenuItem_Click;
            // 
            // SearchToolStripMenuItem
            // 
            SearchToolStripMenuItem.Name = "SearchToolStripMenuItem";
            SearchToolStripMenuItem.Size = new Size(229, 26);
            SearchToolStripMenuItem.Text = "&Розширений пошук";
            SearchToolStripMenuItem.Click += SearchToolStripMenuItem_Click;
            // 
            // ReferenceToolStripMenuItem
            // 
            ReferenceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator5, AboutProjectToolStripMenuItem });
            ReferenceToolStripMenuItem.Name = "ReferenceToolStripMenuItem";
            ReferenceToolStripMenuItem.Size = new Size(77, 24);
            ReferenceToolStripMenuItem.Text = "&Довідка";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(190, 6);
            // 
            // AboutProjectToolStripMenuItem
            // 
            AboutProjectToolStripMenuItem.Name = "AboutProjectToolStripMenuItem";
            AboutProjectToolStripMenuItem.Size = new Size(193, 26);
            AboutProjectToolStripMenuItem.Text = "&Про програму";
            AboutProjectToolStripMenuItem.Click += AboutProjectToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 504);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            Name = "MainForm";
            Text = "Бібліотека";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Cover).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private ToolStripMenuItem ToolsToolStripMenuItem;
        private ToolStripMenuItem FullSearchToolStripMenuItem;
        private ToolStripMenuItem SearchToolStripMenuItem;
        private ToolStripMenuItem ReferenceToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem AboutProjectToolStripMenuItem;
        private Button EditBookButton;
        private ListView BookListView;
        private ColumnHeader TitleHeader;
        private ColumnHeader AuthorHeader;
        private ColumnHeader PublishingHouseHeader;
        private ColumnHeader YearOfPublicationHeader;
        private ColumnHeader GenreHeader;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox SearchTextBox;
        private Button SearchButton;
        private Button RefreshButton;
        private Button AddButton;
        private TableLayoutPanel tableLayoutPanel4;
        private Button RemoveBookButton;
        private PictureBox Cover;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel5;
        private Label TitleNameLabel;
        private Button FullSearchButton;
        private ColumnHeader MarkHeader;
    }
}