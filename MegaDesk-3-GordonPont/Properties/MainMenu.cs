using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;  

namespace MegaDesk_3_GordonPont
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void createNewQuote_Click(object sender, EventArgs e)
        {
            //AddQuote addNewQuoteForm = new AddQuote();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide();
        }
    }
}
