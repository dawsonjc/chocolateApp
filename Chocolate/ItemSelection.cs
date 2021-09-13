using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chocolate
{
    public partial class Form1 : Form
    {
        public static double totalPrice = 0.0d;
        public static bool chocolateType = false;
        public static bool nutSelection = false;
        public static bool additives = false;
        public static bool fillings = false;
        public static bool shape = false;

        // This string is a variable for the order id to be used in the pay page, Dawson
        public static string OrderId = "";

        // These string variables will be transfered over to the pay page to be display there
        public static string CartChocolateType;
        public static string CartNutType;
        public static string CartAdditiveType;
        public static string CartFillingType;
        public static string CartShapeType;
        public Form1()
        {
            // This generates a orderid string, Dawson
            string characters = "0123456789";
            string orderId = "#";
            Random rand = new Random();
            for (int i = 0; i <= 10; i++) {
                int randInt = rand.Next(0, characters.Length);
                orderId += characters.Substring(randInt, 1);
            }
            OrderId = orderId;
            InitializeComponent();
        }

        //Makes all the buttons non-visible once form starts, Jakob
        private void Form1_Load(object sender, EventArgs e)
        {
            btnRemoveChocolateType.Visible = false;
            btnRemoveNutSelection.Visible = false;
            btnRemoveAdditive.Visible = false;
            btnRemoveFilling.Visible = false;
            btnRemoveShape.Visible = false;

        }

        //Method for White Chocolate button selection, Jakob
        private void btnWhiteChocolate_Click(object sender, EventArgs e)
        {
            if(chocolateType == false)
            {
                //Displays the name and price, Jakob
                chocolateType = true;
                lblChocolateTypeCart.Text = "White Chocolate";
                CartChocolateType = "White Chocolate";
                lblChocolateTypePrice.Text = " $3.00";
                btnRemoveChocolateType.Visible = true;

                //Adds the amount to the total price after White Chocolate selection, Jakob
                totalPrice += 3.00;
                lblTotalPrice.Text = "$" + totalPrice.ToString();
            }
        }

        //Method for Dark Chocolate button selection, Jakob
        private void btnDarkChocolate_Click(object sender, EventArgs e)
        {
            if (chocolateType == false)
            {
                //Displays the name and price, Jakob
                chocolateType = true;
                lblChocolateTypeCart.Text = "Dark Chocolate";
                CartChocolateType = "Dark Chocolate";
                lblChocolateTypePrice.Text = " $3.00";
                btnRemoveChocolateType.Visible = true;

                //Adds the amount to the total price after Dark Chocolate selection, Jakob 
                totalPrice += 3.00;
                lblTotalPrice.Text = "$" + totalPrice.ToString();
            }
        }

        //Method for Milk Chocolate button selection, Jakob
        private void btnMilkChocolate_Click(object sender, EventArgs e)
        {
            if (chocolateType == false)
            {
                //Displays the name and price, Jakob
                chocolateType = true;
                lblChocolateTypeCart.Text = "Milk Chocolate";
                CartChocolateType = "Milk Chocolate";
                lblChocolateTypePrice.Text = " $3.00";
                btnRemoveChocolateType.Visible = true;

                //Adds the amount to the total price after Milk Chocolate selection, Jakob
                totalPrice += 3.0;
                lblTotalPrice.Text = "$" + totalPrice.ToString();
            }
        }

        //Method for Almond button selection, Jakob
        private void btnAlmond_Click(object sender, EventArgs e)
        {
            if (nutSelection == false)
            {
                //Displays the name and price, Jakob
                nutSelection = true;
                lblNutSelectionCart.Text = "Almond";
                CartNutType = "Almond";
                lblNutPrice.Text = " $.50";
                btnRemoveNutSelection.Visible = true;

                //Adds the amount to the total price after Almond selection, Jakob
                totalPrice += .50;
                lblTotalPrice.Text = "$" + totalPrice.ToString();
            }
        }

        //method for Hazelnut button selection, Jakob
        private void btnHazelnut_Click(object sender, EventArgs e)
        {
            if (nutSelection == false)
            {
                //Displays the name and price, Jakob
                nutSelection = true;
                lblNutSelectionCart.Text = "Hazelnut";
                CartNutType = "HazelNut";
                lblNutPrice.Text = " $.50";
                btnRemoveNutSelection.Visible = true;

                //Adds the amount to the total price after Hazelnut selection, Jakob
                totalPrice += .50;
                lblTotalPrice.Text = "$" + totalPrice.ToString();
            }
        }

        //method for walnut button selection, Jakob
        private void btnWalnut_Click(object sender, EventArgs e)
        {
            if (nutSelection == false)
            {
                //Displays the name and price, Jakob
                nutSelection = true;
                lblNutSelectionCart.Text = "Walnut";
                CartNutType = "Walnut";
                lblNutPrice.Text = " $.50";
                btnRemoveNutSelection.Visible = true;

                //Adds the amount to the total price after walnut selection, Jakob
                totalPrice += .50;
                lblTotalPrice.Text = "$" + totalPrice.ToString();
            }
        }

        //method for pecan button selection, Jakob
        private void btnPecan_Click(object sender, EventArgs e)
        {
            if (nutSelection == false)
            {
                //Displays the name and price, Jakob
                nutSelection = true;
                lblNutSelectionCart.Text = "Pecan";
                CartNutType = "Pecan";
                lblNutPrice.Text = " $.50";
                btnRemoveNutSelection.Visible = true;

                //Adds the amount to the total price after pecan selection, Jakob
                totalPrice += .50;
                lblTotalPrice.Text = "$" + totalPrice.ToString();
            }
        }

        //method for Oreo button selection, Jakob
        private void btnOreo_Click(object sender, EventArgs e)
        {
            if(additives == false)
            {
                //Displays the name and price, Jakob
                additives = true;
                lblAdditiveCart.Text = "Oreo";
                CartAdditiveType = "Oreo";
                lblAdditivePrice.Text = "$0.50";
                btnRemoveAdditive.Visible = true;

                //Adds the amount to the total price after oreo selection, Jakob
                totalPrice += .50;
                lblTotalPrice.Text = "$" + totalPrice.ToString();
            }
        }

        //method for Coconut button selection, Jakob
        private void btnCoconut_Click(object sender, EventArgs e)
        {
            if (additives == false)
            {
                //Displays the name and price, Jakob
                additives = true;
                lblAdditiveCart.Text = "Coconut";
                CartAdditiveType = "Coconut";
                lblAdditivePrice.Text = "$0.50";
                btnRemoveAdditive.Visible = true;

                //Adds the amount to the total price after coconut selection, Jakob
                totalPrice += .50;
                lblTotalPrice.Text = "$" + totalPrice.ToString();
            }
        }

        //Method for M&M's button selection, Jakob
        private void btnM_Click(object sender, EventArgs e)
        {
            if (additives == false)
            {
                //Displays the name and price, Jakob
                additives = true;
                lblAdditiveCart.Text = "M&M's";
                CartAdditiveType = "M'M";
                lblAdditivePrice.Text = "$0.50";
                btnRemoveAdditive.Visible = true;

                //Adds the amount to the total price after M&M selection, Jakob
                totalPrice += .50;
                lblTotalPrice.Text = "$" + totalPrice.ToString();
            }
        }

        //Method for sprinkles button selection, Jakob
        private void btnSprinkles_Click(object sender, EventArgs e)
        {
            if (additives == false)
            {
                //Displays the name and price, Jakob
                additives = true;
                lblAdditiveCart.Text = "Sprinkles";
                CartAdditiveType = "Sprinkles";
                lblAdditivePrice.Text = "$0.50";
                btnRemoveAdditive.Visible = true;

                //Adds the amount to the total price after sprinkles selection
                totalPrice += .50;
                lblTotalPrice.Text = "$" + totalPrice.ToString();
            }
        }

        //Method for Caramel button selection, Jakob
        private void btnCaramel_Click(object sender, EventArgs e)
        {
            if(fillings == false)
            {
                //Displays the name and price, Jakob
                fillings = true;
                lblFillingCart.Text = "Caramel";
                CartAdditiveType = "Caramel";
                lblFillingPrice.Text = "$0.50";
                btnRemoveFilling.Visible = true;

                //Adds the amount to the total price after caramel selection
                totalPrice += .50;
                lblTotalPrice.Text = "$" + totalPrice.ToString();
            }
        }

        //Method for Fudge button selection, Jakob
        private void btnFudge_Click(object sender, EventArgs e)
        {
            if (fillings == false)
            {
                //Displays the name and price, Jakob
                fillings = true;
                lblFillingCart.Text = "Fudge";
                CartFillingType = "Fudge";
                lblFillingPrice.Text = "$0.50";
                btnRemoveFilling.Visible = true;

                //Adds the amount to the total price after fudge selection, Jakob
                totalPrice += .50;
                lblTotalPrice.Text = "$" + totalPrice.ToString();
            }
        }

        //Method for strawberry button selection, Jakob
        private void btnStrawberry_Click(object sender, EventArgs e)
        {
            if (fillings == false)
            {
                //Displays the name and price, Jakob
                fillings = true;
                lblFillingCart.Text = "Strawberry";
                CartFillingType = "Strawberry";
                lblFillingPrice.Text = "$0.50";
                btnRemoveFilling.Visible = true;

                //Adds the amount to the total price after strawberry selection, Jakob
                totalPrice += .50;
                lblTotalPrice.Text = "$" + totalPrice.ToString();
            }
        }

        //Method for Lemon button selection, Jakob
        private void btnLemon_Click(object sender, EventArgs e)
        {
            if (fillings == false)
            {
                //Displays the name and price, Jakob
                fillings = true;
                lblFillingCart.Text = "Lemon";
                CartFillingType = "Lemon";
                lblFillingPrice.Text = "$0.50";
                btnRemoveFilling.Visible = true;

                //Adds the amount to the total price after Lemon selection, Jakob
                totalPrice += .50;
                lblTotalPrice.Text = "$" + totalPrice.ToString();
            }
        }

        //Method for Square button selection, Jakob
        private void btnSquare_Click(object sender, EventArgs e)
        {
            if(shape == false)
            {
                //Displays the name and price, Jakob
                shape = true;
                lblShapeCart.Text = "Square";
                CartShapeType = "Square";
                lblShapePrice.Text = "$1.00";
                btnRemoveShape.Visible = true;

                //Adds the amount to the total price after Square selection, Jakob
                totalPrice += 1.00;
                lblTotalPrice.Text = "$" + totalPrice.ToString();
            }
        }

        //Method for Circle button selection, Jakob
        private void btnCircle_Click(object sender, EventArgs e)
        {
            if (shape == false)
            {
                //Displays the name and price, Jakob
                shape = true;
                lblShapeCart.Text = "Circle";
                CartShapeType = "Circle";
                lblShapePrice.Text = "$1.00";
                btnRemoveShape.Visible = true;

                //Adds the amount to the total price after Circle selection, Jakob
                totalPrice += 1.00;
                lblTotalPrice.Text = "$" + totalPrice.ToString();
            }
        }

        //Method for Star button selection, Jakob
        private void btnStar_Click(object sender, EventArgs e)
        {
            if (shape == false)
            {
                //Displays the name and price, Jakob
                shape = true;
                lblShapeCart.Text = "Star";
                CartShapeType = "Shape";
                lblShapePrice.Text = "$1.00";
                btnRemoveShape.Visible = true;

                //Adds the amount to the total price after star selection, Jakob
                totalPrice += 1.00;
                lblTotalPrice.Text = "$" + totalPrice.ToString();
            }
        }

        //Method for Triangle button selection, Jakob
        private void btnTriangle_Click(object sender, EventArgs e)
        {
            if (shape == false)
            {
                //Displays the name and price, Jakob
                shape = true;
                lblShapeCart.Text = "Triangle";
                CartShapeType = "Triangle";
                lblShapePrice.Text = "$1.00";
                btnRemoveShape.Visible = true;

                //Adds the amount to the total price after triangle selection, Jakob
                totalPrice += 1.00;
                lblTotalPrice.Text = "$" + totalPrice.ToString();
            }
        }

        //method for removing the chocolate type name and price, Jakob
        private void btnRemoveChocolateType_Click(object sender, EventArgs e)
        {
            chocolateType = false;
            lblChocolateTypeCart.Text = " ";
            lblChocolateTypePrice.Text = "";
            CartChocolateType = "";
            btnRemoveChocolateType.Visible = false;
            totalPrice -= 3.00;
            lblTotalPrice.Text = "$" + totalPrice.ToString();
        }

        //method for removing the nut selection name and price, Jakob
        private void btnRemoveNutSelection_Click(object sender, EventArgs e)
        {
            nutSelection = false;
            lblNutSelectionCart.Text = " ";
            lblNutPrice.Text = " ";
            CartNutType = "";
            btnRemoveNutSelection.Visible = false;
            totalPrice -= .50;
            lblTotalPrice.Text = "$" + totalPrice.ToString();
        }

        //method for removing the additive selection name and price, Jakob
        private void btnRemoveAdditive_Click(object sender, EventArgs e)
        {
            additives = false;
            lblAdditiveCart.Text = " ";
            lblAdditivePrice.Text = " ";
            CartAdditiveType = "";
            btnRemoveAdditive.Visible = false;
            totalPrice -= .50;
            lblTotalPrice.Text = "$" + totalPrice.ToString();
        }

        //method for removing the filling selection name and price, Jakob
        private void btnRemoveFilling_Click(object sender, EventArgs e)
        {
            fillings = false;
            lblFillingCart.Text = " ";
            lblFillingPrice.Text = " ";
            CartFillingType = "";
            btnRemoveFilling.Visible = false;
            totalPrice -= .50;
            lblTotalPrice.Text = "$" + totalPrice.ToString();
        }

        //method for removing shape selection name and price, Jakob
        private void btnRemoveShape_Click(object sender, EventArgs e)
        {
            shape = false;
            lblShapeCart.Text = " ";
            lblShapePrice.Text = " ";
            CartShapeType = "";
            btnRemoveShape.Visible = false;
            totalPrice -= 1.00;
            lblTotalPrice.Text = "$" + totalPrice.ToString();
        }

        //method for clearing the cart and reseting the total price back to $0.00, Jakob
        private void btnCartClear_Click(object sender, EventArgs e)
        {
            chocolateType = false;
            lblChocolateTypeCart.Text = " ";
            lblChocolateTypePrice.Text = "";
            btnRemoveChocolateType.Visible = false;

            nutSelection = false;
            lblNutSelectionCart.Text = " ";
            lblNutPrice.Text = " ";
            btnRemoveNutSelection.Visible = false;

            additives = false;
            lblAdditiveCart.Text = " ";
            lblAdditivePrice.Text = " ";
            btnRemoveAdditive.Visible = false;

            fillings = false;
            lblFillingCart.Text = " ";
            lblFillingPrice.Text = " ";
            btnRemoveFilling.Visible = false;

            shape = false;
            lblShapeCart.Text = " ";
            lblShapePrice.Text = " ";
            btnRemoveShape.Visible = false;

            CartFillingType = "";
            CartChocolateType = "";
            CartNutType = "";
            CartShapeType = "";

            totalPrice = 0.00;
            lblTotalPrice.Text = "$" + totalPrice.ToString();
        }
        private void btnCartContinue_Click(object sender, EventArgs e) {
            if(chocolateType != false && shape != false) {
                Form2 paypage = new Form2();
                this.Hide();
                paypage.ShowDialog();
                this.Close();
            }
            else {
                MessageBox.Show("Must Select a Chocolate and Shape Type");
            }
        }
    }
}
