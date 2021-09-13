using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chocolate {
    public partial class ThankYouPage : Form {
        public ThankYouPage() {
            InitializeComponent();
            lblOrderId.Text = Form1.OrderId.ToString();
        }
    }
}
