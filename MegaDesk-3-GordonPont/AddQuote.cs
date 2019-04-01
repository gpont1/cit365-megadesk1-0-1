using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MegaDesk_GordonPont;

namespace MegaDesk_3_GordonPont
{
    public partial class AddQuote : Form
    {

        public string name = String.Empty;
        int deskWidth = 0;
        int deskDepth = 0;
        int totalDrawers = 0;
        int rushDays = 0;
        int QuoteTotal = 0;
        Desk.Material Materials;
        private const string QUOTEFILE = @"quotes.csv";

        public AddQuote()
        {
            InitializeComponent();
            List<Desk.Material> Materials = Enum.GetValues(typeof(Desk.Material)).Cast<Desk.Material>().ToList();
            Material.DataSource = Materials;
        }

        private void widthValidation(object sender, CancelEventArgs e)
        {
            if (int.TryParse(width.Text, out int WidthInput) == true)
            {
                if (WidthInput < Desk.MINWIDTH || WidthInput > Desk.MAXWIDTH)
                {
                    MessageBox.Show("Please enter a width from " + Desk.MINWIDTH + " to " + Desk.MAXWIDTH + " inches");
                    width.Text = String.Empty;
                    width.BackColor = Color.DarkRed;
                    width.Focus();
                }
                else
                {
                    width.BackColor = System.Drawing.SystemColors.Window;
                }
            }
            else if (int.TryParse(width.Text, out WidthInput) == false && width.Text.Length != 0)
            {
                MessageBox.Show("Please enter a number");
                width.Text = String.Empty;
                width.BackColor = Color.DarkRed;
                width.Focus();
            }
            else

                width.BackColor = System.Drawing.SystemColors.Window;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)  
        {
            try 
            {
                name = customerName.Text;
                deskWidth = int.Parse(width.Text);
                deskDepth = int.Parse(depth.Text);
                totalDrawers = int.Parse(drawers.Text);
                Materials = (Desk.Material)Material.SelectedValue;

                // Get rush order days base on radio box selections
                if (radioNone.Checked)
                {
                    rushDays = 0;
                }
                if (radio3.Checked)
                {
                    rushDays = 3;
                }
                if (radio5.Checked)
                {
                    rushDays = 5;
                }
                if (radio7.Checked)
                {
                    rushDays = 7;
                }

                // create new deskOrder and calcQuote
                DeskQuote NewQuote = new DeskQuote(name, DateTime.Now, deskWidth, deskDepth, totalDrawers, Materials, rushDays);
                QuoteTotal = NewQuote.CalcQuote();

                //build string to quote save to file
                string DeskFileWrite = customerName + "," + DateTime.Now + "," + width + "," + depth + "," + drawers + "," + Material + "," + rushDays + "," + QuoteTotal;

                if (!File.Exists(QUOTEFILE))
                {
                    using (StreamWriter writer = File.CreateText(QUOTEFILE)) { writer.WriteLine(DeskFileWrite); }
                }
                else
                {
                    using (StreamWriter writer = File.AppendText(QUOTEFILE)) { writer.WriteLine(DeskFileWrite); }

                    MessageBox.Show("Quote Submitted");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Saving Quote Failed");
            }

           
            }

        private void depth_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(depth.Text, out int DepthInput) == true)
            {
                if (DepthInput < Desk.MINDEPTH || DepthInput > Desk.MAXDEPTH)
                {
                    MessageBox.Show("Please enter a depth from " + Desk.MINDEPTH + " to " + Desk.MAXDEPTH + " inches");
                    depth.Text = String.Empty;
                    depth.BackColor = Color.DarkRed;
                    depth.Focus();
                }
                else
                {
                    depth.BackColor = System.Drawing.SystemColors.Window;
                }
            }
            else if (int.TryParse(width.Text, out DepthInput) == false && width.Text.Length != 0)
            {
                MessageBox.Show("Please enter a number");
                depth.Text = String.Empty;
                depth.BackColor = Color.DarkRed;
                depth.Focus();
            }
            else

                depth.BackColor = System.Drawing.SystemColors.Window;
        }
    }
    }

        