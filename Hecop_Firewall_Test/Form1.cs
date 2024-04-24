using Hecop_Firewall.Engine;
namespace Firewall_Hecop_Firewall
{
    public partial class Form1 : Form
    {

        FilteringEngine engine = new FilteringEngine();

        static Form1 form1 = new Form1();
        public static Form1 Instance
        {
            get
            {
                if (form1 == null || form1.IsDisposed)
                    form1 = new Form1();
                return form1;
            }
        }


        public Form1()
        {
            InitializeComponent();
            form1 = this;
            engine = new FilteringEngine();
            //engine.ProviderName = ProductName;

        }

        public string[] TrafficsInfo { get; set; } = OptionTraffic.Instance.richTextBox1.Lines;

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (engine != null)
                engine.Clear();
            base.OnFormClosed(e);
        }

        void restartSelection()
        {
            if (engine != null)
            {
                engine.ClearFilters();

                // Chặn port scanning
                if (checkBox1.Checked) engine.SetSilentBlockInV4();
                if (checkBox2.Checked) engine.SetSilentBlockInV6();

                // Chặn tất cả
                //engine.AddFilterInV4(!checkBox3.Checked);
                //engine.AddFilterInV6(!checkBox4.Checked);
                //engine.AddFilterOutV4(!checkBox5.Checked);
                //engine.AddFilterOutV4(!checkBox6.Checked);

                // Chặn dựa trên danh sách cụ thể
                var arrv4 = new Hecop_Firewall.Native.IPPROTO[] { Hecop_Firewall.Native.IPPROTO.ICMP, Hecop_Firewall.Native.IPPROTO.TCP, Hecop_Firewall.Native.IPPROTO.UDP, Hecop_Firewall.Native.IPPROTO.RAW, Hecop_Firewall.Native.IPPROTO.AH };
                var arrv6 = new Hecop_Firewall.Native.IPPROTO[] { Hecop_Firewall.Native.IPPROTO.ICMPV6, Hecop_Firewall.Native.IPPROTO.TCP, Hecop_Firewall.Native.IPPROTO.UDP, Hecop_Firewall.Native.IPPROTO.RAW, Hecop_Firewall.Native.IPPROTO.AH };

                engine.AddFilterInV4(!checkBox10.Checked, null, TrafficsInfo);
                engine.AddFilterInV4(!checkBox10.Checked, null, TrafficsInfo, TrafficsInfo);
                engine.AddFilterInV6(!checkBox9.Checked, null, TrafficsInfo);
                engine.AddFilterInV6(!checkBox9.Checked, null, TrafficsInfo, TrafficsInfo);
                engine.AddFilterOutV4(!checkBox8.Checked, null, TrafficsInfo);
                engine.AddFilterOutV4(!checkBox8.Checked, null, TrafficsInfo, TrafficsInfo);
                engine.AddFilterOutV6(!checkBox7.Checked, null, TrafficsInfo);
                engine.AddFilterOutV6(!checkBox7.Checked, null, TrafficsInfo, TrafficsInfo);


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            engine.Initialize();
            engine.ClearFilters();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            restartSelection();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            restartSelection();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox10.Checked = false;
            restartSelection();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            restartSelection(); checkBox8.Checked = false;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            restartSelection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = "";
            foreach (var item in TrafficsInfo)
            {
                a += item + "\n";
            }
            MessageBox.Show(a);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OptionTraffic.Instance.ShowDialog();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            restartSelection();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            restartSelection();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            restartSelection();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            restartSelection();
        }

      
    }
}
