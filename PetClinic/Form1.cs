using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetClinic
{
    public partial class frmPetClinic : Form
    {
        public frmPetClinic()
        {
            InitializeComponent();
        }

        // add all children of grpOptions that are a ctlPetClinicService
        private void frmPetClinic_Load(object sender, EventArgs e)
        {
            // add event handlers to all ctlPetClinicServices
            grpOptions.Controls.OfType<ctlPetClinicService>().ToList().ForEach(x => x.CheckedChanged += Service_CheckedChanged);
        }

        // UpdateTotal when any checkboxes are changed
        private void Service_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        
        private void UpdateTotal()
        {
            // get the sum of values that are checked
            decimal total = grpOptions.Controls.OfType<ctlPetClinicService>().Sum(x => x.Checked ? x.Value : 0m);

            // display
            lblTotal.Text = total.ToString("C2");
        }

        // clear all checkboxes
        private void btnClear_Click(object sender, EventArgs e)
        {
            grpOptions.Controls.OfType<ctlPetClinicService>().ToList().ForEach(x => x.Clear());
        }

        // exit the app
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
