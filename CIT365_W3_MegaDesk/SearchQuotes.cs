using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIT365_W3_MegaDesk
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
            if (Globals.deskQuotes.Count()==0) {
                MessageBox.Show("No quotes found, form disabled.","MegaDesk Corporation");
                radioShowAll.Enabled = false;
                radioShowByCustomer.Enabled = false;
                radioShowByID.Enabled = false;
                cmdViewSelectedQuote.Enabled = false;
            }
            else
            {
                PerformSearch();
            }
        }

        public void SortQuotes(ref List<DeskQuote> deskQuotes)
        {
            if (radioByID.Checked)
            {
                Globals.deskQuotes.Sort((f1, f2) => f1.id.CompareTo(f2.id));
            }
            else if (radioByCustomer.Checked)
            {
                Globals.deskQuotes.Sort((f1, f2) => f1.customerName.CompareTo(f2.customerName));
            }
            else if (radioByAmount.Checked)
            {
                Globals.deskQuotes.Sort((f1, f2) => f1.totalQuote.CompareTo(f2.totalQuote));
            }

        }

        //This is the default search which returns all quotes.   It also runs by default when opening the form.
        public void PerformSearch()
        {
            //Hide any presently viewed quote results
            tableLayoutPanel1.Visible = false;
            cmdViewSelectedQuote.Visible = false;
            lstQuotes.Items.Clear();
            if (radioShowAll.Checked)
            {
                SortQuotes(ref Globals.deskQuotes);
                foreach (DeskQuote s in Globals.deskQuotes)
                {
                    lstQuotes.Items.Add(s.ToString());
                    //MessageBox.Show(s.ToString());
                }
            }
        }

        //Overriding PerformSearch method to function for searching by ID
        public bool PerformSearch(int ID)
        {
            //Hide any presently viewed quote results
            tableLayoutPanel1.Visible = false;
            cmdViewSelectedQuote.Visible = false;
            lstQuotes.Items.Clear();

            //We are intentionally not sorting since this search method returns only one result.
            foreach (DeskQuote s in Globals.deskQuotes)
            {
                if  (s.id==ID) { 
                lstQuotes.Items.Add(s.ToString());
                return true;
                }
            }
            return false;
        }

        //Overriding PerformSearch method to function for searching by customerNae
        public int PerformSearch(string Name)
        {
            //Hide any presently viewed quote results
            tableLayoutPanel1.Visible = false;
            cmdViewSelectedQuote.Visible = false;
            lstQuotes.Items.Clear();

            SortQuotes(ref Globals.deskQuotes);
            int matches = 0;
            foreach (DeskQuote s in Globals.deskQuotes)
            {
                if (s.customerName.ToUpper().Contains(Name.ToUpper()))
                {
                    lstQuotes.Items.Add(s.ToString());
                    matches++;
                }   
            }
            return matches;
        }

        //Perform search / filter for a specific material.
        public int PerformSearch(Globals.SurfaceMaterials sm)
        {
            //Hide any presently viewed quote results
            tableLayoutPanel1.Visible = false;
            cmdViewSelectedQuote.Visible = false;
            lstQuotes.Items.Clear();

            SortQuotes(ref Globals.deskQuotes);
            int matches = 0;
            foreach (DeskQuote s in Globals.deskQuotes)
            {
                if (s.desk.surfaceMaterial.description==sm.description)
                {
                    lstQuotes.Items.Add(s.ToString());
                    matches++;
                }
            }
            return matches;
        }

        //Populate the form with the selected quote.
        private void cmdViewSelectedQuote_Click(object sender, EventArgs e)
        {
            String selection = lstQuotes.SelectedItem.ToString();
            //MessageBox.Show(selection);
            Match match = Regex.Match(selection, @"Id (\d*)\W",
            RegexOptions.IgnoreCase);

            // Here we check the Match instance.
            if (match.Success)
            {
                // Finally, we get the Group value and display it.
                int selectedID = Int32.Parse(match.Groups[1].Value);
                //Console.WriteLine(selectedID);
                tableLayoutPanel1.Visible = true;
                DeskQuote dq = Globals.deskQuotes[selectedID - 1];
                txtCustomerName.Text = dq.customerName;
                nudDepth.Value = (decimal)dq.desk.depth;
                nudWidth.Value = (decimal)dq.desk.width;
                nudDrawers.Value = (decimal)dq.desk.drawers;
                txtQuote.Text = String.Format("{0:C}", dq.totalQuote);
                txtRushOption.Text = dq.rushType.description;
                txtSurfaceMaterial.Text = dq.desk.surfaceMaterial.description;
            }
            else
            {
                tableLayoutPanel1.Visible = false;
            }
        }

        private void lstQuotes_SelectedValueChanged(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = false;
            cmdViewSelectedQuote.Visible = true;
        }

        private void radioShowAll_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSearchButtons();
        }

        //Display appropriate search controls depending on which radio button is selected
        private void UpdateSearchButtons()
        {
            if (radioShowAll.Checked)
            {
                txtSearchCustomer.Visible = false;
                btnSearchCustomer.Visible = false;
                txtSearchID.Visible = false;
                btnSearchID.Visible = false;
                cmbSearchDeskMaterial.Visible = false;
                btnSearchDeskMaterial.Visible = false;
                PerformSearch();
            }
            else if (radioShowByID.Checked)
            {
                txtSearchCustomer.Visible = false;
                btnSearchCustomer.Visible = false;
                txtSearchID.Visible = true;
                btnSearchID.Visible = true;
                cmbSearchDeskMaterial.Visible = false;
                btnSearchDeskMaterial.Visible = false;
            }
            else if (radioShowByCustomer.Checked)
            {
                txtSearchCustomer.Visible = true;
                btnSearchCustomer.Visible = true;
                txtSearchID.Visible = false;
                btnSearchID.Visible = false;
                cmbSearchDeskMaterial.Visible = false;
                btnSearchDeskMaterial.Visible = false;
            }
            else if (radioSearchMaterial.Checked)
            {
                txtSearchCustomer.Visible = false;
                btnSearchCustomer.Visible = false;
                txtSearchID.Visible = false;
                btnSearchID.Visible = false;
                cmbSearchDeskMaterial.Visible = true;
                btnSearchDeskMaterial.Visible = true;
            }
        }

        private void radioShowByID_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSearchButtons();
        }

        private void radioShowByCustomer_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSearchButtons();
        }

        //Search by customer ID when button is clicked
        private void btnSearchID_Click(object sender, EventArgs e)
        {
            int id;
            bool result = int.TryParse(txtSearchID.Text, out id);
            if (!result)
            {
                MessageBox.Show("Invalid ID value, search cancelled.", "MegaDesk Corp");
            }
            else if (!PerformSearch(id))
            {
                MessageBox.Show("Search for id " + txtSearchID.Text + " failed.","MegaDesk Corp");
            }
        }

        //Search by customer name when button is clicked.   Search is a case insensitive, contains search.
        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            if (txtSearchCustomer.Text.Length==0)
            {
                MessageBox.Show("Missing search text, search cancelled.", "MegaDesk Corp");
            }
            else if (PerformSearch(txtSearchCustomer.Text)==0)
            {
                MessageBox.Show("No results found, search cancelled.", "MegaDesk Corp");
            }
        }

        private void btnSearchDeskMaterial_Click(object sender, EventArgs e)
        {
            if (PerformSearch(Globals.surfaceMaterials[cmbSearchDeskMaterial.SelectedIndex])==0) {
                MessageBox.Show("No results found, search cancelled.", "MegaDesk Corp");
            }
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            Desk d = new Desk();
            this.cmbSearchDeskMaterial.DataSource = Globals.surfaceMaterials;
            this.cmbSearchDeskMaterial.DisplayMember = "description";
            this.cmbSearchDeskMaterial.ValueMember = "ID";
        }

        private void UpdateSearch()
        {
            //If a button other than search by ID is checked, then we need to re-run the search in order to perform the sorting.
            if (radioShowAll.Checked)
            {
                PerformSearch();
            }
            else if (radioSearchMaterial.Checked) {
                if (PerformSearch(Globals.surfaceMaterials[cmbSearchDeskMaterial.SelectedIndex]) == 0)
                {
                    //We are suppressing this message when only the sort has changed.
                    //MessageBox.Show("No results found, search cancelled.", "MegaDesk Corp");
                }
            }
            //DEBUG:  Customer search not updating when sort changed.
            else if (radioShowByCustomer.Checked)
            {
                if (txtSearchCustomer.Text.Length > 0)
                {
                    if (PerformSearch(txtSearchCustomer.Text) == 0)
                    {
                        //We are suppressing this message when only the sort has changed
                        //MessageBox.Show("No results found, search cancelled.", "MegaDesk Corp");
                    }
                }
            }
        }

        private void radioByID_CheckedChanged(object sender, EventArgs e)
        {
            if (radioByID.Checked) UpdateSearch();
        }

        private void radioByAmount_CheckedChanged(object sender, EventArgs e)
        {
            if (radioByAmount.Checked) UpdateSearch();
        }

        private void radioByCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (radioByCustomer.Checked) UpdateSearch();
        }
    }
}

