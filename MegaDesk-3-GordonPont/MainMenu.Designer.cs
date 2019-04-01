namespace MegaDesk_3_GordonPont
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.createNewQuote = new System.Windows.Forms.Button();
            this.megaDeskTitle = new System.Windows.Forms.TextBox();
            this.viewQuotes = new System.Windows.Forms.Button();
            this.searchQuotes = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // createNewQuote
            // 
            this.createNewQuote.Location = new System.Drawing.Point(102, 106);
            this.createNewQuote.Name = "createNewQuote";
            this.createNewQuote.Size = new System.Drawing.Size(229, 53);
            this.createNewQuote.TabIndex = 0;
            this.createNewQuote.Text = "Create New Quote";
            this.createNewQuote.UseVisualStyleBackColor = true;
            this.createNewQuote.Click += new System.EventHandler(this.createNewQuote_Click);
            // 
            // megaDeskTitle
            // 
            this.megaDeskTitle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.megaDeskTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.megaDeskTitle.Location = new System.Drawing.Point(281, 38);
            this.megaDeskTitle.Multiline = true;
            this.megaDeskTitle.Name = "megaDeskTitle";
            this.megaDeskTitle.Size = new System.Drawing.Size(261, 41);
            this.megaDeskTitle.TabIndex = 1;
            this.megaDeskTitle.Text = "Megadesk";
            this.megaDeskTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // viewQuotes
            // 
            this.viewQuotes.Location = new System.Drawing.Point(102, 170);
            this.viewQuotes.Name = "viewQuotes";
            this.viewQuotes.Size = new System.Drawing.Size(229, 53);
            this.viewQuotes.TabIndex = 2;
            this.viewQuotes.Text = "View Quotes";
            this.viewQuotes.UseVisualStyleBackColor = true;
            this.viewQuotes.Click += new System.EventHandler(this.viewQuotes_Click);
            // 
            // searchQuotes
            // 
            this.searchQuotes.Location = new System.Drawing.Point(102, 234);
            this.searchQuotes.Name = "searchQuotes";
            this.searchQuotes.Size = new System.Drawing.Size(229, 53);
            this.searchQuotes.TabIndex = 3;
            this.searchQuotes.Text = "Search Quotes";
            this.searchQuotes.UseVisualStyleBackColor = true;
            this.searchQuotes.Click += new System.EventHandler(this.searchQuotes_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(102, 298);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(229, 53);
            this.exit.TabIndex = 4;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(431, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 186);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.searchQuotes);
            this.Controls.Add(this.viewQuotes);
            this.Controls.Add(this.megaDeskTitle);
            this.Controls.Add(this.createNewQuote);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createNewQuote;
        private System.Windows.Forms.TextBox megaDeskTitle;
        private System.Windows.Forms.Button viewQuotes;
        private System.Windows.Forms.Button searchQuotes;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

