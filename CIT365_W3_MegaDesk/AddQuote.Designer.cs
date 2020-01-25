namespace CIT365_W3_MegaDesk
{
    partial class FormAddQuote
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nudDrawers = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudDepth = new System.Windows.Forms.NumericUpDown();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.cmbDeskMaterial = new System.Windows.Forms.ComboBox();
            this.cmbRushOption = new System.Windows.Forms.ComboBox();
            this.cmdSaveQuote = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrawers)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            this.SuspendLayout();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Desk Material";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.92617F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.07383F));
            this.tableLayoutPanel1.Controls.Add(this.nudDrawers, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCustomerName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbDeskMaterial, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbRushOption, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(38, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(434, 139);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // nudDrawers
            // 
            this.nudDrawers.Location = new System.Drawing.Point(171, 85);
            this.nudDrawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudDrawers.Name = "nudDrawers";
            this.nudDrawers.Size = new System.Drawing.Size(120, 20);
            this.nudDrawers.TabIndex = 5;
            this.nudDrawers.Enter += new System.EventHandler(this.answer_Enter);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Number of Drawers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Rush Option";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nudDepth);
            this.panel1.Controls.Add(this.nudWidth);
            this.panel1.Location = new System.Drawing.Point(171, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 23);
            this.panel1.TabIndex = 2;
            // 
            // nudDepth
            // 
            this.nudDepth.Location = new System.Drawing.Point(130, 2);
            this.nudDepth.Name = "nudDepth";
            this.nudDepth.Size = new System.Drawing.Size(120, 20);
            this.nudDepth.TabIndex = 3;
            this.nudDepth.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(0, 2);
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(120, 20);
            this.nudWidth.TabIndex = 2;
            this.nudWidth.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(171, 3);
            this.txtCustomerName.MaxLength = 50;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(253, 20);
            this.txtCustomerName.TabIndex = 1;
            // 
            // cmbDeskMaterial
            // 
            this.cmbDeskMaterial.FormattingEnabled = true;
            this.cmbDeskMaterial.Location = new System.Drawing.Point(171, 58);
            this.cmbDeskMaterial.Name = "cmbDeskMaterial";
            this.cmbDeskMaterial.Size = new System.Drawing.Size(253, 21);
            this.cmbDeskMaterial.TabIndex = 4;
            // 
            // cmbRushOption
            // 
            this.cmbRushOption.FormattingEnabled = true;
            this.cmbRushOption.Location = new System.Drawing.Point(171, 111);
            this.cmbRushOption.Name = "cmbRushOption";
            this.cmbRushOption.Size = new System.Drawing.Size(253, 21);
            this.cmbRushOption.TabIndex = 6;
            // 
            // cmdSaveQuote
            // 
            this.cmdSaveQuote.Location = new System.Drawing.Point(209, 173);
            this.cmdSaveQuote.Name = "cmdSaveQuote";
            this.cmdSaveQuote.Size = new System.Drawing.Size(75, 23);
            this.cmdSaveQuote.TabIndex = 7;
            this.cmdSaveQuote.Text = "Save Quote";
            this.cmdSaveQuote.UseVisualStyleBackColor = true;
            this.cmdSaveQuote.Click += new System.EventHandler(this.cmdSaveQuote_Click);
            // 
            // FormAddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 219);
            this.Controls.Add(this.cmdSaveQuote);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormAddQuote";
            this.Text = "Add quote";
            this.Load += new System.EventHandler(this.FormAddQuote_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrawers)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudDepth;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.ComboBox cmbRushOption;
        private System.Windows.Forms.ComboBox cmbDeskMaterial;
        private System.Windows.Forms.NumericUpDown nudDrawers;
        private System.Windows.Forms.Button cmdSaveQuote;
    }
}