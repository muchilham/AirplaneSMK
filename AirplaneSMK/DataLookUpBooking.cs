using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirplaneSMK
{
    public partial class DataLookUpBooking : Form
    {
        AirplaneDBDataContext db = new AirplaneDBDataContext();
        String idBooking, idSchedule;
        validasi va;
        float price;
        int[] idcustomer;
        int idPlane;
        public DataLookUpBooking(String idBooking, String idSchedule, int idPlane)
        {
            InitializeComponent();
            va = new validasi(this.eValidasi, this.Controls);
            this.idBooking = idBooking;
            this.idSchedule = idSchedule;
            this.idPlane = idPlane;
        }

        private void btnLookupcustomer_Click(object sender, EventArgs e)
        {
            if (new DataLookup("tbl_Customer2", idSchedule, idPlane).ShowDialog() == DialogResult.OK)
            {
                tbIdcustomer.Text = session.idCustomer.ToString();
                tbCustomername.Text = session.customerName;
            }
        }

        private void btnLookupConsumption_Click(object sender, EventArgs e)
        {
            if (new DataLookup("tbl_Consumption", null, 0).ShowDialog() == DialogResult.OK)
            {
                tbIdconsumption.Text = session.idConsumption.ToString();
                tbConsumptionname.Text = session.consumptionName;
                price = session.priceConsumption;
            }
        }

        private void tbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.numberFormat(e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (va.doValidation() == false) return;
            session.quantity = int.Parse(tbQuantity.Text);
            this.DialogResult = DialogResult.OK;
        }
    }
}
