using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityToolbox
{
    public partial class SecToolForm : Form
    {
        public SecToolForm()
        {
            InitializeComponent();
        }

        private void tabIpTools_SelectedIndexChanged(object sender, EventArgs e)
        {
            var x = sender as TabControl;
            var m = x.SelectedIndex;

            if(m == 0)
            {
                lblTabHeader.Text = "IP Lookup Tools";
            }
            if(m == 1)
            {
                lblTabHeader.Text = "Encoding/Decoding Tools";
            }
        }
    }
}
