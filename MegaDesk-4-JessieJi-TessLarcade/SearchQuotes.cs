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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
            searchBox.DataSource = Enum.GetValues(typeof(SurfaceMaterial));
            listQuotes.Items.Clear();
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)this.Tag;
            mainMenu.Show();
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listQuotes.Items.Clear();
            ReadFile();
        }

        private void ReadFile()
        {
            //read all list of quotes
            List<string[]> deskList = new List<string[]>();
            StreamReader streamReader = new StreamReader("quotes.json");
            string line = "";
            while ((line = streamReader.ReadLine()) != null)
            {
                string[] items = line.Split(',');
                deskList.Add(items);
            }

            //get the material that user chose
            string findThisMtrl = searchBox.SelectedValue.ToString();


            foreach (string[] temp in deskList)
            {
                ListViewItem listViewItem = new ListViewItem();
                if (temp[4].ToString().Equals(findThisMtrl))
                {
                    listViewItem.Text = temp[0];
                    for (int i = 1; i < 8; i++)
                        listViewItem.SubItems.Add(temp[i]);
                    listQuotes.Items.Add(listViewItem);
                }
               
            }
            streamReader.Close();
        }
        
    }
}
