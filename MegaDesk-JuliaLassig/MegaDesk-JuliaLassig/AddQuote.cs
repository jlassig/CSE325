using System;

using System.ComponentModel;
using System.Windows.Forms;

namespace MegaDesk_JuliaLassig
{
    public partial class AddQuote : Form
    {
        private Desk desk = new Desk();
        private int tryWidth;
        private int tryDepth;

        private bool widthIsRight = false;
        private bool depthIsRight = false;
        //private bool nameIsRight = false;
        //private bool drawerIsRight = false;
        //private bool materialIsRight = false;
        //private bool rushIsRight = false;
        public AddQuote()
        {
            InitializeComponent();
        }

        private void mainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }


        private void submitQuoteButton_Click(object sender, EventArgs e)
        {

            int numDrawers = Int32.Parse(numDrawersInput.Text);
            desk.NumDrawers= numDrawers;            
            string materialString = materialInput.Text;
            DeskTopMaterial material;
            bool materialIsEnum = false;
            do {
                if (Enum.TryParse(materialString, out material))
                {
                    desk.Material = material;
                    materialIsEnum = true;
                }
            } while (!materialIsEnum);

            string custName = custNameInput.Text;
            int rushChoice = Int32.Parse(rushOrderInput.Text);
            DateTime fullDate = DateTime.Now;
            DeskQuote deskQuote = new DeskQuote(custName, rushChoice, fullDate, desk);

            if (widthIsRight == true && depthIsRight == true)
            {
                DisplayQuote displayQuote = new DisplayQuote(desk, deskQuote);
                displayQuote.Tag = this;
                displayQuote.Show(this);
                displayQuote.Location = Location;
                Hide();
            }
            else 
            {

            }

        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            //// from this website: https://learn.microsoft.com/en-us/dotnet/api/system.globalization.datetimeformatinfo?view=net-7.0
            quoteDate.Text = today.ToString("MMM dd, yyyy");
            widthError.Visible = false;
            depthError.Visible = false;
            numDrawersInput.SelectedIndex = 0;
            materialInput.SelectedIndex = 0;
            rushOrderInput.SelectedIndex = 0;
        }


        private void widthInput_Validating(object sender, CancelEventArgs e)
        {

            try
            {
                tryWidth = Int32.Parse(widthInput.Text);

                if (tryWidth < Desk.MINWIDTH)
                {
                    widthError.Visible = true;
                    widthError.Text = "Min width is 24 inches. Try again.";
                    widthIsRight = false;
                }
                else if (tryWidth > Desk.MAXWIDTH)
                {
                    widthError.Visible = true;
                    widthError.Text = "Max width is 96 inches. Try again.";
                    widthIsRight= false;
                }
                else
                {
                    desk.Width = tryWidth;
                    widthIsRight = true;
                    widthError.Visible = false;
                }
                
            }
            catch(FormatException fe){
                widthError.Visible = true;
                widthError.Text = "Enter a number. Try again.";
                Console.WriteLine(fe.Message);
            }     
        }


        private void depthInput_KeyUp(object sender, KeyEventArgs e)
        {
            string depthString = "";
            bool depthIsNumbers = false;
            foreach (char c in depthInput.Text)
            {
                if (char.IsDigit(c) && !char.IsControl(c))
                {
                    depthString += c;
                    depthIsNumbers = true;

                }
                else
                {
                    depthIsNumbers = false;
                    depthError.Visible = true;
                    depthError.Text = "Enter a number. Try again.";
                    depthIsRight = false;
                }
            }

            if (depthIsNumbers)
            {
                tryDepth = Int32.Parse(depthString);
                {

                    if (tryDepth < Desk.MINDEPTH)
                    {
                        depthError.Visible = true;
                        depthError.Text = "Min depth is 12 inches. Try again.";
                        depthIsRight = false;
                    }
                    else if (tryDepth > Desk.MAXDEPTH)
                    {
                        depthError.Visible = true;
                        depthError.Text = "Max depth is 48 inches. Try again.";
                        depthIsRight = false;
                    }
                    else
                    {
                        desk.Depth = tryDepth;
                        depthIsRight = true;
                        depthError.Visible = false;
                    }
                }
            }            
        }

    }//end of AddQuoteClass
}
