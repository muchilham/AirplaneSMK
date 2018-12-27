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
    public partial class DataCustomerFrm : Form
    {
        AirplaneDBDataContext db = new AirplaneDBDataContext();
        validasi va;
        MainForm frm;
        tbl_Customer cust;
        int id;
        public DataCustomerFrm()
        {
            InitializeComponent();
            va = new validasi(this.eValidasi, this.Controls);
        }

        public DataCustomerFrm(MainForm frm)
        {
            InitializeComponent();
            va = new validasi(this.eValidasi, this.Controls);
            this.frm = frm;
        }

        private void loadGrid()
        {
            dgvCustomer.DataSource = db.tbl_Customers.ToList();

        }

        private void setTextbox()
        {
            if (!String.IsNullOrEmpty(tbIdcustomer.Text))
            {
                cust = db.tbl_Customers.FirstOrDefault(x => x.id_customer == int.Parse(tbIdcustomer.Text));
                if (cust != null)
                {
                    tbNamecustomer.Text = cust.name_customer;
                    rtbAddresscustomer.Text = cust.address_customer;
                    tbEmailcustomer.Text = cust.email_customer;
                    tbPhonenumbercustomer.Text = cust.phonenumber_customer;
                    btnAdd.Text = "UPDATE";
                }

                else
                {
                    va.clear("tbIdcustomer", 0);
                    btnAdd.Text = "ADD";
                }
            }
        }

        private void aksi(String aksinya)
        {
            cust = aksinya == "insert" ? new tbl_Customer() : db.tbl_Customers.FirstOrDefault(x => x.id_customer == int.Parse(tbIdcustomer.Text));
            cust.name_customer = tbNamecustomer.Text;
            cust.address_customer = rtbAddresscustomer.Text;
            cust.email_customer = tbEmailcustomer.Text;
            cust.phonenumber_customer = tbPhonenumbercustomer.Text;

            if(aksinya == "insert")
            {
                cust.id_customer = int.Parse(tbIdcustomer.Text);
                db.tbl_Customers.InsertOnSubmit(cust);
            }

            db.SubmitChanges();
        }

        private void tbPhonenumbercustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.numberFormat(e);
        }

        private void tbIdcustomer_TextChanged(object sender, EventArgs e)
        {
            setTextbox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String message = "";
            if (va.doValidation() == false) return;
            cust = db.tbl_Customers.FirstOrDefault(x => x.id_customer == int.Parse(tbIdcustomer.Text));
            if(cust != null)
            {
                aksi("update");
                message = "Update";
            }

            else
            {
                aksi("insert");
                message = "Insert";
            }

            MessageBox.Show(message + " data success", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            va.clear("", 0);
            loadGrid();

        }

        private void DataCustomerFrm_Load(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void dgvCustomer_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbIdcustomer.Text = dgvCustomer[0, e.RowIndex].Value.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            va.clear("", 0);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure want delete this record? ", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.No) return;
            var delete = db.tbl_Customers.Where(x => x.id_customer == id).Single();
            db.tbl_Customers.DeleteOnSubmit(delete);
            db.SubmitChanges();
            loadGrid();
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dgvCustomer[0,e.RowIndex].Value.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            tbIdcustomer.Text = id.ToString();
        }

        private void tbIdcustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.numberFormat(e);
        }
    }
}
