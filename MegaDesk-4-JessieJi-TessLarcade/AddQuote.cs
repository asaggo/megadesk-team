using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
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

namespace MegaDesk_4_JessieJi
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            surfMtrlBox.SelectedIndex = -1;
            surfMtrlBox.DataSource = Enum.GetValues(typeof(SurfaceMaterial));
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)this.Tag;
            mainMenu.Show();
            Close();
        }

        private void btnAddNewQuote_Click(object sender, EventArgs e)
        {
            bool isValide = ValidateChildren(ValidationConstraints.Enabled);
            //string filename = "quotes.json";
            if (isValide)
                WriteFile();
        }

        private void WriteFile()
        {
            try
            {
                var newQuote = (custNameBox.Text + "," + deskDepthBox.Text + "," + deskWidthBox.Text + "," + numDrawerBox.Text + "," +
                       surfMtrlBox.Text + "," + rushOrderBox.Text + "," + lblTotalPrice.Text + "," + DateTime.Now.ToString("MM/dd/yyyy") + '\n');
                var jsonDesk = JsonConvert.SerializeObject(newQuote, new IsoDateTimeConverter() { DateTimeFormat = "yyyy-MM-dd" });


                string cFile = @"quotes.json";
                if (!File.Exists(cFile))
                {
                    using (StreamWriter writeFile = File.CreateText("quotes.json"))
                    {
                        var DeskJson = JsonConvert.DeserializeObject<String>(jsonDesk);
                        writeFile.Write(newQuote);
                        MessageBox.Show("Quote has been created!");
                        JsonConvert.SerializeObject("quotes.json", new IsoDateTimeConverter() { DateTimeFormat = "yyyy-MM-dd" });

                        custNameBox.Clear();
                        deskDepthBox.Clear();
                        deskWidthBox.Clear();
                        numDrawerBox.Clear();

                        lblSizePrice.Text = "$";
                        lblNumDrawerPrice.Text = "$";
                        lblSurfMtrlPrice.Text = "$";
                        lblRushOrderPrice.Text = "$";
                        lblTotalPrice.Text = "$";

                        surfMtrlBox.SelectedIndex = -1;
                        rushOrderBox.SelectedIndex = -1;
                        writeFile.Close();

                    }
                }
                else
                {
                    using (StreamWriter writeFile = File.AppendText("quotes.json"))
                    {
                        var DeskJson = JsonConvert.DeserializeObject<String>(jsonDesk);
                        writeFile.Write(newQuote);
                        JsonConvert.SerializeObject("quotes.json", new IsoDateTimeConverter() { DateTimeFormat = "yyyy-MM-dd" });
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error when try to use StreamWriter. It says : " + e.Message);
            }
        }

        /* 
         * Validate Width
         */
        private void deskWidthBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "";
            string inputString = deskWidthBox.Text;
            if (!ValidateDeskWidth(inputString, out errorMsg))
            {
                e.Cancel = true;
                deskWidthBox.Focus();
            }
            else
            {
                e.Cancel = false;
            }
            errorProvider1.SetError(deskWidthBox, errorMsg);

        }

        public bool ValidateDeskWidth(string inputString, out string errorMsg)
        {
            int input;
            if (int.TryParse(inputString, out input))
            {
                if (input < 24 || input > 96)
                {
                    errorMsg = "Please enter a valid integer value.\n It should be between 24 and 96.";
                    return false;
                }
            }
            else //no input
            {
                errorMsg = "Please enter an integer value for the width of the desk";
                return false;
            }
            errorMsg = "";
            return true;
        }

        /* 
         * Validate Depth
         */
        /*
       private void deskDepthBox_Validating(object sender, CancelEventArgs e)
       {
           string errorMsg = "";
           string inputString = deskDepthBox.Text;
           if (!ValidateDeskDepth(inputString, out errorMsg))
           {
               e.Cancel = true;
               deskDepthBox.Focus();
           }
           else
           {
               e.Cancel = false;
           }
           errorProvider1.SetError(deskDepthBox, errorMsg);
       }

       public bool ValidateDeskDepth(string inputString, out string errorMsg)
       {
           int input;
           if (int.TryParse(inputString, out input))
           {
               if (input < 12 || input > 48)
               {
                   errorMsg = "Please enter a valid integer value.\n It should be between 12 and 48.";
                   return false;
               }
           }
           else //no input
           {
               errorMsg = "Please enter an integer value for the depth of the desk";
               return false;
           }
           errorMsg = "";
           return true;
       }
       */

        /* 
         * Validate Depth
         */
         //check what user entered at the moment
        private void deskDepthBox_Validating(object sender, KeyPressEventArgs e)
        {
            string errorMsg = "";            
            if (!char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                errorMsg = "Please enter integer value";
                e.Handled = false;
                deskDepthBox.Focus();
            }
            else
            {
                errorMsg = "";
            }
            errorProvider1.SetError(deskDepthBox, errorMsg);
        }

        //check if the value is in between min and max
        private void checkDeskDepthValue(object sender, EventArgs e)
        {
            int input;
            if (int.TryParse(deskDepthBox.Text, out input))
            {
                if (input < 12 || input > 48)
                {
                    errorProvider1.SetError(deskDepthBox, "Please enter a valid integer value.\n It should be between 12 and 48.");
                    deskDepthBox.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(deskDepthBox, "Please enter an integer value for the depth of the desk");
                deskDepthBox.Focus();
            }
        }
        /* 
         * Validate Num
         */
        private void numDrawerBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "";
            string inputString = numDrawerBox.Text;
            if (!ValidateNumDrawer(inputString, out errorMsg))
            {
                e.Cancel = true;
                numDrawerBox.Focus();
            }
            else
            {
                e.Cancel = false;
            }
            errorProvider1.SetError(numDrawerBox, errorMsg);
        }

        public bool ValidateNumDrawer(string inputString, out string errorMsg)
        {
            int input;
            if (int.TryParse(inputString, out input))
            {
                if (input < 0 || input > 7)
                {
                    errorMsg = "Please enter a valid integer value.\n It should be between 0 and 7.";
                    return false;
                }
            }
            else //no input
            {
                errorMsg = "Please enter an integer value for the number of drawers";
                return false;
            }
            errorMsg = "";
            return true;
        }

        private void btnGetPrice_Click(object sender, EventArgs e)
        {
            bool isValide = ValidateChildren(ValidationConstraints.Enabled);
            //string filename = "quotes.json";
            if (isValide)
                GetPrice();
        }

        private void GetPrice()
        {

            int width = int.Parse(deskWidthBox.Text);
            int depth = int.Parse(deskDepthBox.Text);
            int size = width * depth;
            int sizePrice, drawerPrice, mtrlPrice, surfPrice, rushPrice;
            int.TryParse(numDrawerBox.Text, out int nDrawers);
            /*
            if (int.TryParse(numDrawerBox.Text, out int nDrawers))
                drawerPrice = nDrawers * 50;
            else
                drawerPrice = 0;
                */

            Desk desk = new Desk(int.Parse(deskWidthBox.Text), int.Parse(deskDepthBox.Text), nDrawers);
            DeskQuotes deskQuotes = new DeskQuotes(desk);

            /*
            if (size > 1000)
                sizePrice = size - 1000;
            else
                sizePrice = 0;



            switch (surfMtrlBox.Text)
            {
                case "Pine":
                    mtrlPrice = 50;
                    break;
                case "Oak":
                    mtrlPrice = 200;
                    break;
                case "Laminate":
                    mtrlPrice = 100;
                    break;
                case "Rosewood":
                    mtrlPrice = 300;
                    break;
                case "Veneer":
                    mtrlPrice = 125;
                    break;
                default:
                    mtrlPrice = 0;
                    break;
            }*/

            deskQuotes.CalcOversizeCost();
            deskQuotes.CalcDrawerCost();
            deskQuotes.CalcMtrlCost(surfMtrlBox.Text);
            deskQuotes.CalcRushOrderCost(rushOrderBox.Text);
            deskQuotes.CalcTotalCost();

            lblSizePrice.Text = "$" + deskQuotes.OversizeCost;
            lblNumDrawerPrice.Text = "$" + deskQuotes.DrawerCost;
            lblSurfMtrlPrice.Text = "$" + deskQuotes.MaterialCost;
            lblRushOrderPrice.Text = "$" + deskQuotes.RushOrderCost;
            lblTotalPrice.Text = "$" + deskQuotes.TotalCost;

            /*
            lblSizePrice.Text = "$" + sizePrice.ToString();
            lblNumDrawerPrice.Text = "$" + drawerPrice.ToString();
            lblSurfMtrlPrice.Text = "$" + mtrlPrice.ToString();
            lblRushOrderPrice.Text = ;*/
        }
    }
}
