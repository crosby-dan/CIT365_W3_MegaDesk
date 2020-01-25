namespace CIT365_W3_MegaDesk
{
    partial class SearchQuotes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstQuotes = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearchDeskMaterial = new System.Windows.Forms.Button();
            this.radioSearchMaterial = new System.Windows.Forms.RadioButton();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.btnSearchID = new System.Windows.Forms.Button();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.radioShowByCustomer = new System.Windows.Forms.RadioButton();
            this.radioShowByID = new System.Windows.Forms.RadioButton();
            this.radioShowAll = new System.Windows.Forms.RadioButton();
            this.cmdViewSelectedQuote = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.nudDrawers = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nudDepth = new System.Windows.Forms.NumericUpDown();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuote = new System.Windows.Forms.TextBox();
            this.txtRushOption = new System.Windows.Forms.TextBox();
            this.txtSurfaceMaterial = new System.Windows.Forms.TextBox();
            this.cmbSearchDeskMaterial = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioByID = new System.Windows.Forms.RadioButton();
            this.radioByCustomer = new System.Windows.Forms.RadioButton();
            this.radioByAmount = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrawers)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstQuotes
            // 
            this.lstQuotes.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstQuotes.FormattingEnabled = true;
            this.lstQuotes.ItemHeight = 14;
            this.lstQuotes.Location = new System.Drawing.Point(31, 153);
            this.lstQuotes.Name = "lstQuotes";
            this.lstQuotes.Size = new System.Drawing.Size(318, 158);
            this.lstQuotes.TabIndex = 0;
            this.lstQuotes.SelectedValueChanged += new System.EventHandler(this.lstQuotes_SelectedValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cmbSearchDeskMaterial);
            this.panel1.Controls.Add(this.btnSearchDeskMaterial);
            this.panel1.Controls.Add(this.radioSearchMaterial);
            this.panel1.Controls.Add(this.btnSearchCustomer);
            this.panel1.Controls.Add(this.btnSearchID);
            this.panel1.Controls.Add(this.txtSearchCustomer);
            this.panel1.Controls.Add(this.txtSearchID);
            this.panel1.Controls.Add(this.radioShowByCustomer);
            this.panel1.Controls.Add(this.radioShowByID);
            this.panel1.Controls.Add(this.radioShowAll);
            this.panel1.Location = new System.Drawing.Point(31, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 107);
            this.panel1.TabIndex = 1;
            // 
            // btnSearchDeskMaterial
            // 
            this.btnSearchDeskMaterial.Location = new System.Drawing.Point(272, 79);
            this.btnSearchDeskMaterial.Name = "btnSearchDeskMaterial";
            this.btnSearchDeskMaterial.Size = new System.Drawing.Size(20, 22);
            this.btnSearchDeskMaterial.TabIndex = 9;
            this.btnSearchDeskMaterial.Text = ">>";
            this.btnSearchDeskMaterial.UseVisualStyleBackColor = true;
            this.btnSearchDeskMaterial.Visible = false;
            this.btnSearchDeskMaterial.Click += new System.EventHandler(this.btnSearchDeskMaterial_Click);
            // 
            // radioSearchMaterial
            // 
            this.radioSearchMaterial.AutoSize = true;
            this.radioSearchMaterial.Location = new System.Drawing.Point(12, 80);
            this.radioSearchMaterial.Name = "radioSearchMaterial";
            this.radioSearchMaterial.Size = new System.Drawing.Size(113, 17);
            this.radioSearchMaterial.TabIndex = 7;
            this.radioSearchMaterial.Text = "Search by Material";
            this.radioSearchMaterial.UseVisualStyleBackColor = true;
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Location = new System.Drawing.Point(272, 54);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(20, 22);
            this.btnSearchCustomer.TabIndex = 6;
            this.btnSearchCustomer.Text = ">>";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Visible = false;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // btnSearchID
            // 
            this.btnSearchID.Location = new System.Drawing.Point(172, 27);
            this.btnSearchID.Name = "btnSearchID";
            this.btnSearchID.Size = new System.Drawing.Size(20, 22);
            this.btnSearchID.TabIndex = 5;
            this.btnSearchID.Text = ">>";
            this.btnSearchID.UseVisualStyleBackColor = true;
            this.btnSearchID.Visible = false;
            this.btnSearchID.Click += new System.EventHandler(this.btnSearchID_Click);
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Location = new System.Drawing.Point(138, 55);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(128, 20);
            this.txtSearchCustomer.TabIndex = 4;
            this.txtSearchCustomer.Visible = false;
            // 
            // txtSearchID
            // 
            this.txtSearchID.Location = new System.Drawing.Point(105, 29);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(61, 20);
            this.txtSearchID.TabIndex = 3;
            this.txtSearchID.Visible = false;
            // 
            // radioShowByCustomer
            // 
            this.radioShowByCustomer.AutoSize = true;
            this.radioShowByCustomer.Location = new System.Drawing.Point(12, 56);
            this.radioShowByCustomer.Name = "radioShowByCustomer";
            this.radioShowByCustomer.Size = new System.Drawing.Size(120, 17);
            this.radioShowByCustomer.TabIndex = 2;
            this.radioShowByCustomer.Text = "Search by Customer";
            this.radioShowByCustomer.UseVisualStyleBackColor = true;
            this.radioShowByCustomer.CheckedChanged += new System.EventHandler(this.radioShowByCustomer_CheckedChanged);
            // 
            // radioShowByID
            // 
            this.radioShowByID.AutoSize = true;
            this.radioShowByID.Location = new System.Drawing.Point(12, 31);
            this.radioShowByID.Name = "radioShowByID";
            this.radioShowByID.Size = new System.Drawing.Size(87, 17);
            this.radioShowByID.TabIndex = 1;
            this.radioShowByID.Text = "Search by ID";
            this.radioShowByID.UseVisualStyleBackColor = true;
            this.radioShowByID.CheckedChanged += new System.EventHandler(this.radioShowByID_CheckedChanged);
            // 
            // radioShowAll
            // 
            this.radioShowAll.AutoSize = true;
            this.radioShowAll.Checked = true;
            this.radioShowAll.Location = new System.Drawing.Point(12, 9);
            this.radioShowAll.Name = "radioShowAll";
            this.radioShowAll.Size = new System.Drawing.Size(66, 17);
            this.radioShowAll.TabIndex = 0;
            this.radioShowAll.TabStop = true;
            this.radioShowAll.Text = "Show All";
            this.radioShowAll.UseVisualStyleBackColor = true;
            this.radioShowAll.CheckedChanged += new System.EventHandler(this.radioShowAll_CheckedChanged);
            // 
            // cmdViewSelectedQuote
            // 
            this.cmdViewSelectedQuote.Location = new System.Drawing.Point(352, 197);
            this.cmdViewSelectedQuote.Name = "cmdViewSelectedQuote";
            this.cmdViewSelectedQuote.Size = new System.Drawing.Size(32, 23);
            this.cmdViewSelectedQuote.TabIndex = 2;
            this.cmdViewSelectedQuote.Text = ">>";
            this.cmdViewSelectedQuote.UseVisualStyleBackColor = true;
            this.cmdViewSelectedQuote.Visible = false;
            this.cmdViewSelectedQuote.Click += new System.EventHandler(this.cmdViewSelectedQuote_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.92617F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.07383F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.nudDrawers, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCustomerName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtQuote, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtRushOption, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtSurfaceMaterial, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(390, 125);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(434, 166);
            this.tableLayoutPanel1.TabIndex = 9;
            this.tableLayoutPanel1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Calculated Quote";
            // 
            // nudDrawers
            // 
            this.nudDrawers.Location = new System.Drawing.Point(171, 84);
            this.nudDrawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudDrawers.Name = "nudDrawers";
            this.nudDrawers.Size = new System.Drawing.Size(120, 20);
            this.nudDrawers.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Desk Material";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Number of Drawers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Rush Option";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nudDepth);
            this.panel2.Controls.Add(this.nudWidth);
            this.panel2.Location = new System.Drawing.Point(171, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 23);
            this.panel2.TabIndex = 2;
            // 
            // nudDepth
            // 
            this.nudDepth.Location = new System.Drawing.Point(130, 2);
            this.nudDepth.Name = "nudDepth";
            this.nudDepth.Size = new System.Drawing.Size(120, 20);
            this.nudDepth.TabIndex = 3;
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(0, 2);
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(120, 20);
            this.nudWidth.TabIndex = 2;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(171, 3);
            this.txtCustomerName.MaxLength = 50;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(253, 20);
            this.txtCustomerName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Desk Dimensions Width * Depth";
            // 
            // txtQuote
            // 
            this.txtQuote.Location = new System.Drawing.Point(171, 136);
            this.txtQuote.MaxLength = 50;
            this.txtQuote.Name = "txtQuote";
            this.txtQuote.Size = new System.Drawing.Size(75, 20);
            this.txtQuote.TabIndex = 10;
            // 
            // txtRushOption
            // 
            this.txtRushOption.Location = new System.Drawing.Point(171, 110);
            this.txtRushOption.Name = "txtRushOption";
            this.txtRushOption.Size = new System.Drawing.Size(253, 20);
            this.txtRushOption.TabIndex = 11;
            // 
            // txtSurfaceMaterial
            // 
            this.txtSurfaceMaterial.Location = new System.Drawing.Point(171, 58);
            this.txtSurfaceMaterial.Name = "txtSurfaceMaterial";
            this.txtSurfaceMaterial.Size = new System.Drawing.Size(253, 20);
            this.txtSurfaceMaterial.TabIndex = 12;
            // 
            // cmbSearchDeskMaterial
            // 
            this.cmbSearchDeskMaterial.FormattingEnabled = true;
            this.cmbSearchDeskMaterial.Location = new System.Drawing.Point(138, 79);
            this.cmbSearchDeskMaterial.Name = "cmbSearchDeskMaterial";
            this.cmbSearchDeskMaterial.Size = new System.Drawing.Size(128, 21);
            this.cmbSearchDeskMaterial.TabIndex = 10;
            this.cmbSearchDeskMaterial.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.radioByAmount);
            this.panel3.Controls.Add(this.radioByCustomer);
            this.panel3.Controls.Add(this.radioByID);
            this.panel3.Location = new System.Drawing.Point(31, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(318, 22);
            this.panel3.TabIndex = 10;
            // 
            // radioByID
            // 
            this.radioByID.AutoSize = true;
            this.radioByID.Checked = true;
            this.radioByID.Location = new System.Drawing.Point(63, 2);
            this.radioByID.Name = "radioByID";
            this.radioByID.Size = new System.Drawing.Size(36, 17);
            this.radioByID.TabIndex = 0;
            this.radioByID.TabStop = true;
            this.radioByID.Text = "ID";
            this.radioByID.UseVisualStyleBackColor = true;
            this.radioByID.CheckedChanged += new System.EventHandler(this.radioByID_CheckedChanged);
            // 
            // radioByCustomer
            // 
            this.radioByCustomer.AutoSize = true;
            this.radioByCustomer.Location = new System.Drawing.Point(113, 2);
            this.radioByCustomer.Name = "radioByCustomer";
            this.radioByCustomer.Size = new System.Drawing.Size(69, 17);
            this.radioByCustomer.TabIndex = 1;
            this.radioByCustomer.Text = "Customer";
            this.radioByCustomer.UseVisualStyleBackColor = true;
            this.radioByCustomer.CheckedChanged += new System.EventHandler(this.radioByCustomer_CheckedChanged);
            // 
            // radioByAmount
            // 
            this.radioByAmount.AutoSize = true;
            this.radioByAmount.Location = new System.Drawing.Point(188, 2);
            this.radioByAmount.Name = "radioByAmount";
            this.radioByAmount.Size = new System.Drawing.Size(61, 17);
            this.radioByAmount.TabIndex = 2;
            this.radioByAmount.Text = "Amount";
            this.radioByAmount.UseVisualStyleBackColor = true;
            this.radioByAmount.CheckedChanged += new System.EventHandler(this.radioByAmount_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Sorting";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(102, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Search Options";
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 344);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.cmdViewSelectedQuote);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstQuotes);
            this.Name = "SearchQuotes";
            this.Text = "Search Quotes";
            this.Load += new System.EventHandler(this.SearchQuotes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrawers)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstQuotes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioShowByID;
        private System.Windows.Forms.RadioButton radioShowAll;
        private System.Windows.Forms.RadioButton radioShowByCustomer;
        private System.Windows.Forms.Button cmdViewSelectedQuote;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudDrawers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nudDepth;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuote;
        private System.Windows.Forms.TextBox txtRushOption;
        private System.Windows.Forms.TextBox txtSurfaceMaterial;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.Button btnSearchID;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.Button btnSearchDeskMaterial;
        private System.Windows.Forms.RadioButton radioSearchMaterial;
        private System.Windows.Forms.ComboBox cmbSearchDeskMaterial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioByAmount;
        private System.Windows.Forms.RadioButton radioByCustomer;
        private System.Windows.Forms.RadioButton radioByID;
    }
}