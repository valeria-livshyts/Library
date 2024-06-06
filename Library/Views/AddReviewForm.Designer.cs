namespace Library
{
    partial class AddReviewForm
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
            AuthorTextBox = new TextBox();
            MarkTextBox = new TextBox();
            ReviewTextBox = new TextBox();
            Add_EditReviewButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.Location = new Point(123, 19);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.PlaceholderText = "Введіть своє ім'я";
            AuthorTextBox.Size = new Size(239, 27);
            AuthorTextBox.TabIndex = 0;
            AuthorTextBox.TextChanged += AuthorTextBox_TextChanged;
            // 
            // MarkTextBox
            // 
            MarkTextBox.Location = new Point(123, 73);
            MarkTextBox.Name = "MarkTextBox";
            MarkTextBox.PlaceholderText = "Оцінка від 1 до 5";
            MarkTextBox.Size = new Size(239, 27);
            MarkTextBox.TabIndex = 1;
            MarkTextBox.TextChanged += MarkTextBox_TextChanged;
            // 
            // ReviewTextBox
            // 
            ReviewTextBox.Location = new Point(123, 134);
            ReviewTextBox.Multiline = true;
            ReviewTextBox.Name = "ReviewTextBox";
            ReviewTextBox.PlaceholderText = "Що Ви думаєте про цю книгу?";
            ReviewTextBox.ScrollBars = ScrollBars.Vertical;
            ReviewTextBox.Size = new Size(239, 68);
            ReviewTextBox.TabIndex = 2;
            ReviewTextBox.TextChanged += ReviewTextBox_TextChanged;
            // 
            // Add_EditReviewButton
            // 
            Add_EditReviewButton.Enabled = false;
            Add_EditReviewButton.Location = new Point(123, 229);
            Add_EditReviewButton.Name = "Add_EditReviewButton";
            Add_EditReviewButton.Size = new Size(239, 35);
            Add_EditReviewButton.TabIndex = 3;
            Add_EditReviewButton.Text = "Зберегти";
            Add_EditReviewButton.UseVisualStyleBackColor = true;
            Add_EditReviewButton.Click += Add_EditReviewButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 4;
            label1.Text = "Ваше ім'я";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 5;
            label2.Text = "Ваша оцінка";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 137);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 6;
            label3.Text = "Текст відгуку";
            // 
            // AddReviewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 288);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Add_EditReviewButton);
            Controls.Add(ReviewTextBox);
            Controls.Add(MarkTextBox);
            Controls.Add(AuthorTextBox);
            Name = "AddReviewForm";
            Text = "Відгуки";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AuthorTextBox;
        private TextBox MarkTextBox;
        private TextBox ReviewTextBox;
        private Button Add_EditReviewButton;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}