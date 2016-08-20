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
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.PriceList = new System.Windows.Forms.ListBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.Categorylabel = new System.Windows.Forms.Label();
            this.Pricelabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.CategoryPriceListBox = new System.Windows.Forms.ListBox();
            this.MoviePictureBox = new System.Windows.Forms.PictureBox();
            this.SelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).BeginInit();
            this.SelectionGroupBox.SuspendLayout();
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
            this.CategoryList.Enabled = false;
            this.CategoryList.FormattingEnabled = true;
            this.CategoryList.Location = new System.Drawing.Point(138, 31);
            this.CategoryList.Name = "CategoryList";
            this.CategoryList.Size = new System.Drawing.Size(120, 290);
            this.CategoryList.TabIndex = 0;
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.Location = new System.Drawing.Point(6, 27);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(27, 13);
            this.Titlelabel.TabIndex = 2;
            this.Titlelabel.Text = "Title";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(64, 24);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.ReadOnly = true;
            this.TitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.TitleTextBox.TabIndex = 3;
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Location = new System.Drawing.Point(64, 96);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.ReadOnly = true;
            this.CategoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.CategoryTextBox.TabIndex = 4;
            // 
            // PriceList
            // 
            this.PriceList.Enabled = false;
            this.PriceList.FormattingEnabled = true;
            this.PriceList.Location = new System.Drawing.Point(381, 31);
            this.PriceList.Name = "PriceList";
            this.PriceList.Size = new System.Drawing.Size(68, 147);
            this.PriceList.TabIndex = 5;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(64, 169);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.ReadOnly = true;
            this.PriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.PriceTextBox.TabIndex = 6;
            // 
            // Categorylabel
            // 
            this.Categorylabel.AutoSize = true;
            this.Categorylabel.Location = new System.Drawing.Point(6, 96);
            this.Categorylabel.Name = "Categorylabel";
            this.Categorylabel.Size = new System.Drawing.Size(49, 13);
            this.Categorylabel.TabIndex = 7;
            this.Categorylabel.Text = "Category";
            // 
            // Pricelabel
            // 
            this.Pricelabel.AutoSize = true;
            this.Pricelabel.Location = new System.Drawing.Point(6, 172);
            this.Pricelabel.Name = "Pricelabel";
            this.Pricelabel.Size = new System.Drawing.Size(31, 13);
            this.Pricelabel.TabIndex = 8;
            this.Pricelabel.Text = "Price";
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(374, 478);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 9;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // CategoryPriceListBox
            // 
            this.CategoryPriceListBox.Enabled = false;
            this.CategoryPriceListBox.FormattingEnabled = true;
            this.CategoryPriceListBox.Location = new System.Drawing.Point(318, 31);
            this.CategoryPriceListBox.Name = "CategoryPriceListBox";
            this.CategoryPriceListBox.Size = new System.Drawing.Size(68, 147);
            this.CategoryPriceListBox.TabIndex = 10;
            // 
            // MoviePictureBox
            // 
            this.MoviePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MoviePictureBox.Location = new System.Drawing.Point(13, 355);
            this.MoviePictureBox.Name = "MoviePictureBox";
            this.MoviePictureBox.Size = new System.Drawing.Size(120, 146);
            this.MoviePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MoviePictureBox.TabIndex = 1;
            this.MoviePictureBox.TabStop = false;
            this.MoviePictureBox.Click += new System.EventHandler(this.MoviePictureBox_Click);
            // 
            // SelectionGroupBox
            // 
            this.SelectionGroupBox.Controls.Add(this.Titlelabel);
            this.SelectionGroupBox.Controls.Add(this.TitleTextBox);
            this.SelectionGroupBox.Controls.Add(this.CategoryTextBox);
            this.SelectionGroupBox.Controls.Add(this.Pricelabel);
            this.SelectionGroupBox.Controls.Add(this.PriceTextBox);
            this.SelectionGroupBox.Controls.Add(this.Categorylabel);
            this.SelectionGroupBox.Location = new System.Drawing.Point(283, 219);
            this.SelectionGroupBox.Name = "SelectionGroupBox";
            this.SelectionGroupBox.Size = new System.Drawing.Size(166, 205);
            this.SelectionGroupBox.TabIndex = 11;
            this.SelectionGroupBox.TabStop = false;
            this.SelectionGroupBox.Text = "Selection";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(283, 478);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 513);
            this.ControlBox = false;
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SelectionGroupBox);
            this.Controls.Add(this.CategoryPriceListBox);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PriceList);
            this.Controls.Add(this.MoviePictureBox);
            this.Controls.Add(this.CategoryList);
            this.Controls.Add(this.MoviesList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectionForm";
            this.Text = "Movies";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Movies_FormClosed);
            this.Load += new System.EventHandler(this.Movies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).EndInit();
            this.SelectionGroupBox.ResumeLayout(false);
            this.SelectionGroupBox.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ListBox CategoryPriceListBox;
        private System.Windows.Forms.GroupBox SelectionGroupBox;
        private System.Windows.Forms.Button ExitButton;
    }
}