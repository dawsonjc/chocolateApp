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

namespace Chocolate {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();

            lblOrderId.Text = Form1.OrderId;
            label5.Text = Form1.CartChocolateType;
            label6.Text = Form1.CartAdditiveType;
            label7.Text = Form1.CartFillingType;
            label8.Text = Form1.CartNutType;
            label9.Text = Form1.CartShapeType;
            btnTotal.Text = "$" + Form1.totalPrice.ToString();
        }
        public void checkTxtBox(TextBox name, string missingMessage) {

        }
        private void button4_Click(object sender, EventArgs e) {
            if (txtBoxCartCardNumber.Text == "" || txtBoxCartDay.Text == "" || txtBoxCartMonth.Text == "" || txtBoxCvc.Text == "" || txtBoxZipCode.Text == "") {
                MessageBox.Show("You have left one of the following fields blank please try again!");
            }

            if (txtBoxCartCardNumber.Text.Length == 16 && txtBoxCartDay.Text.Length >= 1 && txtBoxCartMonth.Text.Length >= 1 && txtBoxCvc.Text.Length == 3 && txtBoxZipCode.Text.Length == 5) {
                ThankYouPage myForm = new ThankYouPage();
                this.Hide();
                myForm.ShowDialog();
                this.Close();
            } else {
                MessageBox.Show("One of the fields does not contain the max amount of numbers!");
            }


        }

        // Everything Below is From Konrad.
        public void txtBoxNumberDecline(TextBox name, string message) {
            if (System.Text.RegularExpressions.Regex.IsMatch(name.Text, "[^0-9]")) {
                MessageBox.Show(message);
                name.Text = name.Text.Remove(name.Text.Length - 1);
            }
        }
        public void txtBoxMaxLength(TextBox name, string message, int length) {
            if (name.Text.Length > length) {
                MessageBox.Show(message);
                name.Text = name.Text.Remove(name.Text.Length - 1);
            }
        }


        private void txtBoxCartCardNumber_TextChanged(object sender, EventArgs e) {
            txtBoxNumberDecline(txtBoxCartCardNumber, "Please only enter in numbers! Thank you");
            txtBoxMaxLength(txtBoxCartCardNumber, "You may not enter in more than 16 numbers! Thank you!", 16);
        }

        private void txtBoxCartMonth_TextChanged(object sender, EventArgs e) {
            txtBoxNumberDecline(txtBoxCartMonth, "Please only enter in numbers! Thank you");
            txtBoxMaxLength(txtBoxCartMonth, "You may not enter in more than 2 numbers! Thank you!", 2);
        }

        private void txtBoxCartDay_TextChanged(object sender, EventArgs e) {
            txtBoxNumberDecline(txtBoxCartDay, "Please only enter in numbers! Thank you");
            txtBoxMaxLength(txtBoxCartDay, "You may not enter in more than 2 numbers! Thank you!", 2);
        }

        private void txtBoxCvc_TextChanged(object sender, EventArgs e) {
            txtBoxNumberDecline(txtBoxCvc, "Please only enter in numbers! Thank you");
            txtBoxMaxLength(txtBoxCvc, "You may not enter in more than 3 numbers! Thank you!", 3);
        }

        private void txtBoxZipCode_TextChanged(object sender, EventArgs e) {
            txtBoxNumberDecline(txtBoxZipCode, "Please only enter in numbers! Thank you");
            txtBoxMaxLength(txtBoxZipCode, "You may not enter in more than 5 numbers! Thank you!", 5);
        }
    }
}
