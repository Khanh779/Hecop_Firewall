namespace Firewall_Hecop_Firewall
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkBox1 = new CheckBox();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox9 = new CheckBox();
            checkBox10 = new CheckBox();
            groupBox1 = new GroupBox();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(19, 15);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(167, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Prevent IPv4 port scanning";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(496, 279);
            panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(checkBox7);
            groupBox2.Controls.Add(checkBox8);
            groupBox2.Controls.Add(checkBox9);
            groupBox2.Controls.Add(checkBox10);
            groupBox2.Location = new Point(253, 74);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(228, 185);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Block specific activities";
            // 
            // button2
            // 
            button2.Location = new Point(90, 153);
            button2.Name = "button2";
            button2.Size = new Size(51, 23);
            button2.TabIndex = 8;
            button2.Text = "Check";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(147, 153);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Options";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.ForeColor = Color.FromArgb(255, 128, 0);
            checkBox7.Location = new Point(16, 111);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(200, 19);
            checkBox7.TabIndex = 6;
            checkBox7.Text = "Block outgoing IPv6 connections";
            checkBox7.UseVisualStyleBackColor = true;
            checkBox7.CheckedChanged += checkBox7_CheckedChanged;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.ForeColor = Color.FromArgb(255, 128, 0);
            checkBox8.Location = new Point(16, 86);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(200, 19);
            checkBox8.TabIndex = 5;
            checkBox8.Text = "Block outgoing IPv4 connections";
            checkBox8.UseVisualStyleBackColor = true;
            checkBox8.CheckedChanged += checkBox8_CheckedChanged;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.ForeColor = Color.FromArgb(255, 128, 0);
            checkBox9.Location = new Point(16, 61);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(179, 19);
            checkBox9.TabIndex = 4;
            checkBox9.Text = "Block IPv6 input connections";
            checkBox9.UseVisualStyleBackColor = true;
            checkBox9.CheckedChanged += checkBox9_CheckedChanged;
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.ForeColor = Color.FromArgb(255, 128, 0);
            checkBox10.Location = new Point(16, 36);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(179, 19);
            checkBox10.TabIndex = 3;
            checkBox10.Text = "Block IPv4 input connections";
            checkBox10.UseVisualStyleBackColor = true;
            checkBox10.CheckedChanged += checkBox10_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(checkBox6);
            groupBox1.Controls.Add(checkBox5);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Location = new Point(19, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(228, 185);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Block activity";
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.ForeColor = Color.FromArgb(255, 128, 0);
            checkBox6.Location = new Point(16, 111);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(200, 19);
            checkBox6.TabIndex = 6;
            checkBox6.Text = "Block outgoing IPv6 connections";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.ForeColor = Color.FromArgb(255, 128, 0);
            checkBox5.Location = new Point(16, 86);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(200, 19);
            checkBox5.TabIndex = 5;
            checkBox5.Text = "Block outgoing IPv4 connections";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.ForeColor = Color.FromArgb(255, 128, 0);
            checkBox4.Location = new Point(16, 61);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(179, 19);
            checkBox4.TabIndex = 4;
            checkBox4.Text = "Block IPv6 input connections";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.ForeColor = Color.FromArgb(255, 128, 0);
            checkBox3.Location = new Point(16, 36);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(179, 19);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "Block IPv4 input connections";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(19, 40);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(167, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Prevent IPv6 port scanning";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(522, 303);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hecop Firewall Control";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CheckBox checkBox1;
        private Panel panel1;
        private GroupBox groupBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private GroupBox groupBox2;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private CheckBox checkBox9;
        private CheckBox checkBox10;
        private Button button1;
        private Button button2;
    }
}
