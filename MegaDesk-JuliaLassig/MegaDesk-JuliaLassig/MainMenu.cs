using System;
using System.Windows.Forms;

namespace MegaDesk_JuliaLassig
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        //navigating between forms:
        #region
        private void addQuote_Click(object sender, EventArgs e)
        {
            AddQuote addQuote = new AddQuote();
            addQuote.Tag= this;
            addQuote.Show(this);
            addQuote.Location = Location;
            Hide();

        }

        private void viewQuotes_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewQuotes = new ViewAllQuotes();
            viewQuotes.Tag = this;
            viewQuotes.Show(this);
            viewQuotes.Location = Location;
            Hide();
        }

        private void searchQuotes_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotes = new SearchQuotes();
            searchQuotes.Tag = this;
            searchQuotes.Show(this);
            searchQuotes.Location = Location;   
            Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //https://stackoverflow.com/questions/8507978/exiting-a-c-sharp-winforms-application
            Application.Exit();
        }
        #endregion
    }
}
