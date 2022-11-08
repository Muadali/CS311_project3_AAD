namespace CS311_project3_AAD
{
    partial class Frmadnan
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picBxPizza = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.CboPizzaSize = new System.Windows.Forms.ComboBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.rdoThin = new System.Windows.Forms.RadioButton();
            this.rdoThick = new System.Windows.Forms.RadioButton();
            this.rdoRegular = new System.Windows.Forms.RadioButton();
            this.lblToppings = new System.Windows.Forms.Label();
            this.ckbPepperoni = new System.Windows.Forms.CheckBox();
            this.ckbSausage = new System.Windows.Forms.CheckBox();
            this.ckbCanadianBacon = new System.Windows.Forms.CheckBox();
            this.ckbSpicyItalianSausage = new System.Windows.Forms.CheckBox();
            this.ckbOnion = new System.Windows.Forms.CheckBox();
            this.ckbGreenPepper = new System.Windows.Forms.CheckBox();
            this.ckbBlackOlives = new System.Windows.Forms.CheckBox();
            this.ckbGreenOlives = new System.Windows.Forms.CheckBox();
            this.ckbBananaPeppers = new System.Windows.Forms.CheckBox();
            this.ckbJalepeno = new System.Windows.Forms.CheckBox();
            this.ckbExtraCheese = new System.Windows.Forms.CheckBox();
            this.ckbMushroom = new System.Windows.Forms.CheckBox();
            this.rtfOrderSummary = new System.Windows.Forms.RichTextBox();
            this.lblSummary = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBxPizza)).BeginInit();
            this.SuspendLayout();
            // 
            // picBxPizza
            // 
            this.picBxPizza.Image = global::CS311_project3_AAD.Properties.Resources.Pizza;
            this.picBxPizza.Location = new System.Drawing.Point(-1, -15);
            this.picBxPizza.Margin = new System.Windows.Forms.Padding(4);
            this.picBxPizza.Name = "picBxPizza";
            this.picBxPizza.Size = new System.Drawing.Size(566, 374);
            this.picBxPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxPizza.TabIndex = 0;
            this.picBxPizza.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(573, 101);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(677, 96);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Muad Pizza Palace";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CboPizzaSize
            // 
            this.CboPizzaSize.FormattingEnabled = true;
            this.CboPizzaSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "X-Large",
            "Ginormous"});
            this.CboPizzaSize.Location = new System.Drawing.Point(175, 384);
            this.CboPizzaSize.Margin = new System.Windows.Forms.Padding(4);
            this.CboPizzaSize.Name = "CboPizzaSize";
            this.CboPizzaSize.Size = new System.Drawing.Size(253, 40);
            this.CboPizzaSize.TabIndex = 2;
            this.CboPizzaSize.SelectedIndexChanged += new System.EventHandler(this.CboSize_SelectedIndexChanged);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(48, 384);
            this.lblSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(66, 32);
            this.lblSize.TabIndex = 3;
            this.lblSize.Text = "Size:";
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.Location = new System.Drawing.Point(488, 390);
            this.lblCrustType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(142, 32);
            this.lblCrustType.TabIndex = 4;
            this.lblCrustType.Text = "Crust Type:";
            this.lblCrustType.Click += new System.EventHandler(this.lblCrustType_Click);
            // 
            // rdoThin
            // 
            this.rdoThin.AutoSize = true;
            this.rdoThin.Location = new System.Drawing.Point(694, 390);
            this.rdoThin.Margin = new System.Windows.Forms.Padding(4);
            this.rdoThin.Name = "rdoThin";
            this.rdoThin.Size = new System.Drawing.Size(89, 36);
            this.rdoThin.TabIndex = 5;
            this.rdoThin.TabStop = true;
            this.rdoThin.Text = "Thin";
            this.rdoThin.UseVisualStyleBackColor = true;
            this.rdoThin.CheckedChanged += new System.EventHandler(this.rbThin_CheckedChanged);
            // 
            // rdoThick
            // 
            this.rdoThick.AutoSize = true;
            this.rdoThick.Location = new System.Drawing.Point(879, 388);
            this.rdoThick.Margin = new System.Windows.Forms.Padding(4);
            this.rdoThick.Name = "rdoThick";
            this.rdoThick.Size = new System.Drawing.Size(99, 36);
            this.rdoThick.TabIndex = 6;
            this.rdoThick.TabStop = true;
            this.rdoThick.Text = "Thick";
            this.rdoThick.UseVisualStyleBackColor = true;
            this.rdoThick.CheckedChanged += new System.EventHandler(this.rbThick_CheckedChanged);
            // 
            // rdoRegular
            // 
            this.rdoRegular.AutoSize = true;
            this.rdoRegular.Location = new System.Drawing.Point(1072, 390);
            this.rdoRegular.Margin = new System.Windows.Forms.Padding(4);
            this.rdoRegular.Name = "rdoRegular";
            this.rdoRegular.Size = new System.Drawing.Size(127, 36);
            this.rdoRegular.TabIndex = 7;
            this.rdoRegular.TabStop = true;
            this.rdoRegular.Text = "Regular";
            this.rdoRegular.UseVisualStyleBackColor = true;
            this.rdoRegular.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Location = new System.Drawing.Point(48, 456);
            this.lblToppings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(126, 32);
            this.lblToppings.TabIndex = 8;
            this.lblToppings.Text = "Toppings:";
            // 
            // ckbPepperoni
            // 
            this.ckbPepperoni.AutoSize = true;
            this.ckbPepperoni.Location = new System.Drawing.Point(175, 488);
            this.ckbPepperoni.Margin = new System.Windows.Forms.Padding(4);
            this.ckbPepperoni.Name = "ckbPepperoni";
            this.ckbPepperoni.Size = new System.Drawing.Size(157, 36);
            this.ckbPepperoni.TabIndex = 9;
            this.ckbPepperoni.Text = "Pepperoni";
            this.ckbPepperoni.UseVisualStyleBackColor = true;
            // 
            // ckbSausage
            // 
            this.ckbSausage.AutoSize = true;
            this.ckbSausage.Location = new System.Drawing.Point(175, 532);
            this.ckbSausage.Margin = new System.Windows.Forms.Padding(4);
            this.ckbSausage.Name = "ckbSausage";
            this.ckbSausage.Size = new System.Drawing.Size(133, 36);
            this.ckbSausage.TabIndex = 10;
            this.ckbSausage.Text = "Sausage";
            this.ckbSausage.UseVisualStyleBackColor = true;
            // 
            // ckbCanadianBacon
            // 
            this.ckbCanadianBacon.AutoSize = true;
            this.ckbCanadianBacon.Location = new System.Drawing.Point(175, 577);
            this.ckbCanadianBacon.Margin = new System.Windows.Forms.Padding(4);
            this.ckbCanadianBacon.Name = "ckbCanadianBacon";
            this.ckbCanadianBacon.Size = new System.Drawing.Size(223, 36);
            this.ckbCanadianBacon.TabIndex = 11;
            this.ckbCanadianBacon.Text = "Canadian Bacon";
            this.ckbCanadianBacon.UseVisualStyleBackColor = true;
            // 
            // ckbSpicyItalianSausage
            // 
            this.ckbSpicyItalianSausage.AutoSize = true;
            this.ckbSpicyItalianSausage.Location = new System.Drawing.Point(175, 622);
            this.ckbSpicyItalianSausage.Margin = new System.Windows.Forms.Padding(4);
            this.ckbSpicyItalianSausage.Name = "ckbSpicyItalianSausage";
            this.ckbSpicyItalianSausage.Size = new System.Drawing.Size(279, 36);
            this.ckbSpicyItalianSausage.TabIndex = 12;
            this.ckbSpicyItalianSausage.Text = "Spicy Italian Sausage";
            this.ckbSpicyItalianSausage.UseVisualStyleBackColor = true;
            // 
            // ckbOnion
            // 
            this.ckbOnion.AutoSize = true;
            this.ckbOnion.Location = new System.Drawing.Point(497, 488);
            this.ckbOnion.Margin = new System.Windows.Forms.Padding(4);
            this.ckbOnion.Name = "ckbOnion";
            this.ckbOnion.Size = new System.Drawing.Size(110, 36);
            this.ckbOnion.TabIndex = 13;
            this.ckbOnion.Text = "Onion";
            this.ckbOnion.UseVisualStyleBackColor = true;
            // 
            // ckbGreenPepper
            // 
            this.ckbGreenPepper.AutoSize = true;
            this.ckbGreenPepper.Location = new System.Drawing.Point(497, 532);
            this.ckbGreenPepper.Margin = new System.Windows.Forms.Padding(4);
            this.ckbGreenPepper.Name = "ckbGreenPepper";
            this.ckbGreenPepper.Size = new System.Drawing.Size(195, 36);
            this.ckbGreenPepper.TabIndex = 14;
            this.ckbGreenPepper.Text = "Green Pepper";
            this.ckbGreenPepper.UseVisualStyleBackColor = true;
            // 
            // ckbBlackOlives
            // 
            this.ckbBlackOlives.AutoSize = true;
            this.ckbBlackOlives.Location = new System.Drawing.Point(497, 577);
            this.ckbBlackOlives.Margin = new System.Windows.Forms.Padding(4);
            this.ckbBlackOlives.Name = "ckbBlackOlives";
            this.ckbBlackOlives.Size = new System.Drawing.Size(176, 36);
            this.ckbBlackOlives.TabIndex = 15;
            this.ckbBlackOlives.Text = "Black Olives";
            this.ckbBlackOlives.UseVisualStyleBackColor = true;
            // 
            // ckbGreenOlives
            // 
            this.ckbGreenOlives.AutoSize = true;
            this.ckbGreenOlives.Location = new System.Drawing.Point(497, 622);
            this.ckbGreenOlives.Margin = new System.Windows.Forms.Padding(4);
            this.ckbGreenOlives.Name = "ckbGreenOlives";
            this.ckbGreenOlives.Size = new System.Drawing.Size(184, 36);
            this.ckbGreenOlives.TabIndex = 16;
            this.ckbGreenOlives.Text = "Green Olives";
            this.ckbGreenOlives.UseVisualStyleBackColor = true;
            // 
            // ckbBananaPeppers
            // 
            this.ckbBananaPeppers.AutoSize = true;
            this.ckbBananaPeppers.Location = new System.Drawing.Point(879, 488);
            this.ckbBananaPeppers.Margin = new System.Windows.Forms.Padding(4);
            this.ckbBananaPeppers.Name = "ckbBananaPeppers";
            this.ckbBananaPeppers.Size = new System.Drawing.Size(222, 36);
            this.ckbBananaPeppers.TabIndex = 17;
            this.ckbBananaPeppers.Text = "Banana Peppers";
            this.ckbBananaPeppers.UseVisualStyleBackColor = true;
            // 
            // ckbJalepeno
            // 
            this.ckbJalepeno.AutoSize = true;
            this.ckbJalepeno.Location = new System.Drawing.Point(879, 532);
            this.ckbJalepeno.Margin = new System.Windows.Forms.Padding(4);
            this.ckbJalepeno.Name = "ckbJalepeno";
            this.ckbJalepeno.Size = new System.Drawing.Size(142, 36);
            this.ckbJalepeno.TabIndex = 18;
            this.ckbJalepeno.Text = "Jalepeno";
            this.ckbJalepeno.UseVisualStyleBackColor = true;
            // 
            // ckbExtraCheese
            // 
            this.ckbExtraCheese.AutoSize = true;
            this.ckbExtraCheese.Location = new System.Drawing.Point(879, 577);
            this.ckbExtraCheese.Margin = new System.Windows.Forms.Padding(4);
            this.ckbExtraCheese.Name = "ckbExtraCheese";
            this.ckbExtraCheese.Size = new System.Drawing.Size(184, 36);
            this.ckbExtraCheese.TabIndex = 19;
            this.ckbExtraCheese.Text = "Extra Cheese";
            this.ckbExtraCheese.UseVisualStyleBackColor = true;
            // 
            // ckbMushroom
            // 
            this.ckbMushroom.AutoSize = true;
            this.ckbMushroom.Location = new System.Drawing.Point(879, 622);
            this.ckbMushroom.Margin = new System.Windows.Forms.Padding(4);
            this.ckbMushroom.Name = "ckbMushroom";
            this.ckbMushroom.Size = new System.Drawing.Size(165, 36);
            this.ckbMushroom.TabIndex = 20;
            this.ckbMushroom.Text = "Mushroom";
            this.ckbMushroom.UseVisualStyleBackColor = true;
            // 
            // rtfOrderSummary
            // 
            this.rtfOrderSummary.Location = new System.Drawing.Point(-1, 698);
            this.rtfOrderSummary.Margin = new System.Windows.Forms.Padding(4);
            this.rtfOrderSummary.Name = "rtfOrderSummary";
            this.rtfOrderSummary.Size = new System.Drawing.Size(789, 228);
            this.rtfOrderSummary.TabIndex = 21;
            this.rtfOrderSummary.Text = "";
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Location = new System.Drawing.Point(-1, 662);
            this.lblSummary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(203, 32);
            this.lblSummary.TabIndex = 22;
            this.lblSummary.Text = "Order Summary:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(809, 698);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(120, 32);
            this.lblSubTotal.TabIndex = 23;
            this.lblSubTotal.Text = "SubTotal:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(861, 742);
            this.lblTax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(59, 32);
            this.lblTax.TabIndex = 24;
            this.lblTax.Text = "Tax:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(861, 791);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(77, 32);
            this.lblTotal.TabIndex = 25;
            this.lblTotal.Text = "Total:";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(967, 691);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(208, 39);
            this.txtSubTotal.TabIndex = 26;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(967, 739);
            this.txtTax.Margin = new System.Windows.Forms.Padding(4);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(208, 39);
            this.txtTax.TabIndex = 27;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(967, 784);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(208, 39);
            this.txtTotal.TabIndex = 28;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(835, 868);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(280, 58);
            this.btnCalculate.TabIndex = 29;
            this.btnCalculate.Text = "Calculate:";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Frmadnan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1799, 927);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.rtfOrderSummary);
            this.Controls.Add(this.ckbMushroom);
            this.Controls.Add(this.ckbExtraCheese);
            this.Controls.Add(this.ckbJalepeno);
            this.Controls.Add(this.ckbBananaPeppers);
            this.Controls.Add(this.ckbGreenOlives);
            this.Controls.Add(this.ckbBlackOlives);
            this.Controls.Add(this.ckbGreenPepper);
            this.Controls.Add(this.ckbOnion);
            this.Controls.Add(this.ckbSpicyItalianSausage);
            this.Controls.Add(this.ckbCanadianBacon);
            this.Controls.Add(this.ckbSausage);
            this.Controls.Add(this.ckbPepperoni);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.rdoRegular);
            this.Controls.Add(this.rdoThick);
            this.Controls.Add(this.rdoThin);
            this.Controls.Add(this.lblCrustType);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.CboPizzaSize);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picBxPizza);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frmadnan";
            this.Text = "Muad Pizza Palace";
            ((System.ComponentModel.ISupportInitialize)(this.picBxPizza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picBxPizza;
        private Label lblName;
        private ComboBox CboPizzaSize;
        private Label lblSize;
        private Label lblCrustType;
        private RadioButton rdoThin;
        private RadioButton rdoThick;
        private RadioButton rdoRegular;
        private Label lblToppings;
        private CheckBox ckbPepperoni;
        private CheckBox ckbSausage;
        private CheckBox ckbCanadianBacon;
        private CheckBox ckbSpicyItalianSausage;
        private CheckBox ckbOnion;
        private CheckBox ckbGreenPepper;
        private CheckBox ckbBlackOlives;
        private CheckBox ckbGreenOlives;
        private CheckBox ckbBananaPeppers;
        private CheckBox ckbJalepeno;
        private CheckBox ckbExtraCheese;
        private CheckBox ckbMushroom;
        private RichTextBox rtfOrderSummary;
        private Label lblSummary;
        private Label lblSubTotal;
        private Label lblTax;
        private Label lblTotal;
        private TextBox txtSubTotal;
        private TextBox txtTax;
        private TextBox txtTotal;
        private Button btnCalculate;
    }
}