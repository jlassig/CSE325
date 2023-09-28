using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_JuliaLassig
{
    public class DeskQuote
    {
        private string custName;
        private int rushOrderChoice;
        private DateTime fullDate;
        private Desk desk;
        public const decimal BASEDESKPRICE = 200;
        public const decimal EXTRAAREAPRICE = 1;
        public const decimal DRAWERPRICE = 50;

        public DeskQuote(string custName, int rushOrderChoice, DateTime fullDate, Desk desk)
        {
            this.custName = custName;
            this.rushOrderChoice = rushOrderChoice;
            this.fullDate = fullDate;
            this.desk= desk;


        }
        //getters and setters
        #region
        public string CustName
        {
            get { return custName; }
            set { custName = value; }
        }
        public string QuoteDate
        {
            get { return fullDate.ToString("MMM dd, yyyy"); }
        }
        public int RushOrder
        {
            get { return rushOrderChoice; }
        }

        #endregion

        public decimal GetTotalPrice()
        {
            //math equation like so that gets the total price:
            
            decimal totalPrice = GetDeskPrice() + GetRushPrice();

            return totalPrice;
        }

        public decimal GetDeskPrice()
        {
            decimal deckPrice = BASEDESKPRICE + GetAreaPrice() + GetDrawersPrice() +GetMaterialPrice();
            return deckPrice;
        }


        public decimal GetAreaPrice()
        {
            decimal areaPrice = EXTRAAREAPRICE* desk.GetDesktopArea();
            return areaPrice;
        }

        public decimal GetDrawersPrice()
        {
            decimal drawerTotalPrice = DRAWERPRICE * desk.NumDrawers;
            
            return drawerTotalPrice; 
        }


        public decimal GetMaterialPrice()
        {
            decimal materialPrice = 0;
            // switch case for all the materials. Set the materialPrice to the correct number in each case.
            switch (desk.Material)
            {
                case DeskTopMaterial.laminate:
                    materialPrice = 100;
                    break;
                case DeskTopMaterial.oak:
                    materialPrice = 200;
                    break;
                case DeskTopMaterial.rosewood:
                    materialPrice = 300;
                    break;
                case DeskTopMaterial.veneer:
                    materialPrice = 125;
                    break;
                default:  //this is for pine
                    materialPrice = 50;
                    break;
            }
            return materialPrice;
        }
  

        public decimal GetRushPrice()
        {
            decimal rushPrice = 0;
            string size = GetAreaRange();       
            
            switch(rushOrderChoice)
            {
                case (3):
                    if(size == "small")
                    {
                        rushPrice = 60;
                    }
                    else if(size == "mid")
                    {
                        rushPrice = 70;
                    }
                    else
                    {
                        rushPrice= 80;
                    }
                    break;
                case (5):
                    if (size == "small")
                    {
                        rushPrice = 40;
                    }
                    else if (size == "mid")
                    {
                        rushPrice = 50;
                    }
                    else
                    {
                        rushPrice = 60;
                    }
                    break;
                    case (7):
                    if (size == "small")
                    {
                        rushPrice = 30;
                    }
                    else if (size == "mid")
                    {
                        rushPrice = 35;
                    }
                    else
                    {
                        rushPrice = 40;
                    }
                    break;
                default:
                    rushPrice = 0;
                    break;

            }
            return rushPrice;

        }

        public string GetAreaRange()
        {
            string size = "";
            if(desk.GetDesktopArea() < 1000)
            {
                size = "small";

            }
            else if(desk.GetDesktopArea()>= 1000 && desk.GetDesktopArea()<=2000)
            {
                size = "mid";
            }
            else
            {
                size = "large";
            }
            return size;
        }









    }
}
