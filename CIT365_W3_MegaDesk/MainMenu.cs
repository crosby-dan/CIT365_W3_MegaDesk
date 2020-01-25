using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIT365_W3_MegaDesk
{
    public partial class FormMain : Form
    {

        private struct Materials
        {

        }

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnAddQuote_Click(object sender, EventArgs e)
        {
            FormAddQuote frm = new FormAddQuote();
            frm.Show();
        }

        private void btnViewQuote_Click(object sender, EventArgs e)
        {
            //String input;

            
        }

        private void btnSearchQuotes_Click(object sender, EventArgs e)
        {
            SearchQuotes sq = new SearchQuotes();
            sq.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
