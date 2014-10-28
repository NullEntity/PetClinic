using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetClinic
{
    public partial class ctlPetClinicService : UserControl
    {
        // store the Name as the checkbox's text
        public string ServiceName
        {
            get
            {
                return cbCheckbox.Text;
            }

            set
            {
                cbCheckbox.Text = value;
            }
        }

        // save value and update the label text to it
        private decimal value;
        public decimal Value
        {
            get
            {
                return value;
            }
            set
            {
                lblValue.Text = value.ToString("C2");   // display it as currency
                this.value = value;                     // and save it
            }
        }

        // we want to know if this is checked
        public bool Checked
        {
            get
            {
                return cbCheckbox.Checked;
            }
        }

        public EventHandler CheckedChanged;
        private void cbCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            // bubble up CheckedChanged events
            if (CheckedChanged != null)
                CheckedChanged(this, e);
        }

        // clear the checkmark
        public void Clear()
        {
            cbCheckbox.Checked = false;
        }


        public ctlPetClinicService()
        {
            InitializeComponent();
        }
    }
}
