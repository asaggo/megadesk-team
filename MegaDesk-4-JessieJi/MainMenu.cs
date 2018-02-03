using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_4_JessieJi
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void addNewQuotesButton_Click(object sender, EventArgs e)
        {
            /*
            this.Visible = false;
            AddQuote openAddNewQ = new AddQuote();
            openAddNewQ.ShowDialog();
            */
            AddQuote openAddNewQ = new AddQuote();
            openAddNewQ.Tag = this;
            openAddNewQ.Show(this);
            Hide();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnViewQuotesStart_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuotes = new ViewAllQuotes();
            viewAllQuotes.Tag = this;
            viewAllQuotes.Show(this);
            Hide();
        }

        private void btnSearchQuotesStart_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotes = new SearchQuotes();
            searchQuotes.Tag = this;
            searchQuotes.Show(this);
            Hide();
        }
    }
}
