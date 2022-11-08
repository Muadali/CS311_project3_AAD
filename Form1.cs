using System.Drawing.Text;

namespace CS311_project3_AAD
{
    public partial class Frmadnan : Form
    {
        float runningTotal = 0;
        String CrustType;
        String CrustName;
        String[] Toppings;

        public Frmadnan()
        {
            InitializeComponent();
        }//end Form1

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }//end radioButton3

        private void lblCrustType_Click(object sender, EventArgs e)
        {
            if (rdoRegular.Checked)
            {
                CrustType += "Regular crust ";

            }
            else if (rdoThin.Checked) {
                CrustType += "Thin crust";
            }

            else if (rdoThick.Checked){
                    CrustType += "Thick crust";
                }
            else
            {
                CrustType += "";
            }
               
        }//end lblCrustType

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {

        }//end rbThin

        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {

        }//end rbThick

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            CrustTypeMethod();
            CalculatePizaSize();
            summarize();
        }//end btnCalculate

        private void CboSize_SelectedIndexChanged(object sender, EventArgs e)
        {

            

        }//end cboSize

        private void CalculatePizaSize()
        {
            

            if (CboPizzaSize.SelectedItem== "Small")
            {
                runningTotal=runningTotal + 2;
            }//end if
            if (CboPizzaSize.SelectedItem == "Medium")
            {
                runningTotal = runningTotal + 5;
            }//end if
            
            if (CboPizzaSize.SelectedItem == "Large")
            {
                runningTotal = runningTotal + 10;
            }//end if
            if (CboPizzaSize.SelectedItem == "X-Large")
            {
                runningTotal = runningTotal + 15;
            }//end if
            if (CboPizzaSize.SelectedItem == "Ginormous")
            {
                runningTotal = runningTotal + 20;
            }//end if

        }//end CalculatePizzaSize
        
        private void CrustTypeMethod()

        {
            if (rdoRegular.Checked)
            {
                CrustType += "Regular crust ";

            }
            else if (rdoThin.Checked)
            {
                CrustType += "Thin crust";
            }

            else if (rdoThick.Checked)
            {
                CrustType += "Thick crust";
            }
            else
            {
                CrustType += "";
            }

        }//end CrusTypeMethod

        private void summarize()
        {
            //rtfOrderSummary
            String OrderSummary = "You ordered " + CboPizzaSize.Text + " pizza with " + CrustType + " and the following toppings: \n";

            if (ckbBananaPeppers.Checked)
            {
                runningTotal = runningTotal + 1;
                String BananaPep = "Banana Peppers\n";
                OrderSummary=OrderSummary + BananaPep;
            }//end if

            if (ckbPepperoni.Checked)
            {
                runningTotal = runningTotal + 2;
                String Pep = "Peperoni\n";
                OrderSummary = OrderSummary + Pep;
            }//end if

            if (ckbSausage.Checked)
            {
                runningTotal = runningTotal + 2;
                String Saus = "Sausage\n";
                OrderSummary = OrderSummary + Saus;
            }//end if

            if (ckbCanadianBacon.Checked)
            {
                runningTotal = runningTotal + 2;
                String CB = "Canadian Bacon\n";
                OrderSummary = OrderSummary + CB;
            }//end if

            if (ckbSpicyItalianSausage.Checked)
            {
                runningTotal = runningTotal + 2;
                String SIS = "Spicy Italian Sausage\n";
                OrderSummary = OrderSummary + SIS;
            }//end if

            if (ckbOnion.Checked)
            {
                runningTotal = runningTotal + 1;
                String Onion = "Onion\n";
                OrderSummary = OrderSummary + Onion;
            }//end if

            if (ckbGreenPepper.Checked)
            {
                runningTotal = runningTotal + 1;
                String GPep = "Green Pepper\n";
                OrderSummary = OrderSummary + GPep;
            }//end if

            if (ckbBlackOlives.Checked)
            {
                runningTotal = runningTotal + 1;
                String BOlives = "Black Olives\n";
                OrderSummary = OrderSummary + BOlives;
            }//end if

            if (ckbGreenOlives.Checked)
            {
                runningTotal = runningTotal + 1;
                String GOlives = "Green Olives\n";
                OrderSummary = OrderSummary + GOlives;
            }//end if

            if (ckbJalepeno.Checked)
            {
                runningTotal = runningTotal + 1;
                String Jalepeno = "Jalepeno\n";
                OrderSummary = OrderSummary + Jalepeno;
            }//end if

            if (ckbExtraCheese.Checked)
            {
                runningTotal = runningTotal + 1;
                String XCheese = "Extra Cheese\n";
                OrderSummary = OrderSummary + XCheese;
            }//end if

            if (ckbMushroom.Checked)
            {
                runningTotal = runningTotal + 1;
                String Mushroom = "Mushroom\n";
                OrderSummary = OrderSummary + Mushroom;
            }//end if

            rtfOrderSummary.Text = OrderSummary;

            float runningTotalAlias = runningTotal;
            float salesTax = (float)(runningTotalAlias * 0.1); // 10% Washington State tax 
            float total = runningTotalAlias+ salesTax;

            txtSubTotal.Text = runningTotal.ToString("C");
            txtTax.Text = salesTax.ToString("C");
            txtTotal.Text = total.ToString("C");


        }//end summarize

      
    }//end partial class
}