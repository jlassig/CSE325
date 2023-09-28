using System;
using System.Windows.Forms;

namespace MegaDesk_JuliaLassig
{
    public partial class DisplayQuote : Form
    {
        private Desk desk;
        private DeskQuote deskQuote;
        public DisplayQuote(Desk desk, DeskQuote deskQuote)
        {
            InitializeComponent();

            this.desk = desk;
            this.deskQuote = deskQuote;

        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            quoteDate.Text = deskQuote.QuoteDate;
            customerName.Text = deskQuote.CustName;
            totPrice.Text = $"${Convert.ToString(deskQuote.GetTotalPrice())}";
            deskWidth.Text = Convert.ToString(desk.Width);
            deskDepth.Text = Convert.ToString(desk.Depth);
            numDrawers.Text = Convert.ToString(desk.NumDrawers);
            material.Text = Convert.ToString(desk.Material);
            rushOrder.Text = Convert.ToString(deskQuote.RushOrder);
            desktopArea.Text = Convert.ToString(desk.GetDesktopArea());
            areaPrice.Text = Convert.ToString(deskQuote.GetAreaPrice());
            drawersPrice.Text = Convert.ToString(deskQuote.GetDrawersPrice());
            materialPrice.Text = Convert.ToString(deskQuote.GetMaterialPrice());
            rushPrice.Text = Convert.ToString(deskQuote.GetRushPrice());
            baseDeskPrice.Text = Convert.ToString(DeskQuote.BASEDESKPRICE);

        }

        private void mainMenu_Click(object sender, EventArgs e)
        {
            AddQuote addQuote = (AddQuote)Tag;
            addQuote.Show();
            addQuote.Location = Location;
            Close();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            mainMenu.Location = addQuote.Location;
            addQuote.Close();
        }

    }
}
