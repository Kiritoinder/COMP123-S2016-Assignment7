namespace Assignment7
{
    partial class OrderForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelButton = new System.Windows.Forms.Button();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.Categorylabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MoviePictureBox = new System.Windows.Forms.PictureBox();
            this.StreamButton = new System.Windows.Forms.Button();
            this.MovieSelectedGroupBox = new System.Windows.Forms.GroupBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.OrderGroupBox = new System.Windows.Forms.GroupBox();
            this.BuyCheckBox = new System.Windows.Forms.CheckBox();
            this.ExtraPriceLabel = new System.Windows.Forms.Label();
            this.ExtraPriceTextBox = new System.Windows.Forms.TextBox();
            this.SalesTaxTextBox = new System.Windows.Forms.TextBox();
            this.GrandTotalTextBox = new System.Windows.Forms.TextBox();
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.GrandTotalLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).BeginInit();
            this.MovieSelectedGroupBox.SuspendLayout();
            this.OrderGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(427, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.streamToolStripMenuItem,
            this.cancelToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // streamToolStripMenuItem
            // 
            this.streamToolStripMenuItem.Name = "streamToolStripMenuItem";
            this.streamToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.streamToolStripMenuItem.Text = "Stream";
            this.streamToolStripMenuItem.Click += new System.EventHandler(this.StreamButton_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(325, 420);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(7, 35);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.TitleTextBox.TabIndex = 3;
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Location = new System.Drawing.Point(7, 86);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.CategoryTextBox.TabIndex = 4;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(104, 13);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(46, 20);
            this.PriceTextBox.TabIndex = 5;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(6, 16);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(31, 13);
            this.PriceLabel.TabIndex = 6;
            this.PriceLabel.Text = "Price";
            // 
            // Categorylabel
            // 
            this.Categorylabel.AutoSize = true;
            this.Categorylabel.Location = new System.Drawing.Point(6, 67);
            this.Categorylabel.Name = "Categorylabel";
            this.Categorylabel.Size = new System.Drawing.Size(49, 13);
            this.Categorylabel.TabIndex = 7;
            this.Categorylabel.Text = "Category";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(6, 16);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(27, 13);
            this.TitleLabel.TabIndex = 8;
            this.TitleLabel.Text = "Title";
            // 
            // MoviePictureBox
            // 
            this.MoviePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MoviePictureBox.Location = new System.Drawing.Point(9, 117);
            this.MoviePictureBox.Name = "MoviePictureBox";
            this.MoviePictureBox.Size = new System.Drawing.Size(168, 216);
            this.MoviePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MoviePictureBox.TabIndex = 0;
            this.MoviePictureBox.TabStop = false;
            // 
            // StreamButton
            // 
            this.StreamButton.Location = new System.Drawing.Point(271, 381);
            this.StreamButton.Name = "StreamButton";
            this.StreamButton.Size = new System.Drawing.Size(75, 23);
            this.StreamButton.TabIndex = 9;
            this.StreamButton.Text = "Stream";
            this.StreamButton.UseVisualStyleBackColor = true;
            this.StreamButton.Click += new System.EventHandler(this.StreamButton_Click);
            // 
            // MovieSelectedGroupBox
            // 
            this.MovieSelectedGroupBox.Controls.Add(this.TitleLabel);
            this.MovieSelectedGroupBox.Controls.Add(this.MoviePictureBox);
            this.MovieSelectedGroupBox.Controls.Add(this.TitleTextBox);
            this.MovieSelectedGroupBox.Controls.Add(this.Categorylabel);
            this.MovieSelectedGroupBox.Controls.Add(this.CategoryTextBox);
            this.MovieSelectedGroupBox.Location = new System.Drawing.Point(13, 43);
            this.MovieSelectedGroupBox.Name = "MovieSelectedGroupBox";
            this.MovieSelectedGroupBox.Size = new System.Drawing.Size(200, 343);
            this.MovieSelectedGroupBox.TabIndex = 10;
            this.MovieSelectedGroupBox.TabStop = false;
            this.MovieSelectedGroupBox.Text = "Movie Selected";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(226, 420);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // OrderGroupBox
            // 
            this.OrderGroupBox.Controls.Add(this.BuyCheckBox);
            this.OrderGroupBox.Controls.Add(this.ExtraPriceLabel);
            this.OrderGroupBox.Controls.Add(this.ExtraPriceTextBox);
            this.OrderGroupBox.Controls.Add(this.SalesTaxTextBox);
            this.OrderGroupBox.Controls.Add(this.GrandTotalTextBox);
            this.OrderGroupBox.Controls.Add(this.SubTotalLabel);
            this.OrderGroupBox.Controls.Add(this.SubTotalTextBox);
            this.OrderGroupBox.Controls.Add(this.SalesTaxLabel);
            this.OrderGroupBox.Controls.Add(this.GrandTotalLabel);
            this.OrderGroupBox.Controls.Add(this.PriceLabel);
            this.OrderGroupBox.Controls.Add(this.PriceTextBox);
            this.OrderGroupBox.Location = new System.Drawing.Point(219, 43);
            this.OrderGroupBox.Name = "OrderGroupBox";
            this.OrderGroupBox.Size = new System.Drawing.Size(200, 258);
            this.OrderGroupBox.TabIndex = 11;
            this.OrderGroupBox.TabStop = false;
            this.OrderGroupBox.Text = "Your Order";
            // 
            // BuyCheckBox
            // 
            this.BuyCheckBox.AutoSize = true;
            this.BuyCheckBox.Location = new System.Drawing.Point(41, 158);
            this.BuyCheckBox.Name = "BuyCheckBox";
            this.BuyCheckBox.Size = new System.Drawing.Size(97, 30);
            this.BuyCheckBox.TabIndex = 17;
            this.BuyCheckBox.Text = "Buy the Movie \r\n(Extra $10)";
            this.BuyCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExtraPriceLabel
            // 
            this.ExtraPriceLabel.AutoSize = true;
            this.ExtraPriceLabel.Location = new System.Drawing.Point(6, 43);
            this.ExtraPriceLabel.Name = "ExtraPriceLabel";
            this.ExtraPriceLabel.Size = new System.Drawing.Size(58, 13);
            this.ExtraPriceLabel.TabIndex = 16;
            this.ExtraPriceLabel.Text = "Extra Price";
            this.ExtraPriceLabel.Visible = false;
            // 
            // ExtraPriceTextBox
            // 
            this.ExtraPriceTextBox.Location = new System.Drawing.Point(104, 40);
            this.ExtraPriceTextBox.Name = "ExtraPriceTextBox";
            this.ExtraPriceTextBox.ReadOnly = true;
            this.ExtraPriceTextBox.Size = new System.Drawing.Size(46, 20);
            this.ExtraPriceTextBox.TabIndex = 15;
            this.ExtraPriceTextBox.Visible = false;
            // 
            // SalesTaxTextBox
            // 
            this.SalesTaxTextBox.Location = new System.Drawing.Point(104, 96);
            this.SalesTaxTextBox.Name = "SalesTaxTextBox";
            this.SalesTaxTextBox.Size = new System.Drawing.Size(46, 20);
            this.SalesTaxTextBox.TabIndex = 14;
            // 
            // GrandTotalTextBox
            // 
            this.GrandTotalTextBox.Location = new System.Drawing.Point(104, 122);
            this.GrandTotalTextBox.Name = "GrandTotalTextBox";
            this.GrandTotalTextBox.Size = new System.Drawing.Size(46, 20);
            this.GrandTotalTextBox.TabIndex = 13;
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Location = new System.Drawing.Point(6, 71);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(53, 13);
            this.SubTotalLabel.TabIndex = 12;
            this.SubTotalLabel.Text = "Sub Total";
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.Location = new System.Drawing.Point(104, 68);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.Size = new System.Drawing.Size(46, 20);
            this.SubTotalTextBox.TabIndex = 11;
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Location = new System.Drawing.Point(6, 96);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(86, 13);
            this.SalesTaxLabel.TabIndex = 10;
            this.SalesTaxLabel.Text = "Sales Tax  (13%)";
            // 
            // GrandTotalLabel
            // 
            this.GrandTotalLabel.AutoSize = true;
            this.GrandTotalLabel.Location = new System.Drawing.Point(6, 122);
            this.GrandTotalLabel.Name = "GrandTotalLabel";
            this.GrandTotalLabel.Size = new System.Drawing.Size(63, 13);
            this.GrandTotalLabel.TabIndex = 8;
            this.GrandTotalLabel.Text = "Grand Total";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 471);
            this.ControlBox = false;
            this.Controls.Add(this.OrderGroupBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.MovieSelectedGroupBox);
            this.Controls.Add(this.StreamButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).EndInit();
            this.MovieSelectedGroupBox.ResumeLayout(false);
            this.MovieSelectedGroupBox.PerformLayout();
            this.OrderGroupBox.ResumeLayout(false);
            this.OrderGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MoviePictureBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem streamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label Categorylabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button StreamButton;
        private System.Windows.Forms.GroupBox MovieSelectedGroupBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.GroupBox OrderGroupBox;
        private System.Windows.Forms.CheckBox BuyCheckBox;
        private System.Windows.Forms.Label ExtraPriceLabel;
        private System.Windows.Forms.TextBox SalesTaxTextBox;
        private System.Windows.Forms.TextBox GrandTotalTextBox;
        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.TextBox SubTotalTextBox;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.Label GrandTotalLabel;
        public System.Windows.Forms.TextBox ExtraPriceTextBox;
    }
}