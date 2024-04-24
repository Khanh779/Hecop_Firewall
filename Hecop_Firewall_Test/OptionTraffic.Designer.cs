namespace Firewall_Hecop_Firewall
{
    partial class OptionTraffic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(24, 58);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(362, 173);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "123.30.175.29:443\n123.30.175.29\nhttps://coccoc.com\nhttps://coccoc.com/\n445\n3389\n443\n80";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 19);
            label1.Name = "label1";
            label1.Size = new Size(304, 30);
            label1.TabIndex = 1;
            label1.Text = "Type address - port (if any), according to format x.x.x.x:x\r\nEx: 192.168.0.1 or 192.168.0.1:443";
            // 
            // button1
            // 
            button1.Location = new Point(311, 240);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // OptionTraffic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 279);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "OptionTraffic";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Address - Port Management";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        public RichTextBox richTextBox1;
    }
}