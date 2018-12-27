using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirplaneSMK
{
    public partial class UserControl2 : UserControl
    {
        public event EventHandler ButtonClick;
        public UserControl2()
        {
            InitializeComponent();
        }

        private void btnTransit1_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }
    }
}
