namespace MegaDesk_3_GordonPont
{
    partial class AddQuote
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
        /// the conte
        /// nts of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.TextBox();
            this.requestForName = new System.Windows.Forms.Label();
            this.requestWidth = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.TextBox();
            this.requestDepth = new System.Windows.Forms.Label();
            this.depth = new System.Windows.Forms.TextBox();
            this.requestDrawerNumbers = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.drawers = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.radio7 = new System.Windows.Forms.RadioButton();
            this.radio5 = new System.Windows.Forms.RadioButton();
            this.radioNone = new System.Windows.Forms.RadioButton();
            this.Material = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(0, 9);
            this.title.MinimumSize = new System.Drawing.Size(150, 50);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(700, 91);
            this.title.TabIndex = 0;
            this.title.Text = "Create a New Desk Quote";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(199, 107);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(315, 22);
            this.customerName.TabIndex = 2;
            // 
            // requestForName
            // 
            this.requestForName.Location = new System.Drawing.Point(0, 67);
            this.requestForName.Name = "requestForName";
            this.requestForName.Size = new System.Drawing.Size(703, 37);
            this.requestForName.TabIndex = 3;
            this.requestForName.Text = "Enter your Name:";
            this.requestForName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // requestWidth
            // 
            this.requestWidth.Location = new System.Drawing.Point(5, 132);
            this.requestWidth.Name = "requestWidth";
            this.requestWidth.Size = new System.Drawing.Size(703, 37);
            this.requestWidth.TabIndex = 5;
            this.requestWidth.Text = "Enter the Width of the desk(Min: 24 Inches | Max: 96 Inches)";
            this.requestWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(199, 172);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(315, 22);
            this.width.TabIndex = 4;
            this.width.Validating += new System.ComponentModel.CancelEventHandler(this.widthValidation);
            // 
            // requestDepth
            // 
            this.requestDepth.Location = new System.Drawing.Point(0, 197);
            this.requestDepth.Name = "requestDepth";
            this.requestDepth.Size = new System.Drawing.Size(703, 37);
            this.requestDepth.TabIndex = 7;
            this.requestDepth.Text = "Enter the Depth of the Desk(Min: 12 Inches | Max: 56 Inches)";
            this.requestDepth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // depth
            // 
            this.depth.Location = new System.Drawing.Point(199, 237);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(315, 22);
            this.depth.TabIndex = 6;
            this.depth.Validating += new System.ComponentModel.CancelEventHandler(this.depth_Validating);
            // 
            // requestDrawerNumbers
            // 
            this.requestDrawerNumbers.Location = new System.Drawing.Point(0, 262);
            this.requestDrawerNumbers.Name = "requestDrawerNumbers";
            this.requestDrawerNumbers.Size = new System.Drawing.Size(703, 37);
            this.requestDrawerNumbers.TabIndex = 9;
            this.requestDrawerNumbers.Text = "Select the Number of Drawers: ";
            this.requestDrawerNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(703, 37);
            this.label5.TabIndex = 13;
            this.label5.Text = "Rush Order: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drawers
            // 
            this.drawers.FormattingEnabled = true;
            this.drawers.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.drawers.Location = new System.Drawing.Point(204, 303);
            this.drawers.Name = "drawers";
            this.drawers.Size = new System.Drawing.Size(315, 24);
            this.drawers.TabIndex = 14;
            this.drawers.Text = " ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(394, 478);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(98, 36);
            this.Exit.TabIndex = 17;
            this.Exit.Text = "Cancel";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Location = new System.Drawing.Point(296, 438);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(73, 21);
            this.radio3.TabIndex = 18;
            this.radio3.TabStop = true;
            this.radio3.Text = "3 Days";
            this.radio3.UseVisualStyleBackColor = true;
            // 
            // radio7
            // 
            this.radio7.AutoSize = true;
            this.radio7.Location = new System.Drawing.Point(461, 438);
            this.radio7.Name = "radio7";
            this.radio7.Size = new System.Drawing.Size(73, 21);
            this.radio7.TabIndex = 19;
            this.radio7.TabStop = true;
            this.radio7.Text = "7 Days";
            this.radio7.UseVisualStyleBackColor = true;
            // 
            // radio5
            // 
            this.radio5.AutoSize = true;
            this.radio5.Location = new System.Drawing.Point(382, 438);
            this.radio5.Name = "radio5";
            this.radio5.Size = new System.Drawing.Size(73, 21);
            this.radio5.TabIndex = 20;
            this.radio5.TabStop = true;
            this.radio5.Text = "5 Days";
            this.radio5.UseVisualStyleBackColor = true;
            // 
            // radioNone
            // 
            this.radioNone.AutoSize = true;
            this.radioNone.Cursor = System.Windows.Forms.Cursors.Default;
            this.radioNone.Location = new System.Drawing.Point(224, 438);
            this.radioNone.Name = "radioNone";
            this.radioNone.Size = new System.Drawing.Size(63, 21);
            this.radioNone.TabIndex = 21;
            this.radioNone.TabStop = true;
            this.radioNone.Text = "None";
            this.radioNone.UseVisualStyleBackColor = true;
            // 
            // Material
            // 
            this.Material.FormattingEnabled = true;
            this.Material.Items.AddRange(new object[] {
            "Pine",
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer"});
            this.Material.Location = new System.Drawing.Point(204, 371);
            this.Material.Name = "Material";
            this.Material.Size = new System.Drawing.Size(315, 24);
            this.Material.TabIndex = 23;
            this.Material.Text = " ";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(703, 37);
            this.label1.TabIndex = 22;
            this.label1.Text = "Select the Material:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 554);
            this.Controls.Add(this.Material);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioNone);
            this.Controls.Add(this.radio5);
            this.Controls.Add(this.radio7);
            this.Controls.Add(this.radio3);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.drawers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.requestDrawerNumbers);
            this.Controls.Add(this.requestDepth);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.requestWidth);
            this.Controls.Add(this.width);
            this.Controls.Add(this.requestForName);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.title);
            this.Name = "AddQuote";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.Label requestForName;
        private System.Windows.Forms.Label requestWidth;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.Label requestDepth;
        private System.Windows.Forms.TextBox depth;
        private System.Windows.Forms.Label requestDrawerNumbers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox drawers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.RadioButton radio7;
        private System.Windows.Forms.RadioButton radio5;
        private System.Windows.Forms.RadioButton radioNone;
        private System.Windows.Forms.ComboBox Material;
        private System.Windows.Forms.Label label1;
    }
}