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
    public partial class FormAddQuote : Form
    {
        public FormAddQuote()
        {
            InitializeComponent();
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown control to deal with the "zero" issue.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void FormAddQuote_Load(object sender, EventArgs e)
        {
            // Link our list of material types to the combo box
            Desk d = new Desk();
            this.cmbDeskMaterial.DataSource = Globals.surfaceMaterials;
            this.cmbDeskMaterial.DisplayMember = "description";
            this.cmbDeskMaterial.ValueMember = "ID";
            //MessageBox.Show(Desk.surfaceMaterials.Count().ToString());

            // Link our list of rush types to the combo box
            DeskQuote dq = new DeskQuote();
            this.cmbRushOption.DataSource = Globals.rushTypes;
            this.cmbRushOption.DisplayMember = "description";
            this.cmbRushOption.ValueMember = "ID";
            //MessageBox.Show(DeskQuote.rushTypes.Count().ToString());

            //Set min - max values on number up down controls
            nudWidth.Minimum = Globals.minWidth;
            nudWidth.Maximum = Globals.maxWidth;
            nudDepth.Minimum = Globals.minDepth;
            nudDepth.Maximum = Globals.maxDepth;
            nudDrawers.Minimum = Globals.minDrawers;
            nudDrawers.Maximum = Globals.maxDrawers;
        }

        private void cmdSaveQuote_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text.Length==0) {
                MessageBox.Show("No customer name entered, operation cancelled.");
            }
            else
            {
                Globals.SurfaceMaterials sm2 = Globals.surfaceMaterials[0];
                //Identify index of MaterialType
                foreach (Globals.SurfaceMaterials sm in Globals.surfaceMaterials)
                {
                    if (sm.description == cmbDeskMaterial.Text)
                    {
                        sm2 = sm;
                    }
                }
                //TODO:  Add error handling if matching surface material not found.

                //Create a new desk object
                Desk d = new Desk { width = (double)nudWidth.Value, depth = (double)nudDepth.Value, drawers=(int)nudDrawers.Value, surfaceMaterial=sm2};
                //Calculate cost component 1
                double quote = Globals.baseCost + (d.width * d.depth * Globals.surfaceCost) + (d.drawers * Globals.drawerCost);

                //Add in surface material cost
                //TODO: fix quote addition for surface materials 
                quote += d.surfaceMaterial.cost;

                //Calculate cost component 2
                foreach (Globals.RushType rt in Globals.rushTypes)
                {
                    if (rt.description == cmbRushOption.Text)
                    {
                        //MessageBox.Show("Base cost: " + quote.ToString() + " Option:" + rt.description);
                        if (d.width * d.depth < 1000)
                            quote += rt.tier1Cost;
                        else if (d.width * d.depth < 2000)
                            quote += rt.tier2Cost;
                        else
                            quote += rt.tier3Cost; 
                    }
                }

                //Create a new quote object
                DeskQuote dq = new DeskQuote { id = Globals.QuoteCount++, customerName = txtCustomerName.Text, desk = d, rushType = (Globals.RushType)cmbRushOption.SelectedItem, totalQuote = quote };

                //Add the quote object to the list.
                Globals.deskQuotes.Add(dq);
                MessageBox.Show(String.Format("Quote confirmed for {1} in the amount of {0:C}", quote,txtCustomerName.Text),"MegaDesk Corp");
                this.Hide();
                //MessageBox.Show("Count of desk quotes: " + Globals.deskQuotes.Count().ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
