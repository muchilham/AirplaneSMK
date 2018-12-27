using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirplaneSMK
{
    class validasi
    {
        ErrorProvider err;
        Control.ControlCollection ctl;

        public validasi(ErrorProvider err, Control.ControlCollection ctl)
        {
            this.err = err;
            this.ctl = ctl;
        }

        public string pk { get; set; }

        public void clear(String Skip, int value)
        {
            foreach(Control ctl in this.ctl)
            {
                if(ctl.GetType() == typeof(TextBox) || ctl.GetType() == typeof(RichTextBox))
                {
                    if (ctl.Name == Skip) continue;
                    ctl.Text = "";
                }

                if (ctl.GetType() == typeof(ComboBox))
                    ((ComboBox)ctl).Text = "";
                if (ctl.GetType() == typeof(NumericUpDown))
                    ((NumericUpDown)ctl).Value = value;
                if (ctl.GetType() == typeof(DateTimePicker))
                    ((DateTimePicker)ctl).Value = DateTime.Now;
            }
        }

        public bool doValidation()
        {
            foreach(Control ctl in this.ctl)
            {
                if(ctl.GetType() == typeof(TextBox) || ctl.GetType() == typeof(RichTextBox))
                {
                    if(String.IsNullOrEmpty(ctl.Text))
                    {
                        MessageBox.Show("Semua harus terisi", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.err.SetError(ctl, "Must be filled");
                        return false;
                    }

                    else
                    {
                        this.err.SetError(ctl, "");
                    }
                }

                else if(ctl.GetType() == typeof(ComboBox))
                {
                    if(((ComboBox)ctl).SelectedIndex < 0 )
                    {
                        MessageBox.Show("Semua harus terisi", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.err.SetError(ctl, "Must be filled");
                        return false;
                    }

                    else
                    {
                        this.err.SetError(ctl, "");
                    }
                }

                else if(ctl.GetType() == typeof(NumericUpDown))
                {
                    if(((NumericUpDown)ctl).Value < 0 || String.IsNullOrEmpty(((NumericUpDown)ctl).Value.ToString()))
                    {
                        MessageBox.Show("Semua harus terisi", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.err.SetError(ctl, "Must be filled");
                        return false;
                    }

                    else
                    {
                        this.err.SetError(ctl, "");
                    }
                }
            }
            return true;
        }

        public void numberFormat(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(ch != 8 && !Char.IsDigit(ch))
            {
                e.Handled = true;
            }
        }

        public void getRandom(int batas)
        {
            string kata = "";
            Random random = new Random();
            string[] data = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,0,1,2,3,4,5,6,7,8,9".Split(',');
            for(int i =0; i < batas; i++)
            {
                kata += data[random.Next(0, data.Length)];
            }
        }
    }
}
