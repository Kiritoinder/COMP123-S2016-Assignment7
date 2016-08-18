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
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 513);
            this.Controls.Add(this.CategoryList);
            this.Controls.Add(this.MoviesList);
            this.Name = "SelectionForm";
            this.Text = "Movies";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Movies_FormClosed);
            this.Load += new System.EventHandler(this.Movies_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox MoviesList;
        private System.Windows.Forms.ListBox CategoryList;
    }
}