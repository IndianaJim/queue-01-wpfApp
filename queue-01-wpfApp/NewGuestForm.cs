using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace queue_01_wpfApp
{
    public partial class NewGuestForm: Form
    {
        public string newGuestName;
        public string newGuestPhone;
        public int newGuestpartySize;

        public NewGuestForm()
        {
            InitializeComponent();
        }

        private void addGuestFormButton_Click(object sender, EventArgs e)
        {
            newGuestName = newGuestNameTextBox.Text;
            newGuestPhone = newGuestPhoneTextBox.Text;
            newGuestpartySize = (int)partySizeUpDown.Value;
        }
    }
}
