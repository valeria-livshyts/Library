namespace Library
{
    partial class ShowInfoBookForm
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
            CoverImageBox = new PictureBox();
            TitleLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            GenreLabel = new Label();
            YearOfPublicationLabel = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            AuthorLabel = new Label();
            PublishingHouseLabel = new Label();
            label5 = new Label();
            DescriptionTextBox = new TextBox();
            panel1 = new Panel();
            ReviewListView = new ListView();
            AuthorHeader = new ColumnHeader();
            MarkHeader = new ColumnHeader();
            TextHeader = new ColumnHeader();
            MarkLabel = new Label();
            RemoveReviewButton = new Button();
            EditReviewButton = new Button();
            AddReviewButton = new Button();
            EditButton = new Button();
            OpenContentButton = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)CoverImageBox).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // CoverImageBox
            // 
            CoverImageBox.Location = new Point(7, 70);
            CoverImageBox.Name = "CoverImageBox";
            CoverImageBox.Size = new Size(212, 319);
            CoverImageBox.SizeMode = PictureBoxSizeMode.Zoom;
            CoverImageBox.TabIndex = 0;
            CoverImageBox.TabStop = false;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            TitleLabel.Location = new Point(26, 4);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(104, 41);
            TitleLabel.TabIndex = 1;
            TitleLabel.Text = "Назва";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.1844654F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.81554F));
            tableLayoutPanel1.Controls.Add(GenreLabel, 1, 3);
            tableLayoutPanel1.Controls.Add(YearOfPublicationLabel, 1, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(AuthorLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(PublishingHouseLabel, 1, 1);
            tableLayoutPanel1.Location = new Point(1, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(412, 142);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // GenreLabel
            // 
            GenreLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            GenreLabel.AutoSize = true;
            GenreLabel.Location = new Point(115, 113);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(294, 20);
            GenreLabel.TabIndex = 8;
            GenreLabel.Text = "Genre";
            GenreLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // YearOfPublicationLabel
            // 
            YearOfPublicationLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            YearOfPublicationLabel.AutoSize = true;
            YearOfPublicationLabel.Location = new Point(115, 77);
            YearOfPublicationLabel.Name = "YearOfPublicationLabel";
            YearOfPublicationLabel.Size = new Size(294, 20);
            YearOfPublicationLabel.TabIndex = 8;
            YearOfPublicationLabel.Text = "YearOfPublication";
            YearOfPublicationLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 42);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 4;
            label3.Text = "Видавництво:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 113);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 3;
            label2.Text = "Жанр:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 2;
            label1.Text = "Автор:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 77);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 5;
            label4.Text = "Рік видання:";
            // 
            // AuthorLabel
            // 
            AuthorLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AuthorLabel.AutoEllipsis = true;
            AuthorLabel.AutoSize = true;
            AuthorLabel.Location = new Point(115, 7);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(294, 20);
            AuthorLabel.TabIndex = 6;
            AuthorLabel.Text = "Author";
            AuthorLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PublishingHouseLabel
            // 
            PublishingHouseLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PublishingHouseLabel.AutoEllipsis = true;
            PublishingHouseLabel.Location = new Point(115, 42);
            PublishingHouseLabel.Name = "PublishingHouseLabel";
            PublishingHouseLabel.Size = new Size(294, 20);
            PublishingHouseLabel.TabIndex = 7;
            PublishingHouseLabel.Text = "PublishingHouse";
            PublishingHouseLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(184, 157);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 7;
            label5.Text = "Опис";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(1, 190);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.ReadOnly = true;
            DescriptionTextBox.ScrollBars = ScrollBars.Vertical;
            DescriptionTextBox.Size = new Size(409, 161);
            DescriptionTextBox.TabIndex = 9;
            DescriptionTextBox.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.Controls.Add(ReviewListView);
            panel1.Controls.Add(MarkLabel);
            panel1.Controls.Add(RemoveReviewButton);
            panel1.Controls.Add(EditReviewButton);
            panel1.Controls.Add(AddReviewButton);
            panel1.Controls.Add(EditButton);
            panel1.Controls.Add(OpenContentButton);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(TitleLabel);
            panel1.Controls.Add(CoverImageBox);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(676, 662);
            panel1.TabIndex = 10;
            // 
            // ReviewListView
            // 
            ReviewListView.Columns.AddRange(new ColumnHeader[] { AuthorHeader, MarkHeader, TextHeader });
            ReviewListView.FullRowSelect = true;
            ReviewListView.Location = new Point(51, 525);
            ReviewListView.Name = "ReviewListView";
            ReviewListView.Size = new Size(416, 134);
            ReviewListView.TabIndex = 18;
            ReviewListView.UseCompatibleStateImageBehavior = false;
            ReviewListView.View = View.Details;
            ReviewListView.SelectedIndexChanged += ReviewListView_SelectedIndexChanged;
            ReviewListView.Leave += ReviewListView_Leave;
            // 
            // AuthorHeader
            // 
            AuthorHeader.Text = "Автор";
            // 
            // MarkHeader
            // 
            MarkHeader.Text = "Оцінка книги";
            MarkHeader.Width = 120;
            // 
            // TextHeader
            // 
            TextHeader.Text = "Відгук";
            TextHeader.Width = 100;
            // 
            // MarkLabel
            // 
            MarkLabel.AutoSize = true;
            MarkLabel.Location = new Point(242, 430);
            MarkLabel.Name = "MarkLabel";
            MarkLabel.Size = new Size(42, 20);
            MarkLabel.TabIndex = 17;
            MarkLabel.Text = "Mark";
            // 
            // RemoveReviewButton
            // 
            RemoveReviewButton.Enabled = false;
            RemoveReviewButton.Location = new Point(536, 579);
            RemoveReviewButton.Name = "RemoveReviewButton";
            RemoveReviewButton.Size = new Size(137, 28);
            RemoveReviewButton.TabIndex = 16;
            RemoveReviewButton.Text = "Видалити відгук";
            RemoveReviewButton.UseVisualStyleBackColor = true;
            RemoveReviewButton.Click += RemoveReviewButton_Click;
            // 
            // EditReviewButton
            // 
            EditReviewButton.Enabled = false;
            EditReviewButton.Location = new Point(536, 622);
            EditReviewButton.Name = "EditReviewButton";
            EditReviewButton.Size = new Size(137, 28);
            EditReviewButton.TabIndex = 15;
            EditReviewButton.Text = "Редагувати відгук";
            EditReviewButton.UseVisualStyleBackColor = true;
            EditReviewButton.Click += EditReviewButton_Click;
            // 
            // AddReviewButton
            // 
            AddReviewButton.Location = new Point(536, 535);
            AddReviewButton.Name = "AddReviewButton";
            AddReviewButton.Size = new Size(137, 28);
            AddReviewButton.TabIndex = 14;
            AddReviewButton.Text = "Залишити відгук";
            AddReviewButton.UseVisualStyleBackColor = true;
            AddReviewButton.Click += AddReviewButton_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(7, 427);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(212, 26);
            EditButton.TabIndex = 12;
            EditButton.Text = "Редагувати";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // OpenContentButton
            // 
            OpenContentButton.Location = new Point(7, 395);
            OpenContentButton.Name = "OpenContentButton";
            OpenContentButton.Size = new Size(212, 26);
            OpenContentButton.TabIndex = 11;
            OpenContentButton.Text = "Читати книгу";
            OpenContentButton.UseVisualStyleBackColor = true;
            OpenContentButton.Click += OpenContentButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(DescriptionTextBox);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Location = new Point(238, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(415, 351);
            panel2.TabIndex = 10;
            // 
            // ShowInfoBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 681);
            Controls.Add(panel1);
            Name = "ShowInfoBookForm";
            Text = "Повна інформація про книгу";
            ((System.ComponentModel.ISupportInitialize)CoverImageBox).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox CoverImageBox;
        private Label TitleLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private Label GenreLabel;
        private Label YearOfPublicationLabel;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label AuthorLabel;
        private Label PublishingHouseLabel;
        private Label label5;
        private TextBox DescriptionTextBox;
        private Panel panel1;
        private Panel panel2;
        private Button OpenContentButton;
        private Button EditButton;
        private Button RemoveReviewButton;
        private Button EditReviewButton;
        private Button AddReviewButton;
        private Label MarkLabel;
        private ListView ReviewListView;
        private ColumnHeader AuthorHeader;
        private ColumnHeader MarkHeader;
        private ColumnHeader TextHeader;
    }
}