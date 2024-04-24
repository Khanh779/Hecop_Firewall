using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firewall_Hecop_Firewall
{
    public partial class OptionTraffic : Form
    {

        static OptionTraffic traffic = null;
        public static OptionTraffic Instance
        {
            get
            {
                if (traffic == null || traffic.IsDisposed)
                    traffic = new OptionTraffic();
                return traffic;
            }
        }

        public OptionTraffic()
        {
            InitializeComponent();
            traffic = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            Form1.Instance.TrafficsInfo = richTextBox1.Lines;
        }
    }
}
