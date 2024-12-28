using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simu_Browse
{
    public partial class AddDeviceForm : Form
    {
        public string DeviceName { get; private set; }
        public string DeviceUserAgent { get; private set; }
        public int DeviceWidth { get; private set; }
        public int DeviceHeight { get; private set; }

        public AddDeviceForm()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            DeviceName = textBoxName.Text;
            DeviceUserAgent = textBoxUserAgent.Text;
            DeviceWidth = (int)numericUpDownWidth.Value;
            DeviceHeight = (int)numericUpDownHeight.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
