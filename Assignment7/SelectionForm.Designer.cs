namespace Assignment7
{
    partial class SelectionForm
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
            this.MoviesList = new System.Windows.Forms.ListBox();
            this.CategoryList = new System.Windows.Forms.ListBox();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.MoviePictureBox = new System.Windows.Forms.PictureBox();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.PriceList = new System.Windows.Forms.ListBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.Categorylabel = new System.Windows.Forms.Label();
            this.Pricelabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MoviesList
            // 
            this.MoviesList.FormattingEnabled = true;
            this.MoviesList.Location = new System.Drawing.Point(12, 31);
            this.MoviesList.Name = "MoviesList";
            this.MoviesList.Size = new System.Drawing.Size(130, 290);
            this.MoviesList.TabIndex = 0;
            this.MoviesList.SelectedIndexChanged += new System.EventHandler(this.MoviesList_SelectedIndexChanged);
            // 
            // CategoryList
            // 
            this.CategoryList.FormattingEnabled = true;
            this.CategoryList.Location = new System.Drawing.Point(138, 31);
            this.CategoryList.Name = "CategoryList";
            this.CategoryList.Size = new System.Drawing.Size(120, 290);
            this.CategoryList.TabIndex = 0;
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.Location = new System.Drawing.Point(274, 204);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(27, 13);
            this.Titlelabel.TabIndex = 2;
            this.Titlelabel.Text = "Title";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(277, 237);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.TitleTextBox.TabIndex = 3;
            // 
            // MoviePictureBox
            // 
            this.MoviePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MoviePictureBox.Location = new System.Drawing.Point(13, 355);
            this.MoviePictureBox.Name = "MoviePictureBox";
            this.MoviePictureBox.Size = new System.Drawing.Size(120, 146);
            this.MoviePictureBox.TabIndex = 1;
            this.MoviePictureBox.TabStop = false;
            this.MoviePictureBox.Click += new System.EventHandler(this.MoviePictureBox_Click);
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Location = new System.Drawing.Point(277, 301);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.CategoryTextBox.TabIndex = 4;
            // 
            // PriceList
            // 
            this.PriceList.FormattingEnabled = true;
            this.PriceList.Location = new System.Drawing.Point(277, 31);
            this.PriceList.Name = "PriceList";
            this.PriceList.Size = new System.Drawing.Size(120, 147);
            this.PriceList.TabIndex = 5;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(277, 368);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.PriceTextBox.TabIndex = 6;
            // 
            // Categorylabel
            // 
            this.Categorylabel.AutoSize = true;
            this.Categorylabel.Location = new System.Drawing.Point(274, 273);
            this.Categorylabel.Name = "Categorylabel";
            this.Categorylabel.Size = new System.Drawing.Size(49, 13);
            this.Categorylabel.TabIndex = 7;
            this.Categorylabel.Text = "Category";
            // 
            // Pricelabel
            // 
            this.Pricelabel.AutoSize = true;
            this.Pricelabel.Location = new System.Drawing.Point(277, 349);
            this.Pricelabel.Name = "Pricelabel";
            this.Pricelabel.Size = new System.Drawing.Size(31, 13);
            this.Pricelabel.TabIndex = 8;
            this.Pricelabel.Text = "Price";
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(277, 469);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 9;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 513);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.Pricelabel);
            this.Controls.Add(this.Categorylabel);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.PriceList);
            this.Controls.Add(this.CategoryTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.Titlelabel);
            this.Controls.Add(this.MoviePictureBox);
            this.Controls.Add(this.CategoryList);
            this.Controls.Add(this.MoviesList);
            this.Name = "SelectionForm";
            this.Text = "Movies";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Movies_FormClosed);
            this.Load += new System.EventHandler(this.Movies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MoviesList;
        private System.Windows.Forms.ListBox CategoryList;
        private System.Windows.Forms.PictureBox MoviePictureBox;
        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.ListBox PriceList;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label Categorylabel;
        private System.Windows.Forms.Label Pricelabel;
        private System.Windows.Forms.Button NextButton;
    }
}