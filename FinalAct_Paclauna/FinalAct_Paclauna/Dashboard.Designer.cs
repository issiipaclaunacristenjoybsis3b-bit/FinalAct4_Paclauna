namespace FinalAct_Paclauna
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.logoutbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.productlist = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbltotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblstock = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbllow = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblout = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.addbtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtcreated = new System.Windows.Forms.TextBox();
            this.txtreorder = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.descriptiontxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.categorycmb = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productlist)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.logoutbtn.Font = new System.Drawing.Font("Broadway", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logoutbtn.Location = new System.Drawing.Point(851, 8);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(70, 17);
            this.logoutbtn.TabIndex = 0;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 35);
            this.panel1.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(11, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "W E L C O M E!!";
            // 
            // searchbox
            // 
            this.searchbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.searchbox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.searchbox.Location = new System.Drawing.Point(19, 129);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(347, 18);
            this.searchbox.TabIndex = 3;
            this.searchbox.Text = "Search...";
            // 
            // refreshbtn
            // 
            this.refreshbtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.refreshbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshbtn.Location = new System.Drawing.Point(372, 129);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(91, 21);
            this.refreshbtn.TabIndex = 7;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = false;
            // 
            // productlist
            // 
            this.productlist.BackgroundColor = System.Drawing.Color.White;
            this.productlist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.productlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productlist.EnableHeadersVisualStyles = false;
            this.productlist.Location = new System.Drawing.Point(12, 156);
            this.productlist.Name = "productlist";
            this.productlist.RowHeadersVisible = false;
            this.productlist.Size = new System.Drawing.Size(706, 306);
            this.productlist.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lbltotal);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(19, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 65);
            this.panel2.TabIndex = 9;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(46, 24);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(23, 26);
            this.lbltotal.TabIndex = 2;
            this.lbltotal.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Products";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SkyBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblstock);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(167, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(127, 65);
            this.panel3.TabIndex = 11;
            // 
            // lblstock
            // 
            this.lblstock.AutoSize = true;
            this.lblstock.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstock.Location = new System.Drawing.Point(50, 25);
            this.lblstock.Name = "lblstock";
            this.lblstock.Size = new System.Drawing.Size(23, 26);
            this.lblstock.TabIndex = 3;
            this.lblstock.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "In Stocks";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Peru;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.lbllow);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(316, 42);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(127, 65);
            this.panel4.TabIndex = 10;
            // 
            // lbllow
            // 
            this.lbllow.AutoSize = true;
            this.lbllow.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllow.Location = new System.Drawing.Point(50, 23);
            this.lbllow.Name = "lbllow";
            this.lbllow.Size = new System.Drawing.Size(23, 26);
            this.lbllow.TabIndex = 3;
            this.lbllow.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Low Stock";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.IndianRed;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.lblout);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(469, 42);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(127, 65);
            this.panel5.TabIndex = 12;
            // 
            // lblout
            // 
            this.lblout.AutoSize = true;
            this.lblout.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblout.Location = new System.Drawing.Point(50, 23);
            this.lblout.Name = "lblout";
            this.lblout.Size = new System.Drawing.Size(23, 26);
            this.lblout.TabIndex = 3;
            this.lblout.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Out of Stock";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.addbtn);
            this.panel6.Controls.Add(this.updatebtn);
            this.panel6.Controls.Add(this.clearbtn);
            this.panel6.Controls.Add(this.deletebtn);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.txtcreated);
            this.panel6.Controls.Add(this.txtreorder);
            this.panel6.Controls.Add(this.txtquantity);
            this.panel6.Controls.Add(this.txtprice);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.descriptiontxt);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.categorycmb);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.txtname);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(731, 67);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 393);
            this.panel6.TabIndex = 13;
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.addbtn.Font = new System.Drawing.Font("Franklin Gothic Demi", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(51, 4);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(33, 22);
            this.addbtn.TabIndex = 18;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = false;
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.SteelBlue;
            this.updatebtn.Font = new System.Drawing.Font("Franklin Gothic Demi", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.Location = new System.Drawing.Point(3, 3);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(42, 22);
            this.updatebtn.TabIndex = 17;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = false;
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.Color.DarkKhaki;
            this.clearbtn.Font = new System.Drawing.Font("Franklin Gothic Demi", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.Location = new System.Drawing.Point(90, 4);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(47, 22);
            this.clearbtn.TabIndex = 16;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = false;
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.Brown;
            this.deletebtn.Font = new System.Drawing.Font("Franklin Gothic Demi", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.Location = new System.Drawing.Point(143, 4);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(47, 22);
            this.deletebtn.TabIndex = 15;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(111, 289);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 16);
            this.label16.TabIndex = 14;
            this.label16.Text = "Created";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(21, 289);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 16);
            this.label15.TabIndex = 13;
            this.label15.Text = "Re-order Level";
            // 
            // txtcreated
            // 
            this.txtcreated.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtcreated.Location = new System.Drawing.Point(112, 306);
            this.txtcreated.Multiline = true;
            this.txtcreated.Name = "txtcreated";
            this.txtcreated.Size = new System.Drawing.Size(75, 18);
            this.txtcreated.TabIndex = 12;
            // 
            // txtreorder
            // 
            this.txtreorder.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtreorder.Location = new System.Drawing.Point(21, 306);
            this.txtreorder.Multiline = true;
            this.txtreorder.Name = "txtreorder";
            this.txtreorder.Size = new System.Drawing.Size(75, 18);
            this.txtreorder.TabIndex = 11;
            // 
            // txtquantity
            // 
            this.txtquantity.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtquantity.Location = new System.Drawing.Point(112, 260);
            this.txtquantity.Multiline = true;
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(75, 18);
            this.txtquantity.TabIndex = 10;
            // 
            // txtprice
            // 
            this.txtprice.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtprice.Location = new System.Drawing.Point(20, 260);
            this.txtprice.Multiline = true;
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(76, 18);
            this.txtprice.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(111, 243);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 16);
            this.label14.TabIndex = 8;
            this.label14.Text = "Quantity";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 243);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 16);
            this.label13.TabIndex = 7;
            this.label13.Text = "Price";
            // 
            // descriptiontxt
            // 
            this.descriptiontxt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.descriptiontxt.Location = new System.Drawing.Point(21, 187);
            this.descriptiontxt.Multiline = true;
            this.descriptiontxt.Name = "descriptiontxt";
            this.descriptiontxt.Size = new System.Drawing.Size(155, 44);
            this.descriptiontxt.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 16);
            this.label12.TabIndex = 5;
            this.label12.Text = "Description";
            // 
            // categorycmb
            // 
            this.categorycmb.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.categorycmb.FormattingEnabled = true;
            this.categorycmb.Items.AddRange(new object[] {
            "Computer Peripherals",
            "Computer Hardware",
            "Computer Accessories",
            "Networking Equipment",
            "Storage Devices",
            "Office Supplies"});
            this.categorycmb.Location = new System.Drawing.Point(20, 135);
            this.categorycmb.Name = "categorycmb";
            this.categorycmb.Size = new System.Drawing.Size(152, 21);
            this.categorycmb.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Category";
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtname.Location = new System.Drawing.Point(20, 87);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(155, 18);
            this.txtname.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Name";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(955, 476);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.productlist);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productlist)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.DataGridView productlist;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblstock;
        private System.Windows.Forms.Label lbllow;
        private System.Windows.Forms.Label lblout;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox categorycmb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox descriptiontxt;
        private System.Windows.Forms.TextBox txtreorder;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtcreated;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Label label10;
    }
}