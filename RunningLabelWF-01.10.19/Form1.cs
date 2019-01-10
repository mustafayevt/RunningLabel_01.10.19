using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunningLabelWF_01._10._19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Label label = new Label();
            label.Text = "ha ha";
            label.Size = new Size(35, 15);
            label.Name = "runningLbl";
            label.Location = DesktopLocation;
            label.MouseEnter += Label_MouseEnter;
            Controls.Add(label);
            InitializeComponent();
        }

        private void Label_MouseEnter(object sender, EventArgs e)
        {
            Random random = new Random();
            (sender as Label).Left = random.Next(0, Width - (sender as Label).Width);
            (sender as Label).Top = random.Next(0, Height - (sender as Label).Height);
        }
    }
}
